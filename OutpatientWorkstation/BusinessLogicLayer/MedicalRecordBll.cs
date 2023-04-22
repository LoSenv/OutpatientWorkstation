using OutpatientWorkstation.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.BusinessLogicLayer
{
    public class MedicalRecordBll:IMedicalRecordBll
    {
        private IMedicalRecordDal MedicalRecordDal { get; set; }
        public MedicalRecordBll() 
        {
            this.MedicalRecordDal = new MedicalRecordDal();
        }
        public DataTable MedicalRecordTable { get; set; }
        public void InsertMedicalRecord()
        {

        }
        public void ViewMedicalRecord()
        {
            this.MedicalRecordTable=this.MedicalRecordDal.Select();
        }
    }
}
