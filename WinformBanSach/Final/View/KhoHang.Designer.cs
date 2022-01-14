
namespace Final
{
    partial class InputItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputItem));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.txt_itemID = new System.Windows.Forms.TextBox();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_itemPrice = new System.Windows.Forms.TextBox();
            this.txt_itemQuantity = new System.Windows.Forms.NumericUpDown();
            this.grid_Item = new System.Windows.Forms.DataGridView();
            this.btn_OutItem = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_itemAuthor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_itemPrinter = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_itemType = new System.Windows.Forms.ComboBox();
            this.btn_DelItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_itemQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã số sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(808, 39);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(94, 38);
            this.btn_addItem.TabIndex = 5;
            this.btn_addItem.Text = "Thêm hàng";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // txt_itemID
            // 
            this.txt_itemID.Location = new System.Drawing.Point(106, 50);
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.Size = new System.Drawing.Size(100, 20);
            this.txt_itemID.TabIndex = 6;
            // 
            // txt_itemName
            // 
            this.txt_itemName.Location = new System.Drawing.Point(297, 49);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(148, 20);
            this.txt_itemName.TabIndex = 7;
            // 
            // txt_itemPrice
            // 
            this.txt_itemPrice.Location = new System.Drawing.Point(106, 90);
            this.txt_itemPrice.Name = "txt_itemPrice";
            this.txt_itemPrice.ShortcutsEnabled = false;
            this.txt_itemPrice.Size = new System.Drawing.Size(100, 20);
            this.txt_itemPrice.TabIndex = 8;
            // 
            // txt_itemQuantity
            // 
            this.txt_itemQuantity.Location = new System.Drawing.Point(297, 90);
            this.txt_itemQuantity.Name = "txt_itemQuantity";
            this.txt_itemQuantity.Size = new System.Drawing.Size(34, 20);
            this.txt_itemQuantity.TabIndex = 10;
            this.txt_itemQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grid_Item
            // 
            this.grid_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Item.Location = new System.Drawing.Point(9, 164);
            this.grid_Item.Name = "grid_Item";
            this.grid_Item.Size = new System.Drawing.Size(941, 322);
            this.grid_Item.TabIndex = 11;
            this.grid_Item.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Item_CellDoubleClick);
            // 
            // btn_OutItem
            // 
            this.btn_OutItem.Location = new System.Drawing.Point(808, 105);
            this.btn_OutItem.Name = "btn_OutItem";
            this.btn_OutItem.Size = new System.Drawing.Size(94, 38);
            this.btn_OutItem.TabIndex = 13;
            this.btn_OutItem.Text = "Xuất hàng";
            this.btn_OutItem.UseVisualStyleBackColor = true;
            this.btn_OutItem.Click += new System.EventHandler(this.btn_OutItem_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(676, 105);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(94, 38);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "Thay đổi thông tin";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(517, 120);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(94, 38);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nơi nhận";
            // 
            // txt_Location
            // 
            this.txt_Location.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Location.Location = new System.Drawing.Point(298, 130);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(110, 20);
            this.txt_Location.TabIndex = 18;
            this.txt_Location.Text = "Xuất hàng hãy nhập";
            this.txt_Location.Enter += new System.EventHandler(this.OutItem_Enter);
            this.txt_Location.Leave += new System.EventHandler(this.OutItem_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tác giả";
            // 
            // txt_itemAuthor
            // 
            this.txt_itemAuthor.Location = new System.Drawing.Point(511, 49);
            this.txt_itemAuthor.Name = "txt_itemAuthor";
            this.txt_itemAuthor.Size = new System.Drawing.Size(100, 20);
            this.txt_itemAuthor.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nhà xuất bản";
            // 
            // txt_itemPrinter
            // 
            this.txt_itemPrinter.Location = new System.Drawing.Point(511, 86);
            this.txt_itemPrinter.Name = "txt_itemPrinter";
            this.txt_itemPrinter.Size = new System.Drawing.Size(122, 20);
            this.txt_itemPrinter.TabIndex = 22;
            // 
            // btn_Back
            // 
            this.btn_Back.Image = global::Final.Properties.Resources.back_arrow_1_;
            this.btn_Back.Location = new System.Drawing.Point(9, 9);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(30, 23);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Thể loại";
            // 
            // txt_itemType
            // 
            this.txt_itemType.FormattingEnabled = true;
            this.txt_itemType.Items.AddRange(new object[] {
            "Tình cảm",
            "Thiếu nhi",
            "Hài hước",
            "Hành động ",
            "Khoa học công nghệ",
            "Văn học",
            "Truyện ",
            "Tâm lý",
            "Chính trị"});
            this.txt_itemType.Location = new System.Drawing.Point(106, 125);
            this.txt_itemType.Name = "txt_itemType";
            this.txt_itemType.Size = new System.Drawing.Size(121, 21);
            this.txt_itemType.TabIndex = 24;
            // 
            // btn_DelItem
            // 
            this.btn_DelItem.Location = new System.Drawing.Point(676, 39);
            this.btn_DelItem.Name = "btn_DelItem";
            this.btn_DelItem.Size = new System.Drawing.Size(94, 38);
            this.btn_DelItem.TabIndex = 25;
            this.btn_DelItem.Text = "Xóa hàng";
            this.btn_DelItem.UseVisualStyleBackColor = true;
            this.btn_DelItem.Click += new System.EventHandler(this.btn_DelItem_Click);
            // 
            // InputItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 498);
            this.Controls.Add(this.btn_DelItem);
            this.Controls.Add(this.txt_itemType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_itemPrinter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_itemAuthor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_OutItem);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.grid_Item);
            this.Controls.Add(this.txt_itemQuantity);
            this.Controls.Add(this.txt_itemPrice);
            this.Controls.Add(this.txt_itemName);
            this.Controls.Add(this.txt_itemID);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputItem";
            this.Text = "Kho hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InputItem_FormClosed);
            this.Load += new System.EventHandler(this.InputItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_itemQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.TextBox txt_itemID;
        private System.Windows.Forms.TextBox txt_itemName;
        private System.Windows.Forms.TextBox txt_itemPrice;
        private System.Windows.Forms.NumericUpDown txt_itemQuantity;
        private System.Windows.Forms.DataGridView grid_Item;
        private System.Windows.Forms.Button btn_OutItem;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_itemAuthor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_itemPrinter;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txt_itemType;
        private System.Windows.Forms.Button btn_DelItem;
    }
}