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
    public partial class frm_InsertAgency : Form
    {
        public frm_InsertAgency()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_InsertAgency_Load(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.DisplayAgencyType();
            admin.DisplayTechnicalOffice();
            this.cbo_type.DataSource = admin.AgencyTypeTable;
            this.cbo_type.DisplayMember = "Type";
            this.cbo_type.ValueMember = "No";
            this.cbo_techOffice.DataSource = admin.TechnicalOfficeTable;
            this.cbo_techOffice.DisplayMember = "Name";
            this.cbo_techOffice.ValueMember = "No";
            this.cbo_type.SelectedIndex = -1;
            this.cbo_techOffice.SelectedIndex = -1;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.AgencyTypeNo = (int)this.cbo_type.SelectedValue;
            admin.AgencyName = this.txb_name.Text.Trim();
            admin.AgencyGender = this.rdb_male.Checked;
            admin.AgencyPhone=this.txb_phone.Text.Trim();
            admin.TechnicalOfficeNo= (int)this.cbo_techOffice.SelectedValue;
            admin.AgencyRemark=this.txb_remark.Text.Trim();
            admin.InsertAgency();
            MessageBox.Show(admin.Message);
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            this.cbo_type.SelectedValue = null;
            this.txb_name.Text = null;
            this.rdb_famale.Checked = false;
            this.rdb_male.Checked = false;
            this.txb_phone.Text = null;
            this.txb_remark.Text = null;
        }
    }
}
