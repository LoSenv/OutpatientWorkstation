using OutpatientWorkstation.BusinessLogicLayer;
using OutpatientWorkstation.Model;
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
    public partial class frm_InsertMedicalRecord : Form
    {
        private MedicialRecord MedicialRecord { get; set; }
        private IMedicalRecordBll MedicalRecordBll { get; set; }
        public frm_InsertMedicalRecord()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_InsertMedicalRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
