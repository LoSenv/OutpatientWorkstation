namespace OutpatientWorkstation
{
    partial class frm_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_reg = new System.Windows.Forms.Button();
            this.btn_alogin = new System.Windows.Forms.Button();
            this.txb_pwd = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = true;
            this.btn_login.Location = new System.Drawing.Point(212, 232);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 25);
            this.btn_login.TabIndex = 19;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_reg
            // 
            this.btn_reg.AutoSize = true;
            this.btn_reg.Location = new System.Drawing.Point(334, 232);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(77, 25);
            this.btn_reg.TabIndex = 18;
            this.btn_reg.Text = "立即注册";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // btn_alogin
            // 
            this.btn_alogin.AutoSize = true;
            this.btn_alogin.Location = new System.Drawing.Point(435, 232);
            this.btn_alogin.Name = "btn_alogin";
            this.btn_alogin.Size = new System.Drawing.Size(105, 25);
            this.btn_alogin.TabIndex = 17;
            this.btn_alogin.Text = "管理员登录";
            this.btn_alogin.UseVisualStyleBackColor = true;
            this.btn_alogin.Click += new System.EventHandler(this.btn_alogin_Click);
            // 
            // txb_pwd
            // 
            this.txb_pwd.Location = new System.Drawing.Point(278, 160);
            this.txb_pwd.Name = "txb_pwd";
            this.txb_pwd.Size = new System.Drawing.Size(100, 25);
            this.txb_pwd.TabIndex = 16;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(278, 100);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(100, 25);
            this.txb_name.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "用户名：";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.btn_alogin);
            this.Controls.Add(this.txb_pwd);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Login";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Button btn_alogin;
        private System.Windows.Forms.TextBox txb_pwd;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}

