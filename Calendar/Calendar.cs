using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class wdw_calendar : Form
    {
        public wdw_calendar()
        {
            InitializeComponent();
        }

        private void btn_quit_calendar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_open_calendar(object sender, EventArgs e)
        {
            Form open_calendar = new wdw_calendar();
            open_calendar.Show();
        }
    }
}
