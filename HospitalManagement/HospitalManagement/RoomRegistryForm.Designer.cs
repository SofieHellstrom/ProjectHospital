namespace HospitalManagement
{
    partial class RoomRegistryForm
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
            this.roomIdLbl = new System.Windows.Forms.Label();
            this.functionLbl = new System.Windows.Forms.Label();
            this.capacityLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roomIdTxtBox = new System.Windows.Forms.TextBox();
            this.roomFunctionTxtBox = new System.Windows.Forms.TextBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentLbl = new System.Windows.Forms.Label();
            this.saveMoreRoomsBtn = new System.Windows.Forms.Button();
            this.saveOneAndCloseBtn = new System.Windows.Forms.Button();
            this.roomCapUpDown = new System.Windows.Forms.NumericUpDown();
            this.roomMaxUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.roomCapUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomMaxUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // roomIdLbl
            // 
            this.roomIdLbl.AutoSize = true;
            this.roomIdLbl.Location = new System.Drawing.Point(12, 43);
            this.roomIdLbl.Name = "roomIdLbl";
            this.roomIdLbl.Size = new System.Drawing.Size(46, 13);
            this.roomIdLbl.TabIndex = 0;
            this.roomIdLbl.Text = "Rum ID:";
            // 
            // functionLbl
            // 
            this.functionLbl.AutoSize = true;
            this.functionLbl.Location = new System.Drawing.Point(12, 69);
            this.functionLbl.Name = "functionLbl";
            this.functionLbl.Size = new System.Drawing.Size(51, 13);
            this.functionLbl.TabIndex = 1;
            this.functionLbl.Text = "Funktion:";
            // 
            // capacityLbl
            // 
            this.capacityLbl.AutoSize = true;
            this.capacityLbl.Location = new System.Drawing.Point(12, 95);
            this.capacityLbl.Name = "capacityLbl";
            this.capacityLbl.Size = new System.Drawing.Size(55, 13);
            this.capacityLbl.TabIndex = 2;
            this.capacityLbl.Text = "Kapacitet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max-kapacitet:";
            // 
            // roomIdTxtBox
            // 
            this.roomIdTxtBox.Location = new System.Drawing.Point(88, 40);
            this.roomIdTxtBox.Name = "roomIdTxtBox";
            this.roomIdTxtBox.Size = new System.Drawing.Size(115, 20);
            this.roomIdTxtBox.TabIndex = 4;
            this.roomIdTxtBox.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            this.roomIdTxtBox.Validated += new System.EventHandler(this.roomIdTxtBox_Validated);
            // 
            // roomFunctionTxtBox
            // 
            this.roomFunctionTxtBox.Location = new System.Drawing.Point(88, 66);
            this.roomFunctionTxtBox.Name = "roomFunctionTxtBox";
            this.roomFunctionTxtBox.Size = new System.Drawing.Size(168, 20);
            this.roomFunctionTxtBox.TabIndex = 5;
            this.roomFunctionTxtBox.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(88, 13);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(136, 21);
            this.departmentComboBox.TabIndex = 8;
            // 
            // departmentLbl
            // 
            this.departmentLbl.AutoSize = true;
            this.departmentLbl.Location = new System.Drawing.Point(12, 16);
            this.departmentLbl.Name = "departmentLbl";
            this.departmentLbl.Size = new System.Drawing.Size(57, 13);
            this.departmentLbl.TabIndex = 9;
            this.departmentLbl.Text = "Avdelning:";
            // 
            // saveMoreRoomsBtn
            // 
            this.saveMoreRoomsBtn.Enabled = false;
            this.saveMoreRoomsBtn.Location = new System.Drawing.Point(26, 138);
            this.saveMoreRoomsBtn.Name = "saveMoreRoomsBtn";
            this.saveMoreRoomsBtn.Size = new System.Drawing.Size(117, 23);
            this.saveMoreRoomsBtn.TabIndex = 10;
            this.saveMoreRoomsBtn.Text = "Spara och Rensa";
            this.saveMoreRoomsBtn.UseVisualStyleBackColor = true;
            this.saveMoreRoomsBtn.Click += new System.EventHandler(this.saveMoreRoomsBtn_Click);
            // 
            // saveOneAndCloseBtn
            // 
            this.saveOneAndCloseBtn.Enabled = false;
            this.saveOneAndCloseBtn.Location = new System.Drawing.Point(165, 138);
            this.saveOneAndCloseBtn.Name = "saveOneAndCloseBtn";
            this.saveOneAndCloseBtn.Size = new System.Drawing.Size(117, 23);
            this.saveOneAndCloseBtn.TabIndex = 11;
            this.saveOneAndCloseBtn.Text = "Spara och Stäng";
            this.saveOneAndCloseBtn.UseVisualStyleBackColor = true;
            this.saveOneAndCloseBtn.Click += new System.EventHandler(this.saveOneAndCloseBtn_Click);
            // 
            // roomCapUpDown
            // 
            this.roomCapUpDown.Location = new System.Drawing.Point(88, 93);
            this.roomCapUpDown.Name = "roomCapUpDown";
            this.roomCapUpDown.Size = new System.Drawing.Size(48, 20);
            this.roomCapUpDown.TabIndex = 12;
            // 
            // roomMaxUpDown
            // 
            this.roomMaxUpDown.Location = new System.Drawing.Point(230, 93);
            this.roomMaxUpDown.Name = "roomMaxUpDown";
            this.roomMaxUpDown.Size = new System.Drawing.Size(49, 20);
            this.roomMaxUpDown.TabIndex = 13;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // RoomRegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 180);
            this.Controls.Add(this.roomMaxUpDown);
            this.Controls.Add(this.roomCapUpDown);
            this.Controls.Add(this.saveOneAndCloseBtn);
            this.Controls.Add(this.saveMoreRoomsBtn);
            this.Controls.Add(this.departmentLbl);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.roomFunctionTxtBox);
            this.Controls.Add(this.roomIdTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.capacityLbl);
            this.Controls.Add(this.functionLbl);
            this.Controls.Add(this.roomIdLbl);
            this.Name = "RoomRegistryForm";
            this.Text = "RoomRegistryForm";
            ((System.ComponentModel.ISupportInitialize)(this.roomCapUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomMaxUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roomIdLbl;
        private System.Windows.Forms.Label functionLbl;
        private System.Windows.Forms.Label capacityLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox roomIdTxtBox;
        private System.Windows.Forms.TextBox roomFunctionTxtBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label departmentLbl;
        private System.Windows.Forms.Button saveMoreRoomsBtn;
        private System.Windows.Forms.Button saveOneAndCloseBtn;
        private System.Windows.Forms.NumericUpDown roomCapUpDown;
        private System.Windows.Forms.NumericUpDown roomMaxUpDown;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}