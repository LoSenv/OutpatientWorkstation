namespace OutpatientWorkstation
{
    partial class frm_Dhome
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
            this.pnl_content = new System.Windows.Forms.Panel();
            this.lbl_home = new System.Windows.Forms.Label();
            this.btn_mpwd = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_out = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.病历管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_mRinsert = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_mRview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.tsm_view = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_pview = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_mview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_ordonnance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_oinsert = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_oview = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_content.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_content
            // 
            this.pnl_content.Controls.Add(this.lbl_home);
            this.pnl_content.Location = new System.Drawing.Point(179, 34);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(1085, 415);
            this.pnl_content.TabIndex = 24;
            // 
            // lbl_home
            // 
            this.lbl_home.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_home.AutoSize = true;
            this.lbl_home.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_home.Location = new System.Drawing.Point(14, 51);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(0, 37);
            this.lbl_home.TabIndex = 0;
            // 
            // btn_mpwd
            // 
            this.btn_mpwd.AutoSize = true;
            this.btn_mpwd.Location = new System.Drawing.Point(1187, 3);
            this.btn_mpwd.Name = "btn_mpwd";
            this.btn_mpwd.Size = new System.Drawing.Size(77, 25);
            this.btn_mpwd.TabIndex = 23;
            this.btn_mpwd.Text = "修改密码";
            this.btn_mpwd.UseVisualStyleBackColor = true;
            this.btn_mpwd.Click += new System.EventHandler(this.btn_mpwd_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(1079, 3);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 15);
            this.lblMsg.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1006, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "用户名：";
            // 
            // btn_out
            // 
            this.btn_out.AutoSize = true;
            this.btn_out.Location = new System.Drawing.Point(1125, 3);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(56, 25);
            this.btn_out.TabIndex = 20;
            this.btn_out.Text = "注销";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Controls.Add(this.menuStrip4);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(7, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 415);
            this.panel1.TabIndex = 19;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.病历管理ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 56);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(169, 28);
            this.menuStrip2.TabIndex = 13;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 病历管理ToolStripMenuItem
            // 
            this.病历管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_mRinsert,
            this.tsm_mRview});
            this.病历管理ToolStripMenuItem.Name = "病历管理ToolStripMenuItem";
            this.病历管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.病历管理ToolStripMenuItem.Text = "病历管理";
            // 
            // tsm_mRinsert
            // 
            this.tsm_mRinsert.Name = "tsm_mRinsert";
            this.tsm_mRinsert.Size = new System.Drawing.Size(224, 26);
            this.tsm_mRinsert.Text = "填写病历";
            // 
            // tsm_mRview
            // 
            this.tsm_mRview.Name = "tsm_mRview";
            this.tsm_mRview.Size = new System.Drawing.Size(224, 26);
            this.tsm_mRview.Text = "浏览病历";
            this.tsm_mRview.Click += new System.EventHandler(this.tsm_mRview_Click);
            // 
            // menuStrip4
            // 
            this.menuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_view});
            this.menuStrip4.Location = new System.Drawing.Point(0, 28);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(169, 28);
            this.menuStrip4.TabIndex = 10;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // tsm_view
            // 
            this.tsm_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_pview,
            this.tsm_mview});
            this.tsm_view.Name = "tsm_view";
            this.tsm_view.Size = new System.Drawing.Size(83, 24);
            this.tsm_view.Text = "信息浏览";
            // 
            // tsm_pview
            // 
            this.tsm_pview.Name = "tsm_pview";
            this.tsm_pview.Size = new System.Drawing.Size(182, 26);
            this.tsm_pview.Text = "浏览病人信息";
            this.tsm_pview.Click += new System.EventHandler(this.tsm_pview_Click);
            // 
            // tsm_mview
            // 
            this.tsm_mview.Name = "tsm_mview";
            this.tsm_mview.Size = new System.Drawing.Size(182, 26);
            this.tsm_mview.Text = "浏览药品信息";
            this.tsm_mview.Click += new System.EventHandler(this.tsm_mview_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_ordonnance});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(169, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsm_ordonnance
            // 
            this.tsm_ordonnance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_oinsert,
            this.tsm_oview});
            this.tsm_ordonnance.Name = "tsm_ordonnance";
            this.tsm_ordonnance.Size = new System.Drawing.Size(83, 24);
            this.tsm_ordonnance.Text = "处方管理";
            // 
            // tsm_oinsert
            // 
            this.tsm_oinsert.Name = "tsm_oinsert";
            this.tsm_oinsert.Size = new System.Drawing.Size(152, 26);
            this.tsm_oinsert.Text = "新增处方";
            this.tsm_oinsert.Click += new System.EventHandler(this.tsm_oinsert_Click);
            // 
            // tsm_oview
            // 
            this.tsm_oview.Name = "tsm_oview";
            this.tsm_oview.Size = new System.Drawing.Size(152, 26);
            this.tsm_oview.Text = "浏览处方";
            this.tsm_oview.Click += new System.EventHandler(this.tsm_oview_Click);
            // 
            // frm_Dhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 459);
            this.Controls.Add(this.pnl_content);
            this.Controls.Add(this.btn_mpwd);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Dhome";
            this.Text = "医生首页";
            this.Load += new System.EventHandler(this.frm_Dhome_Load);
            this.pnl_content.ResumeLayout(false);
            this.pnl_content.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Label lbl_home;
        private System.Windows.Forms.Button btn_mpwd;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 病历管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_mRinsert;
        private System.Windows.Forms.ToolStripMenuItem tsm_mRview;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem tsm_view;
        private System.Windows.Forms.ToolStripMenuItem tsm_pview;
        private System.Windows.Forms.ToolStripMenuItem tsm_mview;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_ordonnance;
        private System.Windows.Forms.ToolStripMenuItem tsm_oinsert;
        private System.Windows.Forms.ToolStripMenuItem tsm_oview;
    }
}