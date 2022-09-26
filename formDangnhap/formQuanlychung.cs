using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formDangnhap
{
    public partial class formQuanlychung : Form
    {
        public formQuanlychung()
        {
            InitializeComponent();
        }

        private void Quanlichung_Load(object sender, EventArgs e)
        {

        }

        private void tsbDoimatkhau_Click(object sender, EventArgs e)
        {
            formDoimatkhau doimatkhau = new formDoimatkhau();
            doimatkhau.ShowDialog();
        }
    }
}
