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
    public partial class Settings : Form
    {
        public Settings(Form _parent)
        {
            InitializeComponent();
            this.Owner = _parent;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            //TODO: Check if uninitialized
            cbTerminal.DataSource = new BindingSource(CERP.GetProductionTerminals(), null);
            cbTerminal.DisplayMember = "Value";
            cbTerminal.ValueMember = "Key";

            cbTerminal.SelectedValue = Properties.Settings.Default.TerminalID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string terminalName = ((Dictionary<int, string>)((BindingSource)cbTerminal.DataSource).DataSource)[Convert.ToInt16(cbTerminal.SelectedValue)];

            Properties.Settings.Default.TerminalID = Convert.ToInt16(cbTerminal.SelectedValue);
            Properties.Settings.Default.TerminalName = terminalName;
            Properties.Settings.Default.Save();
            MessageBox.Show("Settings saved.");

            //Update changes on Parent
            Terminal t = (Terminal) this.Owner;
            t.GetSettings();
            t.SetTerminalIDs();
            t.LoadSrcTerminals();
            t.LoadOutBound();
            t.LoadTemplates();

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
