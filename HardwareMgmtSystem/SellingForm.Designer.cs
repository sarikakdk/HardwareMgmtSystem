namespace HardwareMgmtSystem
{
    partial class SellingForm
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
            this.date = new System.Windows.Forms.Label();
            this.customer_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.product_price = new System.Windows.Forms.TextBox();
            this.DGVsales = new System.Windows.Forms.DataGridView();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalAmt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.discper = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.discountGiven = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.net_total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.product_qty = new System.Windows.Forms.NumericUpDown();
            this.clear = new System.Windows.Forms.Button();
            this.bill = new System.Windows.Forms.Button();
            this.bill_date = new System.Windows.Forms.MaskedTextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.billno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVsales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_qty)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(589, 9);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(48, 20);
            this.date.TabIndex = 22;
            this.date.Text = "Date";
            // 
            // customer_name
            // 
            this.customer_name.Location = new System.Drawing.Point(151, 65);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(153, 20);
            this.customer_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Customer Name";
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(166, 121);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(275, 21);
            this.cmbProducts.TabIndex = 3;
            this.cmbProducts.Text = "Product Name";
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // product_price
            // 
            this.product_price.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.product_price.Location = new System.Drawing.Point(447, 121);
            this.product_price.Name = "product_price";
            this.product_price.ReadOnly = true;
            this.product_price.Size = new System.Drawing.Size(98, 20);
            this.product_price.TabIndex = 36;
            this.product_price.Text = "product price";
            this.product_price.TextChanged += new System.EventHandler(this.product_price_TextChanged);
            // 
            // DGVsales
            // 
            this.DGVsales.AllowUserToAddRows = false;
            this.DGVsales.AllowUserToDeleteRows = false;
            this.DGVsales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVsales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sn,
            this.product_name,
            this.price,
            this.qty,
            this.total,
            this.bill_id,
            this.product_id});
            this.DGVsales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVsales.Location = new System.Drawing.Point(12, 147);
            this.DGVsales.Name = "DGVsales";
            this.DGVsales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVsales.Size = new System.Drawing.Size(745, 150);
            this.DGVsales.TabIndex = 37;
            // 
            // sn
            // 
            this.sn.FillWeight = 74.23859F;
            this.sn.HeaderText = "SN";
            this.sn.Name = "sn";
            // 
            // product_name
            // 
            this.product_name.FillWeight = 203.0457F;
            this.product_name.HeaderText = "Product Name";
            this.product_name.Name = "product_name";
            // 
            // price
            // 
            this.price.FillWeight = 74.23859F;
            this.price.HeaderText = "price";
            this.price.Name = "price";
            // 
            // qty
            // 
            this.qty.FillWeight = 74.23859F;
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            // 
            // total
            // 
            this.total.FillWeight = 74.23859F;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // bill_id
            // 
            this.bill_id.HeaderText = "Bill Id";
            this.bill_id.Name = "bill_id";
            this.bill_id.Visible = false;
            // 
            // product_id
            // 
            this.product_id.HeaderText = "Product Id";
            this.product_id.Name = "product_id";
            this.product_id.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(719, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 38);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Bill Number";
            // 
            // totalAmt
            // 
            this.totalAmt.Location = new System.Drawing.Point(604, 306);
            this.totalAmt.Name = "totalAmt";
            this.totalAmt.ReadOnly = true;
            this.totalAmt.Size = new System.Drawing.Size(153, 20);
            this.totalAmt.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "GrandTotal RS";
            // 
            // discper
            // 
            this.discper.Location = new System.Drawing.Point(604, 339);
            this.discper.Name = "discper";
            this.discper.Size = new System.Drawing.Size(153, 20);
            this.discper.TabIndex = 5;
            this.discper.Text = "0";
            this.discper.TextChanged += new System.EventHandler(this.discper_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Discount % ";
            // 
            // discountGiven
            // 
            this.discountGiven.Location = new System.Drawing.Point(604, 369);
            this.discountGiven.Name = "discountGiven";
            this.discountGiven.ReadOnly = true;
            this.discountGiven.Size = new System.Drawing.Size(153, 20);
            this.discountGiven.TabIndex = 47;
            this.discountGiven.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(461, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Discount Given ";
            // 
            // net_total
            // 
            this.net_total.Location = new System.Drawing.Point(607, 439);
            this.net_total.Name = "net_total";
            this.net_total.Size = new System.Drawing.Size(153, 20);
            this.net_total.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(464, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Net Total ";
            // 
            // product_qty
            // 
            this.product_qty.Location = new System.Drawing.Point(565, 121);
            this.product_qty.Name = "product_qty";
            this.product_qty.Size = new System.Drawing.Size(84, 20);
            this.product_qty.TabIndex = 3;
            this.product_qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(24, 411);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(97, 38);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // bill
            // 
            this.bill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill.Location = new System.Drawing.Point(207, 411);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(97, 38);
            this.bill.TabIndex = 6;
            this.bill.Text = "Save Bill";
            this.bill.UseVisualStyleBackColor = false;
            this.bill.Click += new System.EventHandler(this.bill_Click);
            // 
            // bill_date
            // 
            this.bill_date.Location = new System.Drawing.Point(657, 9);
            this.bill_date.Mask = "00/00/0000";
            this.bill_date.Name = "bill_date";
            this.bill_date.ReadOnly = true;
            this.bill_date.Size = new System.Drawing.Size(100, 20);
            this.bill_date.TabIndex = 49;
            this.bill_date.ValidatingType = typeof(System.DateTime);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(12, 120);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(148, 21);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.Text = "Choose Category";
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // billno
            // 
            this.billno.Location = new System.Drawing.Point(151, 32);
            this.billno.Name = "billno";
            this.billno.ReadOnly = true;
            this.billno.Size = new System.Drawing.Size(153, 20);
            this.billno.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(458, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "-------------------------------------------------";
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.billno);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.bill_date);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.product_qty);
            this.Controls.Add(this.discountGiven);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.net_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalAmt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.discper);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DGVsales);
            this.Controls.Add(this.product_price);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.customer_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVsales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.TextBox product_price;
        private System.Windows.Forms.DataGridView DGVsales;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalAmt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox discper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox discountGiven;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox net_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown product_qty;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button bill;
        private System.Windows.Forms.MaskedTextBox bill_date;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox billno;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
    }
}