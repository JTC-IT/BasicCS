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
    }
}
