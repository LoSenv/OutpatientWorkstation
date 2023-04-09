namespace OutpatientWorkstation
{
    partial class frm_Ahome
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
            this.btn_mpwd = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_out = new System.Windows.Forms.Button();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.lbl_home = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_input = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_aInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_pInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.tsm_modify = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_aModify = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_pModify = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_mModify = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.tsm_view = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_aView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_pView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_mView = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_content.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_mpwd
            // 
            this.btn_mpwd.AutoSize = true;
            this.btn_mpwd.Location = new System.Drawing.Point(714, 12);
            this.btn_mpwd.Name = "btn_mpwd";
            this.btn_mpwd.Size = new System.Drawing.Size(77, 25);
            this.btn_mpwd.TabIndex = 12;
            this.btn_mpwd.Text = "修改密码";
            this.btn_mpwd.UseVisualStyleBackColor = true;
            this.btn_mpwd.Click += new System.EventHandler(this.btn_mpwd_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(586, 12);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 15);
            this.lblMsg.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "用户名：";
            // 
            // btn_out
            // 
            this.btn_out.AutoSize = true;
            this.btn_out.Location = new System.Drawing.Point(652, 12);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(56, 25);
            this.btn_out.TabIndex = 9;
            this.btn_out.Text = "注销";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // pnl_content
            // 
            this.pnl_content.Controls.Add(this.lbl_home);
            this.pnl_content.Location = new System.Drawing.Point(188, 40);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(761, 398);
            this.pnl_content.TabIndex = 8;
            // 
            // lbl_home
            // 
            this.lbl_home.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_home.AutoSize = true;
            this.lbl_home.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_home.Location = new System.Drawing.Point(29, 47);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(0, 37);
            this.lbl_home.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.menuStrip1);
            this.flowLayoutPanel1.Controls.Add(this.menuStrip3);
            this.flowLayoutPanel1.Controls.Add(this.menuStrip4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(169, 398);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_input});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(91, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsm_input
            // 
            this.tsm_input.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_aInsert,
            this.tsm_pInsert});
            this.tsm_input.Name = "tsm_input";
            this.tsm_input.Size = new System.Drawing.Size(83, 24);
            this.tsm_input.Text = "信息录入";
            // 
            // tsm_aInsert
            // 
            this.tsm_aInsert.Name = "tsm_aInsert";
            this.tsm_aInsert.Size = new System.Drawing.Size(224, 26);
            this.tsm_aInsert.Text = "录入员工信息";
            this.tsm_aInsert.Click += new System.EventHandler(this.tsm_aInsert_Click);
            // 
            // tsm_pInsert
            // 
            this.tsm_pInsert.Name = "tsm_pInsert";
            this.tsm_pInsert.Size = new System.Drawing.Size(224, 26);
            this.tsm_pInsert.Text = "录入病人信息";
            this.tsm_pInsert.Click += new System.EventHandler(this.tsm_pInsert_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_modify});
            this.menuStrip3.Location = new System.Drawing.Point(0, 28);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(91, 28);
            this.menuStrip3.TabIndex = 5;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // tsm_modify
            // 
            this.tsm_modify.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_aModify,
            this.tsm_pModify,
            this.tsm_mModify});
            this.tsm_modify.Name = "tsm_modify";
            this.tsm_modify.Size = new System.Drawing.Size(83, 24);
            this.tsm_modify.Text = "信息修改";
            // 
            // tsm_aModify
            // 
            this.tsm_aModify.Name = "tsm_aModify";
            this.tsm_aModify.Size = new System.Drawing.Size(224, 26);
            this.tsm_aModify.Text = "修改员工信息";
            this.tsm_aModify.Click += new System.EventHandler(this.tsm_aModify_Click);
            // 
            // tsm_pModify
            // 
            this.tsm_pModify.Name = "tsm_pModify";
            this.tsm_pModify.Size = new System.Drawing.Size(224, 26);
            this.tsm_pModify.Text = "修改病人信息";
            this.tsm_pModify.Click += new System.EventHandler(this.tsm_pModify_Click);
            // 
            // tsm_mModify
            // 
            this.tsm_mModify.Name = "tsm_mModify";
            this.tsm_mModify.Size = new System.Drawing.Size(224, 26);
            this.tsm_mModify.Text = "修改药品信息";
            this.tsm_mModify.Click += new System.EventHandler(this.tsm_mModify_Click);
            // 
            // menuStrip4
            // 
            this.menuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_view});
            this.menuStrip4.Location = new System.Drawing.Point(0, 56);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(169, 28);
            this.menuStrip4.TabIndex = 7;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // tsm_view
            // 
            this.tsm_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_aView,
            this.tsm_pView,
            this.tsm_mView});
            this.tsm_view.Name = "tsm_view";
            this.tsm_view.Size = new System.Drawing.Size(83, 24);
            this.tsm_view.Text = "信息浏览";
            // 
            // tsm_aView
            // 
            this.tsm_aView.Name = "tsm_aView";
            this.tsm_aView.Size = new System.Drawing.Size(224, 26);
            this.tsm_aView.Text = "浏览员工信息";
            this.tsm_aView.Click += new System.EventHandler(this.tsm_aView_Click);
            // 
            // tsm_pView
            // 
            this.tsm_pView.Name = "tsm_pView";
            this.tsm_pView.Size = new System.Drawing.Size(224, 26);
            this.tsm_pView.Text = "浏览病人信息";
            this.tsm_pView.Click += new System.EventHandler(this.tsm_pView_Click);
            // 
            // tsm_mView
            // 
            this.tsm_mView.Name = "tsm_mView";
            this.tsm_mView.Size = new System.Drawing.Size(224, 26);
            this.tsm_mView.Text = "浏览药品信息";
            this.tsm_mView.Click += new System.EventHandler(this.tsm_mView_Click);
            // 
            // frm_Ahome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.btn_mpwd);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.pnl_content);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frm_Ahome";
            this.Text = "管理员首页";
            this.Load += new System.EventHandler(this.frm_Ahome_Load);
            this.pnl_content.ResumeLayout(false);
            this.pnl_content.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mpwd;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_out;
        public  System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Label lbl_home;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_input;
        private System.Windows.Forms.ToolStripMenuItem tsm_aInsert;
        private System.Windows.Forms.ToolStripMenuItem tsm_pInsert;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem tsm_modify;
        private System.Windows.Forms.ToolStripMenuItem tsm_aModify;
        private System.Windows.Forms.ToolStripMenuItem tsm_pModify;
        private System.Windows.Forms.ToolStripMenuItem tsm_mModify;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem tsm_view;
        private System.Windows.Forms.ToolStripMenuItem tsm_aView;
        private System.Windows.Forms.ToolStripMenuItem tsm_pView;
        private System.Windows.Forms.ToolStripMenuItem tsm_mView;
    }
}