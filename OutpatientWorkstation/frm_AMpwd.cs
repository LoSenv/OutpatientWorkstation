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

namespace OutpatientWorkstation
{
    public partial class frm_AMpwd : Form
    {
        private string _name;
        private Admin Admin { get; set; }
        private IAdminBll AdminBll { get; set; }
        public frm_AMpwd(string name):this()
        {
            this._name= name;
        }
        public frm_AMpwd()
        {
            InitializeComponent();
            this.AdminBll = new AdminBll();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_AMpwd_Load(object sender, EventArgs e)
        {

        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            string oldPassword=this.txb_old.Text.Trim();
            string newPassword=this.txb_new.Text.Trim();
            string checkPassword=this.txb_check.Text.Trim();
            this.AdminBll.ModifyPassword(this._name,oldPassword, newPassword, checkPassword);
            MessageBox.Show(this.AdminBll.Message);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.txb_old.Text = null;
            this.txb_new.Text = null;
            this.txb_check.Text = null;
        }
    }
}
