namespace TeacherSite
{
    partial class HalamanLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanLogin));
            this.label9 = new System.Windows.Forms.Label();
            this.button_TSLogin = new System.Windows.Forms.Button();
            this.NIP = new System.Windows.Forms.Label();
            this.textBox_TSNIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TSPassGuru = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(81, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(427, 31);
            this.label9.TabIndex = 20;
            this.label9.Text = "Selamat Datang di Teacher Site";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_TSLogin
            // 
            this.button_TSLogin.Location = new System.Drawing.Point(242, 204);
            this.button_TSLogin.Name = "button_TSLogin";
            this.button_TSLogin.Size = new System.Drawing.Size(75, 23);
            this.button_TSLogin.TabIndex = 21;
            this.button_TSLogin.Text = "Login";
            this.button_TSLogin.UseVisualStyleBackColor = true;
            this.button_TSLogin.Click += new System.EventHandler(this.button_TSLogin_Click);
            // 
            // NIP
            // 
            this.NIP.AutoSize = true;
            this.NIP.Location = new System.Drawing.Point(147, 128);
            this.NIP.Name = "NIP";
            this.NIP.Size = new System.Drawing.Size(25, 13);
            this.NIP.TabIndex = 22;
            this.NIP.Text = "NIP";
            // 
            // textBox_TSNIP
            // 
            this.textBox_TSNIP.Location = new System.Drawing.Point(242, 125);
            this.textBox_TSNIP.Name = "textBox_TSNIP";
            this.textBox_TSNIP.Size = new System.Drawing.Size(179, 20);
            this.textBox_TSNIP.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Password";
            // 
            // textBox_TSPassGuru
            // 
            this.textBox_TSPassGuru.Location = new System.Drawing.Point(242, 157);
            this.textBox_TSPassGuru.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_TSPassGuru.Name = "textBox_TSPassGuru";
            this.textBox_TSPassGuru.PasswordChar = '*';
            this.textBox_TSPassGuru.Size = new System.Drawing.Size(179, 20);
            this.textBox_TSPassGuru.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Lupa Password ?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Hubungi Admin Untuk Melakukan Reset Password";
            // 
            // HalamanLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 360);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_TSPassGuru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_TSNIP);
            this.Controls.Add(this.NIP);
            this.Controls.Add(this.button_TSLogin);
            this.Controls.Add(this.label9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HalamanLogin";
            this.Text = "Teacher Site Smart Akademik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_TSLogin;
        private System.Windows.Forms.Label NIP;
        private System.Windows.Forms.TextBox textBox_TSNIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TSPassGuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

