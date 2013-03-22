using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CERPTerminal
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void tERMINALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Terminal t = new Terminal();
            t.MdiParent = this;
            t.Show();
        }
    }
}
