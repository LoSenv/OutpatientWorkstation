using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OutpatientWorkstation
{
    public partial class frm_Ahome : Form
    {
        private string _name;
        public frm_Ahome(string name) : this()
        {
            this._name = name;
        }
        public frm_Ahome()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_Ahome_Load(object sender, EventArgs e)
        {
            this.lblMsg.Text = this._name;
            this.lbl_home.Text = $"欢迎{this._name}进入医药管理信息系统！";
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            frm_Login frm_Login = new frm_Login();
            frm_Login.ShowDialog();
            frm_Ahome frm_Ahome = new frm_Ahome();
            frm_Ahome.Close();
        }

        private void btn_mpwd_Click(object sender, EventArgs e)
        {
            frm_AMpwd frm_AMpwd = new frm_AMpwd(this._name);
            frm_AMpwd.TopLevel = false;
            frm_AMpwd.FormBorderStyle = FormBorderStyle.None;
            frm_AMpwd.Dock = DockStyle.Fill;
            this.pnl_content.Controls.Clear();
            this.pnl_content.Controls.Add(frm_AMpwd);
            frm_AMpwd.Show();
        }

        private void tsm_aInsert_Click(object sender, EventArgs e)
        {
            frm_InsertAgency frm_InsertAgency = new frm_InsertAgency();
            frm_InsertAgency.TopLevel = false;
            frm_InsertAgency.FormBorderStyle = FormBorderStyle.None;
            frm_InsertAgency.Dock = DockStyle.Fill;
            this.pnl_content.Controls.Clear();
            this.pnl_content.Controls.Add(frm_InsertAgency);
            frm_InsertAgency.Show();
        }

        private void tsm_pInsert_Click(object sender, EventArgs e)
        {
            frm_InsertPatient frm_InsertClient = new frm_InsertPatient();
            frm_InsertClient.TopLevel = false;
            frm_InsertClient.FormBorderStyle = FormBorderStyle.None;
            frm_InsertClient.Dock = DockStyle.Fill;
            this.pnl_content.Controls.Clear();
            this.pnl_content.Controls.Add(frm_InsertClient);
            frm_InsertClient.Show();
        }

        private void tsm_aModify_Click(object sender, EventArgs e)
        {
            frm_ModifyAgency frm_ModifyAgency = new frm_ModifyAgency();
            frm_ModifyAgency.TopLevel = false;
            frm_ModifyAgency.FormBorderStyle = FormBorderStyle.None;
            frm_ModifyAgency.Dock = DockStyle.Fill;
            this.pnl_content.Controls.Clear();
            this.pnl_content.Controls.Add(frm_ModifyAgency);
            frm_ModifyAgency.Show();
        }

        private void tsm_pModify_Click(object sender, EventArgs e)
        {
            frm_ModifyPatient frm_ModifyClient = new frm_ModifyPatient();
            frm_ModifyClient.TopLevel = false;
            frm_ModifyClient.FormBorderStyle = FormBorderStyle.None;
            frm_ModifyClient.Dock = DockStyle.Fill;
            this.pnl_content.Controls.Clear();
            this.pnl_content.Controls.Add(frm_ModifyClient);
            frm_ModifyClient.Show();
        }

        private void tsm_mModify_Click(object sender, EventArgs e)
        {
            frm_ModifyMedicine frm_ModifyMedicine = new frm_ModifyMedicine();
            frm_ModifyMedicine.TopLevel = false;
            frm_ModifyMedicine.FormBorderStyle = FormBorderStyle.None;
            frm_ModifyMedicine.Dock = DockStyle.Fill;
            this.pnl_content.Controls.Clear();
            this.pnl_content.Controls.Add(frm_ModifyMedicine);
            frm_ModifyMedicine.Show();
        }

        private void tsm_aView_Click(object sender, EventArgs e)
        {
            frm_ViewAgency frm_ViewAgency = new frm_ViewAgency();
            frm_ViewAgency.TopLevel = false;
            frm_ViewAgency.FormBorderStyle = FormBorderStyle.None;
            frm_ViewAgency.Dock = DockStyle.Fill;
            this.pnl_content.Controls.Clear();
            this.pnl_content.Controls.Add(frm_ViewAgency);
            frm_ViewAgency.Show();
        }

        private void tsm_pView_Click(object sender, EventArgs e)
        {
            frm_ViewPatient frm_ViewClient = new frm_ViewPatient();
            frm_ViewClient.TopLevel = false;
            frm_ViewClient.FormBorderStyle = FormBorderStyle.None;
            frm_ViewClient.Dock = DockStyle.Fill;
            this.pnl_content.Controls.Clear();
            this.pnl_content.Controls.Add(frm_ViewClient);
            frm_ViewClient.Show();
        }

        private void tsm_mView_Click(object sender, EventArgs e)
        {
            frm_ViewMedicine frm_ViewMedicine = new frm_ViewMedicine();
            frm_ViewMedicine.TopLevel = false;
            frm_ViewMedicine.FormBorderStyle = FormBorderStyle.None;
            frm_ViewMedicine.Dock = DockStyle.Fill;
            this.pnl_content.Controls.Clear();
            this.pnl_content.Controls.Add(frm_ViewMedicine);
            frm_ViewMedicine.Show();
        }
    }
}
