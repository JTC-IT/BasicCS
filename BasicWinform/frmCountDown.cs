using System;
using System.Drawing;
using System.Windows.Forms;
using BasicWinform.Entities;

namespace BasicWinform
{
    public partial class frmCountDown : Form
    {
        private DateTime end = new DateTime(2022, 02, 01, 0, 0, 0);
        public frmCountDown()
        {
            InitializeComponent();
            panel.BackColor = Color.FromArgb(125, Color.Black);
            lblHeader.BackColor = Color.FromArgb(55, Color.Gray);
            radioTet.BackColor = Color.FromArgb(0);
            radioCustom.BackColor = Color.FromArgb(0);
            lblTitle.BackColor = Color.FromArgb(0);
            lblDate.BackColor = Color.FromArgb(0);
            lblH.BackColor = Color.FromArgb(0);
            lblM.BackColor = Color.FromArgb(0);
            lblS.BackColor = Color.FromArgb(0);
            labelk1.BackColor = Color.FromArgb(0);
            labelk2.BackColor = Color.FromArgb(0);
            labelk2.BackColor = Color.FromArgb(0);
            lblTimer.BackColor = Color.FromArgb(155, Color.Black);
            lblTimerS.BackColor = Color.FromArgb(155, Color.Black);

            radioTet.Checked = true;
            dateTimePicker.Value = end;
            numH.Value = 0;
            numM.Value = 0;
            numS.Value = 0;

            timer.Start();
        }

        public void setEnabledCustoms(bool b)
        {
            dateTimePicker.Enabled = b;
            numH.Enabled = b;
            numM.Enabled = b;
            numS.Enabled = b;
        }

        public void setTimeEnd()
        {
            DateTime time = dateTimePicker.Value;
            end = new DateTime(time.Year, time.Month, time.Day, (int)numH.Value, (int)numM.Value, (int)numS.Value);
        }

        private void radioTet_CheckedChanged(object sender, EventArgs e)
        {
            radioTet.ForeColor = Color.Lime;
            radioCustom.ForeColor = Color.White;

            setEnabledCustoms(false);
            end = new DateTime(2022, 02, 01, 0, 0, 0);
            dateTimePicker.Value = end;
            numH.Value = 0;
            numM.Value = 0;
            numS.Value = 0;
        }

        private void radioCustom_CheckedChanged(object sender, EventArgs e)
        {
            radioCustom.ForeColor = Color.Lime;
            radioTet.ForeColor = Color.White;

            setEnabledCustoms(true);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan span = end - DateTime.Now;
            if(span.TotalSeconds >= 0)
            {
                lblTimerS.Text = $"{span.Seconds}";
                lblTimer.Text = $"{span.Days:0#}d  {span.Hours:0#}:{span.Minutes:0#}";
                if(span.TotalSeconds < 25)
                {
                    if(span.Seconds == 19)
                        new MySound(@"C:\Users\trung\source\repos\BasicCS\happynewyear.wav").Play();
                    if (span.Seconds == 0)
                        new happyNewYear().Show();
                }
            }
            else
            {
                lblTimer.Text = "00d 00:00";
                lblTimerS.Text = "00";
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            numH.Value = time.Hour;
            numM.Value = time.Minute + 2;
            numS.Value = time.Second;
            setTimeEnd();
        }

        private void numH_ValueChanged(object sender, EventArgs e)
        {
            setTimeEnd();
        }

        private void numM_ValueChanged(object sender, EventArgs e)
        {
            setTimeEnd();
        }

        private void numS_ValueChanged(object sender, EventArgs e)
        {
            setTimeEnd();
        }
    }
}
