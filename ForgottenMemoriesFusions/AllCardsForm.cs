using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ForgottenMemoriesFusions
{
    public partial class AllCardsForm : Form
    {
        public AllCardsForm()
        {
            InitializeComponent();
        }
        List<Cards> AllCards = new List<Cards>();
        List<string[]> Effects = new List<string[]>();
        List<string> NameList = new List<string>();

        private void AllCardsForm_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("resources/AllCards.txt");
            foreach (string line in lines)
            {
                string[] card = line.Split(',');
                Cards new_card = new Cards();
                new_card.setName(card[0]);
                NameList.Add(new_card.getName());
                ListViewItem list = new ListViewItem(new_card.getName());
                lstAllCards.Items.Add(list);
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
                AllCards.Add(new_card);
            }
            lines = File.ReadAllLines("resources/MagicEffects.txt");
            foreach (string line in lines)
            {
                string[] card = line.Split('/');
                Effects.Add(card);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int found = -1;
            if (NameList.Contains(txtSearch.Text))
            {
                List<string> temp_list = new List<string>();
                foreach (string card in NameList)
                {
                    temp_list.Add(card);
                }
                temp_list.Sort();
                found = temp_list.BinarySearch(txtSearch.Text);
                lstAllCards.FocusedItem = lstAllCards.Items[found];
                lstAllCards.Items[found].Selected = true;
                lstAllCards.EnsureVisible(found);
            }
            else
            {
                MessageBox.Show("Couldn't Find Card\nCheck Capitalisation and Spelling then Try Again", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstAllCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GetIndex() != -1)
            {
                foreach(Cards card in AllCards) 
                {
                    if (card.getName() == lstAllCards.Items[GetIndex()].Text)
                    {
                        txtName.Text = card.getName();
                        txtType.Text = card.getType();
                        if (card.getAtk() < 0)
                        {
                            txtAtk.Text = "N/A";
                            txtDef.Text = "N/A";
                        }
                        else
                        {
                            txtAtk.Text = card.getAtk().ToString();
                            txtDef.Text = card.getDef().ToString();
                        }
                        foreach (string[] effect in Effects)
                        {
                            bool has_effect = false;
                            if (card.getName() == effect[0])
                            {
                                txtEffect.Text = effect[1].ToString();
                                has_effect = true;
                                break;
                            }
                            if (!has_effect)
                            {
                                txtEffect.Text = "No Effect";
                            }
                        }
                        break;
                    }
                }
            }
        }

        private int GetIndex()
        {
            if (lstAllCards.FocusedItem != null)
            {
                 return lstAllCards.FocusedItem.Index;
            }
            return -1;
        }
    }
}
