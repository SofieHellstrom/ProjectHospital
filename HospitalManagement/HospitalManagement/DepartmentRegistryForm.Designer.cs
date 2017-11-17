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
            this.depIDLbl = new System.Windows.Forms.Label();
            this.depNameLbl = new System.Windows.Forms.Label();
            this.depOpenTimeLbl = new System.Windows.Forms.Label();
            this.depCloseTimeLbl = new System.Windows.Forms.Label();
            this.depIDTxtBox = new System.Windows.Forms.TextBox();
            this.depNameTxtBox = new System.Windows.Forms.TextBox();
            this.openingTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // 
            // depNameTxtBox
            // 
            this.depNameTxtBox.Location = new System.Drawing.Point(124, 60);
            this.depNameTxtBox.Name = "depNameTxtBox";
            this.depNameTxtBox.Size = new System.Drawing.Size(187, 20);
            this.depNameTxtBox.TabIndex = 5;
            // 
            // openingTimePicker
            // 
            this.openingTimePicker.CustomFormat = "HH:mm";
            this.openingTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.openingTimePicker.Location = new System.Drawing.Point(124, 86);
            this.openingTimePicker.Name = "openingTimePicker";
            this.openingTimePicker.ShowUpDown = true;
            this.openingTimePicker.Size = new System.Drawing.Size(56, 20);
            this.openingTimePicker.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(124, 112);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(56, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Registrera och Rensa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Registrera och Stäng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DepartmentRegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 211);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.openingTimePicker);
            this.Controls.Add(this.depNameTxtBox);
            this.Controls.Add(this.depIDTxtBox);
            this.Controls.Add(this.depCloseTimeLbl);
            this.Controls.Add(this.depOpenTimeLbl);
            this.Controls.Add(this.depNameLbl);
            this.Controls.Add(this.depIDLbl);
            this.Name = "DepartmentRegistryForm";
            this.Text = "DepartmentRegistryForm";
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
        private System.Windows.Forms.DateTimePicker openingTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}