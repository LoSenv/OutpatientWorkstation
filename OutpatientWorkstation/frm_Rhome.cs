using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutpatientWorkstation
{
    public partial class frm_Rhome : Form
    {
        private string _name;
        public 
            frm_Rhome(string name):this()
        {
            this._name= name;
        }
        public frm_Rhome()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_Rhome_Load(object sender, EventArgs e)
        {

        }
    }
}
