namespace OutpatientWorkstation
{
    partial class frm_InsertAgency
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
            this.cbo_techOffice = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txb_remark = new System.Windows.Forms.TextBox();
            this.txb_phone = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdb_famale = new System.Windows.Forms.RadioButton();
            this.rdb_male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbo_techOffice
            // 
            this.cbo_techOffice.FormattingEnabled = true;
            this.cbo_techOffice.Location = new System.Drawing.Point(245, 96);
            this.cbo_techOffice.Name = "cbo_techOffice";
            this.cbo_techOffice.Size = new System.Drawing.Size(121, 23);
            this.cbo_techOffice.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "科室：";
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(270, 253);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(75, 23);
            this.btn_set.TabIndex = 27;
            this.btn_set.Text = "重置";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(160, 253);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 26;
            this.btn_insert.Text = "录入";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txb_remark
            // 
            this.txb_remark.Location = new System.Drawing.Point(245, 216);
            this.txb_remark.Name = "txb_remark";
            this.txb_remark.Size = new System.Drawing.Size(100, 25);
            this.txb_remark.TabIndex = 25;
            // 
            // txb_phone
            // 
            this.txb_phone.Location = new System.Drawing.Point(245, 185);
            this.txb_phone.Name = "txb_phone";
            this.txb_phone.Size = new System.Drawing.Size(100, 25);
            this.txb_phone.TabIndex = 24;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(245, 125);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(100, 25);
            this.txb_name.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "性别：";
            // 
            // rdb_famale
            // 
            this.rdb_famale.AutoSize = true;
            this.rdb_famale.Location = new System.Drawing.Point(294, 157);
            this.rdb_famale.Name = "rdb_famale";
            this.rdb_famale.Size = new System.Drawing.Size(43, 19);
            this.rdb_famale.TabIndex = 21;
            this.rdb_famale.TabStop = true;
            this.rdb_famale.Text = "女";
            this.rdb_famale.UseVisualStyleBackColor = true;
            // 
            // rdb_male
            // 
            this.rdb_male.AutoSize = true;
            this.rdb_male.Location = new System.Drawing.Point(245, 157);
            this.rdb_male.Name = "rdb_male";
            this.rdb_male.Size = new System.Drawing.Size(43, 19);
            this.rdb_male.TabIndex = 20;
            this.rdb_male.TabStop = true;
            this.rdb_male.Text = "男";
            this.rdb_male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "备注：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "电话：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "员工类型：";
            // 
            // cbo_type
            // 
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Location = new System.Drawing.Point(245, 61);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(121, 23);
            this.cbo_type.TabIndex = 15;
            // 
            // frm_InsertAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbo_techOffice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txb_remark);
            this.Controls.Add(this.txb_phone);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdb_famale);
            this.Controls.Add(this.rdb_male);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_type);
            this.Name = "frm_InsertAgency";
            this.Text = "录入员工信息";
            this.Load += new System.EventHandler(this.frm_InsertAgency_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private  System.Windows.Forms.ComboBox cbo_techOffice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox txb_remark;
        private System.Windows.Forms.TextBox txb_phone;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdb_famale;
        private System.Windows.Forms.RadioButton rdb_male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_type;
    }
}