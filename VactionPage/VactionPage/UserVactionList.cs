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
using System.Globalization;

namespace VactionPage
{
    public partial class UserVactionList : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        int month, year;
        //월, 년을 다른 형태로 전달하는 정적변수
        public static int static_month, static_year;
        public UserVactionList()
        {
            InitializeComponent();
            con = new SqlConnection("server=127.0.0.1; Initial Catalog=code;Integrated Security=SSPI");
        }
        private void UserVactionList_Load(object sender, EventArgs e)
        {
            lbId.Text = Form1.LoginInfo.userId;
            // 관리자만 보이게끔 처리
            if (lbId.Text == "admin")
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
            lbId.Text = Form1.LoginInfo.userId;
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            static_month = month;
            static_year = year;

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
        private void btnprevious_Click(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();
            //이전달로
            month--;
            static_month = month;
            static_year = year;

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
            static_month = month;
            static_year = year;

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

        private void lbAddVac_Click(object sender, EventArgs e)
        {
            this.Hide();
            VactionChoice vactionChoice = new VactionChoice();
            vactionChoice.Show();
        }

        private void lbapp_Click(object sender, EventArgs e)
        {
            this.Hide();
            VacWaitList approvalList = new VacWaitList();
            approvalList.Show();
        }

        private void lbVacOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
        }

        
    }
}
