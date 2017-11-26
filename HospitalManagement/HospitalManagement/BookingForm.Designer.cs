namespace HospitalManagement
{
    partial class BookingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookingPersonNrBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookingPatientName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.purposeBox = new System.Windows.Forms.TextBox();
            this.bokaBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.startTime2 = new System.Windows.Forms.DateTimePicker();
            this.endTime2 = new System.Windows.Forms.DateTimePicker();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.testTypeComboBox = new System.Windows.Forms.ComboBox();
            this.labTestCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personnummer:";
            // 
            // bookingPersonNrBox
            // 
            this.bookingPersonNrBox.Location = new System.Drawing.Point(104, 15);
            this.bookingPersonNrBox.Name = "bookingPersonNrBox";
            this.bookingPersonNrBox.Size = new System.Drawing.Size(143, 20);
            this.bookingPersonNrBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Namn:";
            // 
            // bookingPatientName
            // 
            this.bookingPatientName.Location = new System.Drawing.Point(104, 51);
            this.bookingPatientName.Name = "bookingPatientName";
            this.bookingPatientName.Size = new System.Drawing.Size(143, 20);
            this.bookingPatientName.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2017, 11, 13, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Läkare:";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(104, 174);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(143, 21);
            this.doctorComboBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Syfte:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Från:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Till:";
            // 
            // purposeBox
            // 
            this.purposeBox.Location = new System.Drawing.Point(104, 222);
            this.purposeBox.Name = "purposeBox";
            this.purposeBox.Size = new System.Drawing.Size(143, 20);
            this.purposeBox.TabIndex = 13;
            // 
            // bokaBtn
            // 
            this.bokaBtn.Location = new System.Drawing.Point(104, 268);
            this.bokaBtn.Name = "bokaBtn";
            this.bokaBtn.Size = new System.Drawing.Size(75, 23);
            this.bokaBtn.TabIndex = 14;
            this.bokaBtn.Text = "Boka";
            this.bokaBtn.UseVisualStyleBackColor = true;
            this.bokaBtn.Click += new System.EventHandler(this.bokaBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // startTime2
            // 
            this.startTime2.CustomFormat = "HH:mm";
            this.startTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTime2.Location = new System.Drawing.Point(358, 131);
            this.startTime2.Name = "startTime2";
            this.startTime2.ShowUpDown = true;
            this.startTime2.Size = new System.Drawing.Size(51, 20);
            this.startTime2.TabIndex = 15;
            this.startTime2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // endTime2
            // 
            this.endTime2.CustomFormat = "HH:mm";
            this.endTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTime2.Location = new System.Drawing.Point(454, 131);
            this.endTime2.Name = "endTime2";
            this.endTime2.ShowUpDown = true;
            this.endTime2.Size = new System.Drawing.Size(51, 20);
            this.endTime2.TabIndex = 16;
            this.endTime2.Value = new System.DateTime(2017, 11, 13, 20, 24, 0, 0);
            this.endTime2.ValueChanged += new System.EventHandler(this.endTime2_ValueChanged);
            // 
            // roomComboBox
            // 
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Location = new System.Drawing.Point(358, 174);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(121, 21);
            this.roomComboBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Rum:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Provtyp:";
            // 
            // testTypeComboBox
            // 
            this.testTypeComboBox.FormattingEnabled = true;
            this.testTypeComboBox.Location = new System.Drawing.Point(358, 89);
            this.testTypeComboBox.Name = "testTypeComboBox";
            this.testTypeComboBox.Size = new System.Drawing.Size(143, 21);
            this.testTypeComboBox.TabIndex = 22;
            // 
            // labTestCheckBox
            // 
            this.labTestCheckBox.AutoSize = true;
            this.labTestCheckBox.Location = new System.Drawing.Point(104, 93);
            this.labTestCheckBox.Name = "labTestCheckBox";
            this.labTestCheckBox.Size = new System.Drawing.Size(89, 17);
            this.labTestCheckBox.TabIndex = 23;
            this.labTestCheckBox.Text = "Boka Labtest";
            this.labTestCheckBox.UseVisualStyleBackColor = true;
            this.labTestCheckBox.CheckedChanged += new System.EventHandler(this.labTestCheckBox_CheckedChanged);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 443);
            this.Controls.Add(this.labTestCheckBox);
            this.Controls.Add(this.testTypeComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.roomComboBox);
            this.Controls.Add(this.endTime2);
            this.Controls.Add(this.startTime2);
            this.Controls.Add(this.bokaBtn);
            this.Controls.Add(this.purposeBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bookingPatientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookingPersonNrBox);
            this.Controls.Add(this.label1);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookingPersonNrBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookingPatientName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox purposeBox;
        private System.Windows.Forms.Button bokaBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker startTime2;
        private System.Windows.Forms.DateTimePicker endTime2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.ComboBox testTypeComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox labTestCheckBox;
    }
}