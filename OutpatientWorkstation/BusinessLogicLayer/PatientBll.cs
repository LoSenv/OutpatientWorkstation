using OutpatientWorkstation.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.BusinessLogicLayer
{
    public class PatientBll:IPatientBll
    {
        private IPatientDal PatientDal { get; set; }
        public PatientBll() 
        { 
            this.PatientDal= new PatientDal();
        }
        public DataView PatientViewByName { get; set; }
        public DataTable PatientTable { get; set; }
        public DataRow ResultRow { get; set; }
        public DataTable ResultTable { get; set; }
        public void ViewPatient()
        {
            this.PatientTable = this.PatientDal.Select();
            this.PatientViewByName = new DataView();
            this.PatientViewByName.Table = this.PatientTable;
            this.PatientViewByName.Sort = "姓名 ASC";
        }
        public void SelectByNo(string no)
        {
           this.ResultRow = this.PatientTable.Rows.Find(no);
            this.ResultTable = this.PatientTable.Clone();
            this.ResultTable.ImportRow(this.ResultRow);
            
        }
    }
}
