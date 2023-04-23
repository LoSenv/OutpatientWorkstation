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
    public class RegisterBll:IRegisterBll
    {
        private IRegisterDal RegisterDal { get; set; }
        public RegisterBll() 
        {
            this.RegisterDal = new RegisterDal();
        }
        public string Message { get; set; }
        public DataTable TechnicalOfficeTable { get; set; }
        public DataTable DoctorTable { get; set; }
        public DataTable RegisterTable { get; set; }
        public void LoadInfo()
        {
            this.TechnicalOfficeTable = this.RegisterDal.SelectTechnicalOfficeTable();
            this.DoctorTable = this.RegisterDal.SelectDoctorTable();
            this.RegisterTable = this.RegisterDal.SelectRegisterTable();
        }
        public Patient LoadPatient(string name)
        {
            return this.RegisterDal.SelectPatient(name);
        }
        public void Register(string patientNo, string technicalOfficeNo, string doctorNo, string registrarNo, string registerPrice, string remark, DateTime dateTime)
        {
            int count = this.RegisterDal.Insert(patientNo,technicalOfficeNo,doctorNo,registrarNo,registerPrice,remark,dateTime);
            if (count == 1)
            {
               this.Message="挂号成功！";
            }
            else
            {
                this.Message="挂号失败！";
            }
        }
        public void Refesh()
        {
           this.RegisterTable=this.RegisterDal.SelectRegisterTable();
        }
    }
}
