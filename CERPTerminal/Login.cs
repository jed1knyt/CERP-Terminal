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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tbEmpNo.Text = Properties.Settings.Default.LastUser;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (tbEmpNo.Text.Trim() != "" && tbPwd.Text.Trim() != "")
            {
                RememberMe(tbEmpNo.Text.Trim());

                CERPWS.Service1 svc = new CERPWS.Service1();
                StringReader sr = new StringReader(svc.Login(tbEmpNo.Text, tbPwd.Text));
                DataSet ds = new DataSet();
                DataTable dt = new DataTable("table");
                ds.ReadXml(sr);
                dt = ds.Tables[0];

                if (Convert.ToInt32(dt.Rows[0].ItemArray[0]) == 0)
                {
                    MessageBox.Show(dt.Rows[0].ItemArray[1].ToString());
                }
                else
                {
                    CERP.gUserID = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
                    CERP.gUserName = dt.Rows[0].ItemArray[2].ToString() + ", " + dt.Rows[0].ItemArray[1].ToString();
                    CERP.gRole = Convert.ToInt32(dt.Rows[0].ItemArray[3].ToString());

                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void RememberMe(string name)
        {
            if (chkRemember.Checked && name != "")
            {
                Properties.Settings.Default.LastUser = name;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.LastUser = "";
                Properties.Settings.Default.Save();
            }
        }
    }
}
