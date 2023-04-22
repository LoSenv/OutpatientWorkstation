using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.Model
{
    public class Medicine
    {
        /// <summary>
        /// 药品编号
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 药品名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 药品拼音
        /// </summary>
        public string Pinyin { get; set; }
        /// <summary>
        /// 药品规格
        /// </summary>
        public string Spec { get; set; }
        /// <summary>
        /// 药品功效
        /// </summary>
        public string Efficacy { get; set; }
        /// <summary>
        /// 药品价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 药品库存
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 包装单元编号
        /// </summary>
        public int UnitNo { get; set; }
    }
}
