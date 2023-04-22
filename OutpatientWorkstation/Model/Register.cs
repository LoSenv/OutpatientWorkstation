using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.Model
{
    public class Register
    {
        public int No { get; set; }
        public int PatientNo { get; set; }
        public int TechnicalOfficeNo { get; set; }
        public int DoctorNo { get; set; }
        public int RegistrarNo { get;}
        public decimal RegisterPrice { get; set; }
        public string Remark { get; set; }
    }
}
