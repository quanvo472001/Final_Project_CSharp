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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        public Boolean check(string a)
        {
            if (a.Trim().Length == 0)
            {
                
                return true;
            }
            return false;
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = @"Data Source = QuanVo; Initial Catalog = WinformBanSach; Persist Security Info=True;User ID = quanvo; Password=Quanvo472001";
            connect.Open();
            string userid = txt_User.Text;
            string pass = txt_Pass.Text;
            string posistion = txt_Posistion.Text;
            string name = txt_Name.Text;
            string age = txt_Age.Value.ToString();
            string phone = txt_Phone.Text;
            if(check(userid) || check(pass) || check(posistion)|| check(name)||check(age)||check(phone))
            {
                MessageBox.Show("Nhập phần còn thiếu");
                return;
            }
            string signup = "insert into Users values('"+userid+"','"+pass+"',N'"+name+"','"+phone+"',"+age+",N'"+posistion+"')";
            SqlCommand cmd = new SqlCommand(signup, connect);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đăng kí thành công");
                    this.Visible = false;
                    Login formLogin = new Login();
                    formLogin.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Người dùng đã tồn tại. Mời nhập lại");
                return;
            }
            
            
            connect.Close();
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
