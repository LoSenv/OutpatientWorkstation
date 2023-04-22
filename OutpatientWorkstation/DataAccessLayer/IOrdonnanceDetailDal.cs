using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.DataAccessLayer
{
    public interface IOrdonnanceDetailDal
    {
        DataTable SelectMedicineTable();
        DataTable SelectListTable(int ordonnanceNo);
        DataTable SelectUseMethodTable();
        DataTable SelectFrequencyTable();
        int Insert(DataTable listTable, int ordonnanceNo);
        DataTable SelectOrdonnanceDetail();
    }
}
