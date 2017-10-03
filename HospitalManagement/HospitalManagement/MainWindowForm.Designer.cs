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
            this.tableLayoutPane = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPane.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.tableLayoutPane.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPane.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPane.Name = "tableLayoutPane";
            this.tableLayoutPane.RowCount = 2;
            this.tableLayoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.602151F));
            this.tableLayoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.39785F));
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
            this.panel2.Location = new System.Drawing.Point(114, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 33);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(105, 417);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(114, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(667, 417);
            this.panel4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tableLayoutPane);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.tableLayoutPane.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

