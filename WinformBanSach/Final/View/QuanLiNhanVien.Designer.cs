
namespace Final
{
    partial class Staff_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Manager));
            this.grid_Staff = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_StaffName = new System.Windows.Forms.TextBox();
            this.txt_StaffPosistion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_StaffAge = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_StaffPhone = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StaffAge)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Staff
            // 
            this.grid_Staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Staff.Location = new System.Drawing.Point(269, 12);
            this.grid_Staff.Name = "grid_Staff";
            this.grid_Staff.Size = new System.Drawing.Size(458, 292);
            this.grid_Staff.TabIndex = 0;
            this.grid_Staff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Staff_CellDoubleClick);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(15, 233);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(68, 35);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(94, 233);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(68, 35);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(168, 233);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(68, 35);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Xóa nhân viên";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chức vụ";
            // 
            // txt_StaffName
            // 
            this.txt_StaffName.Location = new System.Drawing.Point(94, 60);
            this.txt_StaffName.Name = "txt_StaffName";
            this.txt_StaffName.Size = new System.Drawing.Size(100, 20);
            this.txt_StaffName.TabIndex = 6;
            // 
            // txt_StaffPosistion
            // 
            this.txt_StaffPosistion.FormattingEnabled = true;
            this.txt_StaffPosistion.Items.AddRange(new object[] {
            "Chủ ",
            "Kế toán",
            "Nhân viên"});
            this.txt_StaffPosistion.Location = new System.Drawing.Point(94, 185);
            this.txt_StaffPosistion.Name = "txt_StaffPosistion";
            this.txt_StaffPosistion.Size = new System.Drawing.Size(100, 21);
            this.txt_StaffPosistion.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tuổi";
            // 
            // txt_StaffAge
            // 
            this.txt_StaffAge.Location = new System.Drawing.Point(94, 100);
            this.txt_StaffAge.Name = "txt_StaffAge";
            this.txt_StaffAge.Size = new System.Drawing.Size(36, 20);
            this.txt_StaffAge.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số điện thoại";
            // 
            // txt_StaffPhone
            // 
            this.txt_StaffPhone.Location = new System.Drawing.Point(93, 142);
            this.txt_StaffPhone.Name = "txt_StaffPhone";
            this.txt_StaffPhone.Size = new System.Drawing.Size(100, 20);
            this.txt_StaffPhone.TabIndex = 11;
            // 
            // btn_Back
            // 
            this.btn_Back.Image = global::Final.Properties.Resources.back_arrow_1_;
            this.btn_Back.Location = new System.Drawing.Point(8, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(33, 24);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Staff_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 316);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.txt_StaffPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_StaffAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_StaffPosistion);
            this.Controls.Add(this.txt_StaffName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.grid_Staff);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Staff_Manager";
            this.Text = "Quản lý nhân viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Staff_Manager_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StaffAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Staff;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_StaffName;
        private System.Windows.Forms.ComboBox txt_StaffPosistion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txt_StaffAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_StaffPhone;
        private System.Windows.Forms.Button btn_Back;
    }
}