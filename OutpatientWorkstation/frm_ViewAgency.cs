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
    public partial class frm_ViewAgency : Form
    {
        public frm_ViewAgency()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_ViewAgency_Load(object sender, EventArgs e)
        {
            
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            //Admin admin = new Admin();
            //admin.ViewAgencyByTree();
            //DataTable departmentTable = admin.AgencySet.Tables[0];
            //DataTable technicalOfficeTable = admin.AgencySet.Tables[1];
            //DataRelation[] dataRelations =
            //{
            //    new DataRelation
            //    ("Department_TechnicalOffice",
            //    departmentTable.Columns["No"],
            //    technicalOfficeTable.Columns["DepartmentNo"])
            //};
            //admin.AgencySet.Relations.AddRange(dataRelations);
            //this.tv_agency.Nodes.Clear();
            //foreach (DataRow departmentRow in departmentTable.Rows)
            //{
            //    TreeNode departmentNode = new TreeNode();
            //    departmentNode.Text = departmentRow["Name"].ToString();
            //    this.tv_agency.Nodes.Add(departmentNode);
            //    foreach (DataRow technicalOfficeRow in departmentRow.GetChildRows("Department_TechnicalOffice"))
            //    {
            //        TreeNode technicalOfficeNode = new TreeNode();
            //        technicalOfficeNode.Text = technicalOfficeRow["Name"].ToString();
            //        technicalOfficeNode.Tag = technicalOfficeRow["No"];
            //        departmentNode.Nodes.Add(technicalOfficeNode);
            //    }
            //}
        }
        private void tv_agency_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //if (this.tv_agency.SelectedNode.Level != 1)
            //    return;
            //int technicalOfficeNo = (int)this.tv_agency.SelectedNode.Tag;
            //Admin admin=new Admin();
            //admin.AfterSelect(technicalOfficeNo);
            //this.dgv_aInfo.Columns.Clear();
            //this.dgv_aInfo.DataSource = admin.AgencyTable;
            //this.dgv_aInfo.Columns["No"].HeaderText = "编号";
            //this.dgv_aInfo.Columns["Name"].HeaderText = "姓名";
            //this.dgv_aInfo.Columns["Gender"].HeaderText = "性别";
            //this.dgv_aInfo.Columns["Phone"].HeaderText = "电话";
            //this.dgv_aInfo.Columns["AgencyTypeNo"].HeaderText = "员工类别";
            //this.dgv_aInfo.Columns["Remark"].HeaderText = "备注";
            //this.dgv_aInfo.Columns["AgencyTypeNo"].Visible = false;
            //DataGridViewComboBoxColumn agencyTypeNoColumn = new DataGridViewComboBoxColumn();
            //this.dgv_aInfo.Columns.Add(agencyTypeNoColumn);
            //agencyTypeNoColumn.Name = "AgencyType";
            //agencyTypeNoColumn.HeaderText = "员工类型";
            //agencyTypeNoColumn.DataSource = admin.AgencyTypeTable;
            //agencyTypeNoColumn.DisplayMember = "Type";
            //agencyTypeNoColumn.ValueMember = "No";
            //agencyTypeNoColumn.DataPropertyName = "AgencyTypeNo";
            //agencyTypeNoColumn.DisplayIndex = 5;
            //this.dgv_aInfo.Columns[this.dgv_aInfo.Columns.Count - 1].AutoSizeMode =
            //    DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
