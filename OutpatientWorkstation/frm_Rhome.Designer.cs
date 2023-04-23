namespace OutpatientWorkstation
{
    partial class frm_Rhome
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
            this.btn_refresh = new System.Windows.Forms.Button();
            this.cbo_price = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_no = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_reg = new System.Windows.Forms.Button();
            this.dgv_reg = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_remark = new System.Windows.Forms.TextBox();
            this.cbo_doctor = new System.Windows.Forms.ComboBox();
            this.cbo_techOffice = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdb_female = new System.Windows.Forms.RadioButton();
            this.rdb_male = new System.Windows.Forms.RadioButton();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.txb_phone = new System.Windows.Forms.TextBox();
            this.txb_adress = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reg)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(96, 126);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 55;
            this.btn_refresh.Text = "刷新";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // cbo_price
            // 
            this.cbo_price.FormattingEnabled = true;
            this.cbo_price.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbo_price.Location = new System.Drawing.Point(463, 151);
            this.cbo_price.Name = "cbo_price";
            this.cbo_price.Size = new System.Drawing.Size(73, 23);
            this.cbo_price.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(386, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 53;
            this.label12.Text = "挂号金额：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(387, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 52;
            this.label10.Text = "病人编号：";
            // 
            // txb_no
            // 
            this.txb_no.Location = new System.Drawing.Point(474, 84);
            this.txb_no.Name = "txb_no";
            this.txb_no.Size = new System.Drawing.Size(100, 25);
            this.txb_no.TabIndex = 51;
            // 
            // btn_load
            // 
            this.btn_load.AutoSize = true;
            this.btn_load.Location = new System.Drawing.Point(718, 44);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 25);
            this.btn_load.TabIndex = 50;
            this.btn_load.Text = "载入";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_reg
            // 
            this.btn_reg.AutoSize = true;
            this.btn_reg.Location = new System.Drawing.Point(709, 156);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(75, 25);
            this.btn_reg.TabIndex = 49;
            this.btn_reg.Text = "挂号";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // dgv_reg
            // 
            this.dgv_reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reg.Location = new System.Drawing.Point(15, 197);
            this.dgv_reg.Name = "dgv_reg";
            this.dgv_reg.RowHeadersWidth = 51;
            this.dgv_reg.RowTemplate.Height = 27;
            this.dgv_reg.Size = new System.Drawing.Size(769, 241);
            this.dgv_reg.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(542, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 47;
            this.label11.Text = "备注：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "选择医生：";
            // 
            // txb_remark
            // 
            this.txb_remark.Location = new System.Drawing.Point(604, 155);
            this.txb_remark.Name = "txb_remark";
            this.txb_remark.Size = new System.Drawing.Size(70, 25);
            this.txb_remark.TabIndex = 45;
            // 
            // cbo_doctor
            // 
            this.cbo_doctor.FormattingEnabled = true;
            this.cbo_doctor.Location = new System.Drawing.Point(296, 155);
            this.cbo_doctor.Name = "cbo_doctor";
            this.cbo_doctor.Size = new System.Drawing.Size(73, 23);
            this.cbo_doctor.TabIndex = 44;
            // 
            // cbo_techOffice
            // 
            this.cbo_techOffice.FormattingEnabled = true;
            this.cbo_techOffice.Location = new System.Drawing.Point(96, 156);
            this.cbo_techOffice.Name = "cbo_techOffice";
            this.cbo_techOffice.Size = new System.Drawing.Size(90, 23);
            this.cbo_techOffice.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 42;
            this.label8.Text = "选择科室：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 41;
            this.label7.Text = "挂号信息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "地址：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "电话：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "出生日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "病人姓名：";
            // 
            // rdb_female
            // 
            this.rdb_female.AutoSize = true;
            this.rdb_female.Location = new System.Drawing.Point(318, 49);
            this.rdb_female.Name = "rdb_female";
            this.rdb_female.Size = new System.Drawing.Size(43, 19);
            this.rdb_female.TabIndex = 35;
            this.rdb_female.TabStop = true;
            this.rdb_female.Text = "女";
            this.rdb_female.UseVisualStyleBackColor = true;
            // 
            // rdb_male
            // 
            this.rdb_male.AutoSize = true;
            this.rdb_male.Location = new System.Drawing.Point(269, 51);
            this.rdb_male.Name = "rdb_male";
            this.rdb_male.Size = new System.Drawing.Size(43, 19);
            this.rdb_male.TabIndex = 34;
            this.rdb_male.TabStop = true;
            this.rdb_male.Text = "男";
            this.rdb_male.UseVisualStyleBackColor = true;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(474, 43);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 25);
            this.dtp_date.TabIndex = 33;
            // 
            // txb_phone
            // 
            this.txb_phone.Location = new System.Drawing.Point(96, 84);
            this.txb_phone.Name = "txb_phone";
            this.txb_phone.Size = new System.Drawing.Size(100, 25);
            this.txb_phone.TabIndex = 32;
            // 
            // txb_adress
            // 
            this.txb_adress.Location = new System.Drawing.Point(269, 84);
            this.txb_adress.Name = "txb_adress";
            this.txb_adress.Size = new System.Drawing.Size(100, 25);
            this.txb_adress.TabIndex = 31;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(96, 43);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(100, 25);
            this.txb_name.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "病人信息";
            // 
            // btn_return
            // 
            this.btn_return.AutoSize = true;
            this.btn_return.Location = new System.Drawing.Point(696, 4);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(77, 25);
            this.btn_return.TabIndex = 56;
            this.btn_return.Text = "返回首页";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // frm_Rhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.cbo_price);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txb_no);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.dgv_reg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txb_remark);
            this.Controls.Add(this.cbo_doctor);
            this.Controls.Add(this.cbo_techOffice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdb_female);
            this.Controls.Add(this.rdb_male);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.txb_phone);
            this.Controls.Add(this.txb_adress);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.label1);
            this.Name = "frm_Rhome";
            this.Text = "挂号员首页";
            this.Load += new System.EventHandler(this.frm_Rhome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ComboBox cbo_price;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_no;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.DataGridView dgv_reg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_remark;
        private System.Windows.Forms.ComboBox cbo_doctor;
        private System.Windows.Forms.ComboBox cbo_techOffice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdb_female;
        private System.Windows.Forms.RadioButton rdb_male;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.TextBox txb_phone;
        private System.Windows.Forms.TextBox txb_adress;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_return;
    }
}