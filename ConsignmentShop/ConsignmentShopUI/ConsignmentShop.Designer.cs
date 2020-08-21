namespace ConsignmentShopUI
{
    partial class ConsignmentShop
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
            this.HeaderText = new System.Windows.Forms.Label();
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.ItemListBoxLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.shoppingCardListBoxLabal = new System.Windows.Forms.Label();
            this.shoppingCardListBox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListboxLebal = new System.Windows.Forms.Label();
            this.vendorListBox = new System.Windows.Forms.ListBox();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderText.Location = new System.Drawing.Point(12, 43);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(499, 46);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "Consignment Shop Demo";
            // 
            // ItemListBox
            // 
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 25;
            this.ItemListBox.Location = new System.Drawing.Point(20, 154);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(370, 229);
            this.ItemListBox.TabIndex = 1;
            // 
            // ItemListBoxLabel
            // 
            this.ItemListBoxLabel.AutoSize = true;
            this.ItemListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemListBoxLabel.Location = new System.Drawing.Point(15, 126);
            this.ItemListBoxLabel.Name = "ItemListBoxLabel";
            this.ItemListBoxLabel.Size = new System.Drawing.Size(122, 25);
            this.ItemListBoxLabel.TabIndex = 2;
            this.ItemListBoxLabel.Text = "Store Items";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add to Cart -> ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // shoppingCardListBoxLabal
            // 
            this.shoppingCardListBoxLabal.AutoSize = true;
            this.shoppingCardListBoxLabal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCardListBoxLabal.Location = new System.Drawing.Point(803, 126);
            this.shoppingCardListBoxLabal.Name = "shoppingCardListBoxLabal";
            this.shoppingCardListBoxLabal.Size = new System.Drawing.Size(157, 25);
            this.shoppingCardListBoxLabal.TabIndex = 5;
            this.shoppingCardListBoxLabal.Text = "Shopping Card";
            this.shoppingCardListBoxLabal.Click += new System.EventHandler(this.shoppingCardListBoxLabal_Click);
            // 
            // shoppingCardListBox
            // 
            this.shoppingCardListBox.FormattingEnabled = true;
            this.shoppingCardListBox.ItemHeight = 25;
            this.shoppingCardListBox.Location = new System.Drawing.Point(808, 154);
            this.shoppingCardListBox.Name = "shoppingCardListBox";
            this.shoppingCardListBox.Size = new System.Drawing.Size(370, 229);
            this.shoppingCardListBox.TabIndex = 4;
            this.shoppingCardListBox.SelectedIndexChanged += new System.EventHandler(this.shoppingCardListBox_SelectedIndexChanged);
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(972, 407);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(206, 37);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorListboxLebal
            // 
            this.vendorListboxLebal.AutoSize = true;
            this.vendorListboxLebal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListboxLebal.Location = new System.Drawing.Point(15, 474);
            this.vendorListboxLebal.Name = "vendorListboxLebal";
            this.vendorListboxLebal.Size = new System.Drawing.Size(93, 25);
            this.vendorListboxLebal.TabIndex = 8;
            this.vendorListboxLebal.Text = "Vendors";
            // 
            // vendorListBox
            // 
            this.vendorListBox.FormattingEnabled = true;
            this.vendorListBox.ItemHeight = 25;
            this.vendorListBox.Location = new System.Drawing.Point(20, 502);
            this.vendorListBox.Name = "vendorListBox";
            this.vendorListBox.Size = new System.Drawing.Size(370, 229);
            this.vendorListBox.TabIndex = 7;
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitLabel.Location = new System.Drawing.Point(803, 474);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(127, 25);
            this.storeProfitLabel.TabIndex = 9;
            this.storeProfitLabel.Text = "Store Profit:";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.Location = new System.Drawing.Point(967, 474);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(66, 25);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "$0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 861);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.vendorListboxLebal);
            this.Controls.Add(this.vendorListBox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCardListBoxLabal);
            this.Controls.Add(this.shoppingCardListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ItemListBoxLabel);
            this.Controls.Add(this.ItemListBox);
            this.Controls.Add(this.HeaderText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "ConsignmentShopDemo ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.Label ItemListBoxLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label shoppingCardListBoxLabal;
        private System.Windows.Forms.ListBox shoppingCardListBox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Label vendorListboxLebal;
        private System.Windows.Forms.ListBox vendorListBox;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label storeProfitValue;
    }
}

