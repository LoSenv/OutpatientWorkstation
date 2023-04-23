using OutpatientWorkstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.DataAccessLayer
{
    public interface IOrdonnanceDal
    {
        int SelectCount(int no);
        int Insert(Ordonnance ordonnance);
    }
}
