namespace HospitalManagement
{
    partial class NoteForm
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
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.noteTypeLbl = new System.Windows.Forms.Label();
            this.importantCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.noteLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Allergi",
            "Diagnos",
            "Standard",
            "Utlåtande"});
            this.typeComboBox.Location = new System.Drawing.Point(143, 29);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 0;
            // 
            // noteTypeLbl
            // 
            this.noteTypeLbl.AutoSize = true;
            this.noteTypeLbl.Location = new System.Drawing.Point(37, 32);
            this.noteTypeLbl.Name = "noteTypeLbl";
            this.noteTypeLbl.Size = new System.Drawing.Size(100, 13);
            this.noteTypeLbl.TabIndex = 1;
            this.noteTypeLbl.Text = "Typ av Anteckning:";
            // 
            // importantCheckBox
            // 
            this.importantCheckBox.AutoSize = true;
            this.importantCheckBox.Location = new System.Drawing.Point(290, 33);
            this.importantCheckBox.Name = "importantCheckBox";
            this.importantCheckBox.Size = new System.Drawing.Size(55, 17);
            this.importantCheckBox.TabIndex = 2;
            this.importantCheckBox.Text = "Viktigt";
            this.importantCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(40, 77);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(473, 213);
            this.textBox.TabIndex = 1;
            // 
            // noteLbl
            // 
            this.noteLbl.AutoSize = true;
            this.noteLbl.Location = new System.Drawing.Point(37, 61);
            this.noteLbl.Name = "noteLbl";
            this.noteLbl.Size = new System.Drawing.Size(31, 13);
            this.noteLbl.TabIndex = 4;
            this.noteLbl.Text = "Text:";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(403, 303);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(110, 26);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Spara Anteckning";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 341);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.noteLbl);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.importantCheckBox);
            this.Controls.Add(this.noteTypeLbl);
            this.Controls.Add(this.typeComboBox);
            this.Name = "NoteForm";
            this.Text = "NoteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label noteTypeLbl;
        private System.Windows.Forms.CheckBox importantCheckBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label noteLbl;
        private System.Windows.Forms.Button saveBtn;
    }
}