using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWinform.Entities
{
    class Faculty
    {
        public int Id{ get; set; }
        public string Name { get; set; }

        public static List<Faculty> getListFaculty()
        {
            List<Faculty> list = new List<Faculty>();
            list.Add(new Faculty
            {
                Id = 0,
                Name = "Tất cả"
            });
            list.Add(new Faculty
            {
                Id = 1,
                Name = "CNTT"
            });
            list.Add(new Faculty
            {
                Id = 2,
                Name = "Toán"
            });
            list.Add(new Faculty
            {
                Id = 3,
                Name = "Lý"
            });
            list.Add(new Faculty
            {
                Id = 4,
                Name = "Báo Chí"
            });
            list.Add(new Faculty
            {
                Id = 5,
                Name = "Lịch Sử"
            });

            return list;
        }
    }
}
