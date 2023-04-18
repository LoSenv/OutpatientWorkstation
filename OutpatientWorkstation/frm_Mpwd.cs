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
using System.Xml.Serialization;

namespace OutpatientWorkstation
{
    public partial class frm_Mpwd : Form
    {
        private User User { get; set; }
        private IUserBll UserBll { get; set; }
        private string _userName;
        public frm_Mpwd(string userName):this()
        {
            this._userName= userName;
        }
        public frm_Mpwd()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            UserBll= new UserBll();
            this.txb_old.Validating += this.ValidateUserOldPassword;
            this.txb_new.Validating+= this.ValidateUserNewPassword;
            this.txb_check.Validating += this.ValidateUserCheckPassword;
        }

        private void frm_Mpwd_Load(object sender, EventArgs e)
        {

        }
        private void btn_modify_Click(object sender, EventArgs e)
        {
            string oldPassword = this.txb_old.Text.Trim();
            string newPassword= this.txb_new.Text.Trim();
            string checkPassword= this.txb_check.Text.Trim();
            this.User=this.UserBll.ModifyPassword(_userName,oldPassword, newPassword, checkPassword);
            MessageBox.Show(this.UserBll.Message);
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.txb_old.Text = null;
            this.txb_new.Text = null;
            this.txb_check.Text = null;
        }
        private void ValidateUserOldPassword(object sender,CancelEventArgs e)
        {
            string oldPassword = this.txb_old.Text.Trim();
            bool isEmpty=string.IsNullOrEmpty(oldPassword);
            if (isEmpty)
            {
                ErrorProvider.SetError(this.txb_old, "旧密码不能为空！");
                return;
            }
            ErrorProvider.SetError(this.txb_old, "");
        }
        private void ValidateUserNewPassword(object sender,CancelEventArgs e)
        {
            string newPassword=this.txb_new.Text.Trim();
            bool isEmpty=string.IsNullOrEmpty(newPassword);
            if (isEmpty)
            {
                ErrorProvider.SetError(this.txb_new, "新密码不能为空！");
                return;
            }
            ErrorProvider.SetError(this.txb_new, "");
        }
        private void ValidateUserCheckPassword(object sender,CancelEventArgs e)
        {
            string newPasword=this.txb_new.Text.Trim();
            string checkPassword=this.txb_check.Text.Trim();
            bool isEmpty=string.IsNullOrEmpty(checkPassword);
            if (isEmpty)
            {
                ErrorProvider.SetError(this.txb_check, "请填写确认密码！");
                return;
            }
            bool isExqual = this.UserBll.CheckEqual(newPasword, checkPassword);
            if(!isExqual)
            {
                ErrorProvider.SetError(this.txb_check, "密码不一致！");
                return;
            }
            ErrorProvider.SetError(this.txb_check, "");
        }

    }
}
