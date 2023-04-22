namespace OutpatientWorkstation
{
    partial class frm_ViewMedicalRecord
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
            this.dgv_medicalRecord = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicalRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(12, 12);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 7;
            this.btn_load.Text = "载入";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // dgv_medicalRecord
            // 
            this.dgv_medicalRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_medicalRecord.Location = new System.Drawing.Point(13, 41);
            this.dgv_medicalRecord.Name = "dgv_medicalRecord";
            this.dgv_medicalRecord.RowHeadersWidth = 51;
            this.dgv_medicalRecord.RowTemplate.Height = 27;
            this.dgv_medicalRecord.Size = new System.Drawing.Size(775, 386);
            this.dgv_medicalRecord.TabIndex = 6;
            // 
            // frm_ViewMedicalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.dgv_medicalRecord);
            this.Name = "frm_ViewMedicalRecord";
            this.Text = "浏览病历";
            this.Load += new System.EventHandler(this.frm_ViewMedicalRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicalRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.DataGridView dgv_medicalRecord;
    }
}