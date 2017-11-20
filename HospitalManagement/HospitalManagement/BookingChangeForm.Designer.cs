namespace HospitalManagement
{
    partial class BookingChangeForm
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
            this.uppdateraBtn = new System.Windows.Forms.Button();
            this.startTime2 = new System.Windows.Forms.DateTimePicker();
            this.endTime2 = new System.Windows.Forms.DateTimePicker();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bortaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Personnummer:";
            // 
            // bookingPersonNrBox
            // 
            this.bookingPersonNrBox.Location = new System.Drawing.Point(100, 18);
            this.bookingPersonNrBox.Name = "bookingPersonNrBox";
            this.bookingPersonNrBox.Size = new System.Drawing.Size(143, 20);
            this.bookingPersonNrBox.TabIndex = 24;
            this.bookingPersonNrBox.TextChanged += new System.EventHandler(this.bookingPersonNrBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Namn:";
            // 
            // bookingPatientName
            // 
            this.bookingPatientName.Location = new System.Drawing.Point(100, 54);
            this.bookingPatientName.Name = "bookingPatientName";
            this.bookingPatientName.Size = new System.Drawing.Size(143, 20);
            this.bookingPatientName.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.Value = new System.DateTime(2017, 11, 13, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Läkare:";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(100, 140);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(143, 21);
            this.doctorComboBox.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Syfte:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Från:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Till:";
            // 
            // purposeBox
            // 
            this.purposeBox.Location = new System.Drawing.Point(100, 233);
            this.purposeBox.Name = "purposeBox";
            this.purposeBox.Size = new System.Drawing.Size(143, 20);
            this.purposeBox.TabIndex = 34;
            // 
            // uppdateraBtn
            // 
            this.uppdateraBtn.Location = new System.Drawing.Point(100, 279);
            this.uppdateraBtn.Name = "uppdateraBtn";
            this.uppdateraBtn.Size = new System.Drawing.Size(75, 23);
            this.uppdateraBtn.TabIndex = 35;
            this.uppdateraBtn.Text = "Uppdatera";
            this.uppdateraBtn.UseVisualStyleBackColor = true;
            // 
            // startTime2
            // 
            this.startTime2.CustomFormat = "HH:mm";
            this.startTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTime2.Location = new System.Drawing.Point(376, 97);
            this.startTime2.Name = "startTime2";
            this.startTime2.ShowUpDown = true;
            this.startTime2.Size = new System.Drawing.Size(51, 20);
            this.startTime2.TabIndex = 36;
            // 
            // endTime2
            // 
            this.endTime2.CustomFormat = "HH:mm";
            this.endTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTime2.Location = new System.Drawing.Point(472, 97);
            this.endTime2.Name = "endTime2";
            this.endTime2.ShowUpDown = true;
            this.endTime2.Size = new System.Drawing.Size(51, 20);
            this.endTime2.TabIndex = 37;
            this.endTime2.Value = new System.DateTime(2017, 11, 13, 20, 24, 0, 0);
            // 
            // roomComboBox
            // 
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Location = new System.Drawing.Point(376, 140);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(121, 21);
            this.roomComboBox.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Rum:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Provtyp:";
            // 
            // bortaBtn
            // 
            this.bortaBtn.Location = new System.Drawing.Point(376, 279);
            this.bortaBtn.Name = "bortaBtn";
            this.bortaBtn.Size = new System.Drawing.Size(75, 23);
            this.bortaBtn.TabIndex = 44;
            this.bortaBtn.Text = "Ta Bort";
            this.bortaBtn.UseVisualStyleBackColor = true;
            // 
            // BookingChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 512);
            this.Controls.Add(this.bortaBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.roomComboBox);
            this.Controls.Add(this.endTime2);
            this.Controls.Add(this.startTime2);
            this.Controls.Add(this.uppdateraBtn);
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
            this.Name = "BookingChangeForm";
            this.Text = "BookingChangeForm";
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
        private System.Windows.Forms.Button uppdateraBtn;
        private System.Windows.Forms.DateTimePicker startTime2;
        private System.Windows.Forms.DateTimePicker endTime2;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bortaBtn;
    }
}