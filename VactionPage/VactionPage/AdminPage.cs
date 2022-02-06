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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }
        private string AdminPage_value;
        public string LoginData
        {
            get { return this.AdminPage_value; }
            set { this.AdminPage_value = value; }
        }
    }
}
