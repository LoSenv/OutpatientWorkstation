namespace OutpatientWorkstation
{
    partial class frm_ModifyMedicine
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
            this.btn_nPage = new System.Windows.Forms.Button();
            this.btn_pPage = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.dgv_mInfo = new System.Windows.Forms.DataGridView();
            this.btn_load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nPage
            // 
            this.btn_nPage.Location = new System.Drawing.Point(575, 13);
            this.btn_nPage.Name = "btn_nPage";
            this.btn_nPage.Size = new System.Drawing.Size(75, 23);
            this.btn_nPage.TabIndex = 74;
            this.btn_nPage.Text = "下一页";
            this.btn_nPage.UseVisualStyleBackColor = true;
            this.btn_nPage.Click += new System.EventHandler(this.btn_nPage_Click);
            // 
            // btn_pPage
            // 
            this.btn_pPage.Location = new System.Drawing.Point(480, 13);
            this.btn_pPage.Name = "btn_pPage";
            this.btn_pPage.Size = new System.Drawing.Size(75, 23);
            this.btn_pPage.TabIndex = 73;
            this.btn_pPage.Text = "上一页";
            this.btn_pPage.UseVisualStyleBackColor = true;
            this.btn_pPage.Click += new System.EventHandler(this.btn_pPage_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(96, 12);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(75, 23);
            this.btn_modify.TabIndex = 72;
            this.btn_modify.Text = "提交";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // dgv_mInfo
            // 
            this.dgv_mInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_mInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mInfo.Location = new System.Drawing.Point(12, 41);
            this.dgv_mInfo.Name = "dgv_mInfo";
            this.dgv_mInfo.RowHeadersWidth = 51;
            this.dgv_mInfo.RowTemplate.Height = 27;
            this.dgv_mInfo.Size = new System.Drawing.Size(776, 397);
            this.dgv_mInfo.TabIndex = 71;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(12, 12);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 75;
            this.btn_load.Text = "载入";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // frm_ModifyMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_nPage);
            this.Controls.Add(this.btn_pPage);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.dgv_mInfo);
            this.Name = "frm_ModifyMedicine";
            this.Text = "修改药品信息";
            this.Load += new System.EventHandler(this.frm_ModifyMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_nPage;
        private System.Windows.Forms.Button btn_pPage;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.DataGridView dgv_mInfo;
        private System.Windows.Forms.Button btn_load;
    }
}