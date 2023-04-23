using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.DataAccessLayer
{
    public interface IMedicalRecordDal
    {
        int Insert(string name, string doctorName, string situation, string registerNo);
        DataTable SelectMedicalRecord();
    }
}
