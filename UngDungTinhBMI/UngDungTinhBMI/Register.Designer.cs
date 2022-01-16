namespace UngDungTinhBMI
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtRPassword = new System.Windows.Forms.TextBox();
            this.txtRUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btRegister = new System.Windows.Forms.Button();
            this.pbHidePass = new System.Windows.Forms.PictureBox();
            this.pbShowPass = new System.Windows.Forms.PictureBox();
            this.pbHideCfPass = new System.Windows.Forms.PictureBox();
            this.pbShowCfPass = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHidePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideCfPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowCfPass)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConfirm
            // 
            this.txtConfirm.BackColor = System.Drawing.Color.White;
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.ForeColor = System.Drawing.Color.DimGray;
            this.txtConfirm.Location = new System.Drawing.Point(67, 343);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(397, 38);
            this.txtConfirm.TabIndex = 3;
            this.txtConfirm.Text = "Confirm Password";
            this.txtConfirm.Enter += new System.EventHandler(this.txtConfirm_Enter);
            this.txtConfirm.Leave += new System.EventHandler(this.txtConfirm_Leave);
            // 
            // txtRPassword
            // 
            this.txtRPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtRPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtRPassword.Location = new System.Drawing.Point(67, 269);
            this.txtRPassword.Name = "txtRPassword";
            this.txtRPassword.Size = new System.Drawing.Size(397, 38);
            this.txtRPassword.TabIndex = 2;
            this.txtRPassword.Text = "Password";
            this.txtRPassword.Enter += new System.EventHandler(this.txtRPassword_Enter);
            this.txtRPassword.Leave += new System.EventHandler(this.txtRPassword_Leave);
            // 
            // txtRUsername
            // 
            this.txtRUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtRUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtRUsername.Location = new System.Drawing.Point(67, 187);
            this.txtRUsername.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.txtRUsername.Name = "txtRUsername";
            this.txtRUsername.Size = new System.Drawing.Size(397, 38);
            this.txtRUsername.TabIndex = 1;
            this.txtRUsername.Text = "UserName";
            this.txtRUsername.Enter += new System.EventHandler(this.txtRUsername_Enter);
            this.txtRUsername.Leave += new System.EventHandler(this.txtRUsername_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 139);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.btRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.ForeColor = System.Drawing.Color.White;
            this.btRegister.Location = new System.Drawing.Point(67, 465);
            this.btRegister.Margin = new System.Windows.Forms.Padding(6);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(174, 58);
            this.btRegister.TabIndex = 4;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // pbHidePass
            // 
            this.pbHidePass.Image = global::UngDungTinhBMI.Properties.Resources.Black_Show_icon;
            this.pbHidePass.Location = new System.Drawing.Point(422, 276);
            this.pbHidePass.Name = "pbHidePass";
            this.pbHidePass.Size = new System.Drawing.Size(36, 24);
            this.pbHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHidePass.TabIndex = 7;
            this.pbHidePass.TabStop = false;
            this.pbHidePass.Click += new System.EventHandler(this.pbHidePass_Click);
            // 
            // pbShowPass
            // 
            this.pbShowPass.Image = global::UngDungTinhBMI.Properties.Resources.Black_Hide_icon;
            this.pbShowPass.Location = new System.Drawing.Point(422, 276);
            this.pbShowPass.Name = "pbShowPass";
            this.pbShowPass.Size = new System.Drawing.Size(36, 24);
            this.pbShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowPass.TabIndex = 6;
            this.pbShowPass.TabStop = false;
            this.pbShowPass.Click += new System.EventHandler(this.pbShowPass_Click);
            // 
            // pbHideCfPass
            // 
            this.pbHideCfPass.Image = global::UngDungTinhBMI.Properties.Resources.Black_Show_icon;
            this.pbHideCfPass.Location = new System.Drawing.Point(422, 350);
            this.pbHideCfPass.Name = "pbHideCfPass";
            this.pbHideCfPass.Size = new System.Drawing.Size(36, 24);
            this.pbHideCfPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHideCfPass.TabIndex = 9;
            this.pbHideCfPass.TabStop = false;
            this.pbHideCfPass.Click += new System.EventHandler(this.pbHideConfPass_Click);
            // 
            // pbShowCfPass
            // 
            this.pbShowCfPass.Image = global::UngDungTinhBMI.Properties.Resources.Black_Hide_icon;
            this.pbShowCfPass.Location = new System.Drawing.Point(422, 350);
            this.pbShowCfPass.Name = "pbShowCfPass";
            this.pbShowCfPass.Size = new System.Drawing.Size(36, 24);
            this.pbShowCfPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowCfPass.TabIndex = 8;
            this.pbShowCfPass.TabStop = false;
            this.pbShowCfPass.Click += new System.EventHandler(this.pbShowConfPass_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.pbHideCfPass);
            this.panel4.Controls.Add(this.pbHidePass);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtRUsername);
            this.panel4.Controls.Add(this.txtRPassword);
            this.panel4.Controls.Add(this.txtConfirm);
            this.panel4.Controls.Add(this.btRegister);
            this.panel4.Controls.Add(this.pbShowPass);
            this.panel4.Controls.Add(this.pbShowCfPass);
            this.panel4.Location = new System.Drawing.Point(351, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 604);
            this.panel4.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(290, 465);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 58);
            this.button1.TabIndex = 10;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 768);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Register_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbHidePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideCfPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowCfPass)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtRPassword;
        private System.Windows.Forms.TextBox txtRUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.PictureBox pbHidePass;
        private System.Windows.Forms.PictureBox pbShowPass;
        private System.Windows.Forms.PictureBox pbHideCfPass;
        private System.Windows.Forms.PictureBox pbShowCfPass;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
    }
}