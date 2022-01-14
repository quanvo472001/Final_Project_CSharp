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
    public partial class Work : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=QuanVo;Initial Catalog=WinformBanSach;Persist Security Info=True;User ID=quanvo;Password=Quanvo472001");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        public Work()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            InputItem item = new InputItem();
            item.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Staff_Manager manager = new Staff_Manager();
            manager.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HistoryItem history = new HistoryItem();
            history.Show();
        }

        private void btn_Reven_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Revenue revenue = new Revenue();
            revenue.Show();
        }

        private void Work_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            Login login = new Login();
            login.Show();
        }

        private void Work_Load(object sender, EventArgs e)
        {
            connect.Open();
            string type_user = "select * from Users where users = '"+_message+"' and (position = N'Chủ' or position='Admin')";
            cmd = new SqlCommand(type_user, connect);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            
            if (dt.Rows.Count <1)
            {
                button3.Enabled = false;
            }
        }
    }
}
