using OutpatientWorkstation.BusinessLogicLayer;
using OutpatientWorkstation.DataAccessLayer;
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
    public partial class frm_ViewMedicalRecord : Form
    {
        private MedicialRecord MedicalRecord { get; set; }
        private IMedicalRecordBll MedicalRecordBll { get; set; }
        public frm_ViewMedicalRecord()
        {
            InitializeComponent();
            MedicalRecordBll = new MedicalRecordBll();
            this.StartPosition= FormStartPosition.CenterScreen;
        }

        private void frm_ViewMedicalRecord_Load(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            this.MedicalRecordBll.ViewMedicalRecord();
            this.dgv_medicalRecord.DataSource = this.MedicalRecordBll.MedicalRecordTable;
            this.dgv_medicalRecord.Columns["MRNo"].HeaderText = "病历编号";
            this.dgv_medicalRecord.Columns["PName"].HeaderText = "病人名称";
            this.dgv_medicalRecord.Columns["RNo"].HeaderText = "挂号编号";
            this.dgv_medicalRecord.Columns["MRName"].HeaderText = "病历名称";
            this.dgv_medicalRecord.Columns["AName"].HeaderText = "医生名称";
        }
    }
}
