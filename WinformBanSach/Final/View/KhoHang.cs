using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class InputItem : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=QuanVo;Initial Catalog=WinformBanSach;Persist Security Info=True;User ID=quanvo;Password=Quanvo472001");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public InputItem()
        {
            InitializeComponent();
            LoadData();
        }

        private void InputItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet2.Item' table. You can move, or remove it, as needed.
            
            
        }
        private void LoadData()
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select * from KhoSach", connect);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                
                grid_Item.DataSource = dt;
                
            }
            else
            {
                MessageBox.Show("No Data");
            }

            connect.Close();
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            
            if (txt_itemQuantity.Value==0)
            {
                MessageBox.Show("Can't add this item");
            }
            else
            {
                connect.Open();
                string addItem = "insert into KhoSach values(N'"+txt_itemName.Text+"',N'"+txt_itemAuthor.Text+"',N'"+txt_itemPrinter.Text+"',"+txt_itemPrice.Text+",N'"+txt_itemType.Text+"',"+txt_itemQuantity.Value+",getdate(),N'Trong kho hàng')";
                cmd = new SqlCommand(addItem, connect);
                int row = cmd.ExecuteNonQuery();
                if (row>0)
                {
                    MessageBox.Show("Add Successfully!");
                    connect.Close();
                }
                LoadData();
                
            }
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            connect.Open();
            string updateItem = "update KhoSach set book_name = N'"+txt_itemName.Text+"',book_author = N'"+txt_itemAuthor.Text+"',book_printer =N'"+txt_itemPrinter.Text+"',book_price= "+txt_itemPrice.Text+",book_type = N'"+txt_itemType.Text+"' where book_id = "+txt_itemID.Text+" ";
            cmd = new SqlCommand(updateItem, connect);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            connect.Close();
            LoadData();
            
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Work work = new Work();
            work.Show();
        }

        private void btn_OutItem_Click(object sender, EventArgs e)
        {
            connect.Open();
            string outitem = "insert into DonHang values (N'"+txt_itemName.Text+"',N'"+txt_itemAuthor.Text+"',N'"+txt_itemPrinter.Text+"',"+txt_itemPrice.Text+",N'"+txt_itemType.Text+"',"+txt_itemQuantity.Value+",getdate(),N'"+txt_Location.Text+"',N'Đang vận chuyển')";
            if (txt_Location.Text == "Xuất hàng hãy nhập")
            {
                MessageBox.Show("Hãy nhập nơi nhận hàng");
                
            }
            else
            {
                SqlCommand cmd = new SqlCommand(outitem, connect);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đã xuất hàng thành công");
                    
                }

            }
            connect.Close();
            LoadData();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            connect.Open();
            string searchItem = "select * from KhoSach where book_id like '%"+txt_itemID.Text+"%'";
            cmd = new SqlCommand(searchItem, connect);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            grid_Item.DataSource = dt;
            connect.Close();
        }

        private void OutItem_Enter(object sender, EventArgs e)
        {
            if(txt_Location.Text == "Xuất hàng hãy nhập")
            {
                txt_Location.Text = "";
                txt_Location.ForeColor = Color.Black;
            }
        }

        private void OutItem_Leave(object sender, EventArgs e)
        {
            if (txt_Location.Text == "")
            {
                txt_Location.Text = "Xuất hàng hãy nhập";
                txt_Location.ForeColor = Color.Silver;
            }
        }

        private void grid_Item_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_itemID.Text = this.grid_Item.CurrentRow.Cells[0].Value.ToString();
            txt_itemName.Text = this.grid_Item.CurrentRow.Cells[1].Value.ToString();
            txt_itemAuthor.Text = this.grid_Item.CurrentRow.Cells[2].Value.ToString();
            txt_itemPrinter.Text = this.grid_Item.CurrentRow.Cells[3].Value.ToString();
            txt_itemType.Text = this.grid_Item.CurrentRow.Cells[5].Value.ToString();
            txt_itemPrice.Text = this.grid_Item.CurrentRow.Cells[4].Value.ToString();
            txt_itemQuantity.Text = this.grid_Item.CurrentRow.Cells[6].Value.ToString();
        }

        private void InputItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }

        private void btn_DelItem_Click(object sender, EventArgs e)
        {
            connect.Open();
            
            DialogResult result = MessageBox.Show("Bạn có muốn xóa mặt hàng này ?", "Connection String", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            else
            {
                string delItem = "delete from KhoSach where book_id = " + txt_itemID.Text + "";
                cmd = new SqlCommand(delItem, connect);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Bạn đã xóa người dùng thành công");
                    connect.Close();
                }
            }
            LoadData();
        }
    }
}
