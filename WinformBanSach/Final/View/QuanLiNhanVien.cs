using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Staff_Manager : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = QuanVo; Initial Catalog = WinformBanSach; Persist Security Info=True;User ID = quanvo; Password=Quanvo472001");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public Staff_Manager()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            connect.Open();
            cmd = new SqlCommand("select name_user as 'Tên nhân viên',age as 'Tuổi',position as 'Chức vụ',phone as 'Số điện thoại'  from Users order by position", connect);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                grid_Staff.DataSource = dt;

            }
            else
            {
                MessageBox.Show("No Data");
            }

            connect.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            connect.Open();
            string searchStaff = "select name_user as 'Tên nhân viên',age as 'Tuổi',position as 'Chức vụ',phone as 'Số điện thoại' from Users where name_user like '%" + txt_StaffName.Text + "%'"; 
            cmd = new SqlCommand(searchStaff, connect);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            grid_Staff.DataSource = dt;
            connect.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            connect.Open();
            string updateStaff = "update Users set age = "+txt_StaffAge.Value+" ,position = N'"+txt_StaffPosistion.Text+"',phone ='"+txt_StaffPhone.Text+"' where name_user = N'"+txt_StaffName.Text+"'";
            cmd = new SqlCommand(updateStaff, connect);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            connect.Close();
            LoadData();
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            connect.Open();
            string deleteStaff = "Delete from Users where name_user=N'"+txt_StaffName.Text+"'";
            DialogResult result = MessageBox.Show("Bạn có muốn xóa người dùng "+txt_StaffName.Text+" ?", "Connection String", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }else
            {
                cmd = new SqlCommand(deleteStaff, connect);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Bạn đã xóa người dùng thành công");
                    connect.Close();
                }
            }
            LoadData();           
            
        }

        private void grid_Staff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_StaffName.Text = this.grid_Staff.CurrentRow.Cells[0].Value.ToString();
            txt_StaffAge.Text = this.grid_Staff.CurrentRow.Cells[1].Value.ToString();
            txt_StaffPosistion.Text = this.grid_Staff.CurrentRow.Cells[2].Value.ToString();
            txt_StaffPhone.Text = this.grid_Staff.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Work work = new Work();
            work.Show();
        }

        private void Staff_Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }
    }
}
