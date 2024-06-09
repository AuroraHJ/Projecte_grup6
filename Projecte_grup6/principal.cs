using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecte_grup6
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void llistatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            llistats llista = new llistats();
            llista.MdiParent = this;
            llista.Show();

        }

        private void unAltreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GP_Results gp = new GP_Results();
            gp.MdiParent = this;
            gp.Show();
        }
    }
}
