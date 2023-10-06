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

        private void FusionMainForm_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("AllCards.txt");
            foreach (string line in lines)
            {
                string[] card = line.Split(',');
                Cards new_card = new Cards();
                new_card.setName(card[0]);
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

        }
    }
}
