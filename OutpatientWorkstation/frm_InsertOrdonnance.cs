using OutpatientWorkstation.BusinessLogicLayer;
using OutpatientWorkstation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutpatientWorkstation
{
    public partial class frm_InsertOrdonnance : Form
    {
        public string _name;
        public Ordonnance Ordonnance { get; set; }
        public IOrdonnanceBll OrdonnanceBll { get; set; }
        public OrdonnanceDetail OrdonnanceDetail { get; set; }
        public IOrdonnanceDetailBll OrdonnanceDetailBll { get; set; }
        public IUserBll UserBll { get; set; }
        public frm_InsertOrdonnance(string name) : this()
        {
            this._name = name;
        }
        public frm_InsertOrdonnance()
        {
            InitializeComponent();
            this.UserBll=new UserBll();
            this.OrdonnanceBll= new OrdonnanceBll();
            this.OrdonnanceDetailBll= new OrdonnanceDetailBll();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_InsertOrdonnance_Load(object sender, EventArgs e)
        {

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(txb_oNo.Text.Trim());
            int patientNo = Convert.ToInt32(this.txb_patient.Text.Trim());
            int agencyNo = this.UserBll.SelectUserNo(this._name);
            DateTime date = DateTime.Now;
           this.Ordonnance=this.OrdonnanceBll.InsertOrdonnance(no,patientNo,agencyNo,date);
            MessageBox.Show(this.OrdonnanceBll.Message);
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            if(this.txb_oNo.Text==null)
            {
                MessageBox.Show("处方号不能为空！");
                return;
            }
            int ordonnanceNo = Convert.ToInt32(txb_oNo.Text.Trim());
            this.OrdonnanceDetailBll.Select(ordonnanceNo);
            this.dgv_stock.Columns.Clear();
            this.dgv_stock.DataSource = this.OrdonnanceDetailBll.MedicineTable;
            this.dgv_stock.Columns["No"].ReadOnly = true;
            this.dgv_stock.Columns["No"].HeaderText = "编号";
            this.dgv_stock.Columns["Name"].HeaderText = "名称";
            this.dgv_stock.Columns["Efficacy"].HeaderText = "功效";
            this.dgv_stock.Columns["Price"].HeaderText = "价格";
            this.dgv_stock.Columns["Count"].HeaderText = "库存";
            this.dgv_stock.Columns["Spec"].Visible = false;
            this.dgv_stock.Columns["Pinyin"].Visible = false;
            this.dgv_stock.Columns["Count"].Visible = false;
            this.dgv_stock.Columns["UnitNo"].Visible = false;
            this.dgv_stock.Columns[this.dgv_stock.Columns.Count - 1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_list.Columns.Clear();
            this.dgv_list.DataSource = this.OrdonnanceDetailBll.ListTable;
            this.dgv_list.Columns["Type"].HeaderText = "处方类型";
            this.dgv_list.Columns["Encod"].HeaderText = "处方编码";
            this.dgv_list.Columns["MedicineNo"].HeaderText = "药品编号";
            this.dgv_list.Columns["Name"].HeaderText = "药品名称";
            this.dgv_list.Columns["UseMethodNo"].HeaderText = "用药方式";
            this.dgv_list.Columns["UseFrequencyNo"].HeaderText = "用药频率";
            this.dgv_list.Columns["Remark"].HeaderText = "备注";
            this.dgv_list.Columns["UseMethodNo"].Visible = false;
            this.dgv_list.Columns["UseFrequencyNo"].Visible = false;
            DataGridViewComboBoxColumn useMethodNoColumn = new DataGridViewComboBoxColumn();
            this.dgv_list.Columns.Add(useMethodNoColumn);
            useMethodNoColumn.Name = "UseMethod";
            useMethodNoColumn.HeaderText = "用药方式";
            useMethodNoColumn.DataSource = this.OrdonnanceDetailBll.UseMethodTable;
            useMethodNoColumn.DisplayMember = "Name";
            useMethodNoColumn.ValueMember = "No";
            useMethodNoColumn.DataPropertyName = "UseMethodNo";
            useMethodNoColumn.DisplayIndex = 5;
            DataGridViewComboBoxColumn useFrequencyNoColumn = new DataGridViewComboBoxColumn();
            this.dgv_list.Columns.Add(useFrequencyNoColumn);
            useFrequencyNoColumn.Name = "UseFrequency";
            useFrequencyNoColumn.HeaderText = "用药频率";
            useFrequencyNoColumn.DataSource = this.OrdonnanceDetailBll.UseFrequencyTable;
            useFrequencyNoColumn.DisplayMember = "Name";
            useFrequencyNoColumn.ValueMember = "No";
            useFrequencyNoColumn.DataPropertyName = "UseFrequencyNo";
            useFrequencyNoColumn.DisplayIndex = 6;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataRowView currentView =
                this.dgv_stock.CurrentRow.DataBoundItem as DataRowView;
            DataRow currentRow = currentView.Row;
            DataRow listRow = this.OrdonnanceDetailBll.ListTable.NewRow();
            listRow["MedicineNo"] = currentRow["No"];
            listRow["Name"] = currentRow["Name"];
            this.OrdonnanceDetailBll.ListTable.Rows.Add(listRow);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataRowView listView =
               this.dgv_list.CurrentRow.DataBoundItem as DataRowView;
            DataRow listRow = listView.Row;
            this.OrdonnanceDetailBll.ListTable.Rows.Remove(listRow);
        }

        private void btn_insertDrug_Click(object sender, EventArgs e)
        {
            int ordonnanceNo = Convert.ToInt32(txb_oNo.Text.Trim());
            this.OrdonnanceDetailBll.InsertOrdonnanceDetail(ordonnanceNo);
            MessageBox.Show(this.OrdonnanceDetailBll.Message);
        }
    }
}
