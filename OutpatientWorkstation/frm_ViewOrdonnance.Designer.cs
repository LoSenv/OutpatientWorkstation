namespace OutpatientWorkstation
{
    partial class frm_ViewOrdonnance
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
            this.dgv_oInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_oInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(12, 15);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 66;
            this.btn_load.Text = "载入";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // dgv_oInfo
            // 
            this.dgv_oInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_oInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_oInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_oInfo.Location = new System.Drawing.Point(12, 42);
            this.dgv_oInfo.Name = "dgv_oInfo";
            this.dgv_oInfo.RowHeadersWidth = 51;
            this.dgv_oInfo.RowTemplate.Height = 27;
            this.dgv_oInfo.Size = new System.Drawing.Size(776, 393);
            this.dgv_oInfo.TabIndex = 65;
            // 
            // frm_ViewOrdonnance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.dgv_oInfo);
            this.Name = "frm_ViewOrdonnance";
            this.Text = "浏览处方";
            this.Load += new System.EventHandler(this.frm_ViewOrdonnance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_oInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.DataGridView dgv_oInfo;
    }
}