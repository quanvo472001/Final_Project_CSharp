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
    public partial class HistoryItem : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = QuanVo; Initial Catalog = WinformBanSach; Persist Security Info=True;User ID = quanvo; Password=Quanvo472001");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public HistoryItem()
        {
            InitializeComponent();
            LoadData();
        }

        private void HistoryItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'outItem.Donhang' table. You can move, or remove it, as needed.
            
        }
        private void LoadData()
        {
            
            cmd = new SqlCommand("select * from DonHang", connect);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                grid_OutItem.DataSource = dt;

            }
            else
            {
                MessageBox.Show("No Data");
            }

            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            connect.Open();
            string updateItem = "update DonHang set order_status = N'"+txt_Status.Text+"' where order_day = '"+date_OutItem.Value+"' and order_id = '"+txt_OutID.Text+"'";
            cmd = new SqlCommand(updateItem, connect);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            LoadData(); 
            connect.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            connect.Open();
            string searchItem = "select * from DonHang where order_id='"+txt_OutID.Text+"' or order_status = N'"+txt_Status.Text+"' or order_day = '"+date_OutItem.Text+"'"; 
            cmd = new SqlCommand(searchItem, connect);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            grid_OutItem.DataSource = dt;
            connect.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Work work = new Work();
            work.Show();
        }

        private void grid_OutItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_OutID.Text = this.grid_OutItem.CurrentRow.Cells[0].Value.ToString();
            txt_NameItem.Text = this.grid_OutItem.CurrentRow.Cells[1].Value.ToString();
            date_OutItem.Value = (DateTime)this.grid_OutItem.CurrentRow.Cells[7].Value;
            txt_Status.Text = this.grid_OutItem.CurrentRow.Cells[9].Value.ToString();
            txt_Location.Text = this.grid_OutItem.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.grid_OutItem.Width, this.grid_OutItem.Height);
            grid_OutItem.DrawToBitmap(bitmap, new Rectangle(0, 0, this.grid_OutItem.Width, this.grid_OutItem.Height));

            e.Graphics.DrawImage(bitmap,-30,100, this.grid_OutItem.Width, this.grid_OutItem.Height);
            e.Graphics.DrawString("Hóa đơn hàng hóa", new Font("Time New Roman", 22, FontStyle.Bold),Brushes.Black,new Point(300,30));
        }

        private void HistoryItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }
    }
}
