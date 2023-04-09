namespace OutpatientWorkstation
{
    partial class frm_InsertOrdonnance
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
            this.txb_oNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.dgv_stock = new System.Windows.Forms.DataGridView();
            this.btn_insertDrug = new System.Windows.Forms.Button();
            this.txb_patient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_oNo
            // 
            this.txb_oNo.Location = new System.Drawing.Point(271, 35);
            this.txb_oNo.Name = "txb_oNo";
            this.txb_oNo.Size = new System.Drawing.Size(100, 25);
            this.txb_oNo.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 94;
            this.label2.Text = "处方单号：";
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.Location = new System.Drawing.Point(458, 35);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 25);
            this.btn_save.TabIndex = 93;
            this.btn_save.Text = "新增处方";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_load
            // 
            this.btn_load.AutoSize = true;
            this.btn_load.Location = new System.Drawing.Point(377, 33);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 25);
            this.btn_load.TabIndex = 92;
            this.btn_load.Text = "载入";
            this.btn_load.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSize = true;
            this.btn_delete.Location = new System.Drawing.Point(453, 232);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 25);
            this.btn_delete.TabIndex = 91;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.AutoSize = true;
            this.btn_add.Location = new System.Drawing.Point(453, 157);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 25);
            this.btn_add.TabIndex = 90;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // dgv_list
            // 
            this.dgv_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(534, 64);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.RowHeadersWidth = 51;
            this.dgv_list.RowTemplate.Height = 27;
            this.dgv_list.Size = new System.Drawing.Size(537, 354);
            this.dgv_list.TabIndex = 89;
            // 
            // dgv_stock
            // 
            this.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock.Location = new System.Drawing.Point(16, 64);
            this.dgv_stock.Name = "dgv_stock";
            this.dgv_stock.RowHeadersWidth = 51;
            this.dgv_stock.RowTemplate.Height = 27;
            this.dgv_stock.Size = new System.Drawing.Size(419, 354);
            this.dgv_stock.TabIndex = 88;
            // 
            // btn_insertDrug
            // 
            this.btn_insertDrug.AutoSize = true;
            this.btn_insertDrug.Location = new System.Drawing.Point(994, 31);
            this.btn_insertDrug.Name = "btn_insertDrug";
            this.btn_insertDrug.Size = new System.Drawing.Size(77, 25);
            this.btn_insertDrug.TabIndex = 87;
            this.btn_insertDrug.Text = "提交";
            this.btn_insertDrug.UseVisualStyleBackColor = true;
            // 
            // txb_patient
            // 
            this.txb_patient.Location = new System.Drawing.Point(90, 33);
            this.txb_patient.Name = "txb_patient";
            this.txb_patient.Size = new System.Drawing.Size(100, 25);
            this.txb_patient.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 85;
            this.label1.Text = "病人编号：";
            // 
            // frm_InsertOrdonnance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.txb_oNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_list);
            this.Controls.Add(this.dgv_stock);
            this.Controls.Add(this.btn_insertDrug);
            this.Controls.Add(this.txb_patient);
            this.Controls.Add(this.label1);
            this.Name = "frm_InsertOrdonnance";
            this.Text = "录入处方信息";
            this.Load += new System.EventHandler(this.frm_InsertOrdonnance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_oNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.DataGridView dgv_stock;
        private System.Windows.Forms.Button btn_insertDrug;
        private System.Windows.Forms.TextBox txb_patient;
        private System.Windows.Forms.Label label1;
    }
}