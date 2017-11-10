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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.currentUserLbl = new System.Windows.Forms.Label();
            this.bigPanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.employeeTabPage = new System.Windows.Forms.TabPage();
            this.specialtyComboBox = new System.Windows.Forms.ComboBox();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.specialtyLbl = new System.Windows.Forms.Label();
            this.departmentLbl = new System.Windows.Forms.Label();
            this.positionLbl = new System.Windows.Forms.Label();
            this.phoneNrTxtBox = new System.Windows.Forms.TextBox();
            this.postalAreaTxtBox = new System.Windows.Forms.TextBox();
            this.postalCodeTxtBox = new System.Windows.Forms.TextBox();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.employeeIdTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.anstIdLbl = new System.Windows.Forms.Label();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.departmentTabPage = new System.Windows.Forms.TabPage();
            this.roomTabPage = new System.Windows.Forms.TabPage();
            this.mainTableLayoutPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.bigPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.employeeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.51567F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.48433F));
            this.mainTableLayoutPanel.Controls.Add(this.cornerPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.leftPanel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.topPanel, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.bigPanel, 1, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.98701F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.01299F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(989, 626);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // cornerPanel
            // 
            this.cornerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cornerPanel.Location = new System.Drawing.Point(3, 3);
            this.cornerPanel.Name = "cornerPanel";
            this.cornerPanel.Size = new System.Drawing.Size(97, 75);
            this.cornerPanel.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.button3);
            this.leftPanel.Controls.Add(this.button2);
            this.leftPanel.Controls.Add(this.addBtn);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(3, 84);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(97, 539);
            this.leftPanel.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ta bort?";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Uppdatera X";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(9, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Ny X";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.currentUserLbl);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(106, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(880, 75);
            this.topPanel.TabIndex = 2;
            // 
            // currentUserLbl
            // 
            this.currentUserLbl.AutoSize = true;
            this.currentUserLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.currentUserLbl.Location = new System.Drawing.Point(851, 0);
            this.currentUserLbl.Name = "currentUserLbl";
            this.currentUserLbl.Size = new System.Drawing.Size(29, 13);
            this.currentUserLbl.TabIndex = 0;
            this.currentUserLbl.Text = "User";
            // 
            // bigPanel
            // 
            this.bigPanel.Controls.Add(this.tabControl);
            this.bigPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bigPanel.Location = new System.Drawing.Point(106, 84);
            this.bigPanel.Name = "bigPanel";
            this.bigPanel.Size = new System.Drawing.Size(880, 539);
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
            this.tabControl.Size = new System.Drawing.Size(880, 539);
            this.tabControl.TabIndex = 0;
            // 
            // employeeTabPage
            // 
            this.employeeTabPage.Controls.Add(this.specialtyComboBox);
            this.employeeTabPage.Controls.Add(this.positionComboBox);
            this.employeeTabPage.Controls.Add(this.departmentComboBox);
            this.employeeTabPage.Controls.Add(this.emailTxtBox);
            this.employeeTabPage.Controls.Add(this.specialtyLbl);
            this.employeeTabPage.Controls.Add(this.departmentLbl);
            this.employeeTabPage.Controls.Add(this.positionLbl);
            this.employeeTabPage.Controls.Add(this.phoneNrTxtBox);
            this.employeeTabPage.Controls.Add(this.postalAreaTxtBox);
            this.employeeTabPage.Controls.Add(this.postalCodeTxtBox);
            this.employeeTabPage.Controls.Add(this.addressTxtBox);
            this.employeeTabPage.Controls.Add(this.lastNameTxtBox);
            this.employeeTabPage.Controls.Add(this.firstNameTxtBox);
            this.employeeTabPage.Controls.Add(this.employeeIdTxtBox);
            this.employeeTabPage.Controls.Add(this.label8);
            this.employeeTabPage.Controls.Add(this.label7);
            this.employeeTabPage.Controls.Add(this.label6);
            this.employeeTabPage.Controls.Add(this.addressLbl);
            this.employeeTabPage.Controls.Add(this.lastNameLbl);
            this.employeeTabPage.Controls.Add(this.firstNameLbl);
            this.employeeTabPage.Controls.Add(this.anstIdLbl);
            this.employeeTabPage.Controls.Add(this.employeesDataGridView);
            this.employeeTabPage.Location = new System.Drawing.Point(4, 22);
            this.employeeTabPage.Name = "employeeTabPage";
            this.employeeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeeTabPage.Size = new System.Drawing.Size(872, 513);
            this.employeeTabPage.TabIndex = 0;
            this.employeeTabPage.Text = "Anställda";
            this.employeeTabPage.UseVisualStyleBackColor = true;
            // 
            // specialtyComboBox
            // 
            this.specialtyComboBox.FormattingEnabled = true;
            this.specialtyComboBox.Location = new System.Drawing.Point(288, 12);
            this.specialtyComboBox.Name = "specialtyComboBox";
            this.specialtyComboBox.Size = new System.Drawing.Size(190, 21);
            this.specialtyComboBox.TabIndex = 22;
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(303, 38);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(175, 21);
            this.positionComboBox.TabIndex = 21;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(101, 38);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(121, 21);
            this.departmentComboBox.TabIndex = 20;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(101, 217);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(270, 20);
            this.emailTxtBox.TabIndex = 19;
            // 
            // specialtyLbl
            // 
            this.specialtyLbl.AutoSize = true;
            this.specialtyLbl.Location = new System.Drawing.Point(207, 15);
            this.specialtyLbl.Name = "specialtyLbl";
            this.specialtyLbl.Size = new System.Drawing.Size(75, 13);
            this.specialtyLbl.TabIndex = 18;
            this.specialtyLbl.Text = "Specialisering:";
            // 
            // departmentLbl
            // 
            this.departmentLbl.AutoSize = true;
            this.departmentLbl.Location = new System.Drawing.Point(16, 41);
            this.departmentLbl.Name = "departmentLbl";
            this.departmentLbl.Size = new System.Drawing.Size(57, 13);
            this.departmentLbl.TabIndex = 17;
            this.departmentLbl.Text = "Avdelning:";
            // 
            // positionLbl
            // 
            this.positionLbl.AutoSize = true;
            this.positionLbl.Location = new System.Drawing.Point(228, 41);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.Size = new System.Drawing.Size(69, 13);
            this.positionLbl.TabIndex = 16;
            this.positionLbl.Text = "Anställd som:";
            // 
            // phoneNrTxtBox
            // 
            this.phoneNrTxtBox.Location = new System.Drawing.Point(101, 191);
            this.phoneNrTxtBox.Name = "phoneNrTxtBox";
            this.phoneNrTxtBox.Size = new System.Drawing.Size(270, 20);
            this.phoneNrTxtBox.TabIndex = 15;
            // 
            // postalAreaTxtBox
            // 
            this.postalAreaTxtBox.Location = new System.Drawing.Point(217, 165);
            this.postalAreaTxtBox.Name = "postalAreaTxtBox";
            this.postalAreaTxtBox.Size = new System.Drawing.Size(154, 20);
            this.postalAreaTxtBox.TabIndex = 14;
            // 
            // postalCodeTxtBox
            // 
            this.postalCodeTxtBox.Location = new System.Drawing.Point(101, 165);
            this.postalCodeTxtBox.Name = "postalCodeTxtBox";
            this.postalCodeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.postalCodeTxtBox.TabIndex = 13;
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(101, 138);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(270, 20);
            this.addressTxtBox.TabIndex = 12;
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Location = new System.Drawing.Point(101, 108);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(171, 20);
            this.lastNameTxtBox.TabIndex = 11;
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Location = new System.Drawing.Point(101, 79);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(171, 20);
            this.firstNameTxtBox.TabIndex = 10;
            // 
            // employeeIdTxtBox
            // 
            this.employeeIdTxtBox.Location = new System.Drawing.Point(101, 12);
            this.employeeIdTxtBox.Name = "employeeIdTxtBox";
            this.employeeIdTxtBox.Size = new System.Drawing.Size(100, 20);
            this.employeeIdTxtBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Telefonnummer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Postnr och Ort:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(15, 141);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(42, 13);
            this.addressLbl.TabIndex = 4;
            this.addressLbl.Text = "Adress:";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(15, 111);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(58, 13);
            this.lastNameLbl.TabIndex = 3;
            this.lastNameLbl.Text = "Efternamn:";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(15, 83);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(51, 13);
            this.firstNameLbl.TabIndex = 2;
            this.firstNameLbl.Text = "Förnamn:";
            // 
            // anstIdLbl
            // 
            this.anstIdLbl.AutoSize = true;
            this.anstIdLbl.Location = new System.Drawing.Point(15, 15);
            this.anstIdLbl.Name = "anstIdLbl";
            this.anstIdLbl.Size = new System.Drawing.Size(80, 13);
            this.anstIdLbl.TabIndex = 1;
            this.anstIdLbl.Text = "Anställnings-ID:";
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Location = new System.Drawing.Point(3, 281);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.Size = new System.Drawing.Size(859, 229);
            this.employeesDataGridView.TabIndex = 0;
            this.employeesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesDataGridView_CellClick);
            // 
            // departmentTabPage
            // 
            this.departmentTabPage.Location = new System.Drawing.Point(4, 22);
            this.departmentTabPage.Name = "departmentTabPage";
            this.departmentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.departmentTabPage.Size = new System.Drawing.Size(871, 513);
            this.departmentTabPage.TabIndex = 1;
            this.departmentTabPage.Text = "Avdelningar";
            this.departmentTabPage.UseVisualStyleBackColor = true;
            // 
            // roomTabPage
            // 
            this.roomTabPage.Location = new System.Drawing.Point(4, 22);
            this.roomTabPage.Name = "roomTabPage";
            this.roomTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.roomTabPage.Size = new System.Drawing.Size(871, 513);
            this.roomTabPage.TabIndex = 2;
            this.roomTabPage.Text = "Rum";
            this.roomTabPage.UseVisualStyleBackColor = true;
            // 
            // AdminWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 626);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "AdminWindowForm";
            this.Text = "Systemadministration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminWindowForm_FormClosed);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bigPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.employeeTabPage.ResumeLayout(false);
            this.employeeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
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
    }
}