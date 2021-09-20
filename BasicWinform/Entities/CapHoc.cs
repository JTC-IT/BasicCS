using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWinform.Entities
{
    public class CapHoc
    {
        public string tenCap { get; set; }
        public string School { get; set; }
        public float Diem { get; set; }
        public HK HanhKiem { get; set; }

        public enum HK { Tot, Kha, TB, Yeu }

        public string HanhKiemToString
        {
            get
            {
                if (HanhKiem == HK.Tot)
                    return "Tốt";
                else if (HanhKiem == HK.Kha)
                    return "Khá";
                else if (HanhKiem == HK.TB)
                    return "Trung bình";
                else
                    return "Yếu";
            }
        }
    }
}
