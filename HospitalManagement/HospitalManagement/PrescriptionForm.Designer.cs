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
            this.components = new System.ComponentModel.Container();
            this.prescriptionMedTxtBox = new System.Windows.Forms.TextBox();
            this.medicationListBox = new System.Windows.Forms.ListBox();
            this.instructionTxtBox = new System.Windows.Forms.TextBox();
            this.uttagLbl = new System.Windows.Forms.Label();
            this.nrOfTimesTxtBox = new System.Windows.Forms.TextBox();
            this.instructionLbl = new System.Windows.Forms.Label();
            this.registerPrescriptionBtn = new System.Windows.Forms.Button();
            this.filterTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.receptLbl = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // prescriptionMedTxtBox
            // 
            this.prescriptionMedTxtBox.Location = new System.Drawing.Point(391, 33);
            this.prescriptionMedTxtBox.Name = "prescriptionMedTxtBox";
            this.prescriptionMedTxtBox.Size = new System.Drawing.Size(246, 20);
            this.prescriptionMedTxtBox.TabIndex = 1;
            this.prescriptionMedTxtBox.TabStop = false;
            // 
            // medicationListBox
            // 
            this.medicationListBox.FormattingEnabled = true;
            this.medicationListBox.Location = new System.Drawing.Point(12, 34);
            this.medicationListBox.Name = "medicationListBox";
            this.medicationListBox.Size = new System.Drawing.Size(363, 251);
            this.medicationListBox.TabIndex = 2;
            this.medicationListBox.SelectedIndexChanged += new System.EventHandler(this.medicationListBox_SelectedIndexChanged);
            // 
            // instructionTxtBox
            // 
            this.instructionTxtBox.Location = new System.Drawing.Point(391, 72);
            this.instructionTxtBox.Multiline = true;
            this.instructionTxtBox.Name = "instructionTxtBox";
            this.instructionTxtBox.Size = new System.Drawing.Size(306, 186);
            this.instructionTxtBox.TabIndex = 3;
            // 
            // uttagLbl
            // 
            this.uttagLbl.AutoSize = true;
            this.uttagLbl.Location = new System.Drawing.Point(652, 15);
            this.uttagLbl.Name = "uttagLbl";
            this.uttagLbl.Size = new System.Drawing.Size(33, 13);
            this.uttagLbl.TabIndex = 4;
            this.uttagLbl.Text = "Uttag";
            // 
            // nrOfTimesTxtBox
            // 
            this.nrOfTimesTxtBox.Location = new System.Drawing.Point(648, 33);
            this.nrOfTimesTxtBox.Name = "nrOfTimesTxtBox";
            this.nrOfTimesTxtBox.Size = new System.Drawing.Size(49, 20);
            this.nrOfTimesTxtBox.TabIndex = 2;
            this.nrOfTimesTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.nrOfTimesTxtBox_Validating);
            // 
            // instructionLbl
            // 
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Location = new System.Drawing.Point(388, 56);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(113, 13);
            this.instructionLbl.TabIndex = 6;
            this.instructionLbl.Text = "Instruktioner till Patient";
            // 
            // registerPrescriptionBtn
            // 
            this.registerPrescriptionBtn.Location = new System.Drawing.Point(577, 265);
            this.registerPrescriptionBtn.Name = "registerPrescriptionBtn";
            this.registerPrescriptionBtn.Size = new System.Drawing.Size(120, 23);
            this.registerPrescriptionBtn.TabIndex = 7;
            this.registerPrescriptionBtn.Text = "Skriv Recept";
            this.registerPrescriptionBtn.UseVisualStyleBackColor = true;
            this.registerPrescriptionBtn.Click += new System.EventHandler(this.registerPrescriptionBtn_Click);
            // 
            // filterTxtBox
            // 
            this.filterTxtBox.Location = new System.Drawing.Point(50, 8);
            this.filterTxtBox.Name = "filterTxtBox";
            this.filterTxtBox.Size = new System.Drawing.Size(169, 20);
            this.filterTxtBox.TabIndex = 1;
            this.filterTxtBox.TextChanged += new System.EventHandler(this.filterTxtBox_TextChanged);
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
            this.receptLbl.Location = new System.Drawing.Point(388, 15);
            this.receptLbl.Name = "receptLbl";
            this.receptLbl.Size = new System.Drawing.Size(76, 13);
            this.receptLbl.TabIndex = 10;
            this.receptLbl.Text = "Receptdetaljer";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 300);
            this.Controls.Add(this.receptLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterTxtBox);
            this.Controls.Add(this.registerPrescriptionBtn);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.nrOfTimesTxtBox);
            this.Controls.Add(this.uttagLbl);
            this.Controls.Add(this.instructionTxtBox);
            this.Controls.Add(this.medicationListBox);
            this.Controls.Add(this.prescriptionMedTxtBox);
            this.Name = "PrescriptionForm";
            this.Text = "Receptskrivning";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prescriptionMedTxtBox;
        private System.Windows.Forms.ListBox medicationListBox;
        private System.Windows.Forms.TextBox instructionTxtBox;
        private System.Windows.Forms.Label uttagLbl;
        private System.Windows.Forms.TextBox nrOfTimesTxtBox;
        private System.Windows.Forms.Label instructionLbl;
        private System.Windows.Forms.Button registerPrescriptionBtn;
        private System.Windows.Forms.TextBox filterTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label receptLbl;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}