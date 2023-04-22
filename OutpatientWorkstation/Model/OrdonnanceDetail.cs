using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.Model
{
    public class OrdonnanceDetail
    {
        /// <summary>
        /// 处方明细编号
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 处方编号
        /// </summary>
        public int OrdonnanceNo { get; set; }
        /// <summary>
        /// 处方明细编码
        /// </summary>
        public string Encod { get; set; }
        /// <summary>
        /// 药物编号
        /// </summary>
        public int MedicineNo { get; set; }
        /// <summary>
        /// 使用方法编号
        /// </summary>
        public int UseMethodNo { get; set; }
        /// <summary>
        /// 使用频率编号
        /// </summary>
        public int UseFrequencyNo { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
