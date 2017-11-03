namespace HospitalManagement
{
    partial class PatientViewForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.postalLbl = new System.Windows.Forms.Label();
            this.postNrTxtBox = new System.Windows.Forms.TextBox();
            this.postOrtTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.prescriptionsListBox = new System.Windows.Forms.ListBox();
            this.journalpostListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.mailTxtBox = new System.Windows.Forms.TextBox();
            this.journalpostContentTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mailTxtBox);
            this.groupBox1.Controls.Add(this.phoneTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.postOrtTxtBox);
            this.groupBox1.Controls.Add(this.postNrTxtBox);
            this.groupBox1.Controls.Add(this.postalLbl);
            this.groupBox1.Controls.Add(this.addressTxtBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameTxtBox);
            this.groupBox1.Controls.Add(this.nameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personuppgifter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.journalpostContentTxtBox);
            this.groupBox2.Controls.Add(this.journalpostListBox);
            this.groupBox2.Location = new System.Drawing.Point(590, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 339);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "JournalAnteckningar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.prescriptionsListBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 218);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recept";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(346, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 218);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bokade Tider";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(6, 19);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(41, 13);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Namn: ";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameTxtBox.Location = new System.Drawing.Point(53, 16);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.ReadOnly = true;
            this.nameTxtBox.Size = new System.Drawing.Size(241, 20);
            this.nameTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adress:";
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addressTxtBox.Location = new System.Drawing.Point(53, 42);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.ReadOnly = true;
            this.addressTxtBox.Size = new System.Drawing.Size(241, 20);
            this.addressTxtBox.TabIndex = 3;
            // 
            // postalLbl
            // 
            this.postalLbl.AutoSize = true;
            this.postalLbl.Location = new System.Drawing.Point(6, 72);
            this.postalLbl.Name = "postalLbl";
            this.postalLbl.Size = new System.Drawing.Size(43, 13);
            this.postalLbl.TabIndex = 4;
            this.postalLbl.Text = "Postort:";
            // 
            // postNrTxtBox
            // 
            this.postNrTxtBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.postNrTxtBox.Location = new System.Drawing.Point(54, 69);
            this.postNrTxtBox.Name = "postNrTxtBox";
            this.postNrTxtBox.ReadOnly = true;
            this.postNrTxtBox.Size = new System.Drawing.Size(76, 20);
            this.postNrTxtBox.TabIndex = 5;
            // 
            // postOrtTxtBox
            // 
            this.postOrtTxtBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.postOrtTxtBox.Location = new System.Drawing.Point(136, 69);
            this.postOrtTxtBox.Name = "postOrtTxtBox";
            this.postOrtTxtBox.ReadOnly = true;
            this.postOrtTxtBox.Size = new System.Drawing.Size(158, 20);
            this.postOrtTxtBox.TabIndex = 6;
            // 
            // groupBox
            // 
            this.groupBox.Location = new System.Drawing.Point(13, 342);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(571, 115);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Provresultat";
            // 
            // prescriptionsListBox
            // 
            this.prescriptionsListBox.FormattingEnabled = true;
            this.prescriptionsListBox.Location = new System.Drawing.Point(6, 19);
            this.prescriptionsListBox.Name = "prescriptionsListBox";
            this.prescriptionsListBox.Size = new System.Drawing.Size(316, 186);
            this.prescriptionsListBox.TabIndex = 0;
            // 
            // journalpostListBox
            // 
            this.journalpostListBox.FormattingEnabled = true;
            this.journalpostListBox.Location = new System.Drawing.Point(6, 19);
            this.journalpostListBox.Name = "journalpostListBox";
            this.journalpostListBox.Size = new System.Drawing.Size(188, 186);
            this.journalpostListBox.TabIndex = 0;
            this.journalpostListBox.SelectedIndexChanged += new System.EventHandler(this.journalpostListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "E-mail:";
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.phoneTxtBox.Location = new System.Drawing.Point(353, 16);
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.ReadOnly = true;
            this.phoneTxtBox.Size = new System.Drawing.Size(219, 20);
            this.phoneTxtBox.TabIndex = 9;
            // 
            // mailTxtBox
            // 
            this.mailTxtBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mailTxtBox.Location = new System.Drawing.Point(353, 42);
            this.mailTxtBox.Name = "mailTxtBox";
            this.mailTxtBox.ReadOnly = true;
            this.mailTxtBox.Size = new System.Drawing.Size(219, 20);
            this.mailTxtBox.TabIndex = 10;
            // 
            // journalpostContentTxtBox
            // 
            this.journalpostContentTxtBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.journalpostContentTxtBox.Location = new System.Drawing.Point(7, 211);
            this.journalpostContentTxtBox.Multiline = true;
            this.journalpostContentTxtBox.Name = "journalpostContentTxtBox";
            this.journalpostContentTxtBox.ReadOnly = true;
            this.journalpostContentTxtBox.Size = new System.Drawing.Size(187, 122);
            this.journalpostContentTxtBox.TabIndex = 1;
            // 
            // PatientViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 471);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PatientViewForm";
            this.Text = "PatientView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PatientViewForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox postOrtTxtBox;
        private System.Windows.Forms.TextBox postNrTxtBox;
        private System.Windows.Forms.Label postalLbl;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ListBox prescriptionsListBox;
        private System.Windows.Forms.TextBox mailTxtBox;
        private System.Windows.Forms.TextBox phoneTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox journalpostListBox;
        private System.Windows.Forms.TextBox journalpostContentTxtBox;
    }
}