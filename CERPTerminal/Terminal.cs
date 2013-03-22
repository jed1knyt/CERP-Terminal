using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CERPTerminal
{
    public partial class Terminal : Form
    {
        public Terminal()
        {
            InitializeComponent();
        }

        private void Terminal_Load(object sender, EventArgs e)
        {
            GetSettings();

            SetTerminalIDs();

            LoadSrcTerminals();

            LoadOutBound();

            LoadTemplates();
            

        }

        public void LoadSrcTerminals()
        {
            cbSrcTerminal.DataSource = new BindingSource(CERP.GetSourceTerminals(Properties.Settings.Default.TerminalID), null); ;
            cbSrcTerminal.DisplayMember = "Value";
            cbSrcTerminal.ValueMember = "Key";
        }

        public void LoadOutBound()
        {
            cbOut.DataSource = new BindingSource(CERP.GetOutBound(Properties.Settings.Default.TerminalID), null); ;
            cbOut.DisplayMember = "Value";
            cbOut.ValueMember = "Key";
        }

        public void LoadTemplates()
        {
            listBox1.DataSource = CERP.GetTemplates(Properties.Settings.Default.TerminalID);
        }

        private void LoadItemDetails(string _barcode)
        {
            CERPWS.Service1 svc = new CERPWS.Service1();

            string result = svc.GetItemDetails(_barcode.Trim());

            StringReader sr = new StringReader(result);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("table");
            ds.ReadXml(sr);
            dt = ds.Tables[0];

            if (dt.Rows[0].ItemArray[0].ToString() == "0")
            {
                MessageBox.Show(dt.Rows[0].ItemArray[1].ToString());

                //TODO: clear properties
            }
            else
            {
                CERPProperties.ItemID = Convert.ToInt16(dt.Rows[0].ItemArray[0]);
                CERPProperties.ItemCode = dt.Rows[0].ItemArray[1].ToString();
                CERPProperties.Description = dt.Rows[0].ItemArray[2].ToString();
                CERPProperties.ProdTerminalID = Convert.ToInt16(dt.Rows[0].ItemArray[3]);
                CERPProperties.UOM = dt.Rows[0].ItemArray[4].ToString();

                tbItemCode.Text = CERPProperties.ItemCode;
                tbDescription.Text = CERPProperties.Description;
                tbUOM.Text = CERPProperties.UOM;
            }
        }

        private void cERPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cERPToolStripMenuItem.ForeColor = Color.Black;
        }

        private void cERPToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            cERPToolStripMenuItem.ForeColor = Color.White;
        }

        private void sETTINGSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings s = new Settings(this);
            s.ShowDialog();
        }

        private void rbIn_CheckedChanged(object sender, EventArgs e)
        {
            SetTerminalIDs();
            SetTemplate(Properties.Settings.Default.TerminalID);
        }

        private void rbOut_CheckedChanged(object sender, EventArgs e)
        {
            SetTerminalIDs();
            SetTemplate(Properties.Settings.Default.TerminalID);
        }
        
        public void SetTerminalIDs()
        {
            if (rbIn.Checked) // IN
            {
                cbSrcTerminal.Enabled = true;
                cbOut.Enabled = false;
                CERPProperties.TerminalID = Properties.Settings.Default.TerminalID;
                CERPProperties.SrcTerminalID = Convert.ToInt16(cbSrcTerminal.SelectedValue); //TODO: check
            }
            else // OUT
            {
                cbSrcTerminal.Enabled = false;
                cbOut.Enabled = true;
                CERPProperties.TerminalID = CERP.GetTerminalOut(Properties.Settings.Default.TerminalID);
                CERPProperties.SrcTerminalID = CERP.GetTerminalOut(Properties.Settings.Default.TerminalID);
            }
        }

        public void GetSettings()
        {
            CERPProperties.TerminalID = Properties.Settings.Default.TerminalID;
            CERPProperties.TerminalName = Properties.Settings.Default.TerminalName;

            lblTerminal.Text = Properties.Settings.Default.TerminalName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string type;
            int terminalID;
            int srcTerminalID;
            int statusID;

            if (tbBarcode.Text != "" && tbTrckNo.Text != "" && tbMatLotNo.Text != "" && tbProdLotNo.Text != "" && Convert.ToDecimal(tbQty.Text) > 0)
            {
                CERPWS.Service1 svc = new CERPWS.Service1();

                if (rbIn.Checked)  // INPUT
                {
                    type = "INPUT";
                    terminalID = Properties.Settings.Default.TerminalID;
                    srcTerminalID = Convert.ToInt16(cbSrcTerminal.SelectedValue);
                    statusID = CERP.GetTerminalStatusCode(CERPProperties.TerminalID);
                }
                else
                {
                    type = "OUTPUT";
                    terminalID = CERP.GetTerminalOut(Properties.Settings.Default.TerminalID);
                    srcTerminalID = CERP.GetTerminalOut(Properties.Settings.Default.TerminalID);
                    statusID = Convert.ToInt16(cbOut.SelectedValue);
                }

                int x = Convert.ToInt16(cbSrcTerminal.SelectedValue);
                int y = CERP.GetTerminalStatusCode(CERPProperties.TerminalID);
                int z = Convert.ToInt16(cbOut.SelectedValue);

                int result = svc.AdjustProductionInventory(type,
                                                            CERPProperties.ItemID,
                                                            "MAT",
                                                            tbTrckNo.Text.Trim(),
                                                            tbProdLotNo.Text.Trim(),
                                                            tbMatLotNo.Text.Trim(),
                                                            srcTerminalID,
                                                            terminalID,
                                                            2, //device id
                                                            statusID,
                                                            Convert.ToDecimal(tbQty.Text.Trim()),
                                                            tbRemarks.Text.Trim());
                MessageBox.Show("Adjusted");
            }            
        }

        private void cbSrcTerminal_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTemplate(Properties.Settings.Default.TerminalID);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            { 
                case 0: // Delivery from Warehouse
                    rbIn.Checked = true;
                    break;
                case 1: // Delivery from Warehouse
                    rbOut.Checked = true;
                    cbOut.SelectedIndex = 0;
                    break;
                case 2: // Delivery from Warehouse
                    rbOut.Checked = true;
                    cbOut.SelectedIndex = 1;
                    break;
                case 3: // Delivery from Warehouse
                    rbOut.Checked = true;
                    cbOut.SelectedIndex = 2;
                    break;
                case 4: // Delivery from Warehouse
                    rbOut.Checked = true;
                    cbOut.SelectedIndex = 3;
                    break;
                case 5: // Delivery from Warehouse
                    rbOut.Checked = true;
                    cbOut.SelectedIndex = 4;
                    break;
            }
            SetTerminalIDs();
        }

        private void SetTemplate(int _terminalID)
        {
            if (listBox1.Items.Count > 0)
            {
                if (rbIn.Checked)
                {
                    if (cbSrcTerminal.SelectedIndex == 0) // Warehouse
                        listBox1.SelectedIndex = 0;
                }
                else
                {
                    switch (cbOut.SelectedIndex)
                    {
                        case 0: // Endorse to Ink Fill
                            listBox1.SelectedIndex = 1;
                            break;
                        case 1: // Defect A
                            listBox1.SelectedIndex = 2;
                            break;
                        case 2: // Defect B
                            listBox1.SelectedIndex = 3;
                            break;
                        case 3: // QA Sample
                            listBox1.SelectedIndex = 4;
                            break;
                        case 4: // Manager's Sample
                            listBox1.SelectedIndex = 5;
                            break;
                    }
                }
            }
        }

        private void cbOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTemplate(Properties.Settings.Default.TerminalID);
        }


        private void tbBarcode_Enter(object sender, EventArgs e)
        {
            Scan s = new Scan(this, "ITEMCODE", tbBarcode);
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadItemDetails(tbBarcode.Text.Trim());
            }
        }

        private void tbBarcode_Click(object sender, EventArgs e)
        {
            Scan s = new Scan(this, "ITEMCODE", tbBarcode);
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadItemDetails(tbBarcode.Text.Trim());
            }
        }

        private void tbTrckNo_Click(object sender, EventArgs e)
        {
            Scan s = new Scan(this, "TRACKINGNO", tbTrckNo);
            s.ShowDialog();
        }

        private void tbTrckNo_Enter(object sender, EventArgs e)
        {
            Scan s = new Scan(this, "TRACKINGNO", tbTrckNo);
            s.ShowDialog();
        }

        private void tbMatLotNo_Click(object sender, EventArgs e)
        {
            Scan s = new Scan(this, "MATLOTNO", tbMatLotNo);
            s.ShowDialog();
        }

        private void tbMatLotNo_Enter(object sender, EventArgs e)
        {
            Scan s = new Scan(this, "MATLOTNO", tbMatLotNo);
            s.ShowDialog();
        }

        private void tbProdLotNo_Click(object sender, EventArgs e)
        {
            Scan s = new Scan(this, "PRODLOTNO", tbProdLotNo);
            s.ShowDialog();
        }

        private void tbProdLotNo_Enter(object sender, EventArgs e)
        {
            Scan s = new Scan(this, "PRODLOTNO", tbProdLotNo);
            s.ShowDialog();
        }

        private void tbBarcode_TextChanged(object sender, EventArgs e)
        {
            tbTrckNo.Focus();
        }

        
        
    }
}
