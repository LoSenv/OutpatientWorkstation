using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.Model
{
    public class MedicalRecord
    {
        /// <summary>
        /// 病历编号
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 病历名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 医生编号
        /// </summary>
        public int DoctorNo { get; set; }
        /// <summary>
        /// 病况
        /// </summary>
        public string Situation { get; set; }
        /// <summary>
        /// 挂号编号
        /// </summary>
        public int RegisterNo { get; set; }

    }
}
