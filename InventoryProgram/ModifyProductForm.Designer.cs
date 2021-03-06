namespace InventoryProgram
{
    partial class ModifyProductForm
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
            this.AddCandidateButton = new System.Windows.Forms.Button();
            this.CancelModAddProduct = new System.Windows.Forms.Button();
            this.DeleteAssociatedButton = new System.Windows.Forms.Button();
            this.SaveModProductButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbModProductID = new System.Windows.Forms.TextBox();
            this.tbModProductMax = new System.Windows.Forms.TextBox();
            this.tbModProductMin = new System.Windows.Forms.TextBox();
            this.tbModProductPrice = new System.Windows.Forms.TextBox();
            this.tbModProductInventory = new System.Windows.Forms.TextBox();
            this.tbModProductName = new System.Windows.Forms.TextBox();
            this.SearchAssociatedButton = new System.Windows.Forms.Button();
            this.tbCandidateSearch = new System.Windows.Forms.TextBox();
            this.lbAssociatedParts = new System.Windows.Forms.Label();
            this.lbCandidateParts = new System.Windows.Forms.Label();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.dgvCandidateParts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateParts)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCandidateButton
            // 
            this.AddCandidateButton.Location = new System.Drawing.Point(974, 328);
            this.AddCandidateButton.Name = "AddCandidateButton";
            this.AddCandidateButton.Size = new System.Drawing.Size(87, 37);
            this.AddCandidateButton.TabIndex = 43;
            this.AddCandidateButton.Text = "Add";
            this.AddCandidateButton.UseVisualStyleBackColor = true;
            this.AddCandidateButton.Click += new System.EventHandler(this.AddCandidateButton_Click);
            // 
            // CancelModAddProduct
            // 
            this.CancelModAddProduct.Location = new System.Drawing.Point(221, 460);
            this.CancelModAddProduct.Name = "CancelModAddProduct";
            this.CancelModAddProduct.Size = new System.Drawing.Size(81, 33);
            this.CancelModAddProduct.TabIndex = 42;
            this.CancelModAddProduct.Text = "Cancel";
            this.CancelModAddProduct.UseVisualStyleBackColor = true;
            // 
            // DeleteAssociatedButton
            // 
            this.DeleteAssociatedButton.Location = new System.Drawing.Point(974, 593);
            this.DeleteAssociatedButton.Name = "DeleteAssociatedButton";
            this.DeleteAssociatedButton.Size = new System.Drawing.Size(87, 40);
            this.DeleteAssociatedButton.TabIndex = 41;
            this.DeleteAssociatedButton.Text = "Delete";
            this.DeleteAssociatedButton.UseVisualStyleBackColor = true;
            this.DeleteAssociatedButton.Click += new System.EventHandler(this.DeleteAssociatedButton_Click);
            // 
            // SaveModProductButton
            // 
            this.SaveModProductButton.Location = new System.Drawing.Point(109, 460);
            this.SaveModProductButton.Name = "SaveModProductButton";
            this.SaveModProductButton.Size = new System.Drawing.Size(83, 33);
            this.SaveModProductButton.TabIndex = 40;
            this.SaveModProductButton.Text = "Save";
            this.SaveModProductButton.UseVisualStyleBackColor = true;
            this.SaveModProductButton.Click += new System.EventHandler(this.SaveModProductButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Iventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "ID";
            // 
            // tbModProductID
            // 
            this.tbModProductID.Location = new System.Drawing.Point(134, 174);
            this.tbModProductID.Name = "tbModProductID";
            this.tbModProductID.ReadOnly = true;
            this.tbModProductID.Size = new System.Drawing.Size(157, 22);
            this.tbModProductID.TabIndex = 33;
            // 
            // tbModProductMax
            // 
            this.tbModProductMax.Location = new System.Drawing.Point(245, 358);
            this.tbModProductMax.Name = "tbModProductMax";
            this.tbModProductMax.Size = new System.Drawing.Size(100, 22);
            this.tbModProductMax.TabIndex = 32;
            // 
            // tbModProductMin
            // 
            this.tbModProductMin.Location = new System.Drawing.Point(73, 358);
            this.tbModProductMin.Name = "tbModProductMin";
            this.tbModProductMin.Size = new System.Drawing.Size(100, 22);
            this.tbModProductMin.TabIndex = 31;
            // 
            // tbModProductPrice
            // 
            this.tbModProductPrice.Location = new System.Drawing.Point(134, 315);
            this.tbModProductPrice.Name = "tbModProductPrice";
            this.tbModProductPrice.Size = new System.Drawing.Size(157, 22);
            this.tbModProductPrice.TabIndex = 30;
            // 
            // tbModProductInventory
            // 
            this.tbModProductInventory.Location = new System.Drawing.Point(134, 268);
            this.tbModProductInventory.Name = "tbModProductInventory";
            this.tbModProductInventory.Size = new System.Drawing.Size(157, 22);
            this.tbModProductInventory.TabIndex = 29;
            // 
            // tbModProductName
            // 
            this.tbModProductName.Location = new System.Drawing.Point(134, 221);
            this.tbModProductName.Name = "tbModProductName";
            this.tbModProductName.Size = new System.Drawing.Size(157, 22);
            this.tbModProductName.TabIndex = 28;
            // 
            // SearchAssociatedButton
            // 
            this.SearchAssociatedButton.Location = new System.Drawing.Point(1015, 79);
            this.SearchAssociatedButton.Name = "SearchAssociatedButton";
            this.SearchAssociatedButton.Size = new System.Drawing.Size(75, 27);
            this.SearchAssociatedButton.TabIndex = 27;
            this.SearchAssociatedButton.Text = "Search";
            this.SearchAssociatedButton.UseVisualStyleBackColor = true;
            // 
            // tbCandidateSearch
            // 
            this.tbCandidateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCandidateSearch.Location = new System.Drawing.Point(733, 79);
            this.tbCandidateSearch.Name = "tbCandidateSearch";
            this.tbCandidateSearch.Size = new System.Drawing.Size(267, 27);
            this.tbCandidateSearch.TabIndex = 26;
            // 
            // lbAssociatedParts
            // 
            this.lbAssociatedParts.AutoSize = true;
            this.lbAssociatedParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssociatedParts.Location = new System.Drawing.Point(378, 361);
            this.lbAssociatedParts.Name = "lbAssociatedParts";
            this.lbAssociatedParts.Size = new System.Drawing.Size(137, 20);
            this.lbAssociatedParts.TabIndex = 25;
            this.lbAssociatedParts.Text = "Associated Parts";
            // 
            // lbCandidateParts
            // 
            this.lbCandidateParts.AutoSize = true;
            this.lbCandidateParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCandidateParts.Location = new System.Drawing.Point(378, 90);
            this.lbCandidateParts.Name = "lbCandidateParts";
            this.lbCandidateParts.Size = new System.Drawing.Size(129, 20);
            this.lbCandidateParts.TabIndex = 24;
            this.lbCandidateParts.Text = "Candidate Parts";
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.AllowUserToAddRows = false;
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(365, 392);
            this.dgvAssociatedParts.MultiSelect = false;
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.ReadOnly = true;
            this.dgvAssociatedParts.RowHeadersVisible = false;
            this.dgvAssociatedParts.RowHeadersWidth = 51;
            this.dgvAssociatedParts.RowTemplate.Height = 24;
            this.dgvAssociatedParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssociatedParts.Size = new System.Drawing.Size(725, 185);
            this.dgvAssociatedParts.TabIndex = 23;
            // 
            // dgvCandidateParts
            // 
            this.dgvCandidateParts.AllowUserToAddRows = false;
            this.dgvCandidateParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidateParts.Location = new System.Drawing.Point(365, 124);
            this.dgvCandidateParts.MultiSelect = false;
            this.dgvCandidateParts.Name = "dgvCandidateParts";
            this.dgvCandidateParts.ReadOnly = true;
            this.dgvCandidateParts.RowHeadersVisible = false;
            this.dgvCandidateParts.RowHeadersWidth = 51;
            this.dgvCandidateParts.RowTemplate.Height = 24;
            this.dgvCandidateParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidateParts.Size = new System.Drawing.Size(725, 187);
            this.dgvCandidateParts.TabIndex = 22;
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 694);
            this.Controls.Add(this.AddCandidateButton);
            this.Controls.Add(this.CancelModAddProduct);
            this.Controls.Add(this.DeleteAssociatedButton);
            this.Controls.Add(this.SaveModProductButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbModProductID);
            this.Controls.Add(this.tbModProductMax);
            this.Controls.Add(this.tbModProductMin);
            this.Controls.Add(this.tbModProductPrice);
            this.Controls.Add(this.tbModProductInventory);
            this.Controls.Add(this.tbModProductName);
            this.Controls.Add(this.SearchAssociatedButton);
            this.Controls.Add(this.tbCandidateSearch);
            this.Controls.Add(this.lbAssociatedParts);
            this.Controls.Add(this.lbCandidateParts);
            this.Controls.Add(this.dgvAssociatedParts);
            this.Controls.Add(this.dgvCandidateParts);
            this.Name = "ModifyProductForm";
            this.Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCandidateButton;
        private System.Windows.Forms.Button CancelModAddProduct;
        private System.Windows.Forms.Button DeleteAssociatedButton;
        private System.Windows.Forms.Button SaveModProductButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbModProductID;
        public System.Windows.Forms.TextBox tbModProductMax;
        public System.Windows.Forms.TextBox tbModProductMin;
        public System.Windows.Forms.TextBox tbModProductPrice;
        public System.Windows.Forms.TextBox tbModProductInventory;
        public System.Windows.Forms.TextBox tbModProductName;
        private System.Windows.Forms.Button SearchAssociatedButton;
        private System.Windows.Forms.TextBox tbCandidateSearch;
        private System.Windows.Forms.Label lbAssociatedParts;
        private System.Windows.Forms.Label lbCandidateParts;
        public System.Windows.Forms.DataGridView dgvAssociatedParts;
        public System.Windows.Forms.DataGridView dgvCandidateParts;
    }
}