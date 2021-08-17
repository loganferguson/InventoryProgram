namespace InventoryProgram
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(486, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(705, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID,
            this.PartName,
            this.Inventory,
            this.Price,
            this.Min,
            this.Max});
            this.dataGridView1.Location = new System.Drawing.Point(33, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(751, 161);
            this.dataGridView1.TabIndex = 2;
            // 
            // PartID
            // 
            this.PartID.HeaderText = "PartID";
            this.PartID.MinimumWidth = 6;
            this.PartID.Name = "PartID";
            this.PartID.Width = 125;
            // 
            // PartName
            // 
            this.PartName.HeaderText = "PartName";
            this.PartName.MinimumWidth = 6;
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            this.PartName.Width = 125;
            // 
            // Inventory
            // 
            this.Inventory.HeaderText = "Inventory";
            this.Inventory.MinimumWidth = 6;
            this.Inventory.Name = "Inventory";
            this.Inventory.ReadOnly = true;
            this.Inventory.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Min
            // 
            this.Min.HeaderText = "Min";
            this.Min.MinimumWidth = 6;
            this.Min.Name = "Min";
            this.Min.ReadOnly = true;
            this.Min.Width = 125;
            // 
            // Max
            // 
            this.Max.HeaderText = "Max";
            this.Max.MinimumWidth = 6;
            this.Max.Name = "Max";
            this.Max.ReadOnly = true;
            this.Max.Width = 125;
            // 
            // AddPartButton
            // 
            this.AddPartButton.Location = new System.Drawing.Point(813, 80);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(90, 42);
            this.AddPartButton.TabIndex = 3;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parts";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(813, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Modify";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(813, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.ProductInventory,
            this.ProductPrice,
            this.ProductMin,
            this.ProductMax});
            this.dataGridView2.Location = new System.Drawing.Point(33, 324);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(751, 161);
            this.dataGridView2.TabIndex = 7;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 125;
            // 
            // ProductInventory
            // 
            this.ProductInventory.HeaderText = "Iventory";
            this.ProductInventory.MinimumWidth = 6;
            this.ProductInventory.Name = "ProductInventory";
            this.ProductInventory.ReadOnly = true;
            this.ProductInventory.Width = 125;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            this.ProductPrice.Width = 125;
            // 
            // ProductMin
            // 
            this.ProductMin.HeaderText = "Min";
            this.ProductMin.MinimumWidth = 6;
            this.ProductMin.Name = "ProductMin";
            this.ProductMin.ReadOnly = true;
            this.ProductMin.Width = 125;
            // 
            // ProductMax
            // 
            this.ProductMax.HeaderText = "Max";
            this.ProductMax.MinimumWidth = 6;
            this.ProductMax.Name = "ProductMax";
            this.ProductMax.ReadOnly = true;
            this.ProductMax.Width = 125;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(36, 279);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(157, 33);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Products";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(813, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(813, 383);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 45);
            this.button5.TabIndex = 10;
            this.button5.Text = "Modify";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(813, 445);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 40);
            this.button6.TabIndex = 11;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 559);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPartButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductMax;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

