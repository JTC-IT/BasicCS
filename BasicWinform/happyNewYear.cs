using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicWinform.Entities;

namespace BasicWinform
{
    public partial class happyNewYear : Form
    {
        int count = 30;
        public happyNewYear()
        {
            InitializeComponent();

            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (count > 1)
                count--;
            else
            {
                timer.Stop();
                System.Windows.Forms.Application.ExitThread();
            }
        }
    }
}
