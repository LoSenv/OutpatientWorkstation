using OutpatientWorkstation.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.DataAccessLayer
{
    public interface IMedicineDal
    {
        DataTable SelectMedicineTable();
        DataTable SelectUnitTable();
        int Update(DataTable medicineTable);
        int Delete(DataTable medicineTable);
    }
}
