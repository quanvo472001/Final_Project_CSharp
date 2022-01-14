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
    public partial class Revenue : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = QuanVo; Initial Catalog = WinformBanSach; Persist Security Info=True;User ID = quanvo; Password=Quanvo472001");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public Revenue()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            connect.Open();
            string load = "Select * from HangHoa";
            cmd = new SqlCommand(load, connect);
            adapter = new SqlDataAdapter(cmd);

            dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                grid_Reven.DataSource = dt;

            }
            else
            {
                MessageBox.Show("No Data");
            }

            connect.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Work work = new Work();
            work.Show();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            connect.Open();
            string searchItem = "select * from HangHoa where item_day='"+date_Item.Text+"' or item_status = N'"+txt_Status.Text+"'";
            cmd = new SqlCommand(searchItem, connect);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            grid_Reven.DataSource = dt;
            connect.Close();
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            connect.Open();
            string searchItem = "select MONTH(item_day) as 'Tháng', SUM(item_quantity) as 'Tổng số hàng đã nhập', SUM(item_total) as 'Số tiền đã trả'  from HangHoa where item_status = N'Nhập hàng' group by MONTH(item_day) ";
            cmd = new SqlCommand(searchItem, connect);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            grid_Reven.DataSource = dt;
            connect.Close();
        }

        private void btn_Out_Click(object sender, EventArgs e)
        {
            connect.Open();
            string searchItem = "select MONTH(item_day) as 'Tháng', SUM(item_quantity) as 'Tổng số hàng đã chuyển đi', SUM(item_total) as 'Số tiền đã nhận'  from HangHoa where item_status = N'Xuất hàng' group by MONTH(item_day) ";
            cmd = new SqlCommand(searchItem, connect);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            grid_Reven.DataSource = dt;
            connect.Close();
        }

        private void Revenue_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
