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
        //SqlDataReader dr;
        
        public static class LoginInfo
        {
            public static string userId;
            public static string adminInfo;
        }
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("server=127.0.0.1; Initial Catalog=code;Integrated Security=SSPI");

        }
        public void btnLogin_Click(object sender, EventArgs e)  //로그인 메소드
        {
            HashPassword hash = new HashPassword();
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM userLogin where id = @id AND password = @pwd";
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            //cmd.Parameters.AddWithValue("@pwd", hash.PassHash(txtPwd.Text));
            cmd.Parameters.AddWithValue("@pwd", txtPwd.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            LoginInfo.userId = txtId.Text;

            if (EmptyCheck() == true)
            { 
                if (dr.Read() )
                {
                    LoginInfo.adminInfo = dr[4].ToString();
                    if (LoginInfo.adminInfo == "사원") 
                    {
                        this.Hide();
                        VactionChoice vacChoice = new VactionChoice();
                        vacChoice.Show();
                    }
                    else
                    {
                        this.Hide();
                        VactionChoice vacChoice = new VactionChoice();
                        vacChoice.Show();
                    }
                }
                else
                {
                    this.lblResult.Text = "아이디와 비밀번호를 다시 한번 확인해주세요.";
                }
            }
            con.Close();
            dr.Close();
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
