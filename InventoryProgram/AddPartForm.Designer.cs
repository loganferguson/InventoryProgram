namespace InventoryProgram
{
    partial class AddPartForm
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPartName = new System.Windows.Forms.TextBox();
            this.tbInventory = new System.Windows.Forms.TextBox();
            this.tbPriceCost = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbMachineID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMachineID = new System.Windows.Forms.Label();
            this.rdInHouse = new System.Windows.Forms.RadioButton();
            this.rdOutsourced = new System.Windows.Forms.RadioButton();
            this.btSavePart = new System.Windows.Forms.Button();
            this.btCancelAddPart = new System.Windows.Forms.Button();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(189, 125);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 22);
            this.tbID.TabIndex = 1;
            // 
            // tbPartName
            // 
            this.tbPartName.Location = new System.Drawing.Point(189, 159);
            this.tbPartName.Name = "tbPartName";
            this.tbPartName.Size = new System.Drawing.Size(166, 22);
            this.tbPartName.TabIndex = 2;
            // 
            // tbInventory
            // 
            this.tbInventory.Location = new System.Drawing.Point(189, 196);
            this.tbInventory.Name = "tbInventory";
            this.tbInventory.Size = new System.Drawing.Size(100, 22);
            this.tbInventory.TabIndex = 3;
            // 
            // tbPriceCost
            // 
            this.tbPriceCost.Location = new System.Drawing.Point(189, 235);
            this.tbPriceCost.Name = "tbPriceCost";
            this.tbPriceCost.Size = new System.Drawing.Size(100, 22);
            this.tbPriceCost.TabIndex = 4;
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(189, 273);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(100, 22);
            this.tbMin.TabIndex = 5;
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(361, 273);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 22);
            this.tbMax.TabIndex = 6;
            // 
            // tbMachineID
            // 
            this.tbMachineID.Location = new System.Drawing.Point(189, 312);
            this.tbMachineID.Name = "tbMachineID";
            this.tbMachineID.Size = new System.Drawing.Size(100, 22);
            this.tbMachineID.TabIndex = 7;
            this.tbMachineID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Part Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Iventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price/Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Max";
            // 
            // lbMachineID
            // 
            this.lbMachineID.AutoSize = true;
            this.lbMachineID.Location = new System.Drawing.Point(93, 315);
            this.lbMachineID.Name = "lbMachineID";
            this.lbMachineID.Size = new System.Drawing.Size(78, 17);
            this.lbMachineID.TabIndex = 14;
            this.lbMachineID.Text = "Machine ID";
            this.lbMachineID.Visible = false;
            // 
            // rdInHouse
            // 
            this.rdInHouse.AutoSize = true;
            this.rdInHouse.Location = new System.Drawing.Point(19, 10);
            this.rdInHouse.Name = "rdInHouse";
            this.rdInHouse.Size = new System.Drawing.Size(86, 21);
            this.rdInHouse.TabIndex = 15;
            this.rdInHouse.TabStop = true;
            this.rdInHouse.Text = "In-House";
            this.rdInHouse.UseVisualStyleBackColor = true;
            this.rdInHouse.CheckedChanged += new System.EventHandler(this.rdInHouse_CheckedChanged);
            // 
            // rdOutsourced
            // 
            this.rdOutsourced.AutoSize = true;
            this.rdOutsourced.Location = new System.Drawing.Point(127, 10);
            this.rdOutsourced.Name = "rdOutsourced";
            this.rdOutsourced.Size = new System.Drawing.Size(103, 21);
            this.rdOutsourced.TabIndex = 16;
            this.rdOutsourced.TabStop = true;
            this.rdOutsourced.Text = "Outsourced";
            this.rdOutsourced.UseVisualStyleBackColor = true;
            this.rdOutsourced.CheckedChanged += new System.EventHandler(this.rdOutsourced_CheckedChanged);
            // 
            // btSavePart
            // 
            this.btSavePart.Location = new System.Drawing.Point(153, 389);
            this.btSavePart.Name = "btSavePart";
            this.btSavePart.Size = new System.Drawing.Size(92, 34);
            this.btSavePart.TabIndex = 17;
            this.btSavePart.Text = "Save";
            this.btSavePart.UseVisualStyleBackColor = true;
            this.btSavePart.Click += new System.EventHandler(this.btSavePart_Click);
            // 
            // btCancelAddPart
            // 
            this.btCancelAddPart.Location = new System.Drawing.Point(268, 389);
            this.btCancelAddPart.Name = "btCancelAddPart";
            this.btCancelAddPart.Size = new System.Drawing.Size(87, 34);
            this.btCancelAddPart.TabIndex = 18;
            this.btCancelAddPart.Text = "Cancel";
            this.btCancelAddPart.UseVisualStyleBackColor = true;
            this.btCancelAddPart.Click += new System.EventHandler(this.btCancelAddPart_Click);
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.BackColor = System.Drawing.SystemColors.Window;
            this.tbCompanyName.Location = new System.Drawing.Point(189, 312);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(100, 22);
            this.tbCompanyName.TabIndex = 7;
            this.tbCompanyName.Visible = false;
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Location = new System.Drawing.Point(63, 315);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(108, 17);
            this.lbCompanyName.TabIndex = 20;
            this.lbCompanyName.Text = "Company Name";
            this.lbCompanyName.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdOutsourced);
            this.groupBox1.Controls.Add(this.rdInHouse);
            this.groupBox1.Location = new System.Drawing.Point(125, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 37);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // AddPartForm
            // 
            this.AccessibleName = "AddPartForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.tbCompanyName);
            this.Controls.Add(this.btCancelAddPart);
            this.Controls.Add(this.btSavePart);
            this.Controls.Add(this.lbMachineID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMachineID);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.tbPriceCost);
            this.Controls.Add(this.tbInventory);
            this.Controls.Add(this.tbPartName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Name = "AddPartForm";
            this.Text = "Add Part";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbPartName;
        private System.Windows.Forms.TextBox tbInventory;
        private System.Windows.Forms.TextBox tbPriceCost;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbMachineID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMachineID;
        private System.Windows.Forms.RadioButton rdInHouse;
        private System.Windows.Forms.RadioButton rdOutsourced;
        private System.Windows.Forms.Button btSavePart;
        private System.Windows.Forms.Button btCancelAddPart;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}