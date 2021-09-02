namespace InventoryProgram
{
    partial class ModifyPartForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbModOutSourced = new System.Windows.Forms.RadioButton();
            this.rbModInHouse = new System.Windows.Forms.RadioButton();
            this.tbModPartID = new System.Windows.Forms.TextBox();
            this.tbModPartName = new System.Windows.Forms.TextBox();
            this.tbModPartInventory = new System.Windows.Forms.TextBox();
            this.tbModPartPrice = new System.Windows.Forms.TextBox();
            this.tbModPartMin = new System.Windows.Forms.TextBox();
            this.tbModPartMax = new System.Windows.Forms.TextBox();
            this.tbModCompanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbModCompanyName = new System.Windows.Forms.Label();
            this.tbModMachineID = new System.Windows.Forms.TextBox();
            this.lbModMachineID = new System.Windows.Forms.Label();
            this.SaveModPartButton = new System.Windows.Forms.Button();
            this.CancelModPartButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbModOutSourced);
            this.groupBox1.Controls.Add(this.rbModInHouse);
            this.groupBox1.Location = new System.Drawing.Point(116, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rbModOutSourced
            // 
            this.rbModOutSourced.AutoSize = true;
            this.rbModOutSourced.Location = new System.Drawing.Point(133, 22);
            this.rbModOutSourced.Name = "rbModOutSourced";
            this.rbModOutSourced.Size = new System.Drawing.Size(103, 21);
            this.rbModOutSourced.TabIndex = 1;
            this.rbModOutSourced.TabStop = true;
            this.rbModOutSourced.Text = "Outsourced";
            this.rbModOutSourced.UseVisualStyleBackColor = true;
            this.rbModOutSourced.CheckedChanged += new System.EventHandler(this.rbModOutSourced_CheckedChanged);
            // 
            // rbModInHouse
            // 
            this.rbModInHouse.AutoSize = true;
            this.rbModInHouse.Location = new System.Drawing.Point(23, 22);
            this.rbModInHouse.Name = "rbModInHouse";
            this.rbModInHouse.Size = new System.Drawing.Size(86, 21);
            this.rbModInHouse.TabIndex = 0;
            this.rbModInHouse.TabStop = true;
            this.rbModInHouse.Text = "In-House";
            this.rbModInHouse.UseVisualStyleBackColor = true;
            this.rbModInHouse.CheckedChanged += new System.EventHandler(this.rbModInHouse_CheckedChanged);
            // 
            // tbModPartID
            // 
            this.tbModPartID.Location = new System.Drawing.Point(169, 151);
            this.tbModPartID.Name = "tbModPartID";
            this.tbModPartID.ReadOnly = true;
            this.tbModPartID.Size = new System.Drawing.Size(157, 22);
            this.tbModPartID.TabIndex = 1;
            // 
            // tbModPartName
            // 
            this.tbModPartName.Location = new System.Drawing.Point(169, 192);
            this.tbModPartName.Name = "tbModPartName";
            this.tbModPartName.Size = new System.Drawing.Size(157, 22);
            this.tbModPartName.TabIndex = 2;
            // 
            // tbModPartInventory
            // 
            this.tbModPartInventory.Location = new System.Drawing.Point(169, 233);
            this.tbModPartInventory.Name = "tbModPartInventory";
            this.tbModPartInventory.Size = new System.Drawing.Size(157, 22);
            this.tbModPartInventory.TabIndex = 3;
            // 
            // tbModPartPrice
            // 
            this.tbModPartPrice.Location = new System.Drawing.Point(169, 273);
            this.tbModPartPrice.Name = "tbModPartPrice";
            this.tbModPartPrice.Size = new System.Drawing.Size(157, 22);
            this.tbModPartPrice.TabIndex = 4;
            // 
            // tbModPartMin
            // 
            this.tbModPartMin.Location = new System.Drawing.Point(139, 324);
            this.tbModPartMin.Name = "tbModPartMin";
            this.tbModPartMin.Size = new System.Drawing.Size(86, 22);
            this.tbModPartMin.TabIndex = 5;
            // 
            // tbModPartMax
            // 
            this.tbModPartMax.Location = new System.Drawing.Point(295, 324);
            this.tbModPartMax.Name = "tbModPartMax";
            this.tbModPartMax.Size = new System.Drawing.Size(85, 22);
            this.tbModPartMax.TabIndex = 6;
            // 
            // tbModCompanyName
            // 
            this.tbModCompanyName.Location = new System.Drawing.Point(169, 365);
            this.tbModCompanyName.Name = "tbModCompanyName";
            this.tbModCompanyName.Size = new System.Drawing.Size(157, 22);
            this.tbModCompanyName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price/Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Max";
            // 
            // lbModCompanyName
            // 
            this.lbModCompanyName.AutoSize = true;
            this.lbModCompanyName.Location = new System.Drawing.Point(46, 365);
            this.lbModCompanyName.Name = "lbModCompanyName";
            this.lbModCompanyName.Size = new System.Drawing.Size(108, 17);
            this.lbModCompanyName.TabIndex = 14;
            this.lbModCompanyName.Text = "Company Name";
            // 
            // tbModMachineID
            // 
            this.tbModMachineID.Location = new System.Drawing.Point(169, 365);
            this.tbModMachineID.Name = "tbModMachineID";
            this.tbModMachineID.Size = new System.Drawing.Size(157, 22);
            this.tbModMachineID.TabIndex = 15;
            // 
            // lbModMachineID
            // 
            this.lbModMachineID.AutoSize = true;
            this.lbModMachineID.Location = new System.Drawing.Point(80, 365);
            this.lbModMachineID.Name = "lbModMachineID";
            this.lbModMachineID.Size = new System.Drawing.Size(74, 17);
            this.lbModMachineID.TabIndex = 16;
            this.lbModMachineID.Text = "MachineID";
            // 
            // SaveModPartButton
            // 
            this.SaveModPartButton.Location = new System.Drawing.Point(142, 423);
            this.SaveModPartButton.Name = "SaveModPartButton";
            this.SaveModPartButton.Size = new System.Drawing.Size(83, 35);
            this.SaveModPartButton.TabIndex = 17;
            this.SaveModPartButton.Text = "Save";
            this.SaveModPartButton.UseVisualStyleBackColor = true;
            this.SaveModPartButton.Click += new System.EventHandler(this.SaveModPartButton_Click);
            // 
            // CancelModPartButton
            // 
            this.CancelModPartButton.Location = new System.Drawing.Point(249, 423);
            this.CancelModPartButton.Name = "CancelModPartButton";
            this.CancelModPartButton.Size = new System.Drawing.Size(83, 35);
            this.CancelModPartButton.TabIndex = 18;
            this.CancelModPartButton.Text = "Cancel";
            this.CancelModPartButton.UseVisualStyleBackColor = true;
            this.CancelModPartButton.Click += new System.EventHandler(this.CancelModPartButton_Click);
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 519);
            this.Controls.Add(this.CancelModPartButton);
            this.Controls.Add(this.SaveModPartButton);
            this.Controls.Add(this.lbModMachineID);
            this.Controls.Add(this.tbModMachineID);
            this.Controls.Add(this.lbModCompanyName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbModCompanyName);
            this.Controls.Add(this.tbModPartMax);
            this.Controls.Add(this.tbModPartMin);
            this.Controls.Add(this.tbModPartPrice);
            this.Controls.Add(this.tbModPartInventory);
            this.Controls.Add(this.tbModPartName);
            this.Controls.Add(this.tbModPartID);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModifyPartForm";
            this.Text = "Modify Part";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbModCompanyName;
        private System.Windows.Forms.Label lbModMachineID;
        private System.Windows.Forms.Button SaveModPartButton;
        private System.Windows.Forms.Button CancelModPartButton;
        public System.Windows.Forms.RadioButton rbModOutSourced;
        public System.Windows.Forms.RadioButton rbModInHouse;
        public System.Windows.Forms.TextBox tbModPartID;
        public System.Windows.Forms.TextBox tbModPartName;
        public System.Windows.Forms.TextBox tbModPartInventory;
        public System.Windows.Forms.TextBox tbModPartPrice;
        public System.Windows.Forms.TextBox tbModPartMin;
        public System.Windows.Forms.TextBox tbModPartMax;
        public System.Windows.Forms.TextBox tbModMachineID;
        public System.Windows.Forms.TextBox tbModCompanyName;
    }
}