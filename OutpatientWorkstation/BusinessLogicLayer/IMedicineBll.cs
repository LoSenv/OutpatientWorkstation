using OutpatientWorkstation.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.BusinessLogicLayer
{
    public interface IMedicineBll
    {
        /// <summary>
        /// 药品表
        /// </summary>
        DataTable MedicineTable { get;}
        /// <summary>
        /// 包装单位表
        /// </summary>
        DataTable UnitTable { get; }
        DataTable ResultTable { get;}
        /// <summary>
        /// 通过名称药品视图
        /// </summary>
        DataView MedicineViewByName { get;}
        DataView CurrentPageView { get; set; }
        /// <summary>
        /// 页数
        /// </summary>
        int PageSize { get; }
        /// <summary>
        /// 当前页号
        /// </summary>
        int CurrentPageNo { get;  }
        /// <summary>
        /// 最大页号
        /// </summary>
        int MaxPageNo { get; set; }
        /// <summary>
        /// 消息
        /// </summary>
        string Message { get; }
        void RefreshRowFilter();
        /// <summary>
        /// 查看药品
        /// </summary>
        void ViewMedicine();
        /// <summary>
        /// 通过编号搜索
        /// </summary>
        /// <param name="no"></param>
        void SearchByNo(string no);
        /// <summary>
        /// 通过名称搜索
        /// </summary>
        /// <param name="name"></param>
        void SearchByName(string name);
        /// <summary>
        /// 通过拼音搜索
        /// </summary>
        /// <param name="pinyin"></param>
        void SearchByPinyin(string pinyin);
        /// <summary>
        /// 上一页
        /// </summary>
        void PrePage();
        /// <summary>
        /// 下一页
        /// </summary>
        void NextPage();
        void ModifyMedicine();
    }
}
