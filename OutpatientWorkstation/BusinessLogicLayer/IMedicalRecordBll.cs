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
        void InsertMedicalRecord(string name, string doctorName, string situation, string registerNo);
        void ViewMedicalRecord();
    }
}
