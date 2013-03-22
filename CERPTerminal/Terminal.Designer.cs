namespace CERPTerminal
{
    partial class Terminal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbOut = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbItemCode = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.tbUOM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSrcTerminal = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbOut = new System.Windows.Forms.RadioButton();
            this.rbIn = new System.Windows.Forms.RadioButton();
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbProdLotNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMatLotNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTrckNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTerminal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cERPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sETTINGSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.cbOut);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.tbUOM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbSrcTerminal);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.tbRemarks);
            this.groupBox1.Controls.Add(this.tbQty);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbProdLotNo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbMatLotNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbTrckNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblTerminal);
            this.groupBox1.Controls.Add(this.shapeContainer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 489);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // cbOut
            // 
            this.cbOut.Enabled = false;
            this.cbOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOut.FormattingEnabled = true;
            this.cbOut.Location = new System.Drawing.Point(192, 163);
            this.cbOut.Name = "cbOut";
            this.cbOut.Size = new System.Drawing.Size(220, 28);
            this.cbOut.TabIndex = 3;
            this.cbOut.SelectedIndexChanged += new System.EventHandler(this.cbOut_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(578, 409);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 58);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbDescription);
            this.panel2.Controls.Add(this.tbItemCode);
            this.panel2.Location = new System.Drawing.Point(417, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 172);
            this.panel2.TabIndex = 66;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.White;
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(7, 76);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(220, 90);
            this.tbDescription.TabIndex = 54;
            // 
            // tbItemCode
            // 
            this.tbItemCode.BackColor = System.Drawing.Color.White;
            this.tbItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemCode.Location = new System.Drawing.Point(7, 44);
            this.tbItemCode.Name = "tbItemCode";
            this.tbItemCode.ReadOnly = true;
            this.tbItemCode.Size = new System.Drawing.Size(220, 26);
            this.tbItemCode.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel3.Controls.Add(this.tbBarcode);
            this.panel3.Location = new System.Drawing.Point(185, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 38);
            this.panel3.TabIndex = 67;
            // 
            // tbBarcode
            // 
            this.tbBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBarcode.Location = new System.Drawing.Point(7, 5);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(220, 26);
            this.tbBarcode.TabIndex = 4;
            this.tbBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBarcode.Click += new System.EventHandler(this.tbBarcode_Click);
            this.tbBarcode.TextChanged += new System.EventHandler(this.tbBarcode_TextChanged);
            this.tbBarcode.Enter += new System.EventHandler(this.tbBarcode_Enter);
            // 
            // tbUOM
            // 
            this.tbUOM.BackColor = System.Drawing.Color.White;
            this.tbUOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUOM.Location = new System.Drawing.Point(319, 371);
            this.tbUOM.Name = "tbUOM";
            this.tbUOM.ReadOnly = true;
            this.tbUOM.Size = new System.Drawing.Size(92, 26);
            this.tbUOM.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Source :";
            // 
            // cbSrcTerminal
            // 
            this.cbSrcTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSrcTerminal.FormattingEnabled = true;
            this.cbSrcTerminal.Location = new System.Drawing.Point(192, 129);
            this.cbSrcTerminal.Name = "cbSrcTerminal";
            this.cbSrcTerminal.Size = new System.Drawing.Size(220, 28);
            this.cbSrcTerminal.TabIndex = 2;
            this.cbSrcTerminal.SelectedIndexChanged += new System.EventHandler(this.cbSrcTerminal_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbOut);
            this.panel1.Controls.Add(this.rbIn);
            this.panel1.Location = new System.Drawing.Point(192, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 30);
            this.panel1.TabIndex = 58;
            // 
            // rbOut
            // 
            this.rbOut.AutoSize = true;
            this.rbOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOut.Location = new System.Drawing.Point(126, 3);
            this.rbOut.Name = "rbOut";
            this.rbOut.Size = new System.Drawing.Size(60, 24);
            this.rbOut.TabIndex = 1;
            this.rbOut.Text = "OUT";
            this.rbOut.UseVisualStyleBackColor = true;
            this.rbOut.CheckedChanged += new System.EventHandler(this.rbOut_CheckedChanged);
            // 
            // rbIn
            // 
            this.rbIn.AutoSize = true;
            this.rbIn.Checked = true;
            this.rbIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIn.Location = new System.Drawing.Point(55, 3);
            this.rbIn.Name = "rbIn";
            this.rbIn.Size = new System.Drawing.Size(43, 24);
            this.rbIn.TabIndex = 0;
            this.rbIn.TabStop = true;
            this.rbIn.Text = "IN";
            this.rbIn.UseVisualStyleBackColor = true;
            this.rbIn.CheckedChanged += new System.EventHandler(this.rbIn_CheckedChanged);
            // 
            // tbRemarks
            // 
            this.tbRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemarks.Location = new System.Drawing.Point(192, 409);
            this.tbRemarks.Multiline = true;
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(380, 58);
            this.tbRemarks.TabIndex = 9;
            // 
            // tbQty
            // 
            this.tbQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQty.Location = new System.Drawing.Point(192, 371);
            this.tbQty.Name = "tbQty";
            this.tbQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbQty.Size = new System.Drawing.Size(122, 26);
            this.tbQty.TabIndex = 8;
            this.tbQty.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(106, 411);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 51;
            this.label12.Text = "Remarks :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(111, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "Quantity :";
            // 
            // tbProdLotNo
            // 
            this.tbProdLotNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProdLotNo.Location = new System.Drawing.Point(192, 339);
            this.tbProdLotNo.Name = "tbProdLotNo";
            this.tbProdLotNo.Size = new System.Drawing.Size(220, 26);
            this.tbProdLotNo.TabIndex = 7;
            this.tbProdLotNo.Click += new System.EventHandler(this.tbProdLotNo_Click);
            this.tbProdLotNo.Enter += new System.EventHandler(this.tbProdLotNo_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Material Lot No. :";
            // 
            // tbMatLotNo
            // 
            this.tbMatLotNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatLotNo.Location = new System.Drawing.Point(191, 307);
            this.tbMatLotNo.Name = "tbMatLotNo";
            this.tbMatLotNo.Size = new System.Drawing.Size(220, 26);
            this.tbMatLotNo.TabIndex = 6;
            this.tbMatLotNo.Click += new System.EventHandler(this.tbMatLotNo_Click);
            this.tbMatLotNo.Enter += new System.EventHandler(this.tbMatLotNo_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Production Lot No. :";
            // 
            // tbTrckNo
            // 
            this.tbTrckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTrckNo.Location = new System.Drawing.Point(192, 275);
            this.tbTrckNo.Name = "tbTrckNo";
            this.tbTrckNo.Size = new System.Drawing.Size(220, 26);
            this.tbTrckNo.TabIndex = 5;
            this.tbTrckNo.Click += new System.EventHandler(this.tbTrckNo_Click);
            this.tbTrckNo.Enter += new System.EventHandler(this.tbTrckNo_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Tracking No. :";
            // 
            // lblTerminal
            // 
            this.lblTerminal.AutoSize = true;
            this.lblTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminal.Location = new System.Drawing.Point(23, 15);
            this.lblTerminal.Name = "lblTerminal";
            this.lblTerminal.Size = new System.Drawing.Size(90, 20);
            this.lblTerminal.TabIndex = 39;
            this.lblTerminal.Text = "TERMINAL";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cERPToolStripMenuItem,
            this.sETTINGSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 29);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cERPToolStripMenuItem
            // 
            this.cERPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.cERPToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cERPToolStripMenuItem.Name = "cERPToolStripMenuItem";
            this.cERPToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.cERPToolStripMenuItem.Text = "CERP";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // sETTINGSToolStripMenuItem
            // 
            this.sETTINGSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sETTINGSToolStripMenuItem.Name = "sETTINGSToolStripMenuItem";
            this.sETTINGSToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.sETTINGSToolStripMenuItem.Text = "SETTINGS";
            this.sETTINGSToolStripMenuItem.Click += new System.EventHandler(this.sETTINGSToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(418, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 144);
            this.listBox1.TabIndex = 71;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Templates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Destination :";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(683, 470);
            this.shapeContainer1.TabIndex = 74;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.LightGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 17;
            this.lineShape1.X2 = 656;
            this.lineShape1.Y1 = 25;
            this.lineShape1.Y2 = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Info";
            // 
            // Terminal
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(713, 541);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Terminal";
            this.Text = "CERP - Terminal";
            this.Load += new System.EventHandler(this.Terminal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cERPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbOut;
        private System.Windows.Forms.RadioButton rbIn;
        private System.Windows.Forms.TextBox tbRemarks;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbProdLotNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMatLotNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTrckNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbItemCode;
        private System.Windows.Forms.ToolStripMenuItem sETTINGSToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSrcTerminal;
        public System.Windows.Forms.Label lblTerminal;
        private System.Windows.Forms.TextBox tbUOM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbOut;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        public System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.Label label4;
    }
}