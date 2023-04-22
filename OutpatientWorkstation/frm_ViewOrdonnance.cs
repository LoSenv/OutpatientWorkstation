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
    public partial class frm_ViewOrdonnance : Form
    {
        private OrdonnanceDetail OrdonnanceDetail { get; set; }
        private IOrdonnanceDetailBll OrdonnanceDetailBll { get; set; }
        public frm_ViewOrdonnance()
        {
            InitializeComponent();
            this.OrdonnanceDetailBll=new OrdonnanceDetailBll();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_ViewOrdonnance_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            this.OrdonnanceDetailBll.SelectOrdonnanceDetail();
            this.dgv_oInfo.DataSource = this.OrdonnanceDetailBll.OrdonnanceDetailTable;
        }
    }
}
