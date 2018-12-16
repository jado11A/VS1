namespace Registry
{
    partial class Registry
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
            this.tb_password_registry = new System.Windows.Forms.RichTextBox();
            this.tb_username_registry = new System.Windows.Forms.RichTextBox();
            this.tb_rp_password_registry = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_registry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_password_registry
            // 
            this.tb_password_registry.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password_registry.Location = new System.Drawing.Point(65, 200);
            this.tb_password_registry.Name = "tb_password_registry";
            this.tb_password_registry.Size = new System.Drawing.Size(350, 35);
            this.tb_password_registry.TabIndex = 3;
            this.tb_password_registry.Text = "password";
            this.tb_password_registry.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // tb_username_registry
            // 
            this.tb_username_registry.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username_registry.Location = new System.Drawing.Point(65, 150);
            this.tb_username_registry.Name = "tb_username_registry";
            this.tb_username_registry.Size = new System.Drawing.Size(350, 35);
            this.tb_username_registry.TabIndex = 2;
            this.tb_username_registry.Text = "username";
            // 
            // tb_rp_password_registry
            // 
            this.tb_rp_password_registry.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_rp_password_registry.Location = new System.Drawing.Point(65, 250);
            this.tb_rp_password_registry.Name = "tb_rp_password_registry";
            this.tb_rp_password_registry.Size = new System.Drawing.Size(350, 35);
            this.tb_rp_password_registry.TabIndex = 4;
            this.tb_rp_password_registry.Text = "repeat password";
            this.tb_rp_password_registry.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(296, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(9, 9);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(65, 340);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(90, 35);
            this.btn_send.TabIndex = 6;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(325, 340);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 35);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // lbl_registry
            // 
            this.lbl_registry.AutoSize = true;
            this.lbl_registry.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registry.Location = new System.Drawing.Point(180, 70);
            this.lbl_registry.Name = "lbl_registry";
            this.lbl_registry.Size = new System.Drawing.Size(125, 32);
            this.lbl_registry.TabIndex = 9;
            this.lbl_registry.Text = "Registry";
            // 
            // Registry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lbl_registry);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tb_rp_password_registry);
            this.Controls.Add(this.tb_password_registry);
            this.Controls.Add(this.tb_username_registry);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Registry";
            this.Text = "Registry";
            this.Load += new System.EventHandler(this.Registry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tb_password_registry;
        private System.Windows.Forms.RichTextBox tb_username_registry;
        private System.Windows.Forms.RichTextBox tb_rp_password_registry;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lbl_registry;
    }
}

