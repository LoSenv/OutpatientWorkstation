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
    public partial class frm_Dhome : Form
    {
        private string _name;
        public
            frm_Dhome(string name) : this()
        {
            this._name = name;
        }
        public frm_Dhome()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_Dhome_Load(object sender, EventArgs e)
        {

        }

        private void tsm_pview_Click(object sender, EventArgs e)
        {
            frm_ViewPatient frm_ViewClient = new frm_ViewPatient();
            frm_ViewClient.TopLevel = false;
            frm_ViewClient.FormBorderStyle = FormBorderStyle.None;
            frm_ViewClient.Dock = DockStyle.Fill;
            this.pnl_content.Controls.Clear();
            this.pnl_content.Controls.Add(frm_ViewClient);
            frm_ViewClient.Show();
        }

        private void tsm_mview_Click(object sender, EventArgs e)
        {
            frm_ViewMedicine frm_ViewMedicine = new frm_ViewMedicine();
            frm_ViewMedicine.TopLevel = false;
            frm_ViewMedicine.FormBorderStyle = FormBorderStyle.None;
            frm_ViewMedicine.Dock = DockStyle.Fill;
            this.pnl_content.Controls.Clear();
            this.pnl_content.Controls.Add(frm_ViewMedicine);
            frm_ViewMedicine.Show();
        }
    }
}
