namespace HospitalManagement
{
    partial class PatientInfoUpdateForm
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
            this.eMailTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.mailLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.bloodtypeComboBox = new System.Windows.Forms.ComboBox();
            this.bloodTypeLbl = new System.Windows.Forms.Label();
            this.postalAreatxt = new System.Windows.Forms.TextBox();
            this.areaLbl = new System.Windows.Forms.Label();
            this.postCodeTxt = new System.Windows.Forms.TextBox();
            this.postCodeLbl = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.eNameLbl = new System.Windows.Forms.Label();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.personIdLbl = new System.Windows.Forms.Label();
            this.personIdTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // eMailTxt
            // 
            this.eMailTxt.Location = new System.Drawing.Point(95, 161);
            this.eMailTxt.Name = "eMailTxt";
            this.eMailTxt.Size = new System.Drawing.Size(275, 20);
            this.eMailTxt.TabIndex = 27;
            this.eMailTxt.TextChanged += new System.EventHandler(this.eMailTxt_TextChanged);
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(95, 134);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(126, 20);
            this.phoneTxt.TabIndex = 25;
            this.phoneTxt.TextChanged += new System.EventHandler(this.phoneTxt_TextChanged);
            // 
            // mailLbl
            // 
            this.mailLbl.AutoSize = true;
            this.mailLbl.Location = new System.Drawing.Point(16, 162);
            this.mailLbl.Name = "mailLbl";
            this.mailLbl.Size = new System.Drawing.Size(35, 13);
            this.mailLbl.TabIndex = 35;
            this.mailLbl.Text = "E-mail";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(12, 137);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(43, 13);
            this.phoneLbl.TabIndex = 34;
            this.phoneLbl.Text = "Telefon";
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Enabled = false;
            this.saveChangesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesBtn.Location = new System.Drawing.Point(226, 234);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(141, 23);
            this.saveChangesBtn.TabIndex = 33;
            this.saveChangesBtn.Text = "Spara Ändringar";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
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
            this.bloodtypeComboBox.Location = new System.Drawing.Point(95, 197);
            this.bloodtypeComboBox.Name = "bloodtypeComboBox";
            this.bloodtypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.bloodtypeComboBox.TabIndex = 28;
            this.bloodtypeComboBox.SelectedIndexChanged += new System.EventHandler(this.bloodtypeComboBox_SelectedIndexChanged);
            // 
            // bloodTypeLbl
            // 
            this.bloodTypeLbl.AutoSize = true;
            this.bloodTypeLbl.Location = new System.Drawing.Point(16, 200);
            this.bloodTypeLbl.Name = "bloodTypeLbl";
            this.bloodTypeLbl.Size = new System.Drawing.Size(55, 13);
            this.bloodTypeLbl.TabIndex = 32;
            this.bloodTypeLbl.Text = "Blodgrupp";
            // 
            // postalAreatxt
            // 
            this.postalAreatxt.Location = new System.Drawing.Point(226, 108);
            this.postalAreatxt.Name = "postalAreatxt";
            this.postalAreatxt.ReadOnly = true;
            this.postalAreatxt.Size = new System.Drawing.Size(144, 20);
            this.postalAreatxt.TabIndex = 31;
            this.postalAreatxt.Validating += new System.ComponentModel.CancelEventHandler(this.postalAreatxt_Validating);
            // 
            // areaLbl
            // 
            this.areaLbl.AutoSize = true;
            this.areaLbl.Location = new System.Drawing.Point(180, 111);
            this.areaLbl.Name = "areaLbl";
            this.areaLbl.Size = new System.Drawing.Size(40, 13);
            this.areaLbl.TabIndex = 30;
            this.areaLbl.Text = "Postort";
            // 
            // postCodeTxt
            // 
            this.postCodeTxt.Location = new System.Drawing.Point(95, 108);
            this.postCodeTxt.MaxLength = 5;
            this.postCodeTxt.Name = "postCodeTxt";
            this.postCodeTxt.Size = new System.Drawing.Size(73, 20);
            this.postCodeTxt.TabIndex = 24;
            this.postCodeTxt.TextChanged += new System.EventHandler(this.postCodeTxt_TextChanged);
            this.postCodeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.postalAreatxt_Validating);
            // 
            // postCodeLbl
            // 
            this.postCodeLbl.AutoSize = true;
            this.postCodeLbl.Location = new System.Drawing.Point(12, 111);
            this.postCodeLbl.Name = "postCodeLbl";
            this.postCodeLbl.Size = new System.Drawing.Size(46, 13);
            this.postCodeLbl.TabIndex = 29;
            this.postCodeLbl.Text = "Postkod";
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(95, 82);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(275, 20);
            this.addressTxt.TabIndex = 23;
            this.addressTxt.TextChanged += new System.EventHandler(this.addressTxt_TextChanged);
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(12, 87);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(39, 13);
            this.addressLbl.TabIndex = 26;
            this.addressLbl.Text = "Adress";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(270, 56);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(100, 20);
            this.lastNameTxt.TabIndex = 21;
            this.lastNameTxt.TextChanged += new System.EventHandler(this.lastNameTxt_TextChanged);
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(95, 56);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(100, 20);
            this.firstNameTxt.TabIndex = 18;
            this.firstNameTxt.TextChanged += new System.EventHandler(this.firstNameTxt_TextChanged);
            // 
            // eNameLbl
            // 
            this.eNameLbl.AutoSize = true;
            this.eNameLbl.Location = new System.Drawing.Point(209, 61);
            this.eNameLbl.Name = "eNameLbl";
            this.eNameLbl.Size = new System.Drawing.Size(55, 13);
            this.eNameLbl.TabIndex = 22;
            this.eNameLbl.Text = "Efternamn";
            // 
            // fNameLbl
            // 
            this.fNameLbl.AutoSize = true;
            this.fNameLbl.Location = new System.Drawing.Point(12, 61);
            this.fNameLbl.Name = "fNameLbl";
            this.fNameLbl.Size = new System.Drawing.Size(48, 13);
            this.fNameLbl.TabIndex = 20;
            this.fNameLbl.Text = "Förnamn";
            // 
            // personIdLbl
            // 
            this.personIdLbl.AutoSize = true;
            this.personIdLbl.Location = new System.Drawing.Point(12, 33);
            this.personIdLbl.Name = "personIdLbl";
            this.personIdLbl.Size = new System.Drawing.Size(77, 13);
            this.personIdLbl.TabIndex = 19;
            this.personIdLbl.Text = "Personnummer";
            // 
            // personIdTxt
            // 
            this.personIdTxt.Enabled = false;
            this.personIdTxt.Location = new System.Drawing.Point(95, 30);
            this.personIdTxt.MaxLength = 11;
            this.personIdTxt.Name = "personIdTxt";
            this.personIdTxt.Size = new System.Drawing.Size(100, 20);
            this.personIdTxt.TabIndex = 17;
            // 
            // PatientInfoUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 271);
            this.Controls.Add(this.eMailTxt);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.mailLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.saveChangesBtn);
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
            this.Name = "PatientInfoUpdateForm";
            this.Text = "PatientInfoUpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eMailTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label mailLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.ComboBox bloodtypeComboBox;
        private System.Windows.Forms.Label bloodTypeLbl;
        private System.Windows.Forms.TextBox postalAreatxt;
        private System.Windows.Forms.Label areaLbl;
        private System.Windows.Forms.TextBox postCodeTxt;
        private System.Windows.Forms.Label postCodeLbl;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label eNameLbl;
        private System.Windows.Forms.Label fNameLbl;
        private System.Windows.Forms.Label personIdLbl;
        private System.Windows.Forms.TextBox personIdTxt;
    }
}