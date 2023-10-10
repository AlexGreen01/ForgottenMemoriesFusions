using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgottenMemoriesFusions
{
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();
        }

        private Button selectedButton;
        private Form activeForm = null;
        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnFusionForm_Click(object sender, EventArgs e)
        {
            openChildForm(new FusionMainForm(), sender);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void btnAllCards_Click(object sender, EventArgs e)
        {
            openChildForm(new AllCardsForm(), sender);
        }

        private void activateButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (selectedButton != (Button)btnsender)
                {
                    disableButtons();
                    selectedButton = (Button)btnsender;
                    selectedButton.BackColor = Color.FromArgb(45, 3, 3);
                    selectedButton.Font = new Font("Yu Mincho", 11F, FontStyle.Bold);
                }
            }
        }

        private void disableButtons()
        {
            foreach (Control otherBtns in panelMenu.Controls)
            {
                if (otherBtns.GetType() == typeof(Button))
                {
                    otherBtns.BackColor = Color.FromArgb(6, 3, 3);
                    otherBtns.Font = new Font("Yu Mincho", 9F, FontStyle.Regular);
                }
            }
        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {
            selectedButton = btnHome;
            selectedButton.BackColor = Color.FromArgb(45, 3, 3);
            selectedButton.Font = new Font("Yu Mincho", 11F, FontStyle.Bold);
        }
    }
}
