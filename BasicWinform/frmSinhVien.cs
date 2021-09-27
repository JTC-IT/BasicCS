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

namespace BisicWinform
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien(Student student)
        {
            InitializeComponent();

            txtName.Text = student.fullName;
            birthDay.Value = student.DOB;
            if (student.sex == Student.Sex.Nam)
                rdNam.Checked = true;
            else if (student.sex == Student.Sex.Nu)
                rdNu.Checked = true;
            else rdKhac.Checked = true;
            txtHomeTown.Text = student.homeTown;

            List<CapHoc> history = new List<CapHoc>();
            history.Add(student.Cap1);
            history.Add(student.Cap2);
            history.Add(student.Cap3);
            capHocBindingSource.DataSource = history;
            girdHistory.DataSource = capHocBindingSource;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "File ảnh(*.png, *.jpg)|*.png; *.jpg";
            fileDialog.Title = "Chọn ảnh chân dung";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureAvata.ImageLocation = fileDialog.FileName;
            }
        }

        private void btnChooseBgColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }
    }
}
