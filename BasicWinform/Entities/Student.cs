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

        public enum Sex { Nam, Nu, Khac };

        public string fullName
        {
            get { return lastName + " " + firstName; }
        }

        public CapHoc Cap1 { get; set; }
        public CapHoc Cap2 { get; set; }
        public CapHoc Cap3 { get; set; }
    }
}
