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
        public frm_AMpwd(string name):this()
        {
            this._name= name;
        }
        public frm_AMpwd()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_AMpwd_Load(object sender, EventArgs e)
        {

        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            //Admin admin= new Admin();
            //admin.Name = _name;
            //admin.OldPassword=this.txb_old.Text.Trim();
            //admin.NewPassword=this.txb_new.Text.Trim();
            //admin.CheckPassword=this.txb_check.Text.Trim();
            //if(!admin.ModifyPassword())
            //{
            //    this.txb_old.Focus();
            //    this.txb_old.SelectAll();
            //    return;
            //}
            //MessageBox.Show(admin.Message);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.txb_old.Text = null;
            this.txb_new.Text = null;
            this.txb_check.Text = null;
        }
    }
}
