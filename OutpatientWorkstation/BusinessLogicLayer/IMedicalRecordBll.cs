using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.BusinessLogicLayer
{
    public interface IMedicalRecordBll
    {
        DataTable MedicalRecordTable { get;  }
        void InsertMedicalRecord();
        void ViewMedicalRecord();
    }
}
