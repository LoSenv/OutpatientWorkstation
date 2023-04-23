using OutpatientWorkstation.DataAccessLayer;
using OutpatientWorkstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.BusinessLogicLayer
{
    public class OrdonnanceBll:IOrdonnanceBll
    {
        private OrdonnanceDal OrdonnanceDal { get; set; }
        public OrdonnanceBll()
        {
            this.OrdonnanceDal = new OrdonnanceDal();
        }
        public bool HasInsert { get; set; }
        public string Message { get; set; }
        private void HandleOrdonnanceExist(int no)
        {
            if (no.ToString()!= null)
            {
                string errorMessage = "该处方已存在！";
                throw new ApplicationException(errorMessage);
            }
        }
        public Ordonnance InsertOrdonnance(int no,int patientNo,int agencyNo,DateTime date)
        {
            this.HasInsert= false;
            Ordonnance ordonnance = new Ordonnance()
            {
                No = no,
                PatientNo = patientNo,
                AgencyNo = agencyNo,
                Date = date
            };
            try
            {
                this.HandleOrdonnanceExist(no);
                this.OrdonnanceDal.Insert(ordonnance);
                this.HasInsert= true;
                this.Message = "新增处方成功！";
            }
            catch(ApplicationException ex)
            {
                this.Message = $"{ex.Message}\n新增处方失败！";
            }
            catch(Exception)
            {
                this.Message = "新增处方失败！";
            }
            return ordonnance;
        }
    }
}
