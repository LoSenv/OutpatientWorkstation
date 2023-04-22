using OutpatientWorkstation.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace OutpatientWorkstation
{
    public partial class frm_InsertAgency : Form
    {
        private User User { get; set; }
        private IUserBll UserBll { get; set; }
        public frm_InsertAgency()
        {
            InitializeComponent();
            this.UserBll= new UserBll();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_InsertAgency_Load(object sender, EventArgs e)
        {
            this.UserBll.InsertAgencyInfo();
            this.cbo_type.DataSource = this.UserBll.AgencyTypeTable;
            this.cbo_type.DisplayMember = "Type";
            this.cbo_type.ValueMember = "No";
            this.cbo_techOffice.DataSource = this.UserBll.TechnicalOfficeTable;
            this.cbo_techOffice.DisplayMember = "Name";
            this.cbo_techOffice.ValueMember = "No";
            this.cbo_type.SelectedIndex = -1;
            this.cbo_techOffice.SelectedIndex = -1;
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            int agencyTypeNo = (int)this.cbo_type.SelectedValue;
            string name = this.txb_name.Text.Trim();
            bool gender = this.rdb_male.Checked;
            string phone = this.txb_phone.Text.Trim();
            int technicalOfficeNo = (int)this.cbo_techOffice.SelectedValue;
            string remark = this.txb_remark.Text.Trim();
            this.UserBll.InsertAgency(agencyTypeNo, name, gender, phone, technicalOfficeNo, remark);
            MessageBox.Show(this.UserBll.Message);
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
