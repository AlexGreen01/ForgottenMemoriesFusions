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
            this.lstMaterial3 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.columnMaterial3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFusion3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAtk3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDef3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOtherMat3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstMaterial4 = new System.Windows.Forms.ListView();
            this.columnOtherMat4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMaterial4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFusion4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAtk4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDef4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lstMaterial5 = new System.Windows.Forms.ListView();
            this.columnOtherMat5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMaterial5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFusion5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAtk5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDef5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
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
            this.lstFusions.FullRowSelect = true;
            this.lstFusions.HideSelection = false;
            this.lstFusions.Location = new System.Drawing.Point(264, 48);
            this.lstFusions.Name = "lstFusions";
            this.lstFusions.Size = new System.Drawing.Size(372, 401);
            this.lstFusions.TabIndex = 0;
            this.lstFusions.UseCompatibleStateImageBehavior = false;
            this.lstFusions.View = System.Windows.Forms.View.Details;
            // 
            // columnMaterial1
            // 
            this.columnMaterial1.Text = "Material 1";
            this.columnMaterial1.Width = 90;
            // 
            // columnMaterial2
            // 
            this.columnMaterial2.Text = "Material 2";
            this.columnMaterial2.Width = 90;
            // 
            // columnSummon
            // 
            this.columnSummon.Text = "Summons:";
            this.columnSummon.Width = 110;
            // 
            // lbLstFusions
            // 
            this.lbLstFusions.AutoSize = true;
            this.lbLstFusions.Location = new System.Drawing.Point(261, 29);
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
            this.lstAllCards.Location = new System.Drawing.Point(46, 585);
            this.lstAllCards.Name = "lstAllCards";
            this.lstAllCards.Size = new System.Drawing.Size(182, 401);
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
            this.lbAllCards.Location = new System.Drawing.Point(43, 566);
            this.lbAllCards.Name = "lbAllCards";
            this.lbAllCards.Size = new System.Drawing.Size(94, 13);
            this.lbAllCards.TabIndex = 5;
            this.lbAllCards.Text = "All Cards In Game:";
            // 
            // lbHand
            // 
            this.lbHand.AutoSize = true;
            this.lbHand.Location = new System.Drawing.Point(17, 34);
            this.lbHand.Name = "lbHand";
            this.lbHand.Size = new System.Drawing.Size(64, 13);
            this.lbHand.TabIndex = 11;
            this.lbHand.Text = "Enter Hand:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(17, 222);
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
            this.txtHand1.Location = new System.Drawing.Point(17, 53);
            this.txtHand1.Name = "txtHand1";
            this.txtHand1.Size = new System.Drawing.Size(211, 20);
            this.txtHand1.TabIndex = 13;
            // 
            // txtHand2
            // 
            this.txtHand2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtHand2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtHand2.Location = new System.Drawing.Point(17, 87);
            this.txtHand2.Name = "txtHand2";
            this.txtHand2.Size = new System.Drawing.Size(211, 20);
            this.txtHand2.TabIndex = 14;
            // 
            // txtHand3
            // 
            this.txtHand3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtHand3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtHand3.Location = new System.Drawing.Point(17, 121);
            this.txtHand3.Name = "txtHand3";
            this.txtHand3.Size = new System.Drawing.Size(211, 20);
            this.txtHand3.TabIndex = 15;
            // 
            // txtHand4
            // 
            this.txtHand4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtHand4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtHand4.Location = new System.Drawing.Point(17, 155);
            this.txtHand4.Name = "txtHand4";
            this.txtHand4.Size = new System.Drawing.Size(211, 20);
            this.txtHand4.TabIndex = 16;
            // 
            // txtHand5
            // 
            this.txtHand5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtHand5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtHand5.Location = new System.Drawing.Point(17, 189);
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
            // lstMaterial3
            // 
            this.lstMaterial3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOtherMat3,
            this.columnMaterial3,
            this.columnFusion3,
            this.columnAtk3,
            this.columnDef3});
            this.lstMaterial3.HideSelection = false;
            this.lstMaterial3.Location = new System.Drawing.Point(667, 48);
            this.lstMaterial3.Name = "lstMaterial3";
            this.lstMaterial3.Size = new System.Drawing.Size(372, 401);
            this.lstMaterial3.TabIndex = 18;
            this.lstMaterial3.UseCompatibleStateImageBehavior = false;
            this.lstMaterial3.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Previous Fusions + Material";
            // 
            // columnMaterial3
            // 
            this.columnMaterial3.Text = "Material:";
            this.columnMaterial3.Width = 90;
            // 
            // columnFusion3
            // 
            this.columnFusion3.Text = "Summons:";
            this.columnFusion3.Width = 110;
            // 
            // columnAtk3
            // 
            this.columnAtk3.Text = "ATK";
            this.columnAtk3.Width = 40;
            // 
            // columnDef3
            // 
            this.columnDef3.Text = "DEF";
            this.columnDef3.Width = 40;
            // 
            // columnOtherMat3
            // 
            this.columnOtherMat3.Text = "Material:";
            this.columnOtherMat3.Width = 90;
            // 
            // lstMaterial4
            // 
            this.lstMaterial4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOtherMat4,
            this.columnMaterial4,
            this.columnFusion4,
            this.columnAtk4,
            this.columnDef4});
            this.lstMaterial4.HideSelection = false;
            this.lstMaterial4.Location = new System.Drawing.Point(1071, 48);
            this.lstMaterial4.Name = "lstMaterial4";
            this.lstMaterial4.Size = new System.Drawing.Size(372, 401);
            this.lstMaterial4.TabIndex = 20;
            this.lstMaterial4.UseCompatibleStateImageBehavior = false;
            this.lstMaterial4.View = System.Windows.Forms.View.Details;
            // 
            // columnOtherMat4
            // 
            this.columnOtherMat4.Text = "Material:";
            this.columnOtherMat4.Width = 90;
            // 
            // columnMaterial4
            // 
            this.columnMaterial4.Text = "Material:";
            this.columnMaterial4.Width = 90;
            // 
            // columnFusion4
            // 
            this.columnFusion4.Text = "Summons:";
            this.columnFusion4.Width = 110;
            // 
            // columnAtk4
            // 
            this.columnAtk4.Text = "ATK";
            this.columnAtk4.Width = 40;
            // 
            // columnDef4
            // 
            this.columnDef4.Text = "DEF";
            this.columnDef4.Width = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1068, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Previous Fusions + Material";
            // 
            // lstMaterial5
            // 
            this.lstMaterial5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOtherMat5,
            this.columnMaterial5,
            this.columnFusion5,
            this.columnAtk5,
            this.columnDef5});
            this.lstMaterial5.HideSelection = false;
            this.lstMaterial5.Location = new System.Drawing.Point(1471, 48);
            this.lstMaterial5.Name = "lstMaterial5";
            this.lstMaterial5.Size = new System.Drawing.Size(404, 401);
            this.lstMaterial5.TabIndex = 22;
            this.lstMaterial5.UseCompatibleStateImageBehavior = false;
            this.lstMaterial5.View = System.Windows.Forms.View.Details;
            // 
            // columnOtherMat5
            // 
            this.columnOtherMat5.Text = "Material:";
            this.columnOtherMat5.Width = 90;
            // 
            // columnMaterial5
            // 
            this.columnMaterial5.Text = "Material:";
            this.columnMaterial5.Width = 90;
            // 
            // columnFusion5
            // 
            this.columnFusion5.Text = "Summons:";
            this.columnFusion5.Width = 110;
            // 
            // columnAtk5
            // 
            this.columnAtk5.Text = "ATK";
            this.columnAtk5.Width = 40;
            // 
            // columnDef5
            // 
            this.columnDef5.Text = "DEF";
            this.columnDef5.Width = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1468, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Previous Fusions + Material";
            // 
            // FusionMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstMaterial5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstMaterial4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMaterial3);
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
        private System.Windows.Forms.ListView lstMaterial3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnMaterial3;
        private System.Windows.Forms.ColumnHeader columnFusion3;
        private System.Windows.Forms.ColumnHeader columnAtk3;
        private System.Windows.Forms.ColumnHeader columnOtherMat3;
        private System.Windows.Forms.ColumnHeader columnDef3;
        private System.Windows.Forms.ListView lstMaterial4;
        private System.Windows.Forms.ColumnHeader columnOtherMat4;
        private System.Windows.Forms.ColumnHeader columnMaterial4;
        private System.Windows.Forms.ColumnHeader columnFusion4;
        private System.Windows.Forms.ColumnHeader columnAtk4;
        private System.Windows.Forms.ColumnHeader columnDef4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstMaterial5;
        private System.Windows.Forms.ColumnHeader columnOtherMat5;
        private System.Windows.Forms.ColumnHeader columnMaterial5;
        private System.Windows.Forms.ColumnHeader columnFusion5;
        private System.Windows.Forms.ColumnHeader columnAtk5;
        private System.Windows.Forms.ColumnHeader columnDef5;
        private System.Windows.Forms.Label label3;
    }
}

