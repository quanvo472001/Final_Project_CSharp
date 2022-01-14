
namespace Final
{
    partial class HistoryItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryItem));
            this.grid_OutItem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_OutID = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.date_OutItem = new System.Windows.Forms.DateTimePicker();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NameItem = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Location = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_OutItem)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_OutItem
            // 
            this.grid_OutItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_OutItem.Location = new System.Drawing.Point(12, 125);
            this.grid_OutItem.Name = "grid_OutItem";
            this.grid_OutItem.Size = new System.Drawing.Size(1033, 313);
            this.grid_OutItem.TabIndex = 0;
            this.grid_OutItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_OutItem_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Đơn hàng";
            // 
            // txt_OutID
            // 
            this.txt_OutID.Location = new System.Drawing.Point(86, 37);
            this.txt_OutID.Name = "txt_OutID";
            this.txt_OutID.Size = new System.Drawing.Size(100, 20);
            this.txt_OutID.TabIndex = 2;
            // 
            // txt_Status
            // 
            this.txt_Status.FormattingEnabled = true;
            this.txt_Status.Items.AddRange(new object[] {
            "Đã nhận",
            "Đang vận chuyển"});
            this.txt_Status.Location = new System.Drawing.Point(122, 82);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(121, 21);
            this.txt_Status.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tình trạng đơn hàng";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(347, 76);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 34);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(428, 76);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 34);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Cập nhật tình trạng";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày xuất";
            // 
            // date_OutItem
            // 
            this.date_OutItem.CustomFormat = "yyyy-MM-dd";
            this.date_OutItem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_OutItem.Location = new System.Drawing.Point(504, 37);
            this.date_OutItem.Name = "date_OutItem";
            this.date_OutItem.Size = new System.Drawing.Size(100, 20);
            this.date_OutItem.TabIndex = 8;
            // 
            // btn_Back
            // 
            this.btn_Back.Image = global::Final.Properties.Resources.back_arrow_1_;
            this.btn_Back.Location = new System.Drawing.Point(12, 7);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(34, 22);
            this.btn_Back.TabIndex = 9;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(509, 76);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 34);
            this.btn_Print.TabIndex = 10;
            this.btn_Print.Text = "In hóa đơn";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên mặt hàng";
            // 
            // txt_NameItem
            // 
            this.txt_NameItem.Location = new System.Drawing.Point(301, 37);
            this.txt_NameItem.Name = "txt_NameItem";
            this.txt_NameItem.Size = new System.Drawing.Size(121, 20);
            this.txt_NameItem.TabIndex = 12;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nơi đến";
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(687, 37);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(100, 20);
            this.txt_Location.TabIndex = 14;
            // 
            // HistoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 450);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_NameItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.date_OutItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.txt_OutID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_OutItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoryItem";
            this.Text = "Đơn hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HistoryItem_FormClosed);
            this.Load += new System.EventHandler(this.HistoryItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_OutItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_OutItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_OutID;
        private System.Windows.Forms.ComboBox txt_Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_OutItem;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NameItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Location;
    }
}