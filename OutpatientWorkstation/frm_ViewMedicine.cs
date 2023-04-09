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
    public partial class frm_ViewMedicine : Form
    {
        public frm_ViewMedicine()
        {
            InitializeComponent();
            this.StartPosition= FormStartPosition.CenterScreen;
            this.dgv_mInfo.AllowUserToAddRows=false;
        }

        private void frm_ViewMedicine_Load(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ViewMedicine();
            this.dgv_mInfo.Columns.Clear();
            admin.MaxPageNo =
               (int)Math.Ceiling((double)admin.MedicineTable.Rows.Count / (double)admin.PageSize);
            admin.CurrentPageView = new DataView();
            admin.CurrentPageView.Table = admin.MedicineTable;
            admin.CurrentPageView.Sort = "RowId ASC";
            admin.RefreshRowFilter();
            this.dgv_mInfo.DataSource = admin.CurrentPageView;
            this.dgv_mInfo.Columns["No"].ReadOnly = true;
            this.dgv_mInfo.Columns["No"].HeaderText = "编号";
            this.dgv_mInfo.Columns["Name"].HeaderText = "名称";
            this.dgv_mInfo.Columns["Spec"].HeaderText = "规格";
            this.dgv_mInfo.Columns["Efficacy"].HeaderText = "功效";
            this.dgv_mInfo.Columns["Price"].HeaderText = "价格";
            this.dgv_mInfo.Columns["Count"].HeaderText = "库存";
            this.dgv_mInfo.Columns["Pinyin"].Visible = false;
            this.dgv_mInfo.Columns["UnitNo"].Visible = false;
            this.dgv_mInfo.Columns["RowId"].Visible = false;
            DataGridViewComboBoxColumn unitNoColumn = new DataGridViewComboBoxColumn();
            this.dgv_mInfo.Columns.Add(unitNoColumn);
            unitNoColumn.Name = "Unit";
            unitNoColumn.HeaderText = "包装单位";
            unitNoColumn.DataSource = admin.UnitTable;
            unitNoColumn.DisplayMember = "Name";
            unitNoColumn.ValueMember = "No";
            unitNoColumn.DataPropertyName = "UnitNo";
            unitNoColumn.DisplayIndex = 9;
            unitNoColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_mInfo.Columns[this.dgv_mInfo.Columns.Count - 1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_SearchByNo_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ViewMedicine();
            admin.SelectMedicineByNo(this.txb_no.Text.Trim(), admin.MedicineTable);
            this.dgv_mInfo.DataSource = admin.ResultTable;
        }

        private void btn_SearchByName_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ViewMedicine();
            admin.SelectMedicineByName(this.txb_name.Text.Trim(), admin.MedicineViewByName);
            this.dgv_mInfo.DataSource = admin.ResultTable;
        }

        private void txb_pin_TextChanged(object sender, EventArgs e)
        {
            Admin admin=new Admin();
            admin.ViewMedicine();
            admin.SelectMedicineByPinyin(this.txb_pin.Text.Trim());
            this.dgv_mInfo.DataSource =admin.ResultTable;
        }

        private void btn_pPage_Click(object sender, EventArgs e)
        {
            Admin admin= new Admin();
            admin.ViewMedicine();
            this.dgv_mInfo.Columns.Clear();
            admin.MaxPageNo =
               (int)Math.Ceiling((double)admin.MedicineTable.Rows.Count / (double)admin.PageSize);
            admin.CurrentPageView = new DataView();
            admin.CurrentPageView.Table = admin.MedicineTable;
            admin.CurrentPageView.Sort = "RowId ASC";
            admin.RefreshRowFilter();
            this.dgv_mInfo.DataSource = admin.CurrentPageView;
            this.dgv_mInfo.Columns["No"].ReadOnly = true;
            this.dgv_mInfo.Columns["No"].HeaderText = "编号";
            this.dgv_mInfo.Columns["Name"].HeaderText = "名称";
            this.dgv_mInfo.Columns["Spec"].HeaderText = "规格";
            this.dgv_mInfo.Columns["Efficacy"].HeaderText = "功效";
            this.dgv_mInfo.Columns["Price"].HeaderText = "价格";
            this.dgv_mInfo.Columns["Count"].HeaderText = "库存";
            this.dgv_mInfo.Columns["Pinyin"].Visible = false;
            this.dgv_mInfo.Columns["UnitNo"].Visible = false;
            this.dgv_mInfo.Columns["RowId"].Visible = false;
            DataGridViewComboBoxColumn unitNoColumn = new DataGridViewComboBoxColumn();
            this.dgv_mInfo.Columns.Add(unitNoColumn);
            unitNoColumn.Name = "Unit";
            unitNoColumn.HeaderText = "包装单位";
            unitNoColumn.DataSource = admin.UnitTable;
            unitNoColumn.DisplayMember = "Name";
            unitNoColumn.ValueMember = "No";
            unitNoColumn.DataPropertyName = "UnitNo";
            unitNoColumn.DisplayIndex = 9;
            unitNoColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_mInfo.Columns[this.dgv_mInfo.Columns.Count - 1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
            admin.PrePage();
        }

        private void btn_nPage_Click(object sender, EventArgs e)
        {
            Admin admin=new Admin();
            admin.ViewMedicine();
            this.dgv_mInfo.Columns.Clear();
            admin.MaxPageNo =
               (int)Math.Ceiling((double)admin.MedicineTable.Rows.Count / (double)admin.PageSize);
            admin.CurrentPageView = new DataView();
            admin.CurrentPageView.Table = admin.MedicineTable;
            admin.CurrentPageView.Sort = "RowId ASC";
            admin.RefreshRowFilter();
            this.dgv_mInfo.DataSource = admin.CurrentPageView;
            this.dgv_mInfo.Columns["No"].ReadOnly = true;
            this.dgv_mInfo.Columns["No"].HeaderText = "编号";
            this.dgv_mInfo.Columns["Name"].HeaderText = "名称";
            this.dgv_mInfo.Columns["Spec"].HeaderText = "规格";
            this.dgv_mInfo.Columns["Efficacy"].HeaderText = "功效";
            this.dgv_mInfo.Columns["Price"].HeaderText = "价格";
            this.dgv_mInfo.Columns["Count"].HeaderText = "库存";
            this.dgv_mInfo.Columns["Pinyin"].Visible = false;
            this.dgv_mInfo.Columns["UnitNo"].Visible = false;
            this.dgv_mInfo.Columns["RowId"].Visible = false;
            DataGridViewComboBoxColumn unitNoColumn = new DataGridViewComboBoxColumn();
            this.dgv_mInfo.Columns.Add(unitNoColumn);
            unitNoColumn.Name = "Unit";
            unitNoColumn.HeaderText = "包装单位";
            unitNoColumn.DataSource = admin.UnitTable;
            unitNoColumn.DisplayMember = "Name";
            unitNoColumn.ValueMember = "No";
            unitNoColumn.DataPropertyName = "UnitNo";
            unitNoColumn.DisplayIndex = 9;
            unitNoColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_mInfo.Columns[this.dgv_mInfo.Columns.Count - 1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
            admin.NextPage();
        }
    }
}
