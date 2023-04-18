using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutpatientWorkstation
{
    public partial class frm_ModifyAgency : Form
    {
        public frm_ModifyAgency()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void frm_ModifyAgency_Load(object sender, EventArgs e)
        {

        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            //Admin admin = new Admin();
            //admin.ViewAgency();
            //this.dgv_modify.Columns.Clear();
            //this.dgv_modify.DataSource = admin.AgencyTable;
            //this.dgv_modify.Columns["No"].ReadOnly = true;
            //this.dgv_modify.Columns["No"].HeaderText = "编号";
            //this.dgv_modify.Columns["Name"].HeaderText = "姓名";
            //this.dgv_modify.Columns["Gender"].HeaderText = "性别";
            //this.dgv_modify.Columns["Phone"].HeaderText = "电话";
            //this.dgv_modify.Columns["Remark"].HeaderText = "备注";
            //this.dgv_modify.Columns["AgencyTypeNo"].Visible = false;
            //DataGridViewComboBoxColumn agencyTypeColumn = new DataGridViewComboBoxColumn();
            //this.dgv_modify.Columns.Add(agencyTypeColumn);
            //agencyTypeColumn.Name = "AgencyType";
            //agencyTypeColumn.HeaderText = "员工类型";
            //agencyTypeColumn.DataSource = admin.AgencyTypeTable;
            //agencyTypeColumn.DisplayMember = "Type";
            //agencyTypeColumn.ValueMember = "No";
            //agencyTypeColumn.DataPropertyName = "AgencyTypeNo";
            //agencyTypeColumn.DisplayIndex = 4;
            //agencyTypeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //this.dgv_modify.Columns[this.dgv_modify.Columns.Count - 2].AutoSizeMode =
            //    DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            //Admin admin = new Admin();
            //admin.ViewAgency();
            //admin.ModifyAgency();
            //MessageBox.Show($"更新{admin.RowAffected}行。");
        }
    }
}
