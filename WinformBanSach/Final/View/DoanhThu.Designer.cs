
namespace Final
{
    partial class Revenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Revenue));
            this.grid_Reven = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_In = new System.Windows.Forms.Button();
            this.date_Item = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Status = new System.Windows.Forms.ComboBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Out = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Reven)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Reven
            // 
            this.grid_Reven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Reven.Location = new System.Drawing.Point(12, 100);
            this.grid_Reven.Name = "grid_Reven";
            this.grid_Reven.Size = new System.Drawing.Size(960, 341);
            this.grid_Reven.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian cần thống kê";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(520, 41);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(107, 35);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_In
            // 
            this.btn_In.Location = new System.Drawing.Point(662, 41);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(107, 35);
            this.btn_In.TabIndex = 4;
            this.btn_In.Text = "Số hàng đã nhập ";
            this.btn_In.UseVisualStyleBackColor = true;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // date_Item
            // 
            this.date_Item.CustomFormat = "yyyy-MM-dd";
            this.date_Item.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Item.Location = new System.Drawing.Point(135, 47);
            this.date_Item.Name = "date_Item";
            this.date_Item.Size = new System.Drawing.Size(92, 20);
            this.date_Item.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tình trạng hàng";
            // 
            // txt_Status
            // 
            this.txt_Status.FormattingEnabled = true;
            this.txt_Status.Items.AddRange(new object[] {
            "Nhập hàng",
            "Xuất hàng"});
            this.txt_Status.Location = new System.Drawing.Point(336, 47);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(91, 21);
            this.txt_Status.TabIndex = 7;
            // 
            // btn_Back
            // 
            this.btn_Back.Image = global::Final.Properties.Resources.back_arrow_1_;
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(35, 24);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Out
            // 
            this.btn_Out.Location = new System.Drawing.Point(808, 41);
            this.btn_Out.Name = "btn_Out";
            this.btn_Out.Size = new System.Drawing.Size(107, 35);
            this.btn_Out.TabIndex = 9;
            this.btn_Out.Text = "Số hàng đã xuất";
            this.btn_Out.UseVisualStyleBackColor = true;
            this.btn_Out.Click += new System.EventHandler(this.btn_Out_Click);
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 449);
            this.Controls.Add(this.btn_Out);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_Item);
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_Reven);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Revenue";
            this.Text = "Doanh thu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Revenue_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Reven)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Reven;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_In;
        private System.Windows.Forms.DateTimePicker date_Item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txt_Status;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Out;
    }
}