namespace CNIT255_Project
{
    partial class StarvingBoiler_Form
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
            this.label_Title = new System.Windows.Forms.Label();
            this.listBox_Rest = new System.Windows.Forms.ListBox();
            this.Label_frm = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Owner = new System.Windows.Forms.Label();
            this.label_Customer = new System.Windows.Forms.Label();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_Title.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.Black;
            this.label_Title.Location = new System.Drawing.Point(12, 25);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(974, 38);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Starving Boiler";
            // 
            // listBox_Rest
            // 
            this.listBox_Rest.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listBox_Rest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Rest.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Rest.FormattingEnabled = true;
            this.listBox_Rest.ItemHeight = 25;
            this.listBox_Rest.Items.AddRange(new object[] {
            "Rest_1",
            "Rest_2",
            "..."});
            this.listBox_Rest.Location = new System.Drawing.Point(19, 91);
            this.listBox_Rest.Name = "listBox_Rest";
            this.listBox_Rest.Size = new System.Drawing.Size(238, 152);
            this.listBox_Rest.TabIndex = 1;
            // 
            // Label_frm
            // 
            this.Label_frm.BackColor = System.Drawing.SystemColors.Control;
            this.Label_frm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_frm.Location = new System.Drawing.Point(853, 2);
            this.Label_frm.Name = "Label_frm";
            this.Label_frm.Size = new System.Drawing.Size(100, 23);
            this.Label_frm.TabIndex = 2;
            this.Label_frm.Text = "     ";
            // 
            // label_X
            // 
            this.label_X.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_X.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_X.ForeColor = System.Drawing.Color.Black;
            this.label_X.Location = new System.Drawing.Point(853, 43);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(37, 39);
            this.label_X.TabIndex = 3;
            this.label_X.Text = "X";
            this.label_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_X.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Owner
            // 
            this.label_Owner.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_Owner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Owner.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Owner.ForeColor = System.Drawing.Color.Black;
            this.label_Owner.Location = new System.Drawing.Point(853, 161);
            this.label_Owner.Name = "label_Owner";
            this.label_Owner.Size = new System.Drawing.Size(131, 41);
            this.label_Owner.TabIndex = 4;
            this.label_Owner.Text = "Owner";
            this.label_Owner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Customer
            // 
            this.label_Customer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_Customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Customer.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Customer.ForeColor = System.Drawing.Color.Black;
            this.label_Customer.Location = new System.Drawing.Point(853, 98);
            this.label_Customer.Name = "label_Customer";
            this.label_Customer.Size = new System.Drawing.Size(168, 41);
            this.label_Customer.TabIndex = 5;
            this.label_Customer.Text = "Customer";
            this.label_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(388, 176);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(55, 17);
            this.checkBox9.TabIndex = 64;
            this.checkBox9.Text = "Indian";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(473, 131);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(54, 17);
            this.checkBox8.TabIndex = 63;
            this.checkBox8.Text = "Italian";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(388, 153);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(57, 17);
            this.checkBox7.TabIndex = 62;
            this.checkBox7.Text = "Coffee";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(473, 153);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(72, 17);
            this.checkBox6.TabIndex = 61;
            this.checkBox6.Text = "Japanese";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(473, 177);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(84, 17);
            this.checkBox5.TabIndex = 60;
            this.checkBox5.Text = "International";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(388, 131);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(71, 17);
            this.checkBox3.TabIndex = 59;
            this.checkBox3.Text = "Breakfast";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Suggestions:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(307, 225);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(320, 108);
            this.listBox2.TabIndex = 57;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 164);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 41);
            this.button1.TabIndex = 56;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(307, 176);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(62, 17);
            this.checkBox4.TabIndex = 55;
            this.checkBox4.Text = "Burgers";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(308, 153);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 17);
            this.checkBox2.TabIndex = 54;
            this.checkBox2.Text = "Mexican";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(308, 131);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 53;
            this.checkBox1.Text = "Chinese";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(652, 351);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 41);
            this.button4.TabIndex = 52;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(652, 305);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 41);
            this.button5.TabIndex = 51;
            this.button5.Text = "Add Restaurant";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(652, 258);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 41);
            this.button6.TabIndex = 50;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(652, 210);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(77, 41);
            this.button7.TabIndex = 49;
            this.button7.Text = "See Menu(s)";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(308, 351);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(320, 108);
            this.listBox1.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 335);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Menu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "255 Project";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 238);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 45;
            // 
            // StarvingBoiler_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1028, 531);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_Customer);
            this.Controls.Add(this.label_Owner);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.listBox_Rest);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.Label_frm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StarvingBoiler_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StarvingBoiler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.ListBox listBox_Rest;
        private System.Windows.Forms.Label Label_frm;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Owner;
        private System.Windows.Forms.Label label_Customer;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}

