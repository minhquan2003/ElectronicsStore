using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom08_CuaHangDienDienLanh
{
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
        }
        
        public DataGridView DgvView
        {
            get { return dgvView; }
            set { dgvView = value; }
        }

        public Label lbView
        {
            get { return lbTenView; }
            set { lbTenView = value; }
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            
        }
    }
}
