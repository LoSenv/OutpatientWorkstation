using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.DataAccessLayer
{
    public  interface IUserDal
    {
        /// <summary>
        /// 查询用户
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        User Select(string username);
        /// <summary>
        /// 查询用户计数
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        int SelectCount(string username);
        /// <summary>
        /// 插入用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int InsertUser(User user);
        /// <summary>
        /// 更新密码
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int UpdatePassword(string userName,string password);
        User SelectNo(string username);
        DataSet SelectByTree();
        DataTable SelectAgencyTable(int technicalOfficeNo);
        DataTable SelectAgencyTypeTable();
        DataTable SelectTechnicalOfficeNoTable();
        int InsertAgency(int agencyTypeNo, string name, bool gender, string phone, int technicalOfficeNo, string remark);

    }
}
