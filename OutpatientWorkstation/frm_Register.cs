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
    public partial class frm_Register : Form
    {
        public frm_Register()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_Register_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            frm_Login frm_Login = new frm_Login();
            frm_Login.ShowDialog();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.SignUp(this.txb_name.Text.Trim(), this.txb_pwd.Text.Trim(), this.txb_check.Text.Trim());
            MessageBox.Show(user.Message);
        }
    }
}
