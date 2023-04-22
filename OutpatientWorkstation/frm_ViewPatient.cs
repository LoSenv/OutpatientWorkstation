using OutpatientWorkstation.BusinessLogicLayer;
using OutpatientWorkstation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutpatientWorkstation
{
    public partial class frm_ViewPatient : Form
    {
        private Patient Patient { get; set; }
        private IPatientBll PatientBll { get; set; }
        public frm_ViewPatient()
        {
            InitializeComponent();
            this.PatientBll = new PatientBll();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_ViewPatient_Load(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            this.PatientBll.ViewPatient();
            this.dgv_cInfo.Columns.Clear();
            this.dgv_cInfo.DataSource = this.PatientBll.PatientTable;
        }

        private void btn_SearchByNo_Click(object sender, EventArgs e)
        {
            string no=this.txb_no.Text.Trim();
            this.PatientBll.ViewPatient();
            this.PatientBll.SelectByNo(no);
            this.dgv_cInfo.DataSource = this.PatientBll.ResultTable;
        }

        private void btn_SearchByName_Click(object sender, EventArgs e)
        {

        }
    }
}
