﻿namespace HospitalManagement
{
    partial class PrescriptionForm
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.medicationListBox = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.uttagLbl = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.instructionLbl = new System.Windows.Forms.Label();
            this.registerPrescriptionBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.receptLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(391, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 20);
            this.textBox2.TabIndex = 1;
            // 
            // medicationListBox
            // 
            this.medicationListBox.FormattingEnabled = true;
            this.medicationListBox.Location = new System.Drawing.Point(12, 34);
            this.medicationListBox.Name = "medicationListBox";
            this.medicationListBox.Size = new System.Drawing.Size(363, 251);
            this.medicationListBox.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(391, 102);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 156);
            this.textBox3.TabIndex = 3;
            // 
            // uttagLbl
            // 
            this.uttagLbl.AutoSize = true;
            this.uttagLbl.Location = new System.Drawing.Point(388, 62);
            this.uttagLbl.Name = "uttagLbl";
            this.uttagLbl.Size = new System.Drawing.Size(60, 13);
            this.uttagLbl.TabIndex = 4;
            this.uttagLbl.Text = "Antal Uttag";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(534, 59);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(49, 20);
            this.textBox4.TabIndex = 5;
            // 
            // instructionLbl
            // 
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Location = new System.Drawing.Point(388, 86);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(113, 13);
            this.instructionLbl.TabIndex = 6;
            this.instructionLbl.Text = "Instruktioner till Patient";
            // 
            // registerPrescriptionBtn
            // 
            this.registerPrescriptionBtn.Location = new System.Drawing.Point(441, 265);
            this.registerPrescriptionBtn.Name = "registerPrescriptionBtn";
            this.registerPrescriptionBtn.Size = new System.Drawing.Size(120, 23);
            this.registerPrescriptionBtn.TabIndex = 7;
            this.registerPrescriptionBtn.Text = "Skriv Recept";
            this.registerPrescriptionBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filter:";
            // 
            // receptLbl
            // 
            this.receptLbl.AutoSize = true;
            this.receptLbl.Location = new System.Drawing.Point(449, 15);
            this.receptLbl.Name = "receptLbl";
            this.receptLbl.Size = new System.Drawing.Size(76, 13);
            this.receptLbl.TabIndex = 10;
            this.receptLbl.Text = "Receptdetaljer";
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 300);
            this.Controls.Add(this.receptLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.registerPrescriptionBtn);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.uttagLbl);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.medicationListBox);
            this.Controls.Add(this.textBox2);
            this.Name = "PrescriptionForm";
            this.Text = "Receptskrivning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox medicationListBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label uttagLbl;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label instructionLbl;
        private System.Windows.Forms.Button registerPrescriptionBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label receptLbl;
    }
}