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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbAllCards = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstFusions
            // 
            this.lstFusions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMaterial1,
            this.columnMaterial2,
            this.columnSummon});
            this.lstFusions.HideSelection = false;
            this.lstFusions.Location = new System.Drawing.Point(520, 48);
            this.lstFusions.Name = "lstFusions";
            this.lstFusions.Size = new System.Drawing.Size(260, 390);
            this.lstFusions.TabIndex = 0;
            this.lstFusions.UseCompatibleStateImageBehavior = false;
            this.lstFusions.View = System.Windows.Forms.View.Details;
            // 
            // columnMaterial1
            // 
            this.columnMaterial1.Text = "Material 1";
            this.columnMaterial1.Width = 70;
            // 
            // columnMaterial2
            // 
            this.columnMaterial2.Text = "Material 2";
            this.columnMaterial2.Width = 70;
            // 
            // columnSummon
            // 
            this.columnSummon.Text = "Summons:";
            this.columnSummon.Width = 120;
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
            this.lstAllCards.Location = new System.Drawing.Point(319, 100);
            this.lstAllCards.Name = "lstAllCards";
            this.lstAllCards.Size = new System.Drawing.Size(170, 338);
            this.lstAllCards.TabIndex = 2;
            this.lstAllCards.UseCompatibleStateImageBehavior = false;
            this.lstAllCards.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Card Name";
            this.columnName.Width = 170;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(319, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(319, 29);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(69, 13);
            this.lbSearch.TabIndex = 4;
            this.lbSearch.Text = "Search Card:";
            // 
            // lbAllCards
            // 
            this.lbAllCards.AutoSize = true;
            this.lbAllCards.Location = new System.Drawing.Point(319, 81);
            this.lbAllCards.Name = "lbAllCards";
            this.lbAllCards.Size = new System.Drawing.Size(94, 13);
            this.lbAllCards.TabIndex = 5;
            this.lbAllCards.Text = "All Cards In Game:";
            // 
            // FusionMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.lbAllCards);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txtSearch);
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
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label lbAllCards;
    }
}

