using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWinform.Entities
{
    public class Student
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Sex sex { get; set; }
        public DateTime DOB { get; set; }
        public string homeTown { get; set; }
        public int IdFaculty { get; set; }

        public enum Sex { Nam, Nu, Khac };


        public string fullName
        {
            get { return lastName + " " + firstName; }
        }

        public CapHoc Cap1 { get; set; }
        public CapHoc Cap2 { get; set; }
        public CapHoc Cap3 { get; set; }


        /// <summary>
        /// Tạo ngẫu nhiên ds Student (MockData)
        /// </summary>
        /// <returns>list students</returns>
        public static List<Student> getListStudents()
        {
            List<Student> list = new List<Student>();

            list.Add(new Student()
            {
                id = 1,
                firstName = "Trung Chính",
                lastName = "Trần",
                DOB = new DateTime(2000, 07, 02),
                sex = Student.Sex.Nam,
                homeTown = "Hà Tĩnh",
                IdFaculty = 1,
                Cap1 = new CapHoc()
                {
                    tenCap = "Cấp 1",
                    School = "Trường Tiểu học Hương Giang",
                    Diem = 7,
                    HanhKiem = CapHoc.HK.Kha
                },
                Cap2 = new CapHoc()
                {
                    tenCap = "Cấp 2",
                    School = "Trường THCS Hương Giang",
                    Diem = 8,
                    HanhKiem = CapHoc.HK.Tot
                },
                Cap3 = new CapHoc()
                {
                    tenCap = "Cấp 3",
                    School = "Trường THPT Hương Khê",
                    Diem = 8,
                    HanhKiem = CapHoc.HK.Tot
                },
            });

            list.Add(new Student()
            {
                id = 2,
                firstName = "Thị Thảo",
                lastName = "Nguyễn",
                DOB = new DateTime(2000, 03, 12),
                sex = Student.Sex.Nu,
                homeTown = "Thừa Thiên Huế",
                IdFaculty = 2,
                Cap1 = new CapHoc()
                {
                    tenCap = "Cấp 1",
                    School = "Trường Tiểu học Hương Trà",
                    Diem = 6,
                    HanhKiem = CapHoc.HK.Tot
                },
                Cap2 = new CapHoc()
                {
                    tenCap = "Cấp 2",
                    School = "Trường THCS Quang Trung",
                    Diem = 8,
                    HanhKiem = CapHoc.HK.Tot
                },
                Cap3 = new CapHoc()
                {
                    tenCap = "Cấp 3",
                    School = "Trường THPT Hai Bà Trưng",
                    Diem = 9,
                    HanhKiem = CapHoc.HK.Tot
                },
            });

            return list;
        }

        public static Student getStudent(int id)
        {
            return getListStudents().Where(s => s.id == id).FirstOrDefault();
        }

        public static List<Student> getListStudents(int idFaculty)
        {
            if (idFaculty == 0)
                return getListStudents();
            return getListStudents().Where(s => s.IdFaculty == idFaculty).ToList();
        }
    }
}
