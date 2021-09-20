using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisicWinform
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void slove(char op)
        {
            if (string.IsNullOrEmpty(txt1.Text))
                return;
            if (string.IsNullOrEmpty(txt2.Text))
                return;

            double result = 0;
            try
            {
                double a = double.Parse(txt1.Text);
                double b = double.Parse(txt2.Text);
                switch (op)
                {
                    case '+':
                        result = a + b;
                        break;
                    case '-':
                        result = a - b;
                        break;
                    case 'x':
                        result = a * b;
                        break;
                    case '/':
                        result = a / b;
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đầu vào phải là số!", "Lỗi input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblResult.Text = result.ToString();
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (sender == btnAdd)
                slove('+');
            else if (sender == btnSub)
                slove('-');
            else if (sender == btnX)
                slove('x');
            else
                slove('/');
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            lblResult.Text = "0";
        }
    }
}
