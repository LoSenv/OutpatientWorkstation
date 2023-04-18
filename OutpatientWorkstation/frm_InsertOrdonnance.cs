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
    public partial class frm_InsertOrdonnance : Form
    {
        public string _name;
        public int _no;
        public frm_InsertOrdonnance(string name) : this()
        {
            this._name = name;
        }
        public frm_InsertOrdonnance()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_InsertOrdonnance_Load(object sender, EventArgs e)
        {

        }
        private void btn_save_Click(object sender, EventArgs e)
        {


        }
        private void btn_load_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_insertDrug_Click(object sender, EventArgs e)
        {

        }
    }
}
