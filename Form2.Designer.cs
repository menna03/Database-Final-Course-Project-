﻿namespace DataBase
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Student name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Student password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.DarkGray;
            this.tbPassword.Location = new System.Drawing.Point(256, 234);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(117, 30);
            this.tbPassword.TabIndex = 20;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(402, 101);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 96);
            this.button5.TabIndex = 19;
            this.button5.Text = "Sign Up";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Student id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbemail
            // 
            this.tbemail.BackColor = System.Drawing.Color.DarkGray;
            this.tbemail.Location = new System.Drawing.Point(256, 168);
            this.tbemail.Margin = new System.Windows.Forms.Padding(2);
            this.tbemail.Multiline = true;
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(117, 29);
            this.tbemail.TabIndex = 18;
            this.tbemail.TextChanged += new System.EventHandler(this.tbemail_TextChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(17, 292);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "Back ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbname
            // 
            this.tbname.BackColor = System.Drawing.Color.DarkGray;
            this.tbname.Location = new System.Drawing.Point(256, 102);
            this.tbname.Margin = new System.Windows.Forms.Padding(2);
            this.tbname.Multiline = true;
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(117, 29);
            this.tbname.TabIndex = 17;
            this.tbname.TextChanged += new System.EventHandler(this.tbname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Student email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbid
            // 
            this.tbid.BackColor = System.Drawing.Color.DarkGray;
            this.tbid.Location = new System.Drawing.Point(256, 23);
            this.tbid.Margin = new System.Windows.Forms.Padding(2);
            this.tbid.Multiline = true;
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(117, 29);
            this.tbid.TabIndex = 16;
            this.tbid.TextChanged += new System.EventHandler(this.tbid_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbid;
    }
}