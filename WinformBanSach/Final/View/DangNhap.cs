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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = @"Data Source = QuanVo; Initial Catalog = WinformBanSach; Persist Security Info=True;User ID = quanvo; Password=Quanvo472001";
            connect.Open();
            string userid = txt_User.Text;
            string pass = txt_Password.Text;
            string accountant = "select * from Users where users ='" + userid + "' and passwords ='" + pass +  "'";
            SqlCommand cmd = new SqlCommand(accountant, connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                
                this.Visible = false;
                Work formWork = new Work();
                formWork.Message = txt_User.Text;
                formWork.Show();

            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!!");
                return;

            }
            connect.Close();
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
