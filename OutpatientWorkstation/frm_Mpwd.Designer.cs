namespace OutpatientWorkstation
{
    partial class frm_Mpwd
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
            this.btn_reset = new System.Windows.Forms.Button();
            this.txb_check = new System.Windows.Forms.TextBox();
            this.txb_new = new System.Windows.Forms.TextBox();
            this.txb_old = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_modify = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(360, 254);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 23;
            this.btn_reset.Text = " 重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txb_check
            // 
            this.txb_check.Location = new System.Drawing.Point(319, 183);
            this.txb_check.Name = "txb_check";
            this.txb_check.Size = new System.Drawing.Size(100, 25);
            this.txb_check.TabIndex = 22;
            // 
            // txb_new
            // 
            this.txb_new.Location = new System.Drawing.Point(319, 150);
            this.txb_new.Name = "txb_new";
            this.txb_new.Size = new System.Drawing.Size(100, 25);
            this.txb_new.TabIndex = 21;
            // 
            // txb_old
            // 
            this.txb_old.Location = new System.Drawing.Point(319, 116);
            this.txb_old.Name = "txb_old";
            this.txb_old.Size = new System.Drawing.Size(100, 25);
            this.txb_old.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "确认密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "新密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "旧密码：";
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(238, 254);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(75, 23);
            this.btn_modify.TabIndex = 16;
            this.btn_modify.Text = "修改";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // frm_Mpwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txb_check);
            this.Controls.Add(this.txb_new);
            this.Controls.Add(this.txb_old);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modify);
            this.Name = "frm_Mpwd";
            this.Text = "员工修改密码";
            this.Load += new System.EventHandler(this.frm_Mpwd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txb_check;
        private System.Windows.Forms.TextBox txb_new;
        private System.Windows.Forms.TextBox txb_old;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}