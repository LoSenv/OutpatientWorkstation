using OutpatientWorkstation.DataAccessLayer;
using OutpatientWorkstation.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutpatientWorkstation.BusinessLogicLayer
{
    public class OrdonnanceDetailBll:IOrdonnanceDetailBll
    {
        private IOrdonnanceDetailDal OrdonnanceDetailDal { get; set; }
        public OrdonnanceDetailBll()
        {
            this.OrdonnanceDetailDal= new OrdonnanceDetailDal();
        }
        public DataTable MedicineTable { get; set; }
        public DataTable ListTable { get; set; }
        public DataTable UseMethodTable { get; set; }
        public DataTable UseFrequencyTable { get; set; }
        public DataTable OrdonnanceDetailTable { get; set; }
        public string Message { get; set; }
        public bool CheckOrdonnanceNoNull(int ordonnanceNo)
        {
            if (ordonnanceNo.ToString() == null)
            {
                this.Message="处方号为空，请新建处方！";
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Select(int ordonnanceNo)
        {
            this.MedicineTable=this.OrdonnanceDetailDal.SelectMedicineTable();
            this.ListTable = this.OrdonnanceDetailDal.SelectListTable(ordonnanceNo);
            this.UseMethodTable = this.OrdonnanceDetailDal.SelectUseMethodTable();
            this.UseFrequencyTable=this.OrdonnanceDetailDal.SelectFrequencyTable();
        }
        public void InsertOrdonnanceDetail(int ordonnanceNo)
        {
            int count=this.OrdonnanceDetailDal.Insert(this.ListTable, ordonnanceNo);
            this.Message = $"更新{count}行！";
        }
        public void SelectOrdonnanceDetail()
        {
            this.OrdonnanceDetailTable=this.OrdonnanceDetailDal.SelectOrdonnanceDetail();
        }
    }
}
