using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VactionPage
{
    public partial class VactionChoice : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        int month, year, ableVac, useVac;
        public VactionChoice()
        {
            InitializeComponent();
            con = new SqlConnection("server=127.0.0.1; Initial Catalog=code;Integrated Security=SSPI");
            
            
        }
        //Form1 값을 받아오기위한 코드
        private string VactionChoice_value;
        public string LoginData
        {
            get { return this.VactionChoice_value; }
            set { this.VactionChoice_value = value; }
        }

        private void VactionChoice_Load(object sender, EventArgs e)
        {
            lbName.Text = LoginData;
            // 관리자만 보이게끔 처리
            if (LoginData == "admin1")
            {
                lbVacOk.Show();
            }
            else
            {
                lbVacOk.Hide();
            }
            displaDays();
        }
        private void displaDays()
        {
            
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            //vaction = now.Month;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT Vaction VALUES"+ lbName.Text +"";

            dr = cmd.ExecuteReader();

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            ableVac = 1;
            LBDATE.Text = monthname + " " + year;
            vacAble.Text = ableVac + "일";
            vacUse.Text = useVac + "일";
            //vacAble.Text = vaction + " ";
            //vacUse.Text = 

            //달의 첫날부터 시작
            DateTime startofthemonth = new DateTime(year, month, 1);

            //월의 갯수구하기
            int days = DateTime.DaysInMonth(year, month);

            //convert the startofthemonth to integer(startofthemonth를 정수로 환산)
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //달력 빈칸 추가
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //달력 일 단위 추가
            for(int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
                
            }
        }

        private void lbapp_Click(object sender, EventArgs e)
        {
            this.Hide();
            VacWaitList approvalList = new VacWaitList();
            approvalList.Show();
        }

        private void lbVacList_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserVactionList userVactionList = new UserVactionList();
            userVactionList.Show();
        }

        private void lbVacOk_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();
            //이전달로
            month--;
            this.ableVac--;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            //달의 첫날부터 시작
            DateTime startofthemonth = new DateTime(year, month, 1);

            //월의 갯수구하기
            int days = DateTime.DaysInMonth(year, month);

            //convert the startofthemonth to integer(startofthemonth를 정수로 환산)
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //달력 빈칸 추가
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //달력 일 단위 추가
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();
            //다음달로
            month++;
            ableVac++;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            //달의 첫날부터 시작
            DateTime startofthemonth = new DateTime(year, month, 1);

            //월의 갯수구하기
            int days = DateTime.DaysInMonth(year, month);

            //convert the startofthemonth to integer(startofthemonth를 정수로 환산)
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //달력 빈칸 추가
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //달력 일 단위 추가
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
