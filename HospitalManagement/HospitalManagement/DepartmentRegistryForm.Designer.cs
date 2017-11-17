namespace HospitalManagement
{
    partial class DepartmentRegistryForm
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
            this.depIDLbl = new System.Windows.Forms.Label();
            this.depNameLbl = new System.Windows.Forms.Label();
            this.depOpenTimeLbl = new System.Windows.Forms.Label();
            this.depCloseTimeLbl = new System.Windows.Forms.Label();
            this.depIDTxtBox = new System.Windows.Forms.TextBox();
            this.depNameTxtBox = new System.Windows.Forms.TextBox();
            this.depOpenTimePicker = new System.Windows.Forms.DateTimePicker();
            this.depCloseTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveMoreDepartmentsBtn = new System.Windows.Forms.Button();
            this.saveOneAndCloseBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // depIDLbl
            // 
            this.depIDLbl.AutoSize = true;
            this.depIDLbl.Location = new System.Drawing.Point(42, 37);
            this.depIDLbl.Name = "depIDLbl";
            this.depIDLbl.Size = new System.Drawing.Size(76, 13);
            this.depIDLbl.TabIndex = 0;
            this.depIDLbl.Text = "Avdelnings ID:";
            // 
            // depNameLbl
            // 
            this.depNameLbl.AutoSize = true;
            this.depNameLbl.Location = new System.Drawing.Point(42, 63);
            this.depNameLbl.Name = "depNameLbl";
            this.depNameLbl.Size = new System.Drawing.Size(38, 13);
            this.depNameLbl.TabIndex = 1;
            this.depNameLbl.Text = "Namn:";
            // 
            // depOpenTimeLbl
            // 
            this.depOpenTimeLbl.AutoSize = true;
            this.depOpenTimeLbl.Location = new System.Drawing.Point(42, 92);
            this.depOpenTimeLbl.Name = "depOpenTimeLbl";
            this.depOpenTimeLbl.Size = new System.Drawing.Size(66, 13);
            this.depOpenTimeLbl.TabIndex = 2;
            this.depOpenTimeLbl.Text = "Öppningstid:";
            // 
            // depCloseTimeLbl
            // 
            this.depCloseTimeLbl.AutoSize = true;
            this.depCloseTimeLbl.Location = new System.Drawing.Point(42, 118);
            this.depCloseTimeLbl.Name = "depCloseTimeLbl";
            this.depCloseTimeLbl.Size = new System.Drawing.Size(74, 13);
            this.depCloseTimeLbl.TabIndex = 3;
            this.depCloseTimeLbl.Text = "Stängningstid:";
            // 
            // depIDTxtBox
            // 
            this.depIDTxtBox.Location = new System.Drawing.Point(124, 34);
            this.depIDTxtBox.Name = "depIDTxtBox";
            this.depIDTxtBox.Size = new System.Drawing.Size(135, 20);
            this.depIDTxtBox.TabIndex = 4;
            this.depIDTxtBox.Validated += new System.EventHandler(this.depIDTxtBox_Validated);
            // 
            // depNameTxtBox
            // 
            this.depNameTxtBox.Location = new System.Drawing.Point(124, 60);
            this.depNameTxtBox.Name = "depNameTxtBox";
            this.depNameTxtBox.Size = new System.Drawing.Size(187, 20);
            this.depNameTxtBox.TabIndex = 5;
            this.depNameTxtBox.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // depOpenTimePicker
            // 
            this.depOpenTimePicker.CustomFormat = "HH:mm";
            this.depOpenTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.depOpenTimePicker.Location = new System.Drawing.Point(124, 86);
            this.depOpenTimePicker.Name = "depOpenTimePicker";
            this.depOpenTimePicker.ShowUpDown = true;
            this.depOpenTimePicker.Size = new System.Drawing.Size(56, 20);
            this.depOpenTimePicker.TabIndex = 6;
            // 
            // depCloseTimePicker
            // 
            this.depCloseTimePicker.CustomFormat = "HH:mm";
            this.depCloseTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.depCloseTimePicker.Location = new System.Drawing.Point(124, 112);
            this.depCloseTimePicker.Name = "depCloseTimePicker";
            this.depCloseTimePicker.ShowUpDown = true;
            this.depCloseTimePicker.Size = new System.Drawing.Size(56, 20);
            this.depCloseTimePicker.TabIndex = 7;
            // 
            // saveMoreDepartmentsBtn
            // 
            this.saveMoreDepartmentsBtn.Enabled = false;
            this.saveMoreDepartmentsBtn.Location = new System.Drawing.Point(35, 170);
            this.saveMoreDepartmentsBtn.Name = "saveMoreDepartmentsBtn";
            this.saveMoreDepartmentsBtn.Size = new System.Drawing.Size(127, 23);
            this.saveMoreDepartmentsBtn.TabIndex = 8;
            this.saveMoreDepartmentsBtn.Text = "Registrera och Rensa";
            this.saveMoreDepartmentsBtn.UseVisualStyleBackColor = true;
            this.saveMoreDepartmentsBtn.Click += new System.EventHandler(this.saveMoreDepartmentsBtn_Click);
            // 
            // saveOneAndCloseBtn
            // 
            this.saveOneAndCloseBtn.Enabled = false;
            this.saveOneAndCloseBtn.Location = new System.Drawing.Point(191, 170);
            this.saveOneAndCloseBtn.Name = "saveOneAndCloseBtn";
            this.saveOneAndCloseBtn.Size = new System.Drawing.Size(132, 23);
            this.saveOneAndCloseBtn.TabIndex = 9;
            this.saveOneAndCloseBtn.Text = "Registrera och Stäng";
            this.saveOneAndCloseBtn.UseVisualStyleBackColor = true;
            this.saveOneAndCloseBtn.Click += new System.EventHandler(this.saveOneAndCloseBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // DepartmentRegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 211);
            this.Controls.Add(this.saveOneAndCloseBtn);
            this.Controls.Add(this.saveMoreDepartmentsBtn);
            this.Controls.Add(this.depCloseTimePicker);
            this.Controls.Add(this.depOpenTimePicker);
            this.Controls.Add(this.depNameTxtBox);
            this.Controls.Add(this.depIDTxtBox);
            this.Controls.Add(this.depCloseTimeLbl);
            this.Controls.Add(this.depOpenTimeLbl);
            this.Controls.Add(this.depNameLbl);
            this.Controls.Add(this.depIDLbl);
            this.Name = "DepartmentRegistryForm";
            this.Text = "DepartmentRegistryForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label depIDLbl;
        private System.Windows.Forms.Label depNameLbl;
        private System.Windows.Forms.Label depOpenTimeLbl;
        private System.Windows.Forms.Label depCloseTimeLbl;
        private System.Windows.Forms.TextBox depIDTxtBox;
        private System.Windows.Forms.TextBox depNameTxtBox;
        private System.Windows.Forms.DateTimePicker depOpenTimePicker;
        private System.Windows.Forms.DateTimePicker depCloseTimePicker;
        private System.Windows.Forms.Button saveMoreDepartmentsBtn;
        private System.Windows.Forms.Button saveOneAndCloseBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}