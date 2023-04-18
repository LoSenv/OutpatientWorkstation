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
        public frm_ViewPatient()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_ViewPatient_Load(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            //Admin admin = new Admin();
            //admin.ViewPatient();
            //admin.PatientViewByName = new DataView();
            //admin.PatientViewByName.Table = admin.PatientTable;
            //admin.PatientViewByName.Sort = "姓名 ASC";
            //this.dgv_cInfo.Columns.Clear();
            //this.dgv_cInfo.DataSource = admin.PatientTable;
        }

        private void btn_SearchByNo_Click(object sender, EventArgs e)
        {
            //Admin admin = new Admin();
            //admin.ViewPatient();
            //admin.SelectPatientByNo(this.txb_no.Text.Trim(),admin.PatientTable);
            //this.dgv_cInfo.DataSource = admin.ResultTable;
        }

        private void btn_SearchByName_Click(object sender, EventArgs e)
        {
            //Admin admin= new Admin();
            //admin.ViewPatient();
            //admin.SelectPatientByName(this.txb_name.Text.Trim(),admin.PatientViewByName);
            //this.dgv_cInfo.DataSource = admin.ResultTable;
        }
    }
}
