namespace OutpatientWorkstation
{
    partial class frm_ViewAgency
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
            this.tv_agency = new System.Windows.Forms.TreeView();
            this.btn_load = new System.Windows.Forms.Button();
            this.dgv_aInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tv_agency
            // 
            this.tv_agency.Location = new System.Drawing.Point(14, 44);
            this.tv_agency.Name = "tv_agency";
            this.tv_agency.Size = new System.Drawing.Size(195, 312);
            this.tv_agency.TabIndex = 68;
            this.tv_agency.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_agency_AfterSelect);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(14, 15);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 67;
            this.btn_load.Text = "载入";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // dgv_aInfo
            // 
            this.dgv_aInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_aInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_aInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aInfo.Location = new System.Drawing.Point(217, 43);
            this.dgv_aInfo.Name = "dgv_aInfo";
            this.dgv_aInfo.RowHeadersWidth = 51;
            this.dgv_aInfo.RowTemplate.Height = 27;
            this.dgv_aInfo.Size = new System.Drawing.Size(570, 393);
            this.dgv_aInfo.TabIndex = 66;
            // 
            // frm_ViewAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tv_agency);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.dgv_aInfo);
            this.Name = "frm_ViewAgency";
            this.Text = "浏览员工信息";
            this.Load += new System.EventHandler(this.frm_ViewAgency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private  System.Windows.Forms.TreeView tv_agency;
        private System.Windows.Forms.Button btn_load;
        private  System.Windows.Forms.DataGridView dgv_aInfo;
    }
}