using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C01
{
    public partial class errorBox : Form
    {
        public errorBox()
        {
            InitializeComponent();
        }

        private void btnErrorOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
