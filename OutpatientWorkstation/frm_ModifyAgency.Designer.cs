namespace OutpatientWorkstation
{
    partial class frm_ModifyAgency
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
            this.btn_modify = new System.Windows.Forms.Button();
            this.dgv_modify = new System.Windows.Forms.DataGridView();
            this.btn_load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modify)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(111, 12);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(75, 23);
            this.btn_modify.TabIndex = 3;
            this.btn_modify.Text = "提交";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // dgv_modify
            // 
            this.dgv_modify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_modify.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_modify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modify.Location = new System.Drawing.Point(12, 41);
            this.dgv_modify.Name = "dgv_modify";
            this.dgv_modify.RowHeadersWidth = 51;
            this.dgv_modify.RowTemplate.Height = 27;
            this.dgv_modify.Size = new System.Drawing.Size(776, 397);
            this.dgv_modify.TabIndex = 2;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(12, 12);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 4;
            this.btn_load.Text = "载入";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // frm_ModifyAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.dgv_modify);
            this.Name = "frm_ModifyAgency";
            this.Text = "修改员工信息";
            this.Load += new System.EventHandler(this.frm_ModifyAgency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.DataGridView dgv_modify;
        private System.Windows.Forms.Button btn_load;
    }
}