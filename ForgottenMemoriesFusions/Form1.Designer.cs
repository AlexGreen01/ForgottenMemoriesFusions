namespace ForgottenMemoriesFusions
{
    partial class FusionMainForm
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
            this.lstFusions = new System.Windows.Forms.ListView();
            this.columnMaterial1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMaterial2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSummon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbLstFusions = new System.Windows.Forms.Label();
            this.lstAllCards = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbAllCards = new System.Windows.Forms.Label();
            this.lbHand = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtHand1 = new System.Windows.Forms.TextBox();
            this.txtHand2 = new System.Windows.Forms.TextBox();
            this.txtHand3 = new System.Windows.Forms.TextBox();
            this.txtHand4 = new System.Windows.Forms.TextBox();
            this.txtHand5 = new System.Windows.Forms.TextBox();
            this.columnAtk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDef = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstFusions
            // 
            this.lstFusions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMaterial1,
            this.columnMaterial2,
            this.columnSummon,
            this.columnAtk,
            this.columnDef});
            this.lstFusions.HideSelection = false;
            this.lstFusions.Location = new System.Drawing.Point(520, 48);
            this.lstFusions.Name = "lstFusions";
            this.lstFusions.Size = new System.Drawing.Size(562, 390);
            this.lstFusions.TabIndex = 0;
            this.lstFusions.UseCompatibleStateImageBehavior = false;
            this.lstFusions.View = System.Windows.Forms.View.Details;
            // 
            // columnMaterial1
            // 
            this.columnMaterial1.Text = "Material 1";
            this.columnMaterial1.Width = 140;
            // 
            // columnMaterial2
            // 
            this.columnMaterial2.Text = "Material 2";
            this.columnMaterial2.Width = 140;
            // 
            // columnSummon
            // 
            this.columnSummon.Text = "Summons:";
            this.columnSummon.Width = 200;
            // 
            // lbLstFusions
            // 
            this.lbLstFusions.AutoSize = true;
            this.lbLstFusions.Location = new System.Drawing.Point(520, 29);
            this.lbLstFusions.Name = "lbLstFusions";
            this.lbLstFusions.Size = new System.Drawing.Size(85, 13);
            this.lbLstFusions.TabIndex = 1;
            this.lbLstFusions.Text = "Possible Fusions";
            // 
            // lstAllCards
            // 
            this.lstAllCards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName});
            this.lstAllCards.FullRowSelect = true;
            this.lstAllCards.HideSelection = false;
            this.lstAllCards.Location = new System.Drawing.Point(23, 48);
            this.lstAllCards.Name = "lstAllCards";
            this.lstAllCards.Size = new System.Drawing.Size(182, 390);
            this.lstAllCards.TabIndex = 2;
            this.lstAllCards.UseCompatibleStateImageBehavior = false;
            this.lstAllCards.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Card Name:";
            this.columnName.Width = 181;
            // 
            // lbAllCards
            // 
            this.lbAllCards.AutoSize = true;
            this.lbAllCards.Location = new System.Drawing.Point(20, 29);
            this.lbAllCards.Name = "lbAllCards";
            this.lbAllCards.Size = new System.Drawing.Size(94, 13);
            this.lbAllCards.TabIndex = 5;
            this.lbAllCards.Text = "All Cards In Game:";
            // 
            // lbHand
            // 
            this.lbHand.AutoSize = true;
            this.lbHand.Location = new System.Drawing.Point(258, 29);
            this.lbHand.Name = "lbHand";
            this.lbHand.Size = new System.Drawing.Size(64, 13);
            this.lbHand.TabIndex = 11;
            this.lbHand.Text = "Enter Hand:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(258, 217);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(138, 40);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Check Possible Fusions:";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtHand1
            // 
            this.txtHand1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtHand1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtHand1.Location = new System.Drawing.Point(258, 48);
            this.txtHand1.Name = "txtHand1";
            this.txtHand1.Size = new System.Drawing.Size(211, 20);
            this.txtHand1.TabIndex = 13;
            // 
            // txtHand2
            // 
            this.txtHand2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtHand2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtHand2.Location = new System.Drawing.Point(258, 82);
            this.txtHand2.Name = "txtHand2";
            this.txtHand2.Size = new System.Drawing.Size(211, 20);
            this.txtHand2.TabIndex = 14;
            // 
            // txtHand3
            // 
            this.txtHand3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtHand3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtHand3.Location = new System.Drawing.Point(258, 116);
            this.txtHand3.Name = "txtHand3";
            this.txtHand3.Size = new System.Drawing.Size(211, 20);
            this.txtHand3.TabIndex = 15;
            // 
            // txtHand4
            // 
            this.txtHand4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtHand4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtHand4.Location = new System.Drawing.Point(258, 150);
            this.txtHand4.Name = "txtHand4";
            this.txtHand4.Size = new System.Drawing.Size(211, 20);
            this.txtHand4.TabIndex = 16;
            // 
            // txtHand5
            // 
            this.txtHand5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtHand5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtHand5.Location = new System.Drawing.Point(258, 184);
            this.txtHand5.Name = "txtHand5";
            this.txtHand5.Size = new System.Drawing.Size(211, 20);
            this.txtHand5.TabIndex = 17;
            // 
            // columnAtk
            // 
            this.columnAtk.Text = "ATK";
            this.columnAtk.Width = 40;
            // 
            // columnDef
            // 
            this.columnDef.Text = "DEF";
            this.columnDef.Width = 40;
            // 
            // FusionMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 450);
            this.Controls.Add(this.txtHand5);
            this.Controls.Add(this.txtHand4);
            this.Controls.Add(this.txtHand3);
            this.Controls.Add(this.txtHand2);
            this.Controls.Add(this.txtHand1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lbHand);
            this.Controls.Add(this.lbAllCards);
            this.Controls.Add(this.lstAllCards);
            this.Controls.Add(this.lbLstFusions);
            this.Controls.Add(this.lstFusions);
            this.Name = "FusionMainForm";
            this.Text = "Fusion Summons Forgotten Memories";
            this.Load += new System.EventHandler(this.FusionMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstFusions;
        private System.Windows.Forms.ColumnHeader columnMaterial1;
        private System.Windows.Forms.ColumnHeader columnMaterial2;
        private System.Windows.Forms.ColumnHeader columnSummon;
        private System.Windows.Forms.Label lbLstFusions;
        private System.Windows.Forms.ListView lstAllCards;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.Label lbAllCards;
        private System.Windows.Forms.Label lbHand;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtHand1;
        private System.Windows.Forms.TextBox txtHand2;
        private System.Windows.Forms.TextBox txtHand3;
        private System.Windows.Forms.TextBox txtHand4;
        private System.Windows.Forms.TextBox txtHand5;
        private System.Windows.Forms.ColumnHeader columnAtk;
        private System.Windows.Forms.ColumnHeader columnDef;
    }
}

