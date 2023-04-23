using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientWorkstation.DataAccessLayer
{
    public  interface IAdminDal
    {
        Admin Select(string adminName);
        int SelectCount(string adminName);
        int UpdatePassword(string name, string password);

    }
}
