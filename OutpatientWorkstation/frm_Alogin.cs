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
    public partial class frm_Alogin : Form
    {
        public frm_Alogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_Alogin_Load(object sender, EventArgs e)
        {

        }

        private void frm_login_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Name = this.txb_name.Text.Trim();
            admin.Password = this.txb_pwd.Text.Trim();
            if (!admin.Login())
            {
                this.txb_pwd.Focus();
                this.txb_pwd.SelectAll();
                return;
            }
            MessageBox.Show(admin.Message);
            frm_Ahome frm_Ahome = new frm_Ahome(this.txb_name.Text.Trim());
            frm_Ahome.ShowDialog();
        }
    }
}
