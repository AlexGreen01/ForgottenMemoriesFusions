namespace ForgottenMemoriesFusions
{
    partial class AllCardsForm
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
            this.lstAllCards = new System.Windows.Forms.ListView();
            this.columnCardName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbNote = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAtk = new System.Windows.Forms.TextBox();
            this.txtDef = new System.Windows.Forms.TextBox();
            this.txtEffect = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbAtk = new System.Windows.Forms.Label();
            this.lbDef = new System.Windows.Forms.Label();
            this.lbEffect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstAllCards
            // 
            this.lstAllCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.lstAllCards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCardName});
            this.lstAllCards.ForeColor = System.Drawing.SystemColors.Window;
            this.lstAllCards.FullRowSelect = true;
            this.lstAllCards.HideSelection = false;
            this.lstAllCards.Location = new System.Drawing.Point(52, 26);
            this.lstAllCards.MultiSelect = false;
            this.lstAllCards.Name = "lstAllCards";
            this.lstAllCards.Size = new System.Drawing.Size(225, 270);
            this.lstAllCards.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstAllCards.TabIndex = 0;
            this.lstAllCards.UseCompatibleStateImageBehavior = false;
            this.lstAllCards.View = System.Windows.Forms.View.Details;
            this.lstAllCards.SelectedIndexChanged += new System.EventHandler(this.lstAllCards_SelectedIndexChanged);
            // 
            // columnCardName
            // 
            this.columnCardName.Text = "All Cards In Game:";
            this.columnCardName.Width = 220;
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Yu Mincho", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.ForeColor = System.Drawing.SystemColors.Control;
            this.lbNote.Location = new System.Drawing.Point(315, 137);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(300, 57);
            this.lbNote.TabIndex = 1;
            this.lbNote.Text = "Select or Search Card For Details\r\n(Monsters In This Game Dont Have Effects)\r\n(Ef" +
    "fects Are Quoted from Game)";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSearch.Location = new System.Drawing.Point(319, 69);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Yu Mincho", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(319, 102);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.txtName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtName.Location = new System.Drawing.Point(897, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.txtType.ForeColor = System.Drawing.SystemColors.Window;
            this.txtType.Location = new System.Drawing.Point(897, 70);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(228, 20);
            this.txtType.TabIndex = 5;
            // 
            // txtAtk
            // 
            this.txtAtk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.txtAtk.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAtk.Location = new System.Drawing.Point(897, 116);
            this.txtAtk.Name = "txtAtk";
            this.txtAtk.Size = new System.Drawing.Size(228, 20);
            this.txtAtk.TabIndex = 6;
            // 
            // txtDef
            // 
            this.txtDef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.txtDef.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDef.Location = new System.Drawing.Point(897, 162);
            this.txtDef.Name = "txtDef";
            this.txtDef.Size = new System.Drawing.Size(228, 20);
            this.txtDef.TabIndex = 7;
            // 
            // txtEffect
            // 
            this.txtEffect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.txtEffect.ForeColor = System.Drawing.SystemColors.Info;
            this.txtEffect.Location = new System.Drawing.Point(897, 208);
            this.txtEffect.Multiline = true;
            this.txtEffect.Name = "txtEffect";
            this.txtEffect.Size = new System.Drawing.Size(228, 88);
            this.txtEffect.TabIndex = 8;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Yu Mincho", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbName.Location = new System.Drawing.Point(847, 24);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 14);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Name";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Yu Mincho", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.SystemColors.Control;
            this.lbType.Location = new System.Drawing.Point(847, 70);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(31, 14);
            this.lbType.TabIndex = 10;
            this.lbType.Text = "Type";
            // 
            // lbAtk
            // 
            this.lbAtk.AutoSize = true;
            this.lbAtk.Font = new System.Drawing.Font("Yu Mincho", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtk.ForeColor = System.Drawing.SystemColors.Control;
            this.lbAtk.Location = new System.Drawing.Point(847, 116);
            this.lbAtk.Name = "lbAtk";
            this.lbAtk.Size = new System.Drawing.Size(31, 14);
            this.lbAtk.TabIndex = 11;
            this.lbAtk.Text = "ATK";
            // 
            // lbDef
            // 
            this.lbDef.AutoSize = true;
            this.lbDef.Font = new System.Drawing.Font("Yu Mincho", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDef.ForeColor = System.Drawing.SystemColors.Control;
            this.lbDef.Location = new System.Drawing.Point(847, 162);
            this.lbDef.Name = "lbDef";
            this.lbDef.Size = new System.Drawing.Size(30, 14);
            this.lbDef.TabIndex = 12;
            this.lbDef.Text = "DEF";
            // 
            // lbEffect
            // 
            this.lbEffect.AutoSize = true;
            this.lbEffect.Font = new System.Drawing.Font("Yu Mincho", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEffect.ForeColor = System.Drawing.SystemColors.Control;
            this.lbEffect.Location = new System.Drawing.Point(847, 208);
            this.lbEffect.Name = "lbEffect";
            this.lbEffect.Size = new System.Drawing.Size(35, 14);
            this.lbEffect.TabIndex = 13;
            this.lbEffect.Text = "Effect";
            // 
            // AllCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(1184, 331);
            this.Controls.Add(this.lbEffect);
            this.Controls.Add(this.lbDef);
            this.Controls.Add(this.lbAtk);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtEffect);
            this.Controls.Add(this.txtDef);
            this.Controls.Add(this.txtAtk);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.lstAllCards);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllCardsForm";
            this.Text = "AllCardsForm";
            this.Load += new System.EventHandler(this.AllCardsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstAllCards;
        private System.Windows.Forms.ColumnHeader columnCardName;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtAtk;
        private System.Windows.Forms.TextBox txtDef;
        private System.Windows.Forms.TextBox txtEffect;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbAtk;
        private System.Windows.Forms.Label lbDef;
        private System.Windows.Forms.Label lbEffect;
    }
}