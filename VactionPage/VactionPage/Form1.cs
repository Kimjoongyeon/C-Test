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
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("server=127.0.0.1; Initial Catalog=code;Integrated Security=SSPI");

        }
        public void btnLogin_Click(object sender, EventArgs e)  //로그인 메소드
        {
            string id = txtId.Text;
            string pw = txtPwd.Text;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM userLogin where id='" + txtId.Text + "' AND password='" + txtPwd.Text + "'";
            dr = cmd.ExecuteReader();
            if(EmptyCheck() == true)
            { 
                if (dr.Read() )
                {
                    if (txtId.Text == "admin1") //이부분에서 관리자만 들어가게끔 바꿔야함 지금은 엉망인 상태임
                    {
                        this.Hide();
                        AdminPage adminPage = new AdminPage();
                        adminPage.LoginData = txtId.Text;
                        adminPage.Show();
                    }
                    else
                    {
                        this.Hide();
                        VactionChoice vacChoice = new VactionChoice();
                        //vacChoice.Owner = this;
                        vacChoice.LoginData = txtId.Text;
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

        // 로그인한 상태로 사이트 이용하게하기(1.로그인시간 정하기 2.암호화, 복호화 이용하여 로그인)
        /*
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!CK)
            {
                Application.Exit();
            }
            else
            {
                Properties.Settings.Default.id = txtId.Text;
                Properties.Settings.Default.Save();
            }
        }


        
    public enum DesType
    {
       Encrypt = 0,    // 암호화
       Decrypt = 1     // 복호화

    }
    public class DES
    {

       // Key 값은 무조건 8자리여야한다.
       private byte[] Key { get; set; }

       // 암호화/복호화 메서드
       public string result(DesType type, string input)
       {
           var des = new DESCryptoServiceProvider()
           {
               Key = Key,
               IV = Key
           };

           var ms = new MemoryStream();

           // 익명 타입으로 transform / data 정의
           var property = new
           {
               transform = type.Equals(DesType.Encrypt) ? des.CreateEncryptor() : des.CreateDecryptor(),
               data = type.Equals(DesType.Encrypt) ? Encoding.UTF8.GetBytes(input.ToCharArray()) : Convert.FromBase64String(input)
           };

           var cryStream = new CryptoStream(ms, property.transform, CryptoStreamMode.Write);
           var data = property.data;

           cryStream.Write(data, 0, data.Length);
           cryStream.FlushFinalBlock();

           return type.Equals(DesType.Encrypt) ? Convert.ToBase64String(ms.ToArray()) : Encoding.UTF8.GetString(ms.GetBuffer());
       }

       // 생성자
       public DES(string key)
       {
           Key = ASCIIEncoding.ASCII.GetBytes(key);
       }
    }
    */
    }
}
