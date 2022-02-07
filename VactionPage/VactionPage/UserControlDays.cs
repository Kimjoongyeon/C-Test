using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VactionPage
{
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            
        }
        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }
        //am pm 구분
        private void panelAM_MouseHover(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Color.LightPink;
        }

        private void panelAM_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Color.White;
        }

        private void panelPM_MouseHover(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Color.LightSkyBlue;
        }

        private void panelPM_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Color.White;
        }

        private void panelAM_Click(object sender, EventArgs e)
        {
            //휴가요청할수있게해야함
            VacAmRegister vacAmRegister = new VacAmRegister();
            vacAmRegister.ShowDialog();
        }

        private void panelPM_Click(object sender, EventArgs e)
        {
            //휴가요청할수있게해야함
            VacPmRegister vacPmRegister = new VacPmRegister();
            vacPmRegister.ShowDialog();
        }
    }
}
