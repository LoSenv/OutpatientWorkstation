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
    public partial class frm_Dhome : Form
    {
        private string _name;
        public
            frm_Dhome(string name) : this()
        {
            this._name = name;
        }
        public frm_Dhome()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_Dhome_Load(object sender, EventArgs e)
        {
            this.lblMsg.Text = _name;
            this.lbl_home.Text = "欢迎"+_name+"进入医生主页！";
        }

        private void tsm_pview_Click(object sender, EventArgs e)
        {
            frm_ViewPatient frm_ViewClient = new frm_ViewPatient();
            frm_ViewClient.TopLevel = false;
            frm_ViewClient.FormBorderStyle = FormBorderStyle.None;
            frm_ViewClient.Dock = DockStyle.Fill;
            this.pnl_content.Controls.Clear();
            this.pnl_content.Controls.Add(frm_ViewClient);
            frm_ViewClient.Show();
        }

        private void tsm_mview_Click(object sender, EventArgs e)
        {
            frm_ViewMedicine frm_ViewMedicine = new frm_ViewMedicine();
            frm_ViewMedicine.TopLevel = false;
            frm_ViewMedicine.FormBorderStyle = FormBorderStyle.None;
            frm_ViewMedicine.Dock = DockStyle.Fill;
            this.pnl_content.Controls.Clear();
            this.pnl_content.Controls.Add(frm_ViewMedicine);
            frm_ViewMedicine.Show();
        }

        private void tsm_oinsert_Click(object sender, EventArgs e)
        {
            frm_InsertOrdonnance frm_InsertOrdonnance = new frm_InsertOrdonnance(this._name);
            frm_InsertOrdonnance.TopLevel = false;
            frm_InsertOrdonnance.FormBorderStyle = FormBorderStyle.None;
            frm_InsertOrdonnance.Dock = DockStyle.Fill;
            this.pnl_content.Controls.Clear();
            this.pnl_content.Controls.Add(frm_InsertOrdonnance);
            frm_InsertOrdonnance.Show();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            frm_Login frm_Login = new frm_Login();
            frm_Login.ShowDialog();
        }

        private void btn_mpwd_Click(object sender, EventArgs e)
        {
            frm_Mpwd frm_Mpwd = new frm_Mpwd(this._name);
            frm_Mpwd.ShowDialog();
        }

        private void tsm_oview_Click(object sender, EventArgs e)
        {
            frm_ViewOrdonnance frm_ViewOrdonnance =new frm_ViewOrdonnance();
            frm_ViewOrdonnance.ShowDialog();
        }

        private void tsm_mRview_Click(object sender, EventArgs e)
        {
            frm_ViewMedicalRecord frm_ViewMedicalRecord =new frm_ViewMedicalRecord();
            frm_ViewMedicalRecord.ShowDialog();
        }

        private void tsm_mRinsert_Click(object sender, EventArgs e)
        {
            frm_InsertMedicalRecord frm_InsertMedicalRecord =new frm_InsertMedicalRecord();
            frm_InsertMedicalRecord.ShowDialog();
        }
    }
}
