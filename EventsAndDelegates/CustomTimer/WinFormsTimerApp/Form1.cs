using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTimerApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            timer = new CustomTimer();
            label.Text = timer.Time.ToString();
            timer.TimeRefresh += Timer_TimeRefresh;
        }

        private void Timer_TimeRefresh(object sender, EventArgs e)
        {
            textBox.Text += "TIMER EXECUTED " + timer.Time + "\n";
        }

        private CustomTimer timer;

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            timer.Interval += 100;
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if ((timer.Interval - 100) >= 0)
            {
                timer.Interval -= 100;
            }
        }
    }
}
