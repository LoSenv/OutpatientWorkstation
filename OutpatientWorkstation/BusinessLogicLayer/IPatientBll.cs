using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.BusinessLogicLayer
{
    public interface IPatientBll
    {
        DataView PatientViewByName { get;}
        DataTable PatientTable { get; }
        DataRow ResultRow { get;  }
        DataTable ResultTable { get; }
        void ViewPatient();
        void SelectByNo(string no);
    }
}
