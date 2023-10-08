using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgottenMemoriesFusions
{
    public partial class FusionMainForm : Form
    {
        public FusionMainForm()
        {
            InitializeComponent();
        }

        List<Cards> YugiDex = new List<Cards>();
        List<Fusions> FusionsList = new List<Fusions>();
        List<string> NameList = new List<string>();

        private void FusionMainForm_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("AllCards.txt");
            foreach (string line in lines)
            {
                string[] card = line.Split(',');
                Cards new_card = new Cards();
                new_card.setName(card[0]);
                NameList.Add(new_card.getName());
                new_card.setType(card[1].Remove(0, 1));
                if (card.Contains(" N/A"))
                {
                    new_card.setAtk(-1);
                    new_card.setDef(-1);
                }
                else
                {
                    new_card.setAtk(int.Parse(card[2]));
                    new_card.setDef(int.Parse(card[3]));
                }
                YugiDex.Add(new_card);
            }
            foreach (Cards card in YugiDex)
            {
                ListViewItem item = new ListViewItem(card.getName());
                lstAllCards.Items.Add(item);
            }
            if (!File.Exists("FusionObjects.bin"))
            {
                lines = File.ReadAllLines("AllFusions.txt");
                foreach (string line in lines)
                {
                    string[] card = line.Split('/');
                    Fusions new_fusion = new Fusions();
                    new_fusion.setName(card[0]);
                    string[] mat1 = card[1].Split(',');
                    new_fusion.setMat1(mat1);
                    string[] mat2 = card[2].Split(',');
                    new_fusion.setMat2(mat2);
                    FusionsList.Add(new_fusion);
                }
                using (Stream stream = File.Open("FusionObjects.bin", FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bformatter.Serialize(stream, FusionsList);
                }
            }
            else
            {
                using (Stream stream = File.Open("FusionObjects.bin", FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    FusionsList = (List<Fusions>)bformatter.Deserialize(stream);
                }
            }
            var auto = new AutoCompleteStringCollection();
            foreach (Cards card in YugiDex) 
            {
                auto.Add(card.getName());
            }
            txtHand1.AutoCompleteCustomSource = auto;
            txtHand2.AutoCompleteCustomSource = auto;
            txtHand3.AutoCompleteCustomSource = auto;
            txtHand4.AutoCompleteCustomSource = auto;
            txtHand5.AutoCompleteCustomSource = auto;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int check = checkBoxes();
            if (check > 0)
            {
                MessageBox.Show("Text Box " + check + " Doesnt Contain A Valid Card Name.", "Invalid Card Name Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cards[] hand = new Cards[5];
                string[] input = new string[5];
                input[0] = txtHand1.Text;
                input[1] = txtHand2.Text;
                input[2] = txtHand3.Text;
                input[3] = txtHand4.Text;
                input[4] = txtHand5.Text;
                foreach (Cards card in YugiDex)
                {
                    for (int i = 0; i < input.Length; i++)
                    { 
                        if (input[i] == card.getName())
                        {
                            hand[i] = card;
                        }
                    }
                }
                findFusions(hand);
            }
        }

        private void findFusions(Cards[] hand)
        {
            for (int i = 0; i < hand.Length; i++)
            {
                foreach (Fusions fusion in FusionsList)
                {
                    if (fusion.getMat1().Contains(hand[i].getName()))
                    {
                        foreach (Cards hand2 in hand)
                        {
                            if (fusion.getMat2().Contains(hand2.getName()) && hand[i] != hand2)
                            {
                                DisplayFusion(hand[i], hand2, fusion);
                            }
                        }
                    }
                }
            }
        }

        private int checkBoxes()
        {
            if (!NameList.Contains(txtHand1.Text))
            {
                return 1;
            }
            else if (!NameList.Contains(txtHand2.Text))
            {
                return 2;
            }
            else if (!NameList.Contains(txtHand3.Text))
            {
                return 3;
            }
            else if (!NameList.Contains(txtHand4.Text))
            {
                return 4;
            }
            else if (!NameList.Contains(txtHand5.Text))
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }

        private void DisplayFusion(Cards mat1, Cards mat2, Fusions summon)
        {
            Cards summonDetails = new Cards();
            foreach (Cards cards in YugiDex)
            {
                if (summon.getName() == cards.getName())
                {
                    summonDetails = cards;
                }
            }
            ListViewItem list = new ListViewItem(mat1.getName());
            list.SubItems.Add(mat2.getName());
            list.SubItems.Add(summon.getName());
            list.SubItems.Add(summonDetails.getAtk().ToString());
            list.SubItems.Add(summonDetails.getDef().ToString());
            lstFusions.Items.Add(list);
        }
    }
}
