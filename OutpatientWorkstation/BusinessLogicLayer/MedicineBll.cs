using OutpatientWorkstation.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OutpatientWorkstation.DataAccessLayer;

namespace OutpatientWorkstation.BusinessLogicLayer
{
    public class MedicineBll:IMedicineBll
    {
        private IMedicineDal MedicineDal { get; set; }
        public MedicineBll() 
        {
            this.MedicineDal= new MedicineDal();
        }
        /// <summary>
        /// 药品表
        /// </summary>
        public DataTable MedicineTable { get; set; }
        /// <summary>
        /// 包装单位表
        /// </summary>
        public DataTable UnitTable { get; set; }
        public DataTable ResultTable { get; set; }
        /// <summary>
        /// 通过名称药品视图
        /// </summary>
        public DataView MedicineViewByName { get; set; }
        public DataView CurrentPageView { get; set; }
        /// <summary>
        /// 页数
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 当前页号
        /// </summary>
        public int CurrentPageNo { get; set; }
        /// <summary>
        /// 最大页号
        /// </summary>
        public int MaxPageNo { get; set; }
        public string Message { get; set; }
        public void RefreshRowFilter()
            => this.CurrentPageView.RowFilter =
            $"RowId>{(this.CurrentPageNo - 1) * this.PageSize}" +
            $"AND RowId<={(this.CurrentPageNo) * this.PageSize}";
        /// <summary>
        /// 查看药品
        /// </summary>
        public void ViewMedicine()
        {
            this.PageSize = 5;
            this.CurrentPageNo = 1;
            this.MedicineTable = this.MedicineDal.SelectMedicineTable();
            this.UnitTable = this.MedicineDal.SelectUnitTable();
            this.MedicineViewByName = new DataView();
            this.MedicineViewByName.Table = this.MedicineTable;
            this.MedicineViewByName.Sort = "Name ASC";
        }
        /// <summary>
        /// 通过编号搜索
        /// </summary>
        /// <param name="no"></param>
        public void SearchByNo(string no)
        {
            DataRow resultRow = this.MedicineTable.Rows.Find(no);
            DataTable resultTable = this.MedicineTable.Clone();
            resultTable.ImportRow(resultRow);
            this.ResultTable = resultTable;
        }
        /// <summary>
        /// 通过名称搜索
        /// </summary>
        /// <param name="name"></param>
        public void SearchByName(string name)
        {
            DataRowView[] resultRowViews =
                this.MedicineViewByName.FindRows(name);
            DataTable resultTable = this.MedicineTable.Clone();
            foreach (DataRowView dataRowView in resultRowViews)
            {
                resultTable.ImportRow(dataRowView.Row);
            }
            this.ResultTable = resultTable;
        }
        /// <summary>
        /// 通过拼音搜索
        /// </summary>
        /// <param name="pinyin"></param>
        public void SearchByPinyin(string pinyin)
        {
            DataRow[] resultRow =
               this.MedicineTable.Select($"Pinyin LIKE '%{pinyin}%'");
            DataTable resultTable = this.MedicineTable.Clone();
            foreach (DataRow row in resultRow)
            {
                resultTable.ImportRow(row);
            }
            this.ResultTable = resultTable;
        }
        public void PrePage()
        {
            if (CurrentPageNo > 1)
            {
                this.CurrentPageNo--;
                this.RefreshRowFilter();
            }
        }
        public void NextPage()
        {
            if (CurrentPageNo < this.MaxPageNo)
            {
                this.CurrentPageNo++;
                this.RefreshRowFilter();
            }
        }
        public void ModifyMedicine()
        {
            int count1= this.MedicineDal.Update(this.MedicineTable);
            int count2 =this.MedicineDal.Delete(this.MedicineTable);
            this.Message = $"已成功更新{count1 + count2}行";
        }
    }
    }
