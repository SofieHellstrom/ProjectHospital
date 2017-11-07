namespace HospitalManagement
{
    partial class ChangeUserInfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oldPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.newPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.doItBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ange nuvarande lösenord:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ange nytt lösenord:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Upprepa nytt lösenord:";
            // 
            // oldPasswordTxtBox
            // 
            this.oldPasswordTxtBox.Location = new System.Drawing.Point(155, 31);
            this.oldPasswordTxtBox.Name = "oldPasswordTxtBox";
            this.oldPasswordTxtBox.Size = new System.Drawing.Size(176, 20);
            this.oldPasswordTxtBox.TabIndex = 3;
            // 
            // newPasswordTxtBox
            // 
            this.newPasswordTxtBox.Location = new System.Drawing.Point(155, 66);
            this.newPasswordTxtBox.Name = "newPasswordTxtBox";
            this.newPasswordTxtBox.Size = new System.Drawing.Size(176, 20);
            this.newPasswordTxtBox.TabIndex = 4;
            // 
            // repeatPasswordTxtBox
            // 
            this.repeatPasswordTxtBox.Location = new System.Drawing.Point(155, 101);
            this.repeatPasswordTxtBox.Name = "repeatPasswordTxtBox";
            this.repeatPasswordTxtBox.Size = new System.Drawing.Size(176, 20);
            this.repeatPasswordTxtBox.TabIndex = 5;
            // 
            // doItBtn
            // 
            this.doItBtn.Location = new System.Drawing.Point(120, 150);
            this.doItBtn.Name = "doItBtn";
            this.doItBtn.Size = new System.Drawing.Size(101, 23);
            this.doItBtn.TabIndex = 6;
            this.doItBtn.Text = "Byt Lösenord";
            this.doItBtn.UseVisualStyleBackColor = true;
            this.doItBtn.Click += new System.EventHandler(this.doItBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // ChangeUserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 199);
            this.Controls.Add(this.doItBtn);
            this.Controls.Add(this.repeatPasswordTxtBox);
            this.Controls.Add(this.newPasswordTxtBox);
            this.Controls.Add(this.oldPasswordTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeUserInfoForm";
            this.Text = "ChangeUserInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldPasswordTxtBox;
        private System.Windows.Forms.TextBox newPasswordTxtBox;
        private System.Windows.Forms.TextBox repeatPasswordTxtBox;
        private System.Windows.Forms.Button doItBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}