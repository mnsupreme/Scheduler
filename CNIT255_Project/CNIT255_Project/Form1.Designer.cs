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
            this.listBox_Rest.Size = new System.Drawing.Size(238, 177);
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
            // StarvingBoiler_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1035, 531);
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

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.ListBox listBox_Rest;
        private System.Windows.Forms.Label Label_frm;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Owner;
        private System.Windows.Forms.Label label_Customer;
    }
}

