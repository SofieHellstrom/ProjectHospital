namespace HospitalManagement
{
    partial class PatientRegistryForm
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
            this.personIdTxt = new System.Windows.Forms.TextBox();
            this.personIdLbl = new System.Windows.Forms.Label();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.eNameLbl = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.postCodeLbl = new System.Windows.Forms.Label();
            this.postCodeTxt = new System.Windows.Forms.TextBox();
            this.areaLbl = new System.Windows.Forms.Label();
            this.postalAreatxt = new System.Windows.Forms.TextBox();
            this.bloodTypeLbl = new System.Windows.Forms.Label();
            this.bloodtypeComboBox = new System.Windows.Forms.ComboBox();
            this.savePatientBtn = new System.Windows.Forms.Button();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.mailLbl = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.eMailTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // personIdTxt
            // 
            this.personIdTxt.Location = new System.Drawing.Point(99, 36);
            this.personIdTxt.MaxLength = 11;
            this.personIdTxt.Name = "personIdTxt";
            this.personIdTxt.Size = new System.Drawing.Size(100, 20);
            this.personIdTxt.TabIndex = 0;
            // 
            // personIdLbl
            // 
            this.personIdLbl.AutoSize = true;
            this.personIdLbl.Location = new System.Drawing.Point(16, 39);
            this.personIdLbl.Name = "personIdLbl";
            this.personIdLbl.Size = new System.Drawing.Size(77, 13);
            this.personIdLbl.TabIndex = 1;
            this.personIdLbl.Text = "Personnummer";
            // 
            // fNameLbl
            // 
            this.fNameLbl.AutoSize = true;
            this.fNameLbl.Location = new System.Drawing.Point(16, 67);
            this.fNameLbl.Name = "fNameLbl";
            this.fNameLbl.Size = new System.Drawing.Size(48, 13);
            this.fNameLbl.TabIndex = 2;
            this.fNameLbl.Text = "Förnamn";
            // 
            // eNameLbl
            // 
            this.eNameLbl.AutoSize = true;
            this.eNameLbl.Location = new System.Drawing.Point(213, 67);
            this.eNameLbl.Name = "eNameLbl";
            this.eNameLbl.Size = new System.Drawing.Size(55, 13);
            this.eNameLbl.TabIndex = 3;
            this.eNameLbl.Text = "Efternamn";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(99, 62);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(100, 20);
            this.firstNameTxt.TabIndex = 1;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(274, 62);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(100, 20);
            this.lastNameTxt.TabIndex = 2;
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(16, 93);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(39, 13);
            this.addressLbl.TabIndex = 6;
            this.addressLbl.Text = "Adress";
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(99, 88);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(275, 20);
            this.addressTxt.TabIndex = 3;
            // 
            // postCodeLbl
            // 
            this.postCodeLbl.AutoSize = true;
            this.postCodeLbl.Location = new System.Drawing.Point(16, 117);
            this.postCodeLbl.Name = "postCodeLbl";
            this.postCodeLbl.Size = new System.Drawing.Size(46, 13);
            this.postCodeLbl.TabIndex = 8;
            this.postCodeLbl.Text = "Postkod";
            // 
            // postCodeTxt
            // 
            this.postCodeTxt.Location = new System.Drawing.Point(99, 114);
            this.postCodeTxt.MaxLength = 5;
            this.postCodeTxt.Name = "postCodeTxt";
            this.postCodeTxt.Size = new System.Drawing.Size(73, 20);
            this.postCodeTxt.TabIndex = 4;
            // 
            // areaLbl
            // 
            this.areaLbl.AutoSize = true;
            this.areaLbl.Location = new System.Drawing.Point(184, 117);
            this.areaLbl.Name = "areaLbl";
            this.areaLbl.Size = new System.Drawing.Size(40, 13);
            this.areaLbl.TabIndex = 10;
            this.areaLbl.Text = "Postort";
            // 
            // postalAreatxt
            // 
            this.postalAreatxt.Location = new System.Drawing.Point(230, 114);
            this.postalAreatxt.Name = "postalAreatxt";
            this.postalAreatxt.ReadOnly = true;
            this.postalAreatxt.Size = new System.Drawing.Size(144, 20);
            this.postalAreatxt.TabIndex = 11;
            // 
            // bloodTypeLbl
            // 
            this.bloodTypeLbl.AutoSize = true;
            this.bloodTypeLbl.Location = new System.Drawing.Point(20, 206);
            this.bloodTypeLbl.Name = "bloodTypeLbl";
            this.bloodTypeLbl.Size = new System.Drawing.Size(55, 13);
            this.bloodTypeLbl.TabIndex = 12;
            this.bloodTypeLbl.Text = "Blodgrupp";
            // 
            // bloodtypeComboBox
            // 
            this.bloodtypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.bloodtypeComboBox.FormattingEnabled = true;
            this.bloodtypeComboBox.Items.AddRange(new object[] {
            "A - Positiv",
            "A - Negativ",
            "B - Positiv",
            "B - Negativ",
            "0 - Positiv",
            "0 - Negativ",
            "AB - Positiv",
            "AB - Negativ"});
            this.bloodtypeComboBox.Location = new System.Drawing.Point(99, 203);
            this.bloodtypeComboBox.Name = "bloodtypeComboBox";
            this.bloodtypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.bloodtypeComboBox.TabIndex = 7;
            // 
            // savePatientBtn
            // 
            this.savePatientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePatientBtn.Location = new System.Drawing.Point(230, 240);
            this.savePatientBtn.Name = "savePatientBtn";
            this.savePatientBtn.Size = new System.Drawing.Size(141, 23);
            this.savePatientBtn.TabIndex = 14;
            this.savePatientBtn.Text = "Registrera Patient";
            this.savePatientBtn.UseVisualStyleBackColor = true;
            this.savePatientBtn.Click += new System.EventHandler(this.savePatientBtn_Click);
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(16, 143);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(43, 13);
            this.phoneLbl.TabIndex = 15;
            this.phoneLbl.Text = "Telefon";
            // 
            // mailLbl
            // 
            this.mailLbl.AutoSize = true;
            this.mailLbl.Location = new System.Drawing.Point(20, 168);
            this.mailLbl.Name = "mailLbl";
            this.mailLbl.Size = new System.Drawing.Size(35, 13);
            this.mailLbl.TabIndex = 16;
            this.mailLbl.Text = "E-mail";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(99, 140);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(126, 20);
            this.phoneTxt.TabIndex = 5;
            // 
            // eMailTxt
            // 
            this.eMailTxt.Location = new System.Drawing.Point(99, 167);
            this.eMailTxt.Name = "eMailTxt";
            this.eMailTxt.Size = new System.Drawing.Size(275, 20);
            this.eMailTxt.TabIndex = 6;
            // 
            // PatientRegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 280);
            this.Controls.Add(this.eMailTxt);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.mailLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.savePatientBtn);
            this.Controls.Add(this.bloodtypeComboBox);
            this.Controls.Add(this.bloodTypeLbl);
            this.Controls.Add(this.postalAreatxt);
            this.Controls.Add(this.areaLbl);
            this.Controls.Add(this.postCodeTxt);
            this.Controls.Add(this.postCodeLbl);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.eNameLbl);
            this.Controls.Add(this.fNameLbl);
            this.Controls.Add(this.personIdLbl);
            this.Controls.Add(this.personIdTxt);
            this.Name = "PatientRegistryForm";
            this.Text = "PatientRegistryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox personIdTxt;
        private System.Windows.Forms.Label personIdLbl;
        private System.Windows.Forms.Label fNameLbl;
        private System.Windows.Forms.Label eNameLbl;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label postCodeLbl;
        private System.Windows.Forms.TextBox postCodeTxt;
        private System.Windows.Forms.Label areaLbl;
        private System.Windows.Forms.TextBox postalAreatxt;
        private System.Windows.Forms.Label bloodTypeLbl;
        private System.Windows.Forms.ComboBox bloodtypeComboBox;
        private System.Windows.Forms.Button savePatientBtn;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label mailLbl;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox eMailTxt;
    }
}