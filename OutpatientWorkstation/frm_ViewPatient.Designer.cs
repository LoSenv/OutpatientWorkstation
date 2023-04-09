namespace OutpatientWorkstation
{
    partial class frm_ViewPatient
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
            this.btn_load = new System.Windows.Forms.Button();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_no = new System.Windows.Forms.TextBox();
            this.btn_SearchByName = new System.Windows.Forms.Button();
            this.btn_SearchByNo = new System.Windows.Forms.Button();
            this.dgv_cInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(13, 20);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 65;
            this.btn_load.Text = "载入";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(351, 13);
            this.txb_name.Margin = new System.Windows.Forms.Padding(4);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(106, 25);
            this.txb_name.TabIndex = 64;
            // 
            // txb_no
            // 
            this.txb_no.Location = new System.Drawing.Point(120, 12);
            this.txb_no.Margin = new System.Windows.Forms.Padding(4);
            this.txb_no.Name = "txb_no";
            this.txb_no.Size = new System.Drawing.Size(88, 25);
            this.txb_no.TabIndex = 63;
            // 
            // btn_SearchByName
            // 
            this.btn_SearchByName.Location = new System.Drawing.Point(465, 9);
            this.btn_SearchByName.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SearchByName.Name = "btn_SearchByName";
            this.btn_SearchByName.Size = new System.Drawing.Size(127, 29);
            this.btn_SearchByName.TabIndex = 62;
            this.btn_SearchByName.Text = "根据名称搜索";
            this.btn_SearchByName.UseVisualStyleBackColor = true;
            this.btn_SearchByName.Click += new System.EventHandler(this.btn_SearchByName_Click);
            // 
            // btn_SearchByNo
            // 
            this.btn_SearchByNo.Location = new System.Drawing.Point(216, 12);
            this.btn_SearchByNo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SearchByNo.Name = "btn_SearchByNo";
            this.btn_SearchByNo.Size = new System.Drawing.Size(127, 29);
            this.btn_SearchByNo.TabIndex = 61;
            this.btn_SearchByNo.Text = "根据编号搜索";
            this.btn_SearchByNo.UseVisualStyleBackColor = true;
            this.btn_SearchByNo.Click += new System.EventHandler(this.btn_SearchByNo_Click);
            // 
            // dgv_cInfo
            // 
            this.dgv_cInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_cInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cInfo.Location = new System.Drawing.Point(12, 48);
            this.dgv_cInfo.Name = "dgv_cInfo";
            this.dgv_cInfo.RowHeadersWidth = 51;
            this.dgv_cInfo.RowTemplate.Height = 27;
            this.dgv_cInfo.Size = new System.Drawing.Size(776, 393);
            this.dgv_cInfo.TabIndex = 60;
            // 
            // frm_ViewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.txb_no);
            this.Controls.Add(this.btn_SearchByName);
            this.Controls.Add(this.btn_SearchByNo);
            this.Controls.Add(this.dgv_cInfo);
            this.Name = "frm_ViewPatient";
            this.Text = "浏览病人信息";
            this.Load += new System.EventHandler(this.frm_ViewPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_no;
        private System.Windows.Forms.Button btn_SearchByName;
        private System.Windows.Forms.Button btn_SearchByNo;
        private System.Windows.Forms.DataGridView dgv_cInfo;
    }
}