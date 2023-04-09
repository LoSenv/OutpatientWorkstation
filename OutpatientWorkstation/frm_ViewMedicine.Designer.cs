namespace OutpatientWorkstation
{
    partial class frm_ViewMedicine
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
            this.btn_pin = new System.Windows.Forms.Button();
            this.txb_pin = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_no = new System.Windows.Forms.TextBox();
            this.btn_SearchByName = new System.Windows.Forms.Button();
            this.btn_SearchByNo = new System.Windows.Forms.Button();
            this.dgv_mInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nPage
            // 
            this.btn_nPage.Location = new System.Drawing.Point(665, 46);
            this.btn_nPage.Name = "btn_nPage";
            this.btn_nPage.Size = new System.Drawing.Size(75, 23);
            this.btn_nPage.TabIndex = 78;
            this.btn_nPage.Text = "下一页";
            this.btn_nPage.UseVisualStyleBackColor = true;
            this.btn_nPage.Click += new System.EventHandler(this.btn_nPage_Click);
            // 
            // btn_pPage
            // 
            this.btn_pPage.Location = new System.Drawing.Point(550, 45);
            this.btn_pPage.Name = "btn_pPage";
            this.btn_pPage.Size = new System.Drawing.Size(75, 23);
            this.btn_pPage.TabIndex = 77;
            this.btn_pPage.Text = "上一页";
            this.btn_pPage.UseVisualStyleBackColor = true;
            this.btn_pPage.Click += new System.EventHandler(this.btn_pPage_Click);
            // 
            // btn_pin
            // 
            this.btn_pin.AutoSize = true;
            this.btn_pin.Location = new System.Drawing.Point(396, 8);
            this.btn_pin.Name = "btn_pin";
            this.btn_pin.Size = new System.Drawing.Size(107, 25);
            this.btn_pin.TabIndex = 76;
            this.btn_pin.Text = "根据拼音搜索";
            this.btn_pin.UseVisualStyleBackColor = true;
            // 
            // txb_pin
            // 
            this.txb_pin.Location = new System.Drawing.Point(396, 43);
            this.txb_pin.Name = "txb_pin";
            this.txb_pin.Size = new System.Drawing.Size(100, 25);
            this.txb_pin.TabIndex = 75;
            this.txb_pin.TextChanged += new System.EventHandler(this.txb_pin_TextChanged);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(76, 46);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 74;
            this.btn_load.Text = "载入";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(283, 43);
            this.txb_name.Margin = new System.Windows.Forms.Padding(4);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(106, 25);
            this.txb_name.TabIndex = 73;
            // 
            // txb_no
            // 
            this.txb_no.Location = new System.Drawing.Point(170, 43);
            this.txb_no.Margin = new System.Windows.Forms.Padding(4);
            this.txb_no.Name = "txb_no";
            this.txb_no.Size = new System.Drawing.Size(88, 25);
            this.txb_no.TabIndex = 72;
            // 
            // btn_SearchByName
            // 
            this.btn_SearchByName.Location = new System.Drawing.Point(283, 6);
            this.btn_SearchByName.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SearchByName.Name = "btn_SearchByName";
            this.btn_SearchByName.Size = new System.Drawing.Size(106, 29);
            this.btn_SearchByName.TabIndex = 71;
            this.btn_SearchByName.Text = "根据名称搜索";
            this.btn_SearchByName.UseVisualStyleBackColor = true;
            this.btn_SearchByName.Click += new System.EventHandler(this.btn_SearchByName_Click);
            // 
            // btn_SearchByNo
            // 
            this.btn_SearchByNo.Location = new System.Drawing.Point(170, 6);
            this.btn_SearchByNo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SearchByNo.Name = "btn_SearchByNo";
            this.btn_SearchByNo.Size = new System.Drawing.Size(105, 29);
            this.btn_SearchByNo.TabIndex = 70;
            this.btn_SearchByNo.Text = "根据编号搜索";
            this.btn_SearchByNo.UseVisualStyleBackColor = true;
            this.btn_SearchByNo.Click += new System.EventHandler(this.btn_SearchByNo_Click);
            // 
            // dgv_mInfo
            // 
            this.dgv_mInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_mInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mInfo.Location = new System.Drawing.Point(16, 75);
            this.dgv_mInfo.Name = "dgv_mInfo";
            this.dgv_mInfo.RowHeadersWidth = 51;
            this.dgv_mInfo.RowTemplate.Height = 27;
            this.dgv_mInfo.Size = new System.Drawing.Size(769, 370);
            this.dgv_mInfo.TabIndex = 69;
            // 
            // frm_ViewMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_nPage);
            this.Controls.Add(this.btn_pPage);
            this.Controls.Add(this.btn_pin);
            this.Controls.Add(this.txb_pin);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.txb_no);
            this.Controls.Add(this.btn_SearchByName);
            this.Controls.Add(this.btn_SearchByNo);
            this.Controls.Add(this.dgv_mInfo);
            this.Name = "frm_ViewMedicine";
            this.Text = "浏览药品信息";
            this.Load += new System.EventHandler(this.frm_ViewMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nPage;
        private System.Windows.Forms.Button btn_pPage;
        private System.Windows.Forms.Button btn_pin;
        private System.Windows.Forms.TextBox txb_pin;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_no;
        private System.Windows.Forms.Button btn_SearchByName;
        private System.Windows.Forms.Button btn_SearchByNo;
        private System.Windows.Forms.DataGridView dgv_mInfo;
    }
}