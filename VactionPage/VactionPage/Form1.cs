using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace VactionPage
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public static class LoginInfo
        {
            public static string userId;
        }
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("server=127.0.0.1; Initial Catalog=code;Integrated Security=SSPI");

        }
        public void btnLogin_Click(object sender, EventArgs e)  //로그인 메소드
        {
            //string id = txtId.Text;
            //string pw = txtPwd.Text;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            // 비번 복호화해서 로그인하게 해야함
            //cmd.CommandText = "SELECT * FROM userLogin where id='" + txtId.Text + "' AND password='" + txtPwd.Text + "'";
            cmd.CommandText = "select * from userLogin where id = @id AND password= Pwdcompare(@pwd, password)";
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@pwd", txtPwd.Text);
            dr = cmd.ExecuteReader();
            
            if(EmptyCheck() == true)
            { 
                if (dr.Read() )
                {
                    if (txtId.Text == "admin") //이부분에서 관리자만 들어가게끔 바꿔야함 지금은 계정하나만 들어갈수 있는 상태임
                    {
                        this.Hide();
                        AdminPage adminPage = new AdminPage();
                        adminPage.Show();
                    }
                    else
                    {
                        this.Hide();
                        VactionChoice vacChoice = new VactionChoice();
                        LoginInfo.userId = txtId.Text;
                        VacAmRegister vacAmRegister = new VacAmRegister();
                        vacAmRegister.LoginData = txtId.Text;
                        vacChoice.Show();
                    }
                }
                else
                {
                    this.lblResult.Text = "아이디와 비밀번호를 다시 한번 확인해주세요.";
                }
            }
            con.Close();
        }
        private bool EmptyCheck() //빈 공간을 방지하기 위한 메소드
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                this.lblResult.Text = "아이디를 입력해주세요.";
                txtId.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtPwd.Text))
            {
                this.lblResult.Text = "비밀번호를 입력해주세요.";
                txtId.Focus();
                return false;
            }
            return true;
        }
        private void btnClose_Click(object sender, EventArgs e)  //창 닫기
        {
            this.Close();
        }
    }
}
