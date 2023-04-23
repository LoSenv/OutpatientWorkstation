using OutpatientWorkstation.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutpatientWorkstation.BusinessLogicLayer
{
    public class MedicalRecordBll:IMedicalRecordBll
    {
        private IMedicalRecordDal MedicalRecordDal { get; set; }
        public MedicalRecordBll() 
        {
            this.MedicalRecordDal = new MedicalRecordDal();
        }
        public string Message { get; set; }
        public DataTable MedicalRecordTable { get; set; }
        public void InsertMedicalRecord(string name, string doctorName, string situation, string registerNo)
        {
            int count=this.MedicalRecordDal.Insert(name,doctorName,situation,registerNo);
            if (count == 1)
            {
                this.Message="病历保存成功！";
            }
            else
            {
                MessageBox.Show("病历保存失败！");
            }
        }
        public void ViewMedicalRecord()
        {
            this.MedicalRecordTable=this.MedicalRecordDal.SelectMedicalRecord();
        }
    }
}
