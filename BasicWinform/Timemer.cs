using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWinform
{
    public partial class Timemer : Form
    {
        int count;
        public Timemer()
        {
            InitializeComponent();
            count = (int)numTimer.Value * 60;
            int m = count / 60;
            lblTimer.Text = m + ":" + (count - m * 60);
        }

        
        private void timer_Tick(object sender, EventArgs e)
        {
            if(count >= 0)
            {
                lblTimer.Text = $"{count / 60 :0#}:{count % 60:0#}";
                count--;
            }
            else
            {
                timer.Stop();
                btnStop.Enabled = false;
                btnStart.Enabled = true;
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            count = (int)numTimer.Value * 60;
            timer.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblTimer.Text = "0";
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }
    }
}
