namespace OutpatientWorkstation
{
    partial class frm_Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_sign = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_check = new System.Windows.Forms.TextBox();
            this.btn_reg = new System.Windows.Forms.Button();
            this.txb_pwd = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sign
            // 
            this.btn_sign.Location = new System.Drawing.Point(329, 285);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(75, 23);
            this.btn_sign.TabIndex = 25;
            this.btn_sign.Text = "前往登录";
            this.btn_sign.UseVisualStyleBackColor = true;
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "确认密码：";
            // 
            // txb_check
            // 
            this.txb_check.Location = new System.Drawing.Point(311, 229);
            this.txb_check.Name = "txb_check";
            this.txb_check.Size = new System.Drawing.Size(100, 25);
            this.txb_check.TabIndex = 23;
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(230, 285);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(75, 23);
            this.btn_reg.TabIndex = 22;
            this.btn_reg.Text = "注册";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // txb_pwd
            // 
            this.txb_pwd.Location = new System.Drawing.Point(311, 177);
            this.txb_pwd.Name = "txb_pwd";
            this.txb_pwd.Size = new System.Drawing.Size(100, 25);
            this.txb_pwd.TabIndex = 21;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(311, 117);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(100, 25);
            this.txb_name.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "用户名：";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_check);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.txb_pwd);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Register";
            this.Text = "用户注册";
            this.Load += new System.EventHandler(this.frm_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_check;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.TextBox txb_pwd;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}