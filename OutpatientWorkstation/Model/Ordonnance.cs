using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.Model
{
    public class Ordonnance
    {
        /// <summary>
        /// 处方编号
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 病人编号
        /// </summary>
        public int PatientNo { get; set; }
        /// <summary>
        /// 医生编号
        /// </summary>
        public int AgencyNo { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date { get; set; }
    }
}
