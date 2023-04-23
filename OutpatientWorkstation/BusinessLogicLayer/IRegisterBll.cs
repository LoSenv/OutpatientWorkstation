using OutpatientWorkstation.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.BusinessLogicLayer
{
    public interface IRegisterBll
    {
        string Message { get;  }
        DataTable TechnicalOfficeTable { get; }
        DataTable DoctorTable { get; }
        DataTable RegisterTable { get; }
        void LoadInfo();
        Patient LoadPatient(string name);
        void Register(string patientNo, string technicalOfficeNo, string doctorNo, string registrarNo, string registerPrice, string remark, DateTime dateTime);
    }
}
