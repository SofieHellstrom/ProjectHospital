namespace HospitalManagement
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.warningLbl = new System.Windows.Forms.Label();
            this.skipLoginCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.snabbloginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skipLoginCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Användarnamn:";
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.Location = new System.Drawing.Point(149, 38);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(152, 22);
            this.usernameTxtBox.TabIndex = 2;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(149, 72);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(152, 22);
            this.passwordTxtBox.TabIndex = 3;
            this.passwordTxtBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lösenord:";
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(149, 138);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 27);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Logga in";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // warningLbl
            // 
            this.warningLbl.AutoSize = true;
            this.warningLbl.ForeColor = System.Drawing.Color.Red;
            this.warningLbl.Location = new System.Drawing.Point(164, 106);
            this.warningLbl.Name = "warningLbl";
            this.warningLbl.Size = new System.Drawing.Size(47, 13);
            this.warningLbl.TabIndex = 7;
            this.warningLbl.Text = "Warning";
            this.warningLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warningLbl.Visible = false;
            // 
            // skipLoginCMS
            // 
            this.skipLoginCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snabbloginToolStripMenuItem});
            this.skipLoginCMS.Name = "skipLoginCMS";
            this.skipLoginCMS.Size = new System.Drawing.Size(153, 48);
            // 
            // snabbloginToolStripMenuItem
            // 
            this.snabbloginToolStripMenuItem.Name = "snabbloginToolStripMenuItem";
            this.snabbloginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.snabbloginToolStripMenuItem.Text = "Snabblogin";
            this.snabbloginToolStripMenuItem.Click += new System.EventHandler(this.snabbloginToolStripMenuItem_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 209);
            this.ContextMenuStrip = this.skipLoginCMS;
            this.Controls.Add(this.warningLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.Text = "Inloggning";
            this.skipLoginCMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label warningLbl;
        private System.Windows.Forms.ContextMenuStrip skipLoginCMS;
        private System.Windows.Forms.ToolStripMenuItem snabbloginToolStripMenuItem;
    }
}