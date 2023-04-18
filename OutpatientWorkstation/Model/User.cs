using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutpatientWorkstation
{
    public class User
    {
        /// <summary>
        /// 员工编号
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 员工名称；
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 员工性别
        /// </summary>
        public bool Gender { get; set; }
        /// <summary>
        /// 员工电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 密码；
        /// </summary>
        public byte[] Password {  get; set; }
        /// <summary>
        /// 科室编号
        /// </summary>
        public int TechnicalOfficeNo { get; set; }
        /// <summary>
        /// 用户类型编号
        /// </summary>
        public int AgencyTypeNo { get; set; }
        /// <summary>
        /// 员工备注
        /// </summary>
        public string Remark { get; set; }
        
    }
}
