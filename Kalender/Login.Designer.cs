namespace WindowsFormsApp1
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_username_login = new System.Windows.Forms.RichTextBox();
            this.tb_password_login = new System.Windows.Forms.RichTextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_quit_login = new System.Windows.Forms.Button();
            this.lbl_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_username_login
            // 
            this.tb_username_login.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username_login.Location = new System.Drawing.Point(65, 200);
            this.tb_username_login.Name = "tb_username_login";
            this.tb_username_login.Size = new System.Drawing.Size(350, 35);
            this.tb_username_login.TabIndex = 0;
            this.tb_username_login.Text = "username";
            this.tb_username_login.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tb_password_login
            // 
            this.tb_password_login.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password_login.Location = new System.Drawing.Point(65, 250);
            this.tb_password_login.Name = "tb_password_login";
            this.tb_password_login.Size = new System.Drawing.Size(350, 35);
            this.tb_password_login.TabIndex = 1;
            this.tb_password_login.Text = "password";
            this.tb_password_login.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(65, 340);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(90, 35);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_click);
            // 
            // btn_quit_login
            // 
            this.btn_quit_login.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit_login.Location = new System.Drawing.Point(325, 340);
            this.btn_quit_login.Name = "btn_quit_login";
            this.btn_quit_login.Size = new System.Drawing.Size(90, 35);
            this.btn_quit_login.TabIndex = 3;
            this.btn_quit_login.Text = "Quit";
            this.btn_quit_login.UseVisualStyleBackColor = true;
            this.btn_quit_login.Click += new System.EventHandler(this.btn_quit_login_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(190, 85);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(91, 32);
            this.lbl_login.TabIndex = 4;
            this.lbl_login.Text = "Login";
            this.lbl_login.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.btn_quit_login);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password_login);
            this.Controls.Add(this.tb_username_login);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tb_username_login;
        private System.Windows.Forms.RichTextBox tb_password_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_quit_login;
        private System.Windows.Forms.Label lbl_login;
    }
}

