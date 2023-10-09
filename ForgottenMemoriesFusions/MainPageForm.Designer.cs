namespace ForgottenMemoriesFusions
{
    partial class MainPageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lbTopTitle = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnFusionForm = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.lbCreator = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnAllCards = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.btnAllCards);
            this.panelMenu.Controls.Add(this.lbTopTitle);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.btnFusionForm);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1904, 70);
            this.panelMenu.TabIndex = 0;
            // 
            // lbTopTitle
            // 
            this.lbTopTitle.AutoSize = true;
            this.lbTopTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTopTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbTopTitle.Location = new System.Drawing.Point(792, 20);
            this.lbTopTitle.Name = "lbTopTitle";
            this.lbTopTitle.Size = new System.Drawing.Size(334, 34);
            this.lbTopTitle.TabIndex = 4;
            this.lbTopTitle.Text = "Forbidden Memories Tool";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(240, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 45);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnFusionForm
            // 
            this.btnFusionForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnFusionForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFusionForm.ForeColor = System.Drawing.Color.White;
            this.btnFusionForm.Location = new System.Drawing.Point(477, 12);
            this.btnFusionForm.Name = "btnFusionForm";
            this.btnFusionForm.Size = new System.Drawing.Size(200, 45);
            this.btnFusionForm.TabIndex = 2;
            this.btnFusionForm.Text = "Fusion Generator:";
            this.btnFusionForm.UseVisualStyleBackColor = false;
            this.btnFusionForm.Click += new System.EventHandler(this.btnFusionForm_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(715, 16);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(485, 250);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // lbCreator
            // 
            this.lbCreator.AutoSize = true;
            this.lbCreator.Font = new System.Drawing.Font("Yu Mincho Demibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreator.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbCreator.Location = new System.Drawing.Point(711, 269);
            this.lbCreator.Name = "lbCreator";
            this.lbCreator.Size = new System.Drawing.Size(199, 21);
            this.lbCreator.TabIndex = 1;
            this.lbCreator.Text = "Program by EclipseDraco:";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.panelChildForm.Controls.Add(this.pictureLogo);
            this.panelChildForm.Controls.Add(this.lbCreator);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 70);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1904, 331);
            this.panelChildForm.TabIndex = 1;
            // 
            // btnAllCards
            // 
            this.btnAllCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnAllCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllCards.ForeColor = System.Drawing.Color.White;
            this.btnAllCards.Location = new System.Drawing.Point(1246, 12);
            this.btnAllCards.Name = "btnAllCards";
            this.btnAllCards.Size = new System.Drawing.Size(200, 45);
            this.btnAllCards.TabIndex = 5;
            this.btnAllCards.Text = "View All Cards";
            this.btnAllCards.UseVisualStyleBackColor = false;
            this.btnAllCards.Click += new System.EventHandler(this.btnAllCards_Click);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 401);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainPageForm";
            this.Text = "MainPageForm";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label lbCreator;
        private System.Windows.Forms.Button btnFusionForm;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lbTopTitle;
        private System.Windows.Forms.Button btnAllCards;
    }
}