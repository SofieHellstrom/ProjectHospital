namespace HospitalManagement
{
    partial class AdminWindowForm
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cornerPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.editLoginInfoBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.currentUserLbl = new System.Windows.Forms.Label();
            this.bigPanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.employeeTabPage = new System.Windows.Forms.TabPage();
            this.employeeInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.personIDTxtBox = new System.Windows.Forms.TextBox();
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
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.departmentTabPage = new System.Windows.Forms.TabPage();
            this.depInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.depIDLbl = new System.Windows.Forms.Label();
            this.depNameTxtBox = new System.Windows.Forms.TextBox();
            this.depNameLbl = new System.Windows.Forms.Label();
            this.depIDTxtBox = new System.Windows.Forms.TextBox();
            this.depOpensLbl = new System.Windows.Forms.Label();
            this.depClosesTimePicker = new System.Windows.Forms.DateTimePicker();
            this.depClosesLbl = new System.Windows.Forms.Label();
            this.depOpensTimePicker = new System.Windows.Forms.DateTimePicker();
            this.departmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.roomTabPage = new System.Windows.Forms.TabPage();
            this.mainTableLayoutPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.bigPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.employeeTabPage.SuspendLayout();
            this.employeeInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.departmentTabPage.SuspendLayout();
            this.depInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.4368F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.56319F));
            this.mainTableLayoutPanel.Controls.Add(this.cornerPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.leftPanel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.topPanel, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.bigPanel, 1, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.549521F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.45048F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(1017, 626);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // cornerPanel
            // 
            this.cornerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cornerPanel.Location = new System.Drawing.Point(3, 3);
            this.cornerPanel.Name = "cornerPanel";
            this.cornerPanel.Size = new System.Drawing.Size(120, 35);
            this.cornerPanel.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.editLoginInfoBtn);
            this.leftPanel.Controls.Add(this.updateBtn);
            this.leftPanel.Controls.Add(this.addBtn);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(3, 44);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(120, 579);
            this.leftPanel.TabIndex = 1;
            // 
            // editLoginInfoBtn
            // 
            this.editLoginInfoBtn.Location = new System.Drawing.Point(3, 60);
            this.editLoginInfoBtn.Name = "editLoginInfoBtn";
            this.editLoginInfoBtn.Size = new System.Drawing.Size(108, 23);
            this.editLoginInfoBtn.TabIndex = 2;
            this.editLoginInfoBtn.Text = "Användaruppgifter";
            this.editLoginInfoBtn.UseVisualStyleBackColor = true;
            this.editLoginInfoBtn.Click += new System.EventHandler(this.editLoginInfoBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(3, 31);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(108, 23);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "Redigera Anställd";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(3, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(108, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Ny Anställd";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.currentUserLbl);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(129, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(885, 35);
            this.topPanel.TabIndex = 2;
            // 
            // currentUserLbl
            // 
            this.currentUserLbl.AutoSize = true;
            this.currentUserLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.currentUserLbl.Location = new System.Drawing.Point(856, 0);
            this.currentUserLbl.Name = "currentUserLbl";
            this.currentUserLbl.Size = new System.Drawing.Size(29, 13);
            this.currentUserLbl.TabIndex = 0;
            this.currentUserLbl.Text = "User";
            // 
            // bigPanel
            // 
            this.bigPanel.Controls.Add(this.tabControl);
            this.bigPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bigPanel.Location = new System.Drawing.Point(129, 44);
            this.bigPanel.Name = "bigPanel";
            this.bigPanel.Size = new System.Drawing.Size(885, 579);
            this.bigPanel.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.employeeTabPage);
            this.tabControl.Controls.Add(this.departmentTabPage);
            this.tabControl.Controls.Add(this.roomTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(885, 579);
            this.tabControl.TabIndex = 0;
            // 
            // employeeTabPage
            // 
            this.employeeTabPage.Controls.Add(this.employeeInfoGroupBox);
            this.employeeTabPage.Controls.Add(this.employeesDataGridView);
            this.employeeTabPage.Location = new System.Drawing.Point(4, 22);
            this.employeeTabPage.Name = "employeeTabPage";
            this.employeeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeeTabPage.Size = new System.Drawing.Size(877, 553);
            this.employeeTabPage.TabIndex = 0;
            this.employeeTabPage.Text = "Anställda";
            this.employeeTabPage.UseVisualStyleBackColor = true;
            this.employeeTabPage.Enter += new System.EventHandler(this.employeeTabPage_Enter);
            // 
            // employeeInfoGroupBox
            // 
            this.employeeInfoGroupBox.Controls.Add(this.personIDTxtBox);
            this.employeeInfoGroupBox.Controls.Add(this.personIdLbl);
            this.employeeInfoGroupBox.Controls.Add(this.anstIdLbl);
            this.employeeInfoGroupBox.Controls.Add(this.emailTxtBox);
            this.employeeInfoGroupBox.Controls.Add(this.specialtyComboBox);
            this.employeeInfoGroupBox.Controls.Add(this.phoneNrTxtBox);
            this.employeeInfoGroupBox.Controls.Add(this.employeeIdTxtBox);
            this.employeeInfoGroupBox.Controls.Add(this.postalAreaTxtBox);
            this.employeeInfoGroupBox.Controls.Add(this.positionComboBox);
            this.employeeInfoGroupBox.Controls.Add(this.postalCodeTxtBox);
            this.employeeInfoGroupBox.Controls.Add(this.addressTxtBox);
            this.employeeInfoGroupBox.Controls.Add(this.positionLbl);
            this.employeeInfoGroupBox.Controls.Add(this.label8);
            this.employeeInfoGroupBox.Controls.Add(this.departmentComboBox);
            this.employeeInfoGroupBox.Controls.Add(this.label7);
            this.employeeInfoGroupBox.Controls.Add(this.lastNameTxtBox);
            this.employeeInfoGroupBox.Controls.Add(this.label6);
            this.employeeInfoGroupBox.Controls.Add(this.departmentLbl);
            this.employeeInfoGroupBox.Controls.Add(this.addressLbl);
            this.employeeInfoGroupBox.Controls.Add(this.firstNameTxtBox);
            this.employeeInfoGroupBox.Controls.Add(this.specialtyLbl);
            this.employeeInfoGroupBox.Controls.Add(this.firstNameLbl);
            this.employeeInfoGroupBox.Controls.Add(this.lastNameLbl);
            this.employeeInfoGroupBox.Location = new System.Drawing.Point(6, 9);
            this.employeeInfoGroupBox.Name = "employeeInfoGroupBox";
            this.employeeInfoGroupBox.Size = new System.Drawing.Size(509, 235);
            this.employeeInfoGroupBox.TabIndex = 23;
            this.employeeInfoGroupBox.TabStop = false;
            this.employeeInfoGroupBox.Text = "Vald Anställd";
            // 
            // personIDTxtBox
            // 
            this.personIDTxtBox.Location = new System.Drawing.Point(270, 13);
            this.personIDTxtBox.Name = "personIDTxtBox";
            this.personIDTxtBox.Size = new System.Drawing.Size(191, 20);
            this.personIDTxtBox.TabIndex = 24;
            // 
            // personIdLbl
            // 
            this.personIdLbl.AutoSize = true;
            this.personIdLbl.Location = new System.Drawing.Point(184, 16);
            this.personIdLbl.Name = "personIdLbl";
            this.personIdLbl.Size = new System.Drawing.Size(80, 13);
            this.personIdLbl.TabIndex = 23;
            this.personIdLbl.Text = "Personnummer:";
            // 
            // anstIdLbl
            // 
            this.anstIdLbl.AutoSize = true;
            this.anstIdLbl.Location = new System.Drawing.Point(6, 16);
            this.anstIdLbl.Name = "anstIdLbl";
            this.anstIdLbl.Size = new System.Drawing.Size(45, 13);
            this.anstIdLbl.TabIndex = 1;
            this.anstIdLbl.Text = "Anst-ID:";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(78, 198);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(285, 20);
            this.emailTxtBox.TabIndex = 19;
            // 
            // specialtyComboBox
            // 
            this.specialtyComboBox.FormattingEnabled = true;
            this.specialtyComboBox.Location = new System.Drawing.Point(319, 39);
            this.specialtyComboBox.Name = "specialtyComboBox";
            this.specialtyComboBox.Size = new System.Drawing.Size(171, 21);
            this.specialtyComboBox.TabIndex = 22;
            // 
            // phoneNrTxtBox
            // 
            this.phoneNrTxtBox.Location = new System.Drawing.Point(78, 172);
            this.phoneNrTxtBox.Name = "phoneNrTxtBox";
            this.phoneNrTxtBox.Size = new System.Drawing.Size(285, 20);
            this.phoneNrTxtBox.TabIndex = 15;
            // 
            // employeeIdTxtBox
            // 
            this.employeeIdTxtBox.Location = new System.Drawing.Point(78, 13);
            this.employeeIdTxtBox.Name = "employeeIdTxtBox";
            this.employeeIdTxtBox.Size = new System.Drawing.Size(100, 20);
            this.employeeIdTxtBox.TabIndex = 9;
            // 
            // postalAreaTxtBox
            // 
            this.postalAreaTxtBox.Location = new System.Drawing.Point(184, 146);
            this.postalAreaTxtBox.Name = "postalAreaTxtBox";
            this.postalAreaTxtBox.Size = new System.Drawing.Size(179, 20);
            this.postalAreaTxtBox.TabIndex = 14;
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(78, 39);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(171, 21);
            this.positionComboBox.TabIndex = 21;
            // 
            // postalCodeTxtBox
            // 
            this.postalCodeTxtBox.Location = new System.Drawing.Point(78, 146);
            this.postalCodeTxtBox.Name = "postalCodeTxtBox";
            this.postalCodeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.postalCodeTxtBox.TabIndex = 13;
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(78, 119);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(285, 20);
            this.addressTxtBox.TabIndex = 12;
            // 
            // positionLbl
            // 
            this.positionLbl.AutoSize = true;
            this.positionLbl.Location = new System.Drawing.Point(6, 42);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.Size = new System.Drawing.Size(69, 13);
            this.positionLbl.TabIndex = 16;
            this.positionLbl.Text = "Anställd som:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "E-mail:";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(78, 66);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(171, 21);
            this.departmentComboBox.Sorted = true;
            this.departmentComboBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Telefon:";
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Location = new System.Drawing.Point(319, 93);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(171, 20);
            this.lastNameTxtBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Postadress:";
            // 
            // departmentLbl
            // 
            this.departmentLbl.AutoSize = true;
            this.departmentLbl.Location = new System.Drawing.Point(6, 69);
            this.departmentLbl.Name = "departmentLbl";
            this.departmentLbl.Size = new System.Drawing.Size(57, 13);
            this.departmentLbl.TabIndex = 17;
            this.departmentLbl.Text = "Avdelning:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(7, 122);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(42, 13);
            this.addressLbl.TabIndex = 4;
            this.addressLbl.Text = "Adress:";
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Location = new System.Drawing.Point(78, 93);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(171, 20);
            this.firstNameTxtBox.TabIndex = 10;
            // 
            // specialtyLbl
            // 
            this.specialtyLbl.AutoSize = true;
            this.specialtyLbl.Location = new System.Drawing.Point(255, 42);
            this.specialtyLbl.Name = "specialtyLbl";
            this.specialtyLbl.Size = new System.Drawing.Size(60, 13);
            this.specialtyLbl.TabIndex = 18;
            this.specialtyLbl.Text = "Läkarspec:";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(6, 96);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(51, 13);
            this.firstNameLbl.TabIndex = 2;
            this.firstNameLbl.Text = "Förnamn:";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(255, 96);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(58, 13);
            this.lastNameLbl.TabIndex = 3;
            this.lastNameLbl.Text = "Efternamn:";
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AllowUserToAddRows = false;
            this.employeesDataGridView.AllowUserToDeleteRows = false;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.employeesDataGridView.Location = new System.Drawing.Point(3, 250);
            this.employeesDataGridView.MultiSelect = false;
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.Size = new System.Drawing.Size(859, 260);
            this.employeesDataGridView.TabIndex = 0;
            this.employeesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesDataGridView_CellClick);
            this.employeesDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.employeesDataGridView_DataBindingComplete);
            // 
            // departmentTabPage
            // 
            this.departmentTabPage.Controls.Add(this.depInfoGroupBox);
            this.departmentTabPage.Controls.Add(this.departmentsDataGridView);
            this.departmentTabPage.Location = new System.Drawing.Point(4, 22);
            this.departmentTabPage.Name = "departmentTabPage";
            this.departmentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.departmentTabPage.Size = new System.Drawing.Size(877, 553);
            this.departmentTabPage.TabIndex = 1;
            this.departmentTabPage.Text = "Avdelningar";
            this.departmentTabPage.UseVisualStyleBackColor = true;
            this.departmentTabPage.Enter += new System.EventHandler(this.departmentTabPage_Enter);
            // 
            // depInfoGroupBox
            // 
            this.depInfoGroupBox.Controls.Add(this.depIDLbl);
            this.depInfoGroupBox.Controls.Add(this.depNameTxtBox);
            this.depInfoGroupBox.Controls.Add(this.depNameLbl);
            this.depInfoGroupBox.Controls.Add(this.depIDTxtBox);
            this.depInfoGroupBox.Controls.Add(this.depOpensLbl);
            this.depInfoGroupBox.Controls.Add(this.depClosesTimePicker);
            this.depInfoGroupBox.Controls.Add(this.depClosesLbl);
            this.depInfoGroupBox.Controls.Add(this.depOpensTimePicker);
            this.depInfoGroupBox.Location = new System.Drawing.Point(6, 6);
            this.depInfoGroupBox.Name = "depInfoGroupBox";
            this.depInfoGroupBox.Size = new System.Drawing.Size(318, 130);
            this.depInfoGroupBox.TabIndex = 9;
            this.depInfoGroupBox.TabStop = false;
            this.depInfoGroupBox.Text = "Vald Avdelning";
            // 
            // depIDLbl
            // 
            this.depIDLbl.AutoSize = true;
            this.depIDLbl.Location = new System.Drawing.Point(6, 16);
            this.depIDLbl.Name = "depIDLbl";
            this.depIDLbl.Size = new System.Drawing.Size(76, 13);
            this.depIDLbl.TabIndex = 1;
            this.depIDLbl.Text = "Avdelnings ID:";
            // 
            // depNameTxtBox
            // 
            this.depNameTxtBox.Location = new System.Drawing.Point(88, 42);
            this.depNameTxtBox.Name = "depNameTxtBox";
            this.depNameTxtBox.Size = new System.Drawing.Size(184, 20);
            this.depNameTxtBox.TabIndex = 8;
            // 
            // depNameLbl
            // 
            this.depNameLbl.AutoSize = true;
            this.depNameLbl.Location = new System.Drawing.Point(6, 45);
            this.depNameLbl.Name = "depNameLbl";
            this.depNameLbl.Size = new System.Drawing.Size(38, 13);
            this.depNameLbl.TabIndex = 2;
            this.depNameLbl.Text = "Namn:";
            // 
            // depIDTxtBox
            // 
            this.depIDTxtBox.Location = new System.Drawing.Point(88, 13);
            this.depIDTxtBox.Name = "depIDTxtBox";
            this.depIDTxtBox.Size = new System.Drawing.Size(100, 20);
            this.depIDTxtBox.TabIndex = 7;
            // 
            // depOpensLbl
            // 
            this.depOpensLbl.AutoSize = true;
            this.depOpensLbl.Location = new System.Drawing.Point(6, 76);
            this.depOpensLbl.Name = "depOpensLbl";
            this.depOpensLbl.Size = new System.Drawing.Size(45, 13);
            this.depOpensLbl.TabIndex = 3;
            this.depOpensLbl.Text = "Öppnar:";
            // 
            // depClosesTimePicker
            // 
            this.depClosesTimePicker.CustomFormat = "HH:mm";
            this.depClosesTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.depClosesTimePicker.Location = new System.Drawing.Point(88, 96);
            this.depClosesTimePicker.Name = "depClosesTimePicker";
            this.depClosesTimePicker.ShowUpDown = true;
            this.depClosesTimePicker.Size = new System.Drawing.Size(77, 20);
            this.depClosesTimePicker.TabIndex = 6;
            // 
            // depClosesLbl
            // 
            this.depClosesLbl.AutoSize = true;
            this.depClosesLbl.Location = new System.Drawing.Point(6, 102);
            this.depClosesLbl.Name = "depClosesLbl";
            this.depClosesLbl.Size = new System.Drawing.Size(47, 13);
            this.depClosesLbl.TabIndex = 4;
            this.depClosesLbl.Text = "Stänger:";
            // 
            // depOpensTimePicker
            // 
            this.depOpensTimePicker.CustomFormat = "HH:mm";
            this.depOpensTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.depOpensTimePicker.Location = new System.Drawing.Point(88, 70);
            this.depOpensTimePicker.Name = "depOpensTimePicker";
            this.depOpensTimePicker.ShowUpDown = true;
            this.depOpensTimePicker.Size = new System.Drawing.Size(77, 20);
            this.depOpensTimePicker.TabIndex = 5;
            // 
            // departmentsDataGridView
            // 
            this.departmentsDataGridView.AllowUserToAddRows = false;
            this.departmentsDataGridView.AllowUserToDeleteRows = false;
            this.departmentsDataGridView.AllowUserToOrderColumns = true;
            this.departmentsDataGridView.AllowUserToResizeColumns = false;
            this.departmentsDataGridView.CausesValidation = false;
            this.departmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentsDataGridView.Location = new System.Drawing.Point(6, 142);
            this.departmentsDataGridView.MultiSelect = false;
            this.departmentsDataGridView.Name = "departmentsDataGridView";
            this.departmentsDataGridView.ReadOnly = true;
            this.departmentsDataGridView.Size = new System.Drawing.Size(496, 405);
            this.departmentsDataGridView.TabIndex = 3;
            this.departmentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.departmentsDataGridView_CellClick);
            this.departmentsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.departmentsDataGridView_DataBindingComplete);
            this.departmentsDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.departmentsDataGridView_RowEnter);
            // 
            // roomTabPage
            // 
            this.roomTabPage.Location = new System.Drawing.Point(4, 22);
            this.roomTabPage.Name = "roomTabPage";
            this.roomTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.roomTabPage.Size = new System.Drawing.Size(877, 553);
            this.roomTabPage.TabIndex = 2;
            this.roomTabPage.Text = "Rum";
            this.roomTabPage.UseVisualStyleBackColor = true;
            // 
            // AdminWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 626);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "AdminWindowForm";
            this.Text = "Systemadministration";
            this.Activated += new System.EventHandler(this.AdminWindowForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminWindowForm_FormClosed);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bigPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.employeeTabPage.ResumeLayout(false);
            this.employeeInfoGroupBox.ResumeLayout(false);
            this.employeeInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.departmentTabPage.ResumeLayout(false);
            this.depInfoGroupBox.ResumeLayout(false);
            this.depInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Panel cornerPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bigPanel;
        private System.Windows.Forms.Label currentUserLbl;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage employeeTabPage;
        private System.Windows.Forms.TabPage departmentTabPage;
        private System.Windows.Forms.TabPage roomTabPage;
        private System.Windows.Forms.Button editLoginInfoBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label anstIdLbl;
        private System.Windows.Forms.TextBox phoneNrTxtBox;
        private System.Windows.Forms.TextBox postalAreaTxtBox;
        private System.Windows.Forms.TextBox postalCodeTxtBox;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.TextBox employeeIdTxtBox;
        private System.Windows.Forms.Label specialtyLbl;
        private System.Windows.Forms.Label departmentLbl;
        private System.Windows.Forms.Label positionLbl;
        private System.Windows.Forms.ComboBox specialtyComboBox;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.GroupBox employeeInfoGroupBox;
        private System.Windows.Forms.TextBox personIDTxtBox;
        private System.Windows.Forms.Label personIdLbl;
        private System.Windows.Forms.DataGridView departmentsDataGridView;
        private System.Windows.Forms.Label depClosesLbl;
        private System.Windows.Forms.Label depOpensLbl;
        private System.Windows.Forms.Label depNameLbl;
        private System.Windows.Forms.Label depIDLbl;
        private System.Windows.Forms.DateTimePicker depOpensTimePicker;
        private System.Windows.Forms.TextBox depNameTxtBox;
        private System.Windows.Forms.TextBox depIDTxtBox;
        private System.Windows.Forms.DateTimePicker depClosesTimePicker;
        private System.Windows.Forms.GroupBox depInfoGroupBox;
    }
}