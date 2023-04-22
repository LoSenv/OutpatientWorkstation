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
    public partial class frm_Register : Form
    {
        private User User { get; set; }
        private IUserBll UserBll { get; set; }
        public frm_Register()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            UserBll=new UserBll();
            this.txb_name.Validating += this.ValidateUserName;
            this.txb_pwd.Validating += this.ValidatePassword;
            this.txb_check.Validating += this.ValidateCheckPassword;
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
            string username=this.txb_name.Text.Trim();
            string userPassword=this.txb_pwd.Text.Trim();
            string checkPassword=this.txb_check.Text.Trim();
            this.User=this.UserBll.SignUp(username, userPassword,checkPassword);
            MessageBox.Show(this.UserBll.Message);
        }
        /// <summary>
        /// 验证用户号；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateUserName(object sender, CancelEventArgs e)
        {
            string userName = this.txb_name.Text.Trim();
            bool isEmpty = string.IsNullOrEmpty(userName);
            if (isEmpty)
            {
                this.ErrorProvider.SetError(this.txb_name, "用户号不能为空");
                return;
            }
            this.ErrorProvider.SetError(this.txb_name, "");
        }
        /// <summary>
        /// 验证密码；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidatePassword(object sender, CancelEventArgs e)
        {
            string password = this.txb_pwd.Text.Trim();
            bool isEmpty = string.IsNullOrEmpty(password);
            if (isEmpty)
            {
                this.ErrorProvider.SetError(this.txb_pwd, "密码不能为空");
            }
            this.ErrorProvider.SetError(this.txb_pwd, "");
        }
        private void ValidateCheckPassword(object sender, CancelEventArgs e)
        {
            string password = this.txb_pwd.Text.Trim();
            string checkPassword=this.txb_check.Text.Trim();
            if(password != checkPassword)
            {
                this.ErrorProvider.SetError(this.txb_pwd, "密码不一致");
            }
            this.ErrorProvider.SetError(this.txb_check, "");
        }
    }
}
