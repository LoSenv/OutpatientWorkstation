using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.BusinessLogicLayer
{
    public interface IOrdonnanceDetailBll
    {
         DataTable MedicineTable { get; }
         DataTable ListTable { get;  }
         DataTable UseMethodTable { get;  }
         DataTable UseFrequencyTable { get;  }
        DataTable OrdonnanceDetailTable { get; }
        string Message { get;  }
        bool CheckOrdonnanceNoNull(int ordonnanceNo);
        void Select(int ordonnanceNo);
        void InsertOrdonnanceDetail(int ordonnanceNo);
        void SelectOrdonnanceDetail();
    }
}
