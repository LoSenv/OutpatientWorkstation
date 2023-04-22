using OutpatientWorkstation.BusinessLogicLayer;
using OutpatientWorkstation.Model;
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
    public partial class frm_ModifyMedicine : Form
    {
        private Medicine Medicine { get; set; }
        private IMedicineBll MedicineBll { get; set; }
        public frm_ModifyMedicine()
        {
            InitializeComponent();
            MedicineBll= new MedicineBll();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.dgv_mInfo.AllowUserToAddRows = false;
        }

        private void frm_ModifyMedicine_Load(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            MedicineBll.ViewMedicine();
            this.dgv_mInfo.Columns.Clear();
            MedicineBll.MaxPageNo =
                (int)Math.Ceiling((double)MedicineBll.MedicineTable.Rows.Count / (double)MedicineBll.PageSize);
            MedicineBll.CurrentPageView = new DataView();
            MedicineBll.CurrentPageView.Table = MedicineBll.MedicineTable;
            MedicineBll.CurrentPageView.Sort = "RowId ASC";
            MedicineBll.RefreshRowFilter();
            this.dgv_mInfo.DataSource = MedicineBll.CurrentPageView;
            this.dgv_mInfo.Columns["No"].ReadOnly = true;
            this.dgv_mInfo.Columns["No"].HeaderText = "编号";
            this.dgv_mInfo.Columns["Name"].HeaderText = "名称";
            this.dgv_mInfo.Columns["Pinyin"].HeaderText = "拼音";
            this.dgv_mInfo.Columns["Spec"].HeaderText = "规格";
            this.dgv_mInfo.Columns["Efficacy"].HeaderText = "功效";
            this.dgv_mInfo.Columns["Price"].HeaderText = "价格";
            this.dgv_mInfo.Columns["Count"].HeaderText = "库存";
            this.dgv_mInfo.Columns["UnitNo"].Visible = false;
            this.dgv_mInfo.Columns["RowId"].Visible = false;
            DataGridViewComboBoxColumn unitNoColumn = new DataGridViewComboBoxColumn();
            this.dgv_mInfo.Columns.Add(unitNoColumn);
            unitNoColumn.Name = "Unit";
            unitNoColumn.HeaderText = "包装单位";
            unitNoColumn.DataSource = MedicineBll.UnitTable;
            unitNoColumn.DisplayMember = "Name";
            unitNoColumn.ValueMember = "No";
            unitNoColumn.DataPropertyName = "UnitNo";
            unitNoColumn.DisplayIndex = 8;
            unitNoColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_mInfo.Columns[this.dgv_mInfo.Columns.Count - 1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }
        private void btn_modify_Click(object sender, EventArgs e)
        {
            MedicineBll.ModifyMedicine();
            MessageBox.Show(this.MedicineBll.Message);
        }

        private void btn_pPage_Click(object sender, EventArgs e)
        {
            MedicineBll.PrePage();
        }

        private void btn_nPage_Click(object sender, EventArgs e)
        {
            MedicineBll.NextPage();
        }
    }
}
