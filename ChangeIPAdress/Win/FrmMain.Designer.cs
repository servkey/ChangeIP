namespace ChangeIPAdress.Win
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tsbMain = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbApply = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.tsmProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmApply = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPreference = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLSpanish = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.TabProfiles = new System.Windows.Forms.TabControl();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.grpProfiles = new System.Windows.Forms.GroupBox();
            this.lstProfiles = new System.Windows.Forms.ListBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblDNSServer = new System.Windows.Forms.Label();
            this.lblTDNSServer = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.lblTGateway = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lblNetworkInterface = new System.Windows.Forms.Label();
            this.lblTIPAddress = new System.Windows.Forms.Label();
            this.lblTNetworkInterface = new System.Windows.Forms.Label();
            this.tabNew = new System.Windows.Forms.TabPage();
            this.rdbSpecifyDNS = new System.Windows.Forms.RadioButton();
            this.pnlIPs = new System.Windows.Forms.Panel();
            this.rdbSpecifyIp = new System.Windows.Forms.RadioButton();
            this.rdbIpAutomatically = new System.Windows.Forms.RadioButton();
            this.grpIPAddress = new System.Windows.Forms.GroupBox();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.lblGatewayTxt = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.lblIPSubnetTxt = new System.Windows.Forms.Label();
            this.txtIPSubnet = new System.Windows.Forms.TextBox();
            this.lblIPAddressTxt = new System.Windows.Forms.Label();
            this.txtProfile = new System.Windows.Forms.TextBox();
            this.lblTProfile = new System.Windows.Forms.Label();
            this.rdbDNSAutomatically = new System.Windows.Forms.RadioButton();
            this.lblTNetworkInterfaceCmb = new System.Windows.Forms.Label();
            this.cmbInterfaces = new System.Windows.Forms.ComboBox();
            this.grpDNSServer = new System.Windows.Forms.GroupBox();
            this.lblTDNSServerTxt = new System.Windows.Forms.Label();
            this.txtDNSServer = new System.Windows.Forms.TextBox();
            this.tabConsole = new System.Windows.Forms.TabPage();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.ssbMain = new System.Windows.Forms.StatusStrip();
            this.tsbMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.TabProfiles.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.grpProfiles.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.tabNew.SuspendLayout();
            this.pnlIPs.SuspendLayout();
            this.grpIPAddress.SuspendLayout();
            this.grpDNSServer.SuspendLayout();
            this.tabConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsbMain
            // 
            this.tsbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbNew,
            this.tsbDelete,
            this.tsbApply,
            this.tsbExit});
            this.tsbMain.Location = new System.Drawing.Point(0, 24);
            this.tsbMain.Name = "tsbMain";
            this.tsbMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsbMain.Size = new System.Drawing.Size(331, 25);
            this.tsbMain.TabIndex = 1;
            this.tsbMain.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::ChangeIPAdress.Properties.Resources.disk;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "Save profile";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = global::ChangeIPAdress.Properties.Resources.New;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(23, 22);
            this.tsbNew.Text = "New...";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::ChangeIPAdress.Properties.Resources.Delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "Delete profile";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbApply
            // 
            this.tsbApply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbApply.Image = global::ChangeIPAdress.Properties.Resources.camera_test;
            this.tsbApply.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApply.Name = "tsbApply";
            this.tsbApply.Size = new System.Drawing.Size(23, 22);
            this.tsbApply.Text = "Apply profile";
            this.tsbApply.Click += new System.EventHandler(this.tsbApply_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = global::ChangeIPAdress.Properties.Resources.exit;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(23, 22);
            this.tsbExit.Text = "Exit";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.SystemColors.Menu;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProfile,
            this.tsmPreference,
            this.tsmHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(331, 24);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            this.mnuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuMain_ItemClicked);
            // 
            // tsmProfile
            // 
            this.tsmProfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNew,
            this.tsmSave,
            this.tsmApply,
            this.tsmDelete,
            this.toolStripMenuItem2,
            this.tsmExit});
            this.tsmProfile.Name = "tsmProfile";
            this.tsmProfile.Size = new System.Drawing.Size(53, 20);
            this.tsmProfile.Text = "Profile";
            // 
            // tsmNew
            // 
            this.tsmNew.Name = "tsmNew";
            this.tsmNew.Size = new System.Drawing.Size(107, 22);
            this.tsmNew.Text = "New...";
            this.tsmNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsmSave
            // 
            this.tsmSave.Name = "tsmSave";
            this.tsmSave.Size = new System.Drawing.Size(107, 22);
            this.tsmSave.Text = "Save";
            this.tsmSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsmApply
            // 
            this.tsmApply.Name = "tsmApply";
            this.tsmApply.Size = new System.Drawing.Size(107, 22);
            this.tsmApply.Text = "Apply";
            this.tsmApply.Click += new System.EventHandler(this.tsbApply_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(107, 22);
            this.tsmDelete.Text = "Delete";
            this.tsmDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(104, 6);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(107, 22);
            this.tsmExit.Text = "Exit";
            this.tsmExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // tsmPreference
            // 
            this.tsmPreference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLanguage});
            this.tsmPreference.Name = "tsmPreference";
            this.tsmPreference.Size = new System.Drawing.Size(80, 20);
            this.tsmPreference.Text = "Preferences";
            // 
            // tsmLanguage
            // 
            this.tsmLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLEnglish,
            this.tsmLSpanish});
            this.tsmLanguage.Name = "tsmLanguage";
            this.tsmLanguage.Size = new System.Drawing.Size(152, 22);
            this.tsmLanguage.Text = "Language";
            // 
            // tsmLEnglish
            // 
            this.tsmLEnglish.Name = "tsmLEnglish";
            this.tsmLEnglish.Size = new System.Drawing.Size(152, 22);
            this.tsmLEnglish.Text = "English";
            this.tsmLEnglish.Click += new System.EventHandler(this.tsmEnglish_Click);
            // 
            // tsmLSpanish
            // 
            this.tsmLSpanish.CheckOnClick = true;
            this.tsmLSpanish.Name = "tsmLSpanish";
            this.tsmLSpanish.Size = new System.Drawing.Size(152, 22);
            this.tsmLSpanish.Text = "Spanish";
            this.tsmLSpanish.Click += new System.EventHandler(this.tsmEnglish_Click);
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbout});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(44, 20);
            this.tsmHelp.Text = "Help";
            // 
            // tsmAbout
            // 
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(116, 22);
            this.tsmAbout.Text = "About...";
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // TabProfiles
            // 
            this.TabProfiles.Controls.Add(this.tabProfile);
            this.TabProfiles.Controls.Add(this.tabNew);
            this.TabProfiles.Controls.Add(this.tabConsole);
            this.TabProfiles.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.TabProfiles.Location = new System.Drawing.Point(5, 52);
            this.TabProfiles.Name = "TabProfiles";
            this.TabProfiles.SelectedIndex = 0;
            this.TabProfiles.Size = new System.Drawing.Size(320, 343);
            this.TabProfiles.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TabProfiles.TabIndex = 1;
            this.TabProfiles.SelectedIndexChanged += new System.EventHandler(this.TabProfiles_SelectedIndexChanged);
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.grpProfiles);
            this.tabProfile.Controls.Add(this.grpDetails);
            this.tabProfile.Location = new System.Drawing.Point(4, 22);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Size = new System.Drawing.Size(312, 317);
            this.tabProfile.TabIndex = 2;
            this.tabProfile.Text = "Profiles";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // grpProfiles
            // 
            this.grpProfiles.Controls.Add(this.lstProfiles);
            this.grpProfiles.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpProfiles.Location = new System.Drawing.Point(5, 49);
            this.grpProfiles.Name = "grpProfiles";
            this.grpProfiles.Size = new System.Drawing.Size(142, 219);
            this.grpProfiles.TabIndex = 2;
            this.grpProfiles.TabStop = false;
            this.grpProfiles.Text = "Select Profile";
            // 
            // lstProfiles
            // 
            this.lstProfiles.FormattingEnabled = true;
            this.lstProfiles.Location = new System.Drawing.Point(8, 19);
            this.lstProfiles.Name = "lstProfiles";
            this.lstProfiles.Size = new System.Drawing.Size(125, 186);
            this.lstProfiles.TabIndex = 1;
            this.lstProfiles.Click += new System.EventHandler(this.lstProfiles_Click);
            this.lstProfiles.SelectedIndexChanged += new System.EventHandler(this.lstProfiles_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.lblDNSServer);
            this.grpDetails.Controls.Add(this.lblTDNSServer);
            this.grpDetails.Controls.Add(this.lblGateway);
            this.grpDetails.Controls.Add(this.lblTGateway);
            this.grpDetails.Controls.Add(this.lblIPAddress);
            this.grpDetails.Controls.Add(this.lblNetworkInterface);
            this.grpDetails.Controls.Add(this.lblTIPAddress);
            this.grpDetails.Controls.Add(this.lblTNetworkInterface);
            this.grpDetails.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpDetails.Location = new System.Drawing.Point(153, 49);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(146, 219);
            this.grpDetails.TabIndex = 1;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details";
            // 
            // lblDNSServer
            // 
            this.lblDNSServer.AutoSize = true;
            this.lblDNSServer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDNSServer.Location = new System.Drawing.Point(6, 180);
            this.lblDNSServer.Name = "lblDNSServer";
            this.lblDNSServer.Size = new System.Drawing.Size(19, 13);
            this.lblDNSServer.TabIndex = 8;
            this.lblDNSServer.Text = "----";
            // 
            // lblTDNSServer
            // 
            this.lblTDNSServer.AutoSize = true;
            this.lblTDNSServer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTDNSServer.Location = new System.Drawing.Point(6, 163);
            this.lblTDNSServer.Name = "lblTDNSServer";
            this.lblTDNSServer.Size = new System.Drawing.Size(64, 13);
            this.lblTDNSServer.TabIndex = 7;
            this.lblTDNSServer.Text = "DNS Server";
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGateway.Location = new System.Drawing.Point(6, 133);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(19, 13);
            this.lblGateway.TabIndex = 6;
            this.lblGateway.Text = "----";
            // 
            // lblTGateway
            // 
            this.lblTGateway.AutoSize = true;
            this.lblTGateway.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTGateway.Location = new System.Drawing.Point(6, 116);
            this.lblTGateway.Name = "lblTGateway";
            this.lblTGateway.Size = new System.Drawing.Size(49, 13);
            this.lblTGateway.TabIndex = 5;
            this.lblTGateway.Text = "Gateway";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIPAddress.Location = new System.Drawing.Point(6, 88);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(19, 13);
            this.lblIPAddress.TabIndex = 4;
            this.lblIPAddress.Text = "----";
            // 
            // lblNetworkInterface
            // 
            this.lblNetworkInterface.AutoSize = true;
            this.lblNetworkInterface.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNetworkInterface.Location = new System.Drawing.Point(6, 48);
            this.lblNetworkInterface.Name = "lblNetworkInterface";
            this.lblNetworkInterface.Size = new System.Drawing.Size(19, 13);
            this.lblNetworkInterface.TabIndex = 3;
            this.lblNetworkInterface.Text = "----";
            // 
            // lblTIPAddress
            // 
            this.lblTIPAddress.AutoSize = true;
            this.lblTIPAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTIPAddress.Location = new System.Drawing.Point(6, 71);
            this.lblTIPAddress.Name = "lblTIPAddress";
            this.lblTIPAddress.Size = new System.Drawing.Size(58, 13);
            this.lblTIPAddress.TabIndex = 2;
            this.lblTIPAddress.Text = "IP Address";
            // 
            // lblTNetworkInterface
            // 
            this.lblTNetworkInterface.AutoSize = true;
            this.lblTNetworkInterface.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTNetworkInterface.Location = new System.Drawing.Point(5, 31);
            this.lblTNetworkInterface.Name = "lblTNetworkInterface";
            this.lblTNetworkInterface.Size = new System.Drawing.Size(92, 13);
            this.lblTNetworkInterface.TabIndex = 0;
            this.lblTNetworkInterface.Text = "Network Interface";
            // 
            // tabNew
            // 
            this.tabNew.Controls.Add(this.rdbSpecifyDNS);
            this.tabNew.Controls.Add(this.pnlIPs);
            this.tabNew.Controls.Add(this.txtProfile);
            this.tabNew.Controls.Add(this.lblTProfile);
            this.tabNew.Controls.Add(this.rdbDNSAutomatically);
            this.tabNew.Controls.Add(this.lblTNetworkInterfaceCmb);
            this.tabNew.Controls.Add(this.cmbInterfaces);
            this.tabNew.Controls.Add(this.grpDNSServer);
            this.tabNew.Location = new System.Drawing.Point(4, 22);
            this.tabNew.Name = "tabNew";
            this.tabNew.Padding = new System.Windows.Forms.Padding(3);
            this.tabNew.Size = new System.Drawing.Size(312, 317);
            this.tabNew.TabIndex = 0;
            this.tabNew.Text = "New";
            this.tabNew.UseVisualStyleBackColor = true;
            // 
            // rdbSpecifyDNS
            // 
            this.rdbSpecifyDNS.AutoSize = true;
            this.rdbSpecifyDNS.BackColor = System.Drawing.Color.White;
            this.rdbSpecifyDNS.Location = new System.Drawing.Point(46, 255);
            this.rdbSpecifyDNS.Name = "rdbSpecifyDNS";
            this.rdbSpecifyDNS.Size = new System.Drawing.Size(206, 17);
            this.rdbSpecifyDNS.TabIndex = 6;
            this.rdbSpecifyDNS.TabStop = true;
            this.rdbSpecifyDNS.Text = "Use the following DNS Server address";
            this.rdbSpecifyDNS.UseVisualStyleBackColor = false;
            this.rdbSpecifyDNS.CheckedChanged += new System.EventHandler(this.rdbSpecifyDNS_CheckedChanged);
            // 
            // pnlIPs
            // 
            this.pnlIPs.Controls.Add(this.rdbSpecifyIp);
            this.pnlIPs.Controls.Add(this.rdbIpAutomatically);
            this.pnlIPs.Controls.Add(this.grpIPAddress);
            this.pnlIPs.Location = new System.Drawing.Point(33, 81);
            this.pnlIPs.Name = "pnlIPs";
            this.pnlIPs.Size = new System.Drawing.Size(239, 150);
            this.pnlIPs.TabIndex = 4;
            // 
            // rdbSpecifyIp
            // 
            this.rdbSpecifyIp.AutoSize = true;
            this.rdbSpecifyIp.BackColor = System.Drawing.Color.White;
            this.rdbSpecifyIp.Location = new System.Drawing.Point(12, 26);
            this.rdbSpecifyIp.Name = "rdbSpecifyIp";
            this.rdbSpecifyIp.Size = new System.Drawing.Size(128, 17);
            this.rdbSpecifyIp.TabIndex = 2;
            this.rdbSpecifyIp.TabStop = true;
            this.rdbSpecifyIp.Text = "Specify an IP address";
            this.rdbSpecifyIp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbSpecifyIp.UseVisualStyleBackColor = false;
            this.rdbSpecifyIp.CheckedChanged += new System.EventHandler(this.rdbSpecifyIp_CheckedChanged);
            // 
            // rdbIpAutomatically
            // 
            this.rdbIpAutomatically.AutoSize = true;
            this.rdbIpAutomatically.Checked = true;
            this.rdbIpAutomatically.Location = new System.Drawing.Point(12, 8);
            this.rdbIpAutomatically.Name = "rdbIpAutomatically";
            this.rdbIpAutomatically.Size = new System.Drawing.Size(174, 17);
            this.rdbIpAutomatically.TabIndex = 1;
            this.rdbIpAutomatically.TabStop = true;
            this.rdbIpAutomatically.Text = "Obtain IP Address automatically";
            this.rdbIpAutomatically.UseVisualStyleBackColor = true;
            // 
            // grpIPAddress
            // 
            this.grpIPAddress.Controls.Add(this.txtGateway);
            this.grpIPAddress.Controls.Add(this.lblGatewayTxt);
            this.grpIPAddress.Controls.Add(this.txtIPAddress);
            this.grpIPAddress.Controls.Add(this.lblIPSubnetTxt);
            this.grpIPAddress.Controls.Add(this.txtIPSubnet);
            this.grpIPAddress.Controls.Add(this.lblIPAddressTxt);
            this.grpIPAddress.Enabled = false;
            this.grpIPAddress.Location = new System.Drawing.Point(6, 28);
            this.grpIPAddress.Name = "grpIPAddress";
            this.grpIPAddress.Size = new System.Drawing.Size(227, 117);
            this.grpIPAddress.TabIndex = 20;
            this.grpIPAddress.TabStop = false;
            // 
            // txtGateway
            // 
            this.txtGateway.Location = new System.Drawing.Point(75, 85);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(139, 20);
            this.txtGateway.TabIndex = 3;
            // 
            // lblGatewayTxt
            // 
            this.lblGatewayTxt.AutoSize = true;
            this.lblGatewayTxt.Location = new System.Drawing.Point(20, 87);
            this.lblGatewayTxt.Name = "lblGatewayTxt";
            this.lblGatewayTxt.Size = new System.Drawing.Size(49, 13);
            this.lblGatewayTxt.TabIndex = 19;
            this.lblGatewayTxt.Text = "Gateway";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(75, 25);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(139, 20);
            this.txtIPAddress.TabIndex = 1;
            // 
            // lblIPSubnetTxt
            // 
            this.lblIPSubnetTxt.AutoSize = true;
            this.lblIPSubnetTxt.Location = new System.Drawing.Point(15, 58);
            this.lblIPSubnetTxt.Name = "lblIPSubnetTxt";
            this.lblIPSubnetTxt.Size = new System.Drawing.Size(54, 13);
            this.lblIPSubnetTxt.TabIndex = 18;
            this.lblIPSubnetTxt.Text = "IP Subnet";
            // 
            // txtIPSubnet
            // 
            this.txtIPSubnet.Location = new System.Drawing.Point(75, 55);
            this.txtIPSubnet.Name = "txtIPSubnet";
            this.txtIPSubnet.Size = new System.Drawing.Size(139, 20);
            this.txtIPSubnet.TabIndex = 2;
            // 
            // lblIPAddressTxt
            // 
            this.lblIPAddressTxt.AutoSize = true;
            this.lblIPAddressTxt.Location = new System.Drawing.Point(11, 28);
            this.lblIPAddressTxt.Name = "lblIPAddressTxt";
            this.lblIPAddressTxt.Size = new System.Drawing.Size(58, 13);
            this.lblIPAddressTxt.TabIndex = 1;
            this.lblIPAddressTxt.Text = "IP Address";
            // 
            // txtProfile
            // 
            this.txtProfile.Location = new System.Drawing.Point(108, 12);
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.Size = new System.Drawing.Size(159, 20);
            this.txtProfile.TabIndex = 1;
            this.txtProfile.Text = "New Profile...";
            // 
            // lblTProfile
            // 
            this.lblTProfile.AutoSize = true;
            this.lblTProfile.Location = new System.Drawing.Point(40, 15);
            this.lblTProfile.Name = "lblTProfile";
            this.lblTProfile.Size = new System.Drawing.Size(67, 13);
            this.lblTProfile.TabIndex = 3;
            this.lblTProfile.Text = "Profile Name";
            // 
            // rdbDNSAutomatically
            // 
            this.rdbDNSAutomatically.AutoSize = true;
            this.rdbDNSAutomatically.Checked = true;
            this.rdbDNSAutomatically.Location = new System.Drawing.Point(46, 235);
            this.rdbDNSAutomatically.Name = "rdbDNSAutomatically";
            this.rdbDNSAutomatically.Size = new System.Drawing.Size(221, 17);
            this.rdbDNSAutomatically.TabIndex = 5;
            this.rdbDNSAutomatically.TabStop = true;
            this.rdbDNSAutomatically.Text = "Obtain DNS Server Address automatically";
            this.rdbDNSAutomatically.UseVisualStyleBackColor = true;
            // 
            // lblTNetworkInterfaceCmb
            // 
            this.lblTNetworkInterfaceCmb.AutoSize = true;
            this.lblTNetworkInterfaceCmb.Location = new System.Drawing.Point(110, 40);
            this.lblTNetworkInterfaceCmb.Name = "lblTNetworkInterfaceCmb";
            this.lblTNetworkInterfaceCmb.Size = new System.Drawing.Size(92, 13);
            this.lblTNetworkInterfaceCmb.TabIndex = 3;
            this.lblTNetworkInterfaceCmb.Text = "Network Interface";
            // 
            // cmbInterfaces
            // 
            this.cmbInterfaces.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbInterfaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterfaces.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbInterfaces.FormattingEnabled = true;
            this.cmbInterfaces.Location = new System.Drawing.Point(39, 56);
            this.cmbInterfaces.Name = "cmbInterfaces";
            this.cmbInterfaces.Size = new System.Drawing.Size(227, 21);
            this.cmbInterfaces.TabIndex = 2;
            this.cmbInterfaces.SelectedIndexChanged += new System.EventHandler(this.cmbInterfaces_SelectedIndexChanged);
            // 
            // grpDNSServer
            // 
            this.grpDNSServer.Controls.Add(this.lblTDNSServerTxt);
            this.grpDNSServer.Controls.Add(this.txtDNSServer);
            this.grpDNSServer.Enabled = false;
            this.grpDNSServer.Location = new System.Drawing.Point(38, 259);
            this.grpDNSServer.Name = "grpDNSServer";
            this.grpDNSServer.Size = new System.Drawing.Size(227, 53);
            this.grpDNSServer.TabIndex = 7;
            this.grpDNSServer.TabStop = false;
            // 
            // lblTDNSServerTxt
            // 
            this.lblTDNSServerTxt.AutoSize = true;
            this.lblTDNSServerTxt.Location = new System.Drawing.Point(5, 26);
            this.lblTDNSServerTxt.Name = "lblTDNSServerTxt";
            this.lblTDNSServerTxt.Size = new System.Drawing.Size(64, 13);
            this.lblTDNSServerTxt.TabIndex = 14;
            this.lblTDNSServerTxt.Text = "DNS Server";
            // 
            // txtDNSServer
            // 
            this.txtDNSServer.Location = new System.Drawing.Point(75, 22);
            this.txtDNSServer.Name = "txtDNSServer";
            this.txtDNSServer.Size = new System.Drawing.Size(139, 20);
            this.txtDNSServer.TabIndex = 0;
            // 
            // tabConsole
            // 
            this.tabConsole.Controls.Add(this.txtConsole);
            this.tabConsole.Location = new System.Drawing.Point(4, 22);
            this.tabConsole.Name = "tabConsole";
            this.tabConsole.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsole.Size = new System.Drawing.Size(312, 317);
            this.tabConsole.TabIndex = 1;
            this.tabConsole.Text = "Console";
            this.tabConsole.UseVisualStyleBackColor = true;
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtConsole.ForeColor = System.Drawing.Color.Lime;
            this.txtConsole.Location = new System.Drawing.Point(6, 13);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(293, 302);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.Text = "";
            // 
            // ssbMain
            // 
            this.ssbMain.Location = new System.Drawing.Point(0, 398);
            this.ssbMain.Name = "ssbMain";
            this.ssbMain.Size = new System.Drawing.Size(331, 22);
            this.ssbMain.TabIndex = 4;
            this.ssbMain.Text = "statusStrip1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(331, 420);
            this.Controls.Add(this.ssbMain);
            this.Controls.Add(this.TabProfiles);
            this.Controls.Add(this.tsbMain);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change IP Address";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tsbMain.ResumeLayout(false);
            this.tsbMain.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.TabProfiles.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.grpProfiles.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.tabNew.ResumeLayout(false);
            this.tabNew.PerformLayout();
            this.pnlIPs.ResumeLayout(false);
            this.pnlIPs.PerformLayout();
            this.grpIPAddress.ResumeLayout(false);
            this.grpIPAddress.PerformLayout();
            this.grpDNSServer.ResumeLayout(false);
            this.grpDNSServer.PerformLayout();
            this.tabConsole.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsbMain;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem tsmPreference;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmProfile;
        private System.Windows.Forms.ToolStripMenuItem tsmNew;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStripButton tsbApply;
        private System.Windows.Forms.TabControl TabProfiles;
        private System.Windows.Forms.TabPage tabNew;
        private System.Windows.Forms.TabPage tabConsole;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.GroupBox grpDNSServer;
        private System.Windows.Forms.TextBox txtDNSServer;
        private System.Windows.Forms.Label lblTNetworkInterfaceCmb;
        private System.Windows.Forms.ComboBox cmbInterfaces;
        private System.Windows.Forms.Label lblTDNSServerTxt;
        private System.Windows.Forms.RadioButton rdbDNSAutomatically;
        private System.Windows.Forms.StatusStrip ssbMain;
        private System.Windows.Forms.TextBox txtProfile;
        private System.Windows.Forms.Label lblTProfile;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblTIPAddress;
        private System.Windows.Forms.Label lblTNetworkInterface;
        private System.Windows.Forms.Panel pnlIPs;
        private System.Windows.Forms.RadioButton rdbSpecifyIp;
        private System.Windows.Forms.RadioButton rdbIpAutomatically;
        private System.Windows.Forms.GroupBox grpIPAddress;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.Label lblGatewayTxt;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label lblIPSubnetTxt;
        private System.Windows.Forms.TextBox txtIPSubnet;
        private System.Windows.Forms.Label lblIPAddressTxt;
        private System.Windows.Forms.RadioButton rdbSpecifyDNS;
        private System.Windows.Forms.Label lblDNSServer;
        private System.Windows.Forms.Label lblTDNSServer;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Label lblTGateway;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lblNetworkInterface;
        private System.Windows.Forms.ToolStripMenuItem tsmSave;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.GroupBox grpProfiles;
        private System.Windows.Forms.ListBox lstProfiles;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmLanguage;
        private System.Windows.Forms.ToolStripMenuItem tsmLEnglish;
        private System.Windows.Forms.ToolStripMenuItem tsmLSpanish;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripMenuItem tsmApply;
    }
}