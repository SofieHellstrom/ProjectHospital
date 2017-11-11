namespace HospitalManagement
{
    partial class EmployeeRegistryForm
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
            this.saveMoreEmployeesBtn = new System.Windows.Forms.Button();
            this.saveOneAndCloseBtn = new System.Windows.Forms.Button();
            this.personIdTxtBox = new System.Windows.Forms.TextBox();
            this.personIdLbl = new System.Windows.Forms.Label();
            this.anstIdLbl = new System.Windows.Forms.Label();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.specialtyComboBox = new System.Windows.Forms.ComboBox();
            this.phoneNrTxtBox = new System.Windows.Forms.TextBox();
            this.employeeIdTxtBox = new System.Windows.Forms.TextBox();
            this.postalAreaTxtBox = new System.Windows.Forms.TextBox();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.postalCodeTxtBox = new System.Windows.Forms.TextBox();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.positionLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.departmentLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.specialtyLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.suggestNewIdLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // saveMoreEmployeesBtn
            // 
            this.saveMoreEmployeesBtn.Enabled = false;
            this.saveMoreEmployeesBtn.Location = new System.Drawing.Point(15, 327);
            this.saveMoreEmployeesBtn.Name = "saveMoreEmployeesBtn";
            this.saveMoreEmployeesBtn.Size = new System.Drawing.Size(160, 23);
            this.saveMoreEmployeesBtn.TabIndex = 11;
            this.saveMoreEmployeesBtn.Text = "Registrera och Rensa";
            this.saveMoreEmployeesBtn.UseVisualStyleBackColor = true;
            // 
            // saveOneAndCloseBtn
            // 
            this.saveOneAndCloseBtn.Enabled = false;
            this.saveOneAndCloseBtn.Location = new System.Drawing.Point(219, 328);
            this.saveOneAndCloseBtn.Name = "saveOneAndCloseBtn";
            this.saveOneAndCloseBtn.Size = new System.Drawing.Size(163, 23);
            this.saveOneAndCloseBtn.TabIndex = 12;
            this.saveOneAndCloseBtn.Text = "Registrera och Stäng";
            this.saveOneAndCloseBtn.UseVisualStyleBackColor = true;
            // 
            // personIdTxtBox
            // 
            this.personIdTxtBox.Location = new System.Drawing.Point(84, 19);
            this.personIdTxtBox.Name = "personIdTxtBox";
            this.personIdTxtBox.Size = new System.Drawing.Size(191, 20);
            this.personIdTxtBox.TabIndex = 0;
            this.personIdTxtBox.Validated += new System.EventHandler(this.personIDTxtBox_Validated);
            // 
            // personIdLbl
            // 
            this.personIdLbl.AutoSize = true;
            this.personIdLbl.Location = new System.Drawing.Point(12, 22);
            this.personIdLbl.Name = "personIdLbl";
            this.personIdLbl.Size = new System.Drawing.Size(54, 13);
            this.personIdLbl.TabIndex = 67;
            this.personIdLbl.Text = "PersonNr:";
            // 
            // anstIdLbl
            // 
            this.anstIdLbl.AutoSize = true;
            this.anstIdLbl.Location = new System.Drawing.Point(13, 102);
            this.anstIdLbl.Name = "anstIdLbl";
            this.anstIdLbl.Size = new System.Drawing.Size(45, 13);
            this.anstIdLbl.TabIndex = 46;
            this.anstIdLbl.Text = "Anst-ID:";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(84, 291);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(298, 20);
            this.emailTxtBox.TabIndex = 10;
            this.emailTxtBox.Validated += new System.EventHandler(this.emailTxtBox_Validated);
            // 
            // specialtyComboBox
            // 
            this.specialtyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.specialtyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.specialtyComboBox.Enabled = false;
            this.specialtyComboBox.FormattingEnabled = true;
            this.specialtyComboBox.Location = new System.Drawing.Point(84, 72);
            this.specialtyComboBox.Name = "specialtyComboBox";
            this.specialtyComboBox.Size = new System.Drawing.Size(171, 21);
            this.specialtyComboBox.TabIndex = 2;
            // 
            // phoneNrTxtBox
            // 
            this.phoneNrTxtBox.Location = new System.Drawing.Point(84, 265);
            this.phoneNrTxtBox.Name = "phoneNrTxtBox";
            this.phoneNrTxtBox.Size = new System.Drawing.Size(298, 20);
            this.phoneNrTxtBox.TabIndex = 9;
            this.phoneNrTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.phoneNrTxtBox_Validating);
            // 
            // employeeIdTxtBox
            // 
            this.employeeIdTxtBox.Location = new System.Drawing.Point(84, 99);
            this.employeeIdTxtBox.Name = "employeeIdTxtBox";
            this.employeeIdTxtBox.Size = new System.Drawing.Size(99, 20);
            this.employeeIdTxtBox.TabIndex = 3;
            this.employeeIdTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.employeeIdTxtBox_Validating);
            // 
            // postalAreaTxtBox
            // 
            this.postalAreaTxtBox.Location = new System.Drawing.Point(203, 239);
            this.postalAreaTxtBox.Name = "postalAreaTxtBox";
            this.postalAreaTxtBox.Size = new System.Drawing.Size(179, 20);
            this.postalAreaTxtBox.TabIndex = 58;
            this.postalAreaTxtBox.TabStop = false;
            this.postalAreaTxtBox.Enter += new System.EventHandler(this.postalAreaTxtBox_Enter);
            // 
            // positionComboBox
            // 
            this.positionComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.positionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Items.AddRange(new object[] {
            "IT-Admin",
            "Läkare",
            "Receptionist",
            "Sjuksköterska"});
            this.positionComboBox.Location = new System.Drawing.Point(84, 45);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(171, 21);
            this.positionComboBox.Sorted = true;
            this.positionComboBox.TabIndex = 1;
            this.positionComboBox.SelectedIndexChanged += new System.EventHandler(this.positionComboBox_SelectedIndexChanged);
            this.positionComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.positionComboBox_Validating);
            // 
            // postalCodeTxtBox
            // 
            this.postalCodeTxtBox.Location = new System.Drawing.Point(84, 239);
            this.postalCodeTxtBox.Name = "postalCodeTxtBox";
            this.postalCodeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.postalCodeTxtBox.TabIndex = 8;
            this.postalCodeTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.postalCodeTxtBox_Validating);
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(85, 213);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(297, 20);
            this.addressTxtBox.TabIndex = 7;
            this.addressTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.addressTxtBox_Validating);
            // 
            // positionLbl
            // 
            this.positionLbl.AutoSize = true;
            this.positionLbl.Location = new System.Drawing.Point(12, 48);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.Size = new System.Drawing.Size(69, 13);
            this.positionLbl.TabIndex = 60;
            this.positionLbl.Text = "Anställd som:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "E-mail:";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.departmentComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(84, 125);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(171, 21);
            this.departmentComboBox.Sorted = true;
            this.departmentComboBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Telefon:";
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Location = new System.Drawing.Point(84, 187);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(171, 20);
            this.lastNameTxtBox.TabIndex = 6;
            this.lastNameTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.lastNameTxtBox_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Postadress:";
            // 
            // departmentLbl
            // 
            this.departmentLbl.AutoSize = true;
            this.departmentLbl.Location = new System.Drawing.Point(13, 128);
            this.departmentLbl.Name = "departmentLbl";
            this.departmentLbl.Size = new System.Drawing.Size(57, 13);
            this.departmentLbl.TabIndex = 61;
            this.departmentLbl.Text = "Avdelning:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(13, 216);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(42, 13);
            this.addressLbl.TabIndex = 49;
            this.addressLbl.Text = "Adress:";
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Location = new System.Drawing.Point(84, 161);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(171, 20);
            this.firstNameTxtBox.TabIndex = 5;
            this.firstNameTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.firstNameTxtBox_Validating);
            // 
            // specialtyLbl
            // 
            this.specialtyLbl.AutoSize = true;
            this.specialtyLbl.Location = new System.Drawing.Point(12, 75);
            this.specialtyLbl.Name = "specialtyLbl";
            this.specialtyLbl.Size = new System.Drawing.Size(60, 13);
            this.specialtyLbl.TabIndex = 62;
            this.specialtyLbl.Text = "Läkarspec:";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(13, 164);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(51, 13);
            this.firstNameLbl.TabIndex = 47;
            this.firstNameLbl.Text = "Förnamn:";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(13, 190);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(58, 13);
            this.lastNameLbl.TabIndex = 48;
            this.lastNameLbl.Text = "Efternamn:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // suggestNewIdLbl
            // 
            this.suggestNewIdLbl.AutoSize = true;
            this.suggestNewIdLbl.Location = new System.Drawing.Point(204, 102);
            this.suggestNewIdLbl.Name = "suggestNewIdLbl";
            this.suggestNewIdLbl.Size = new System.Drawing.Size(133, 13);
            this.suggestNewIdLbl.TabIndex = 69;
            this.suggestNewIdLbl.Text = "Högsta Använda ID: None";
            // 
            // EmployeeRegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 363);
            this.Controls.Add(this.suggestNewIdLbl);
            this.Controls.Add(this.personIdTxtBox);
            this.Controls.Add(this.personIdLbl);
            this.Controls.Add(this.anstIdLbl);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.specialtyComboBox);
            this.Controls.Add(this.phoneNrTxtBox);
            this.Controls.Add(this.employeeIdTxtBox);
            this.Controls.Add(this.postalAreaTxtBox);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.postalCodeTxtBox);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.positionLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.departmentLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.firstNameTxtBox);
            this.Controls.Add(this.specialtyLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.saveOneAndCloseBtn);
            this.Controls.Add(this.saveMoreEmployeesBtn);
            this.Name = "EmployeeRegistryForm";
            this.Text = "Registrera Ny Anställd";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveMoreEmployeesBtn;
        private System.Windows.Forms.Button saveOneAndCloseBtn;
        private System.Windows.Forms.TextBox personIdTxtBox;
        private System.Windows.Forms.Label personIdLbl;
        private System.Windows.Forms.Label anstIdLbl;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.ComboBox specialtyComboBox;
        private System.Windows.Forms.TextBox phoneNrTxtBox;
        private System.Windows.Forms.TextBox employeeIdTxtBox;
        private System.Windows.Forms.TextBox postalAreaTxtBox;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.TextBox postalCodeTxtBox;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.Label positionLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label departmentLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.Label specialtyLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label suggestNewIdLbl;
    }
}