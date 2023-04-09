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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name=this.txb_name.Text.Trim();
            user.Password=this.txb_pwd.Text.Trim();
            if(!user.LogIn())
            {
                this.txb_pwd.Focus();
                this.txb_pwd.SelectAll();
                return;
            }
            MessageBox.Show(user.Message);
            if (user.Result == 1)
            {
                frm_Dhome frm_Dhome = new frm_Dhome(this.Name);
                frm_Dhome.ShowDialog();
            }
            if (user.Result == 2)
            {
                frm_Rhome frm_Rhome = new frm_Rhome(this.Name);
                frm_Rhome.ShowDialog();
            }
        }

        private void btn_alogin_Click(object sender, EventArgs e)
        {
            frm_Alogin frm_Alogin = new frm_Alogin();
            frm_Alogin.ShowDialog();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            frm_Register frm_Register= new frm_Register();
            frm_Register.ShowDialog();
        }
    }
}
