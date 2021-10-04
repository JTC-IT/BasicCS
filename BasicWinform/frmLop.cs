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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
            cmbKhoa.DataSource = Faculty.getListFaculty();
            cmbKhoa.DisplayMember = "Name";
            cmbKhoa.ValueMember = "Id";

            girdStudent.DataSource = studentBindingSource;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = cmbKhoa.SelectedItem as Faculty;
            studentBindingSource.DataSource = Student.getListStudents(item.Id);
        }
    }
}
