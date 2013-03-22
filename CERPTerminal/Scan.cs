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
    public partial class Scan : Form
    {
        string type;
        TextBox caller;

        public Scan(Form _parent, string _type, TextBox _caller)
        {
            InitializeComponent();
            this.Owner = _parent;
            type = _type;
            caller = _caller;
        }

        private void Scan_Load(object sender, EventArgs e)
        {
            switch (type)
            {
                case "ITEMCODE":
                    lblMessage.Text = "SCAN the item serial.";
                    break;
                case "TRACKINGNO":
                    lblMessage.Text = "SCAN the TRACKING Number.";
                    break;
                case "MATLOTNO":
                    lblMessage.Text = "SCAN the MATERIAL LOT Number.";
                    break;
                case "PRODLOTNO":
                    lblMessage.Text = "SCAN the PRODUCTION LOT Number.";
                    break;
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbBarcode.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbBarcode.Text != "")
            {
                caller.Text = tbBarcode.Text.Trim();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
