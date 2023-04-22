using OutpatientWorkstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.BusinessLogicLayer
{
    public interface IOrdonnanceBll
    {
        /// <summary>
        /// 是否插入
        /// </summary>
        bool HasInsert { get;}
        /// <summary>
        /// 消息
        /// </summary>
        string Message { get; }
        /// <summary>
        /// 插入处方
        /// </summary>
        /// <param name="no"></param>
        /// <param name="patientNo"></param>
        /// <param name="agencyNo"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        Ordonnance InsertOrdonnance(int no, int patientNo, int agencyNo, DateTime date);
    }
}
