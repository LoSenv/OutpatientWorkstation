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
    public partial class frm_Alogin : Form
    {
        private Admin Admin { get; set; }
        private IAdminBll AdminBll { get; set; }
        public frm_Alogin()
        {
            InitializeComponent();
            AdminBll = new AdminBll();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.txb_name.Validating += this.ValidateAdminName;
            this.txb_pwd.Validating += this.ValidatePassword;
        }

        private void frm_Alogin_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_login_Click(object sender, EventArgs e)
        {
            string adminName=this.txb_name.Text;
            string password=this.txb_pwd.Text;
            this.Admin=this.AdminBll.LogIn(adminName, password);
            MessageBox.Show(AdminBll.Message);
            if(!AdminBll.HasLoggedIn)
            {
                this.txb_pwd.Focus();
                this.txb_pwd.SelectAll();
                return;
            }
            frm_Ahome frm_Ahome = new frm_Ahome(adminName);
            frm_Ahome.ShowDialog();
        }
        /// <summary>
        /// 验证用户名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateAdminName(object sender,CancelEventArgs e)
        {
            string adminName=this.txb_name.Text;
            bool isEmpty=string.IsNullOrEmpty(adminName);
            if(isEmpty)
            {
                ErrorProvider.SetError(this.txb_name, "用户名不能为空！");
                return;
            }
            bool isExist=this.AdminBll.CheckExist(adminName);
            if(!isExist)
            {
                ErrorProvider.SetError(this.txb_name, "该用户不存在！");
                return;
            }
            ErrorProvider.SetError(this.txb_name, "");
        }
        /// <summary>
        /// 验证密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidatePassword(object sender,CancelEventArgs e)
        {
            string password=this.txb_pwd.Text;
            bool isEmpty=string.IsNullOrEmpty(password);
            if(isEmpty)
            {
                ErrorProvider.SetError(this.txb_pwd, "密码不能为空！");
                return;
            }
            ErrorProvider.SetError(this.txb_pwd, "");
        }
    }
}
