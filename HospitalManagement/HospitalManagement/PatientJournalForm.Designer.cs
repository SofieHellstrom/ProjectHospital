namespace HospitalManagement
{
    partial class PatientJournalForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.bokningListbox = new System.Windows.Forms.ListBox();
            this.newNotesBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.journalpostPreviewTxtBox = new System.Windows.Forms.TextBox();
            this.journalPostListBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.signInBtn = new System.Windows.Forms.Button();
            this.signedInRoomTxtBox = new System.Windows.Forms.TextBox();
            this.signedInDepTxtBox = new System.Windows.Forms.TextBox();
            this.signInStatusTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.inskrivningsStatusLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.prescriptionListBox = new System.Windows.Forms.ListBox();
            this.createReceiptBtn = new System.Windows.Forms.Button();
            this.tidsbokningBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.allergyLbl = new System.Windows.Forms.Label();
            this.allergyListBox = new System.Windows.Forms.ListBox();
            this.testResultListBox = new System.Windows.Forms.ListBox();
            this.testResultLbl = new System.Windows.Forms.Label();
            this.bloodTypeTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.savePersonInfoChange = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.eMailTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.postalAreaTxt = new System.Windows.Forms.TextBox();
            this.postalCodeTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.namnTxt = new System.Windows.Forms.TextBox();
            this.personNrTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.groupBox6);
            this.mainPanel.Controls.Add(this.newNotesBtn);
            this.mainPanel.Controls.Add(this.groupBox5);
            this.mainPanel.Controls.Add(this.groupBox4);
            this.mainPanel.Controls.Add(this.groupBox3);
            this.mainPanel.Controls.Add(this.createReceiptBtn);
            this.mainPanel.Controls.Add(this.tidsbokningBtn);
            this.mainPanel.Controls.Add(this.groupBox2);
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(919, 732);
            this.mainPanel.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.bokningListbox);
            this.groupBox6.Location = new System.Drawing.Point(19, 608);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(540, 76);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Bokade tider/Provtagning";
            // 
            // bokningListbox
            // 
            this.bokningListbox.FormattingEnabled = true;
            this.bokningListbox.Location = new System.Drawing.Point(6, 15);
            this.bokningListbox.Name = "bokningListbox";
            this.bokningListbox.Size = new System.Drawing.Size(528, 56);
            this.bokningListbox.TabIndex = 0;
            // 
            // newNotesBtn
            // 
            this.newNotesBtn.Location = new System.Drawing.Point(652, 579);
            this.newNotesBtn.Name = "newNotesBtn";
            this.newNotesBtn.Size = new System.Drawing.Size(169, 23);
            this.newNotesBtn.TabIndex = 7;
            this.newNotesBtn.Text = "Ny Journal-anteckning";
            this.newNotesBtn.UseVisualStyleBackColor = true;
            this.newNotesBtn.Click += new System.EventHandler(this.newNotesBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.journalpostPreviewTxtBox);
            this.groupBox5.Controls.Add(this.journalPostListBox);
            this.groupBox5.Location = new System.Drawing.Point(565, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(343, 552);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Journal-anteckningar";
            // 
            // journalpostPreviewTxtBox
            // 
            this.journalpostPreviewTxtBox.Location = new System.Drawing.Point(6, 316);
            this.journalpostPreviewTxtBox.Multiline = true;
            this.journalpostPreviewTxtBox.Name = "journalpostPreviewTxtBox";
            this.journalpostPreviewTxtBox.Size = new System.Drawing.Size(331, 230);
            this.journalpostPreviewTxtBox.TabIndex = 1;
            this.journalpostPreviewTxtBox.Enter += new System.EventHandler(this.journalpostPreviewTxtBox_Enter);
            // 
            // journalPostListBox
            // 
            this.journalPostListBox.FormattingEnabled = true;
            this.journalPostListBox.Location = new System.Drawing.Point(6, 20);
            this.journalPostListBox.Name = "journalPostListBox";
            this.journalPostListBox.Size = new System.Drawing.Size(331, 290);
            this.journalPostListBox.TabIndex = 0;
            this.journalPostListBox.SelectedIndexChanged += new System.EventHandler(this.journalPostListBox_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.signInBtn);
            this.groupBox4.Controls.Add(this.signedInRoomTxtBox);
            this.groupBox4.Controls.Add(this.signedInDepTxtBox);
            this.groupBox4.Controls.Add(this.signInStatusTxtBox);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.inskrivningsStatusLbl);
            this.groupBox4.Location = new System.Drawing.Point(19, 274);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 156);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inskrivnings-uppgifter";
            // 
            // signInBtn
            // 
            this.signInBtn.Location = new System.Drawing.Point(12, 115);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(88, 23);
            this.signInBtn.TabIndex = 8;
            this.signInBtn.Text = "Skriv in";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // signedInRoomTxtBox
            // 
            this.signedInRoomTxtBox.Location = new System.Drawing.Point(90, 80);
            this.signedInRoomTxtBox.Name = "signedInRoomTxtBox";
            this.signedInRoomTxtBox.Size = new System.Drawing.Size(100, 20);
            this.signedInRoomTxtBox.TabIndex = 5;
            // 
            // signedInDepTxtBox
            // 
            this.signedInDepTxtBox.Location = new System.Drawing.Point(90, 53);
            this.signedInDepTxtBox.Name = "signedInDepTxtBox";
            this.signedInDepTxtBox.Size = new System.Drawing.Size(143, 20);
            this.signedInDepTxtBox.TabIndex = 4;
            // 
            // signInStatusTxtBox
            // 
            this.signInStatusTxtBox.Location = new System.Drawing.Point(90, 26);
            this.signInStatusTxtBox.Name = "signInStatusTxtBox";
            this.signInStatusTxtBox.Size = new System.Drawing.Size(143, 20);
            this.signInStatusTxtBox.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Rum";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Avdelning";
            // 
            // inskrivningsStatusLbl
            // 
            this.inskrivningsStatusLbl.AutoSize = true;
            this.inskrivningsStatusLbl.Location = new System.Drawing.Point(9, 29);
            this.inskrivningsStatusLbl.Name = "inskrivningsStatusLbl";
            this.inskrivningsStatusLbl.Size = new System.Drawing.Size(37, 13);
            this.inskrivningsStatusLbl.TabIndex = 0;
            this.inskrivningsStatusLbl.Text = "Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.prescriptionListBox);
            this.groupBox3.Location = new System.Drawing.Point(19, 436);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(540, 132);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recept";
            // 
            // prescriptionListBox
            // 
            this.prescriptionListBox.FormattingEnabled = true;
            this.prescriptionListBox.Location = new System.Drawing.Point(6, 19);
            this.prescriptionListBox.Name = "prescriptionListBox";
            this.prescriptionListBox.Size = new System.Drawing.Size(528, 108);
            this.prescriptionListBox.TabIndex = 0;
            // 
            // createReceiptBtn
            // 
            this.createReceiptBtn.Location = new System.Drawing.Point(19, 579);
            this.createReceiptBtn.Name = "createReceiptBtn";
            this.createReceiptBtn.Size = new System.Drawing.Size(113, 23);
            this.createReceiptBtn.TabIndex = 3;
            this.createReceiptBtn.Text = "Skriv Recept";
            this.createReceiptBtn.UseVisualStyleBackColor = true;
            this.createReceiptBtn.Click += new System.EventHandler(this.createReceiptBtn_Click);
            // 
            // tidsbokningBtn
            // 
            this.tidsbokningBtn.Location = new System.Drawing.Point(19, 690);
            this.tidsbokningBtn.Name = "tidsbokningBtn";
            this.tidsbokningBtn.Size = new System.Drawing.Size(131, 23);
            this.tidsbokningBtn.TabIndex = 2;
            this.tidsbokningBtn.Text = "Boka Tid/Provtagning";
            this.tidsbokningBtn.UseVisualStyleBackColor = true;
            this.tidsbokningBtn.Click += new System.EventHandler(this.tidsbokningBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.allergyLbl);
            this.groupBox2.Controls.Add(this.allergyListBox);
            this.groupBox2.Controls.Add(this.testResultListBox);
            this.groupBox2.Controls.Add(this.testResultLbl);
            this.groupBox2.Controls.Add(this.bloodTypeTxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(271, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 414);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medicinsk Information";
            // 
            // allergyLbl
            // 
            this.allergyLbl.AutoSize = true;
            this.allergyLbl.Location = new System.Drawing.Point(9, 49);
            this.allergyLbl.Name = "allergyLbl";
            this.allergyLbl.Size = new System.Drawing.Size(47, 13);
            this.allergyLbl.TabIndex = 6;
            this.allergyLbl.Text = "Allergier:";
            // 
            // allergyListBox
            // 
            this.allergyListBox.FormattingEnabled = true;
            this.allergyListBox.Location = new System.Drawing.Point(9, 65);
            this.allergyListBox.Name = "allergyListBox";
            this.allergyListBox.Size = new System.Drawing.Size(273, 121);
            this.allergyListBox.TabIndex = 5;
            // 
            // testResultListBox
            // 
            this.testResultListBox.FormattingEnabled = true;
            this.testResultListBox.Location = new System.Drawing.Point(9, 208);
            this.testResultListBox.Name = "testResultListBox";
            this.testResultListBox.Size = new System.Drawing.Size(273, 199);
            this.testResultListBox.TabIndex = 4;
            // 
            // testResultLbl
            // 
            this.testResultLbl.AutoSize = true;
            this.testResultLbl.Location = new System.Drawing.Point(6, 192);
            this.testResultLbl.Name = "testResultLbl";
            this.testResultLbl.Size = new System.Drawing.Size(71, 13);
            this.testResultLbl.TabIndex = 3;
            this.testResultLbl.Text = "ProvResultat:";
            // 
            // bloodTypeTxt
            // 
            this.bloodTypeTxt.Enabled = false;
            this.bloodTypeTxt.Location = new System.Drawing.Point(79, 22);
            this.bloodTypeTxt.Name = "bloodTypeTxt";
            this.bloodTypeTxt.Size = new System.Drawing.Size(121, 20);
            this.bloodTypeTxt.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Blodgrupp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.savePersonInfoChange);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.eMailTxt);
            this.groupBox1.Controls.Add(this.phoneTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.postalAreaTxt);
            this.groupBox1.Controls.Add(this.postalCodeTxt);
            this.groupBox1.Controls.Add(this.addressTxt);
            this.groupBox1.Controls.Add(this.namnTxt);
            this.groupBox1.Controls.Add(this.personNrTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personuppgifter";
            // 
            // savePersonInfoChange
            // 
            this.savePersonInfoChange.Location = new System.Drawing.Point(66, 214);
            this.savePersonInfoChange.Name = "savePersonInfoChange";
            this.savePersonInfoChange.Size = new System.Drawing.Size(124, 23);
            this.savePersonInfoChange.TabIndex = 18;
            this.savePersonInfoChange.Text = "Ändra Personuppgifter";
            this.savePersonInfoChange.UseVisualStyleBackColor = true;
            this.savePersonInfoChange.Click += new System.EventHandler(this.savePersonInfoChange_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "E-mail";
            // 
            // eMailTxt
            // 
            this.eMailTxt.Enabled = false;
            this.eMailTxt.Location = new System.Drawing.Point(90, 178);
            this.eMailTxt.Name = "eMailTxt";
            this.eMailTxt.Size = new System.Drawing.Size(143, 20);
            this.eMailTxt.TabIndex = 16;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Enabled = false;
            this.phoneTxt.Location = new System.Drawing.Point(90, 152);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(143, 20);
            this.phoneTxt.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefon";
            // 
            // postalAreaTxt
            // 
            this.postalAreaTxt.Enabled = false;
            this.postalAreaTxt.Location = new System.Drawing.Point(90, 125);
            this.postalAreaTxt.Name = "postalAreaTxt";
            this.postalAreaTxt.Size = new System.Drawing.Size(143, 20);
            this.postalAreaTxt.TabIndex = 13;
            // 
            // postalCodeTxt
            // 
            this.postalCodeTxt.Enabled = false;
            this.postalCodeTxt.Location = new System.Drawing.Point(90, 99);
            this.postalCodeTxt.Name = "postalCodeTxt";
            this.postalCodeTxt.Size = new System.Drawing.Size(100, 20);
            this.postalCodeTxt.TabIndex = 12;
            // 
            // addressTxt
            // 
            this.addressTxt.Enabled = false;
            this.addressTxt.Location = new System.Drawing.Point(90, 72);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(143, 20);
            this.addressTxt.TabIndex = 11;
            // 
            // namnTxt
            // 
            this.namnTxt.Enabled = false;
            this.namnTxt.Location = new System.Drawing.Point(90, 43);
            this.namnTxt.Name = "namnTxt";
            this.namnTxt.Size = new System.Drawing.Size(143, 20);
            this.namnTxt.TabIndex = 10;
            // 
            // personNrTxt
            // 
            this.personNrTxt.Enabled = false;
            this.personNrTxt.Location = new System.Drawing.Point(90, 16);
            this.personNrTxt.Name = "personNrTxt";
            this.personNrTxt.Size = new System.Drawing.Size(143, 20);
            this.personNrTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Postort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Postnummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Namn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personnummer";
            // 
            // PatientJournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 725);
            this.Controls.Add(this.mainPanel);
            this.Name = "PatientJournalForm";
            this.Text = "PatientJournalForm";
            this.Activated += new System.EventHandler(this.PatientJournalForm_Activated);
            this.mainPanel.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox postalCodeTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox namnTxt;
        private System.Windows.Forms.TextBox personNrTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox postalAreaTxt;
        private System.Windows.Forms.TextBox eMailTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button createReceiptBtn;
        private System.Windows.Forms.Button tidsbokningBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox bloodTypeTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label testResultLbl;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label inskrivningsStatusLbl;
        private System.Windows.Forms.TextBox signedInRoomTxtBox;
        private System.Windows.Forms.TextBox signedInDepTxtBox;
        private System.Windows.Forms.TextBox signInStatusTxtBox;
        private System.Windows.Forms.Button newNotesBtn;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Button savePersonInfoChange;
        private System.Windows.Forms.ListBox prescriptionListBox;
        private System.Windows.Forms.TextBox journalpostPreviewTxtBox;
        private System.Windows.Forms.ListBox journalPostListBox;
        private System.Windows.Forms.Label allergyLbl;
        private System.Windows.Forms.ListBox allergyListBox;
        private System.Windows.Forms.ListBox testResultListBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox bokningListbox;
    }
}