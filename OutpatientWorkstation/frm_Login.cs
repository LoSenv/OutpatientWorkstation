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
    public partial class frm_Login : Form
    {
        private User User { get; set; }
        private IUserBll UserBll { get; set; }
        public frm_Login()
        {
            InitializeComponent();
            UserBll= new UserBll();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.txb_name.Validating += this.ValidateUserName;
            this.txb_pwd.Validating += this.ValidatePassowrd;
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Click(object sender, EventArgs e)
        {
            string usrName=this.txb_name.Text;
            string password=this.txb_pwd.Text;
            this.User=this.UserBll.LogIn(usrName,password);
            MessageBox.Show(this.UserBll.Message);
            if(!this.UserBll.HasLoggedIn)
            {
                this.txb_pwd.Focus();
                this.txb_pwd.SelectAll();
                return;
            }
            if(UserBll.AgencyTypeNo==1)
            {
                frm_Dhome frm_Dhome = new frm_Dhome(usrName);
                frm_Dhome.ShowDialog();
            }
            else
            {
                frm_Rhome frm_Rhome = new frm_Rhome(usrName);
                frm_Rhome.ShowDialog();
            }
        }
        /// <summary>
        /// 验证用户名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateUserName(object sender,CancelEventArgs e)
        {
            string userName=this.txb_name.Text;
            bool isEmpty=string.IsNullOrEmpty(userName);
            if(isEmpty)
            {
                this.ErrorProvider.SetError(this.txb_name, "用户名不能为空！");
                return;
            }
            bool isExisting=this.UserBll.CheckExist(userName);
            if(!isExisting)
            {
                this.ErrorProvider.SetError(this.txb_name, "该用户不存在！");
                return;
            }
            this.ErrorProvider.SetError(this.txb_name,"");
        }
        /// <summary>
        /// 验证密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidatePassowrd(object sender,CancelEventArgs e)
        {
            string password=this.txb_pwd.Text;
            bool isEmpty=string.IsNullOrEmpty (password);
            if(isEmpty)
            {
                this.ErrorProvider.SetError(this.txb_pwd, "密码不能为空！");
                return;
            }
            this.ErrorProvider.SetError(this.txb_pwd,"");
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
