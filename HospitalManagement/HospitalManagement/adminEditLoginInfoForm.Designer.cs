namespace HospitalManagement
{
    partial class adminEditLoginInfoForm
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
            this.userNameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.doItBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordWarningLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(39, 30);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(82, 13);
            this.userNameLbl.TabIndex = 0;
            this.userNameLbl.Text = "Användarnamn:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(39, 69);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(76, 13);
            this.passwordLbl.TabIndex = 1;
            this.passwordLbl.Text = "Nytt Lösenord:";
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.Location = new System.Drawing.Point(127, 27);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(184, 20);
            this.userNameTxtBox.TabIndex = 2;
            this.userNameTxtBox.TextChanged += new System.EventHandler(this.ActivateButtonIfChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(127, 66);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(184, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.ActivateButtonIfChanged);
            // 
            // doItBtn
            // 
            this.doItBtn.Enabled = false;
            this.doItBtn.Location = new System.Drawing.Point(134, 113);
            this.doItBtn.Name = "doItBtn";
            this.doItBtn.Size = new System.Drawing.Size(75, 23);
            this.doItBtn.TabIndex = 4;
            this.doItBtn.Text = "Uppdatera";
            this.doItBtn.UseVisualStyleBackColor = true;
            this.doItBtn.Click += new System.EventHandler(this.doItBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // passwordWarningLbl
            // 
            this.passwordWarningLbl.AutoSize = true;
            this.passwordWarningLbl.ForeColor = System.Drawing.Color.Blue;
            this.passwordWarningLbl.Location = new System.Drawing.Point(99, 97);
            this.passwordWarningLbl.Name = "passwordWarningLbl";
            this.passwordWarningLbl.Size = new System.Drawing.Size(157, 13);
            this.passwordWarningLbl.TabIndex = 5;
            this.passwordWarningLbl.Text = "OBS! Lösenord kommer ändras.";
            this.passwordWarningLbl.Visible = false;
            // 
            // adminEditLoginInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 157);
            this.Controls.Add(this.passwordWarningLbl);
            this.Controls.Add(this.doItBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.userNameLbl);
            this.Name = "adminEditLoginInfoForm";
            this.Text = "Ändra inloggningsuppgifter";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button doItBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label passwordWarningLbl;
    }
}