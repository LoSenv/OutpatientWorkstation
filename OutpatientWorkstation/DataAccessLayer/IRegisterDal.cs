using OutpatientWorkstation.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.DataAccessLayer
{
    public interface IRegisterDal
    {
        DataTable SelectTechnicalOfficeTable();
        DataTable SelectDoctorTable();
        DataTable SelectRegisterTable();
        Patient SelectPatient(string name);
        int Insert(string patientNo, string technicalOfficeNo, string doctorNo, string registrarNo, string registerPrice, string remark);
    }
}
