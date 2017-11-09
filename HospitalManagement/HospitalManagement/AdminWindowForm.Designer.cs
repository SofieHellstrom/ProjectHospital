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
            this.topPanel = new System.Windows.Forms.Panel();
            this.bigPanel = new System.Windows.Forms.Panel();
            this.currentUserLbl = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.employeeTabPage = new System.Windows.Forms.TabPage();
            this.departmentTabPage = new System.Windows.Forms.TabPage();
            this.roomTabPage = new System.Windows.Forms.TabPage();
            this.addBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.bigPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.47178F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.52822F));
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
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(691, 308);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // cornerPanel
            // 
            this.cornerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cornerPanel.Location = new System.Drawing.Point(3, 3);
            this.cornerPanel.Name = "cornerPanel";
            this.cornerPanel.Size = new System.Drawing.Size(93, 33);
            this.cornerPanel.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.button3);
            this.leftPanel.Controls.Add(this.button2);
            this.leftPanel.Controls.Add(this.addBtn);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(3, 42);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(93, 263);
            this.leftPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.currentUserLbl);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(102, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(586, 33);
            this.topPanel.TabIndex = 2;
            // 
            // bigPanel
            // 
            this.bigPanel.Controls.Add(this.tabControl);
            this.bigPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bigPanel.Location = new System.Drawing.Point(102, 42);
            this.bigPanel.Name = "bigPanel";
            this.bigPanel.Size = new System.Drawing.Size(586, 263);
            this.bigPanel.TabIndex = 3;
            // 
            // currentUserLbl
            // 
            this.currentUserLbl.AutoSize = true;
            this.currentUserLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.currentUserLbl.Location = new System.Drawing.Point(557, 0);
            this.currentUserLbl.Name = "currentUserLbl";
            this.currentUserLbl.Size = new System.Drawing.Size(29, 13);
            this.currentUserLbl.TabIndex = 0;
            this.currentUserLbl.Text = "User";
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
            this.tabControl.Size = new System.Drawing.Size(586, 263);
            this.tabControl.TabIndex = 0;
            // 
            // employeeTabPage
            // 
            this.employeeTabPage.Location = new System.Drawing.Point(4, 22);
            this.employeeTabPage.Name = "employeeTabPage";
            this.employeeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeeTabPage.Size = new System.Drawing.Size(578, 237);
            this.employeeTabPage.TabIndex = 0;
            this.employeeTabPage.Text = "Anställda";
            this.employeeTabPage.UseVisualStyleBackColor = true;
            // 
            // departmentTabPage
            // 
            this.departmentTabPage.Location = new System.Drawing.Point(4, 22);
            this.departmentTabPage.Name = "departmentTabPage";
            this.departmentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.departmentTabPage.Size = new System.Drawing.Size(606, 237);
            this.departmentTabPage.TabIndex = 1;
            this.departmentTabPage.Text = "Avdelningar";
            this.departmentTabPage.UseVisualStyleBackColor = true;
            // 
            // roomTabPage
            // 
            this.roomTabPage.Location = new System.Drawing.Point(4, 22);
            this.roomTabPage.Name = "roomTabPage";
            this.roomTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.roomTabPage.Size = new System.Drawing.Size(578, 237);
            this.roomTabPage.TabIndex = 2;
            this.roomTabPage.Text = "Rum";
            this.roomTabPage.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Uppdatera X";
            this.button2.UseVisualStyleBackColor = true;
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
            // AdminWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 308);
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
    }
}