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
    public partial class frm_InsertPatient : Form
    {
        public frm_InsertPatient()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_InsertPatient_Load(object sender, EventArgs e)
        {
            
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.PatientName = this.txb_name.Text.Trim();
            admin.BirthDate = this.dtp_date.Value;
            admin.PatientGender = this.rdb_male.Checked;
            admin.PatientPhone = this.txb_phone.Text.Trim();
            admin.PatientAdress = this.txb_adress.Text.Trim();
            admin.InsertPatient();
            MessageBox.Show(admin.Message);
        }
        private void btn_set_Click(object sender, EventArgs e)
        {
            this.txb_name.Text = null;
            this.dtp_date.Text = null;
            this.rdb_male.Checked = false;
            this.rdb_female.Checked = false;
            this.txb_phone.Text = null;
            this.txb_adress.Text = null;
        }
       
    }
}
