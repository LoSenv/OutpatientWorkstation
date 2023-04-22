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
    public partial class frm_Rhome : Form
    {
        private User User { get; set; }
        private IUserBll UserBll { get; set; }
        private Register Register { get; set; }
        private IRegisterBll RegisterBll { get; set; }
        private string _name;
        public 
            frm_Rhome(string name):this()
        {
            this._name= name;
        }
        public frm_Rhome()
        {
            InitializeComponent();
            this.UserBll = new UserBll();
            this.RegisterBll=new RegisterBll();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_Rhome_Load(object sender, EventArgs e)
        {
            this.RegisterBll.LoadInfo();
            this.cbo_techOffice.DataSource = this.RegisterBll.TechnicalOfficeTable;
            this.cbo_techOffice.DisplayMember = "Name";
            this.cbo_techOffice.ValueMember = "No";
            this.cbo_techOffice.SelectedIndex = -1;
            this.cbo_doctor.DataSource =this.RegisterBll.DoctorTable;
            this.cbo_doctor.DisplayMember = "Name";
            this.cbo_doctor.ValueMember = "No";
            this.cbo_doctor.SelectedIndex = -1;
            this.dgv_reg.Columns.Clear();
            this.dgv_reg.DataSource = this.RegisterBll.RegisterTable;
            this.dgv_reg.Columns["RNo"].HeaderText = "编号";
            this.dgv_reg.Columns["PName"].HeaderText = "病人姓名";
            this.dgv_reg.Columns["AName"].HeaderText = "医生姓名";
            this.dgv_reg.Columns["TName"].HeaderText = "科室名称";
            this.dgv_reg.Columns["RRemark"].HeaderText = "备注";
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            string name=this.txb_name.Text.Trim();
            Patient patient = this.RegisterBll.LoadPatient(name);
            this.txb_no.Text = patient.No.ToString();
            this.rdb_male.Checked = (bool)patient.Gender;
            this.rdb_female.Checked = !(bool)patient.Gender;
            this.dtp_date.Text = patient.BirthDate.ToLongDateString();
            this.txb_phone.Text = patient.Phone.ToString();
            this.txb_adress.Text = patient.Adress.ToString();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
             
            string patientNo = this.txb_no.Text.Trim();
            string technicalOfficeNo = this.cbo_techOffice.SelectedValue.ToString();
            string doctorNo = this.cbo_doctor.SelectedValue.ToString();
            string registrarNo = this.UserBll.SelectUserNo(this._name).ToString();
            string registerPrice = this.cbo_price.SelectedItem.ToString();
            string remark = this.txb_remark.Text.Trim();
            this.RegisterBll.Register(patientNo, technicalOfficeNo, doctorNo, registrarNo, registerPrice, remark);
            MessageBox.Show(this.RegisterBll.Message);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.dgv_reg.Columns.Clear();
            this.dgv_reg.DataSource = this.RegisterBll.RegisterTable;
            this.dgv_reg.Columns["RNo"].HeaderText = "编号";
            this.dgv_reg.Columns["PName"].HeaderText = "病人姓名";
            this.dgv_reg.Columns["AName"].HeaderText = "医生姓名";
            this.dgv_reg.Columns["TName"].HeaderText = "科室名称";
            this.dgv_reg.Columns["RRemark"].HeaderText = "备注";
            this.dgv_reg.Columns["RDateTime"].HeaderText = "挂号时间";
        }
    }
}
