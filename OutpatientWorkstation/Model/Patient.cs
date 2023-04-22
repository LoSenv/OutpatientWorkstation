using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.Model
{
    public class Patient
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public bool Gender { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Adress { get; set; }
    }
}
