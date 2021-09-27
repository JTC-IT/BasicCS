using System.Collections.Generic;
using System.Windows.Forms;
using BasicWinform.Entities;
using BisicWinform;

namespace BasicWinform
{
    public partial class frmListSv : Form
    {
        public frmListSv(List<Student> list)
        {
            InitializeComponent();

            studentBindingSource.DataSource = list;
            girdStudents.DataSource = studentBindingSource;
        }

        public Student selectedStudent
        {
            get
            {
                return studentBindingSource.Current as Student;
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedStudent != null)
                new frmSinhVien(selectedStudent).Show();
        }

        private void ts_btnDel_Click(object sender, System.EventArgs e)
        {
            if(selectedStudent != null &&
                MessageBox.Show("Bạn có chắc chắn muốn xóa ko?"
                , "Remove student"
                , MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question) == DialogResult.OK)
            {
                studentBindingSource.RemoveCurrent();
            }
        }
    }
}
