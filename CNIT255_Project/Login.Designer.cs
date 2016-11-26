namespace _255_Project
{
    partial class Login
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddRestaurant = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSeeMenu = new System.Windows.Forms.Button();
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.lstSuggestions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRestaurant = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(506, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 51);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddRestaurant
            // 
            this.btnAddRestaurant.Location = new System.Drawing.Point(506, 308);
            this.btnAddRestaurant.Name = "btnAddRestaurant";
            this.btnAddRestaurant.Size = new System.Drawing.Size(103, 51);
            this.btnAddRestaurant.TabIndex = 30;
            this.btnAddRestaurant.Text = "Add Restaurant";
            this.btnAddRestaurant.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(506, 251);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 51);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSeeMenu
            // 
            this.btnSeeMenu.Location = new System.Drawing.Point(506, 192);
            this.btnSeeMenu.Name = "btnSeeMenu";
            this.btnSeeMenu.Size = new System.Drawing.Size(103, 51);
            this.btnSeeMenu.TabIndex = 28;
            this.btnSeeMenu.Text = "See Menu(s)";
            this.btnSeeMenu.UseVisualStyleBackColor = true;
            this.btnSeeMenu.Click += new System.EventHandler(this.btnSeeMenu_Click);
            // 
            // lstMenu
            // 
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.ItemHeight = 16;
            this.lstMenu.Location = new System.Drawing.Point(46, 365);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(426, 132);
            this.lstMenu.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Menu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "255 Project";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(190, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 16;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(506, 135);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(103, 51);
            this.btnApply.TabIndex = 36;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstSuggestions
            // 
            this.lstSuggestions.FormattingEnabled = true;
            this.lstSuggestions.ItemHeight = 16;
            this.lstSuggestions.Location = new System.Drawing.Point(45, 210);
            this.lstSuggestions.Name = "lstSuggestions";
            this.lstSuggestions.Size = new System.Drawing.Size(426, 132);
            this.lstSuggestions.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Suggestions:";
            // 
            // cboRestaurant
            // 
            this.cboRestaurant.FormattingEnabled = true;
            this.cboRestaurant.Items.AddRange(new object[] {
            "Chinese",
            "Mexican",
            "Burgers",
            "Breakfast",
            "Coffee",
            "Indian",
            "Italian",
            "Japanese ",
            "International "});
            this.cboRestaurant.Location = new System.Drawing.Point(46, 74);
            this.cboRestaurant.Name = "cboRestaurant";
            this.cboRestaurant.Size = new System.Drawing.Size(425, 24);
            this.cboRestaurant.TabIndex = 45;
            this.cboRestaurant.Text = "Restaurant";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 551);
            this.Controls.Add(this.cboRestaurant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSuggestions);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddRestaurant);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSeeMenu);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Name = "Login";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddRestaurant;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSeeMenu;
        private System.Windows.Forms.ListBox lstMenu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ListBox lstSuggestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRestaurant;

    }
}