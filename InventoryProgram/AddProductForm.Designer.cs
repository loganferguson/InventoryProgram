namespace InventoryProgram
{
    partial class AddProductForm
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
            this.dgvCandidateParts = new System.Windows.Forms.DataGridView();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.lbCandidateParts = new System.Windows.Forms.Label();
            this.lbAssociatedParts = new System.Windows.Forms.Label();
            this.tbCandidateSearch = new System.Windows.Forms.TextBox();
            this.SearchAssociatedButton = new System.Windows.Forms.Button();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbProductInventory = new System.Windows.Forms.TextBox();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.tbProductMin = new System.Windows.Forms.TextBox();
            this.tbProductMax = new System.Windows.Forms.TextBox();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteAssociatedButton = new System.Windows.Forms.Button();
            this.CancelAddProduct = new System.Windows.Forms.Button();
            this.AddCandidateButton = new System.Windows.Forms.Button();
            this.lbAddProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCandidateParts
            // 
            this.dgvCandidateParts.AllowUserToAddRows = false;
            this.dgvCandidateParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidateParts.Location = new System.Drawing.Point(360, 127);
            this.dgvCandidateParts.Name = "dgvCandidateParts";
            this.dgvCandidateParts.ReadOnly = true;
            this.dgvCandidateParts.RowHeadersVisible = false;
            this.dgvCandidateParts.RowHeadersWidth = 51;
            this.dgvCandidateParts.RowTemplate.Height = 24;
            this.dgvCandidateParts.Size = new System.Drawing.Size(653, 164);
            this.dgvCandidateParts.TabIndex = 0;
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.AllowUserToAddRows = false;
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(360, 395);
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.ReadOnly = true;
            this.dgvAssociatedParts.RowHeadersVisible = false;
            this.dgvAssociatedParts.RowHeadersWidth = 51;
            this.dgvAssociatedParts.RowTemplate.Height = 24;
            this.dgvAssociatedParts.Size = new System.Drawing.Size(653, 161);
            this.dgvAssociatedParts.TabIndex = 1;
            // 
            // lbCandidateParts
            // 
            this.lbCandidateParts.AutoSize = true;
            this.lbCandidateParts.Location = new System.Drawing.Point(373, 93);
            this.lbCandidateParts.Name = "lbCandidateParts";
            this.lbCandidateParts.Size = new System.Drawing.Size(109, 17);
            this.lbCandidateParts.TabIndex = 2;
            this.lbCandidateParts.Text = "Candidate Parts";
            // 
            // lbAssociatedParts
            // 
            this.lbAssociatedParts.AutoSize = true;
            this.lbAssociatedParts.Location = new System.Drawing.Point(373, 364);
            this.lbAssociatedParts.Name = "lbAssociatedParts";
            this.lbAssociatedParts.Size = new System.Drawing.Size(114, 17);
            this.lbAssociatedParts.TabIndex = 3;
            this.lbAssociatedParts.Text = "Associated Parts";
            // 
            // tbCandidateSearch
            // 
            this.tbCandidateSearch.Location = new System.Drawing.Point(636, 87);
            this.tbCandidateSearch.Name = "tbCandidateSearch";
            this.tbCandidateSearch.Size = new System.Drawing.Size(247, 22);
            this.tbCandidateSearch.TabIndex = 4;
            // 
            // SearchAssociatedButton
            // 
            this.SearchAssociatedButton.Location = new System.Drawing.Point(903, 87);
            this.SearchAssociatedButton.Name = "SearchAssociatedButton";
            this.SearchAssociatedButton.Size = new System.Drawing.Size(75, 23);
            this.SearchAssociatedButton.TabIndex = 5;
            this.SearchAssociatedButton.Text = "Search";
            this.SearchAssociatedButton.UseVisualStyleBackColor = true;
            this.SearchAssociatedButton.Click += new System.EventHandler(this.SearchAssociatedButton_Click);
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(129, 224);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(157, 22);
            this.tbProductName.TabIndex = 6;
            // 
            // tbProductInventory
            // 
            this.tbProductInventory.Location = new System.Drawing.Point(129, 271);
            this.tbProductInventory.Name = "tbProductInventory";
            this.tbProductInventory.Size = new System.Drawing.Size(157, 22);
            this.tbProductInventory.TabIndex = 7;
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Location = new System.Drawing.Point(129, 318);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(157, 22);
            this.tbProductPrice.TabIndex = 8;
            // 
            // tbProductMin
            // 
            this.tbProductMin.Location = new System.Drawing.Point(68, 361);
            this.tbProductMin.Name = "tbProductMin";
            this.tbProductMin.Size = new System.Drawing.Size(100, 22);
            this.tbProductMin.TabIndex = 9;
            // 
            // tbProductMax
            // 
            this.tbProductMax.Location = new System.Drawing.Point(240, 361);
            this.tbProductMax.Name = "tbProductMax";
            this.tbProductMax.Size = new System.Drawing.Size(100, 22);
            this.tbProductMax.TabIndex = 10;
            // 
            // tbProductID
            // 
            this.tbProductID.Location = new System.Drawing.Point(129, 177);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Size = new System.Drawing.Size(157, 22);
            this.tbProductID.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Iventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Max";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DeleteAssociatedButton
            // 
            this.DeleteAssociatedButton.Location = new System.Drawing.Point(864, 574);
            this.DeleteAssociatedButton.Name = "DeleteAssociatedButton";
            this.DeleteAssociatedButton.Size = new System.Drawing.Size(87, 40);
            this.DeleteAssociatedButton.TabIndex = 19;
            this.DeleteAssociatedButton.Text = "Delete";
            this.DeleteAssociatedButton.UseVisualStyleBackColor = true;
            // 
            // CancelAddProduct
            // 
            this.CancelAddProduct.Location = new System.Drawing.Point(216, 463);
            this.CancelAddProduct.Name = "CancelAddProduct";
            this.CancelAddProduct.Size = new System.Drawing.Size(81, 33);
            this.CancelAddProduct.TabIndex = 20;
            this.CancelAddProduct.Text = "Cancel";
            this.CancelAddProduct.UseVisualStyleBackColor = true;
            this.CancelAddProduct.Click += new System.EventHandler(this.CancelAddProduct_Click);
            // 
            // AddCandidateButton
            // 
            this.AddCandidateButton.Location = new System.Drawing.Point(864, 311);
            this.AddCandidateButton.Name = "AddCandidateButton";
            this.AddCandidateButton.Size = new System.Drawing.Size(87, 37);
            this.AddCandidateButton.TabIndex = 21;
            this.AddCandidateButton.Text = "Add";
            this.AddCandidateButton.UseVisualStyleBackColor = true;
            // 
            // lbAddProduct
            // 
            this.lbAddProduct.AutoSize = true;
            this.lbAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddProduct.Location = new System.Drawing.Point(32, 27);
            this.lbAddProduct.Name = "lbAddProduct";
            this.lbAddProduct.Size = new System.Drawing.Size(120, 25);
            this.lbAddProduct.TabIndex = 22;
            this.lbAddProduct.Text = "Add Product";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 679);
            this.Controls.Add(this.lbAddProduct);
            this.Controls.Add(this.AddCandidateButton);
            this.Controls.Add(this.CancelAddProduct);
            this.Controls.Add(this.DeleteAssociatedButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProductID);
            this.Controls.Add(this.tbProductMax);
            this.Controls.Add(this.tbProductMin);
            this.Controls.Add(this.tbProductPrice);
            this.Controls.Add(this.tbProductInventory);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.SearchAssociatedButton);
            this.Controls.Add(this.tbCandidateSearch);
            this.Controls.Add(this.lbAssociatedParts);
            this.Controls.Add(this.lbCandidateParts);
            this.Controls.Add(this.dgvAssociatedParts);
            this.Controls.Add(this.dgvCandidateParts);
            this.Name = "AddProductForm";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
        private System.Windows.Forms.Label lbCandidateParts;
        private System.Windows.Forms.Label lbAssociatedParts;
        private System.Windows.Forms.TextBox tbCandidateSearch;
        private System.Windows.Forms.Button SearchAssociatedButton;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbProductInventory;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.TextBox tbProductMin;
        private System.Windows.Forms.TextBox tbProductMax;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteAssociatedButton;
        private System.Windows.Forms.Button CancelAddProduct;
        private System.Windows.Forms.Button AddCandidateButton;
        private System.Windows.Forms.Label lbAddProduct;
        public System.Windows.Forms.DataGridView dgvCandidateParts;
    }
}