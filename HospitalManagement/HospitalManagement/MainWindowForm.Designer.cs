namespace HospitalManagement
{
    partial class MainWindow
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
            this.tableLayoutPane = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userIdentityLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.patientJournalBtn = new System.Windows.Forms.Button();
            this.newPatientBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personidnrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new HospitalManagement.HospitalDataSet();
            this.searchPatientBtn = new System.Windows.Forms.Button();
            this.searchPatientBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.searchDoctorBtn = new System.Windows.Forms.Button();
            this.searchDoctorBox = new System.Windows.Forms.TextBox();
            this.patientTableAdapter = new HospitalManagement.HospitalDataSetTableAdapters.patientTableAdapter();
            this.hospitalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet1 = new HospitalManagement.HospitalDataSet1();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new HospitalManagement.HospitalDataSet1TableAdapters.staffTableAdapter();
            this.firstnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPane.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPane
            // 
            this.tableLayoutPane.ColumnCount = 2;
            this.tableLayoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.24936F));
            this.tableLayoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.75063F));
            this.tableLayoutPane.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPane.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPane.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPane.Controls.Add(this.tabControl1, 1, 1);
            this.tableLayoutPane.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPane.Name = "tableLayoutPane";
            this.tableLayoutPane.RowCount = 2;
            this.tableLayoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.602151F));
            this.tableLayoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.39785F));
            this.tableLayoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPane.Size = new System.Drawing.Size(784, 462);
            this.tableLayoutPane.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 33);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userIdentityLbl);
            this.panel2.Location = new System.Drawing.Point(114, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 33);
            this.panel2.TabIndex = 1;
            // 
            // userIdentityLbl
            // 
            this.userIdentityLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userIdentityLbl.AutoSize = true;
            this.userIdentityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdentityLbl.Location = new System.Drawing.Point(435, 10);
            this.userIdentityLbl.Name = "userIdentityLbl";
            this.userIdentityLbl.Size = new System.Drawing.Size(232, 13);
            this.userIdentityLbl.TabIndex = 0;
            this.userIdentityLbl.Text = "User: Efternamn, Förnamn (Anställningsnummer)";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.patientJournalBtn);
            this.panel3.Controls.Add(this.newPatientBtn);
            this.panel3.Location = new System.Drawing.Point(3, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(105, 417);
            this.panel3.TabIndex = 2;
            // 
            // patientJournalBtn
            // 
            this.patientJournalBtn.Location = new System.Drawing.Point(3, 32);
            this.patientJournalBtn.Name = "patientJournalBtn";
            this.patientJournalBtn.Size = new System.Drawing.Size(99, 23);
            this.patientJournalBtn.TabIndex = 1;
            this.patientJournalBtn.Text = "PatientJournal";
            this.patientJournalBtn.UseVisualStyleBackColor = true;
            this.patientJournalBtn.Click += new System.EventHandler(this.patientJournalBtn_Click);
            // 
            // newPatientBtn
            // 
            this.newPatientBtn.Location = new System.Drawing.Point(3, 3);
            this.newPatientBtn.Name = "newPatientBtn";
            this.newPatientBtn.Size = new System.Drawing.Size(99, 23);
            this.newPatientBtn.TabIndex = 0;
            this.newPatientBtn.Text = "Ny Patient";
            this.newPatientBtn.UseVisualStyleBackColor = true;
            this.newPatientBtn.Click += new System.EventHandler(this.newPatientBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(114, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 417);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.searchPatientBtn);
            this.tabPage1.Controls.Add(this.searchPatientBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(659, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patienter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personidnrDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 78);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(621, 239);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // personidnrDataGridViewTextBoxColumn
            // 
            this.personidnrDataGridViewTextBoxColumn.DataPropertyName = "person_id_nr";
            this.personidnrDataGridViewTextBoxColumn.HeaderText = "Personnummer";
            this.personidnrDataGridViewTextBoxColumn.Name = "personidnrDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Förnamn";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Efternamn";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Rum";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "patient";
            this.patientBindingSource.DataSource = this.hospitalDataSet;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchPatientBtn
            // 
            this.searchPatientBtn.Location = new System.Drawing.Point(150, 10);
            this.searchPatientBtn.Name = "searchPatientBtn";
            this.searchPatientBtn.Size = new System.Drawing.Size(101, 23);
            this.searchPatientBtn.TabIndex = 1;
            this.searchPatientBtn.Text = "Sök Patient";
            this.searchPatientBtn.UseVisualStyleBackColor = true;
            this.searchPatientBtn.Click += new System.EventHandler(this.searchPatientBtn_Click);
            // 
            // searchPatientBox
            // 
            this.searchPatientBox.Location = new System.Drawing.Point(20, 10);
            this.searchPatientBox.Name = "searchPatientBox";
            this.searchPatientBox.Size = new System.Drawing.Size(100, 20);
            this.searchPatientBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.searchDoctorBtn);
            this.tabPage2.Controls.Add(this.searchDoctorBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(659, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Läkare";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn1,
            this.lastnameDataGridViewTextBoxColumn1,
            this.departmentDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.specialtyDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.staffBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(26, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(595, 255);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // searchDoctorBtn
            // 
            this.searchDoctorBtn.Location = new System.Drawing.Point(159, 14);
            this.searchDoctorBtn.Name = "searchDoctorBtn";
            this.searchDoctorBtn.Size = new System.Drawing.Size(75, 23);
            this.searchDoctorBtn.TabIndex = 1;
            this.searchDoctorBtn.Text = "Sök ";
            this.searchDoctorBtn.UseVisualStyleBackColor = true;
            // 
            // searchDoctorBox
            // 
            this.searchDoctorBox.Location = new System.Drawing.Point(26, 16);
            this.searchDoctorBox.Name = "searchDoctorBox";
            this.searchDoctorBox.Size = new System.Drawing.Size(100, 20);
            this.searchDoctorBox.TabIndex = 0;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // hospitalDataSetBindingSource
            // 
            this.hospitalDataSetBindingSource.DataSource = this.hospitalDataSet;
            this.hospitalDataSetBindingSource.Position = 0;
            // 
            // hospitalDataSet1
            // 
            this.hospitalDataSet1.DataSetName = "HospitalDataSet1";
            this.hospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.hospitalDataSet1;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // firstnameDataGridViewTextBoxColumn1
            // 
            this.firstnameDataGridViewTextBoxColumn1.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn1.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn1.Name = "firstnameDataGridViewTextBoxColumn1";
            // 
            // lastnameDataGridViewTextBoxColumn1
            // 
            this.lastnameDataGridViewTextBoxColumn1.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn1.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn1.Name = "lastnameDataGridViewTextBoxColumn1";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // specialtyDataGridViewTextBoxColumn
            // 
            this.specialtyDataGridViewTextBoxColumn.DataPropertyName = "specialty";
            this.specialtyDataGridViewTextBoxColumn.HeaderText = "specialty";
            this.specialtyDataGridViewTextBoxColumn.Name = "specialtyDataGridViewTextBoxColumn";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tableLayoutPane);
            this.Name = "MainWindow";
            this.Text = "HospitalManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load_1);
            this.tableLayoutPane.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button newPatientBtn;
        private System.Windows.Forms.Button patientJournalBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button searchPatientBtn;
        private System.Windows.Forms.TextBox searchPatientBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private HospitalDataSetTableAdapters.patientTableAdapter patientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personidnrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label userIdentityLbl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button searchDoctorBtn;
        private System.Windows.Forms.TextBox searchDoctorBox;
        private System.Windows.Forms.BindingSource hospitalDataSetBindingSource;
        private HospitalDataSet1 hospitalDataSet1;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private HospitalDataSet1TableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyDataGridViewTextBoxColumn;
    }
}

