namespace Ripcord
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.cbPortFilter = new System.Windows.Forms.CheckBox();
            this.txtFilterPorts = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.checkPassedFilter = new System.Windows.Forms.CheckBox();
            this.cbTypeFilter = new System.Windows.Forms.ComboBox();
            this.numSpeedValue2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkSpeedFilter = new System.Windows.Forms.CheckBox();
            this.numSpeedValue1 = new System.Windows.Forms.NumericUpDown();
            this.cbLocationFilter = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearSources = new System.Windows.Forms.Button();
            this.btnLoadSources = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTask = new System.Windows.Forms.ComboBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.lvProxies = new System.Windows.Forms.ListView();
            this.cProxy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAnonymityLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cResponseTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCheckInitiated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsProxyList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportProxiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allProxiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedProxiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyProxies = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyUncheckedProxies = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyCheckedProxies = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopySelectedProxies = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoadProxiesFromClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoadProxiesFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteProxies = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearUncheckedProxies = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearCheckedProxies = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteSelectedProxies = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiJudgeProxy = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblEliteProxies = new System.Windows.Forms.Label();
            this.lblAnonProxies = new System.Windows.Forms.Label();
            this.lblTransProxies = new System.Windows.Forms.Label();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.lblDeadSources = new System.Windows.Forms.Label();
            this.lblWorkingSources = new System.Windows.Forms.Label();
            this.lblDeadProxies = new System.Windows.Forms.Label();
            this.lblWorkingProxies = new System.Windows.Forms.Label();
            this.lblTotalSources = new System.Windows.Forms.Label();
            this.lblTotalProxies = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tCounter = new System.Windows.Forms.Timer(this.components);
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedValue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedValue1)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.cmsProxyList.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.cbPortFilter);
            this.groupFilter.Controls.Add(this.txtFilterPorts);
            this.groupFilter.Controls.Add(this.btnReset);
            this.groupFilter.Controls.Add(this.btnFilter);
            this.groupFilter.Controls.Add(this.checkPassedFilter);
            this.groupFilter.Controls.Add(this.cbTypeFilter);
            this.groupFilter.Controls.Add(this.numSpeedValue2);
            this.groupFilter.Controls.Add(this.label1);
            this.groupFilter.Controls.Add(this.checkSpeedFilter);
            this.groupFilter.Controls.Add(this.numSpeedValue1);
            this.groupFilter.Controls.Add(this.cbLocationFilter);
            this.groupFilter.Location = new System.Drawing.Point(14, 160);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(211, 174);
            this.groupFilter.TabIndex = 0;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Filter";
            // 
            // cbPortFilter
            // 
            this.cbPortFilter.AutoSize = true;
            this.cbPortFilter.Location = new System.Drawing.Point(7, 96);
            this.cbPortFilter.Name = "cbPortFilter";
            this.cbPortFilter.Size = new System.Drawing.Size(50, 17);
            this.cbPortFilter.TabIndex = 12;
            this.cbPortFilter.Text = "Ports";
            this.cbPortFilter.UseVisualStyleBackColor = true;
            // 
            // txtFilterPorts
            // 
            this.txtFilterPorts.Location = new System.Drawing.Point(7, 118);
            this.txtFilterPorts.Name = "txtFilterPorts";
            this.txtFilterPorts.Size = new System.Drawing.Size(196, 20);
            this.txtFilterPorts.TabIndex = 11;
            this.txtFilterPorts.Text = "8123,8909,8090,8118,8081,8082,800,80,3128,3129,3127,3124,443";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(48, 144);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(128, 144);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // checkPassedFilter
            // 
            this.checkPassedFilter.AutoSize = true;
            this.checkPassedFilter.Enabled = false;
            this.checkPassedFilter.Location = new System.Drawing.Point(82, 96);
            this.checkPassedFilter.Name = "checkPassedFilter";
            this.checkPassedFilter.Size = new System.Drawing.Size(86, 17);
            this.checkPassedFilter.TabIndex = 7;
            this.checkPassedFilter.Text = "URL Passed";
            this.checkPassedFilter.UseVisualStyleBackColor = true;
            // 
            // cbTypeFilter
            // 
            this.cbTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeFilter.FormattingEnabled = true;
            this.cbTypeFilter.Items.AddRange(new object[] {
            "All Types",
            "Transparent",
            "Anonymous",
            "Elite"});
            this.cbTypeFilter.Location = new System.Drawing.Point(7, 46);
            this.cbTypeFilter.Name = "cbTypeFilter";
            this.cbTypeFilter.Size = new System.Drawing.Size(196, 21);
            this.cbTypeFilter.TabIndex = 6;
            // 
            // numSpeedValue2
            // 
            this.numSpeedValue2.Location = new System.Drawing.Point(153, 73);
            this.numSpeedValue2.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numSpeedValue2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numSpeedValue2.Name = "numSpeedValue2";
            this.numSpeedValue2.Size = new System.Drawing.Size(50, 20);
            this.numSpeedValue2.TabIndex = 5;
            this.numSpeedValue2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            // 
            // checkSpeedFilter
            // 
            this.checkSpeedFilter.AutoSize = true;
            this.checkSpeedFilter.Location = new System.Drawing.Point(7, 73);
            this.checkSpeedFilter.Name = "checkSpeedFilter";
            this.checkSpeedFilter.Size = new System.Drawing.Size(57, 17);
            this.checkSpeedFilter.TabIndex = 3;
            this.checkSpeedFilter.Text = "Speed";
            this.checkSpeedFilter.UseVisualStyleBackColor = true;
            // 
            // numSpeedValue1
            // 
            this.numSpeedValue1.Location = new System.Drawing.Point(82, 73);
            this.numSpeedValue1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSpeedValue1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpeedValue1.Name = "numSpeedValue1";
            this.numSpeedValue1.Size = new System.Drawing.Size(50, 20);
            this.numSpeedValue1.TabIndex = 2;
            this.numSpeedValue1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cbLocationFilter
            // 
            this.cbLocationFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocationFilter.FormattingEnabled = true;
            this.cbLocationFilter.Items.AddRange(new object[] {
            "All Locations",
            "Afghanistan",
            "Albania",
            "Algeria",
            "American Samoa",
            "Andorra",
            "Angola",
            "Anguilla",
            "Antarctica",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bermuda",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Bouvet Island",
            "Brazil",
            "British Indian Ocean Territory",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Cayman Islands",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Christmas Island",
            "Cocos (Keeling) Islands",
            "Colombia",
            "Comoros",
            "Congo",
            "Congo, the Democratic Republic of the",
            "Cook Islands",
            "Costa Rica",
            "Cote D\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Falkland Islands (Malvinas)",
            "Faroe Islands",
            "Fiji",
            "Finland",
            "France",
            "French Guiana",
            "French Polynesia",
            "French Southern Territories",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Gibraltar",
            "Greece",
            "Greenland",
            "Grenada",
            "Guadeloupe",
            "Guam",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Heard Island and Mcdonald Islands",
            "Holy See (Vatican City State)",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran, Islamic Republic of",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, Democratic People\'s Republic of",
            "Korea, Republic of",
            "Kuwait",
            "Kyrgyzstan",
            "Lao People\'s Democratic Republic",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libyan Arab Jamahiriya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macao",
            "Macedonia, the Former Yugoslav Republic of",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Martinique",
            "Mauritania",
            "Mauritius",
            "Mayotte",
            "Mexico",
            "Micronesia, Federated States of",
            "Moldova, Republic of",
            "Monaco",
            "Mongolia",
            "Montserrat",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "Netherlands Antilles",
            "New Caledonia",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Niue",
            "Norfolk Island",
            "Northern Mariana Islands",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestinian Territory, Occupied",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Pitcairn",
            "Poland",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Reunion",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Helena",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Pierre and Miquelon",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia and Montenegro",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Georgia and the South Sandwich Islands",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Svalbard and Jan Mayen",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syrian Arab Republic",
            "Taiwan, Province of China",
            "Tajikistan",
            "Tanzania, United Republic of",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Turks and Caicos Islands",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "United States Minor Outlying Islands",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Virgin Islands, British",
            "Virgin Islands, US",
            "Wallis and Futuna",
            "Western Sahara",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.cbLocationFilter.Location = new System.Drawing.Point(7, 19);
            this.cbLocationFilter.Name = "cbLocationFilter";
            this.cbLocationFilter.Size = new System.Drawing.Size(196, 21);
            this.cbLocationFilter.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 420);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1079, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 17);
            this.lblStatus.Text = "Waiting for user...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClearSources);
            this.groupBox3.Controls.Add(this.btnLoadSources);
            this.groupBox3.Location = new System.Drawing.Point(14, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sources";
            // 
            // btnClearSources
            // 
            this.btnClearSources.Location = new System.Drawing.Point(110, 19);
            this.btnClearSources.Name = "btnClearSources";
            this.btnClearSources.Size = new System.Drawing.Size(93, 23);
            this.btnClearSources.TabIndex = 1;
            this.btnClearSources.Text = "Clear";
            this.btnClearSources.UseVisualStyleBackColor = true;
            this.btnClearSources.Click += new System.EventHandler(this.btnClearSources_Click);
            // 
            // btnLoadSources
            // 
            this.btnLoadSources.Location = new System.Drawing.Point(10, 19);
            this.btnLoadSources.Name = "btnLoadSources";
            this.btnLoadSources.Size = new System.Drawing.Size(94, 23);
            this.btnLoadSources.TabIndex = 0;
            this.btnLoadSources.Text = "Load";
            this.btnLoadSources.UseVisualStyleBackColor = true;
            this.btnLoadSources.Click += new System.EventHandler(this.btnLoadSources_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTask);
            this.groupBox2.Location = new System.Drawing.Point(14, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuration";
            // 
            // cbTask
            // 
            this.cbTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTask.FormattingEnabled = true;
            this.cbTask.Items.AddRange(new object[] {
            "Scrape",
            "Check",
            "URL Harvester"});
            this.cbTask.Location = new System.Drawing.Point(10, 19);
            this.cbTask.Name = "cbTask";
            this.cbTask.Size = new System.Drawing.Size(193, 21);
            this.cbTask.TabIndex = 1;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(928, 377);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(137, 30);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lvProxies
            // 
            this.lvProxies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cProxy,
            this.cAnonymityLevel,
            this.cCountry,
            this.cRegion,
            this.cCity,
            this.cResponseTime,
            this.cCheckInitiated});
            this.lvProxies.ContextMenuStrip = this.cmsProxyList;
            this.lvProxies.FullRowSelect = true;
            this.lvProxies.Location = new System.Drawing.Point(231, 12);
            this.lvProxies.Name = "lvProxies";
            this.lvProxies.Size = new System.Drawing.Size(834, 322);
            this.lvProxies.TabIndex = 3;
            this.lvProxies.UseCompatibleStateImageBehavior = false;
            this.lvProxies.View = System.Windows.Forms.View.Details;
            this.lvProxies.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvProxies_ColumnClick);
            this.lvProxies.SelectedIndexChanged += new System.EventHandler(this.lvProxies_SelectedIndexChanged);
            // 
            // cProxy
            // 
            this.cProxy.Text = "Proxy";
            this.cProxy.Width = 171;
            // 
            // cAnonymityLevel
            // 
            this.cAnonymityLevel.Text = "Anonymity level";
            this.cAnonymityLevel.Width = 126;
            // 
            // cCountry
            // 
            this.cCountry.Text = "Country";
            this.cCountry.Width = 112;
            // 
            // cRegion
            // 
            this.cRegion.Text = "Region";
            this.cRegion.Width = 103;
            // 
            // cCity
            // 
            this.cCity.Text = "City";
            this.cCity.Width = 106;
            // 
            // cResponseTime
            // 
            this.cResponseTime.Text = "Speed (ms)";
            this.cResponseTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cResponseTime.Width = 68;
            // 
            // cCheckInitiated
            // 
            this.cCheckInitiated.Text = "Check initiated";
            this.cCheckInitiated.Width = 108;
            // 
            // cmsProxyList
            // 
            this.cmsProxyList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportProxiesToolStripMenuItem,
            this.tsmiCopyProxies,
            this.toolStripSeparator3,
            this.loadToolStripMenuItem,
            this.tsmiDeleteProxies,
            this.toolStripSeparator1,
            this.tsmiJudgeProxy});
            this.cmsProxyList.Name = "contextMenuStrip1";
            this.cmsProxyList.Size = new System.Drawing.Size(141, 126);
            // 
            // exportProxiesToolStripMenuItem
            // 
            this.exportProxiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allProxiesToolStripMenuItem,
            this.checkedProxiesToolStripMenuItem});
            this.exportProxiesToolStripMenuItem.Name = "exportProxiesToolStripMenuItem";
            this.exportProxiesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exportProxiesToolStripMenuItem.Text = "Save";
            // 
            // allProxiesToolStripMenuItem
            // 
            this.allProxiesToolStripMenuItem.Name = "allProxiesToolStripMenuItem";
            this.allProxiesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.allProxiesToolStripMenuItem.Text = "Unchecked proxies";
            this.allProxiesToolStripMenuItem.Click += new System.EventHandler(this.allProxiesToolStripMenuItem_Click);
            // 
            // checkedProxiesToolStripMenuItem
            // 
            this.checkedProxiesToolStripMenuItem.Name = "checkedProxiesToolStripMenuItem";
            this.checkedProxiesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.checkedProxiesToolStripMenuItem.Text = "Checked proxies";
            this.checkedProxiesToolStripMenuItem.Click += new System.EventHandler(this.checkedProxiesToolStripMenuItem_Click);
            // 
            // tsmiCopyProxies
            // 
            this.tsmiCopyProxies.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopyUncheckedProxies,
            this.tsmiCopyCheckedProxies,
            this.tsmiCopySelectedProxies});
            this.tsmiCopyProxies.Name = "tsmiCopyProxies";
            this.tsmiCopyProxies.Size = new System.Drawing.Size(140, 22);
            this.tsmiCopyProxies.Text = "Copy";
            // 
            // tsmiCopyUncheckedProxies
            // 
            this.tsmiCopyUncheckedProxies.Name = "tsmiCopyUncheckedProxies";
            this.tsmiCopyUncheckedProxies.Size = new System.Drawing.Size(173, 22);
            this.tsmiCopyUncheckedProxies.Text = "Unchecked proxies";
            this.tsmiCopyUncheckedProxies.Click += new System.EventHandler(this.tsmiCopyUncheckedProxies_Click);
            // 
            // tsmiCopyCheckedProxies
            // 
            this.tsmiCopyCheckedProxies.Name = "tsmiCopyCheckedProxies";
            this.tsmiCopyCheckedProxies.Size = new System.Drawing.Size(173, 22);
            this.tsmiCopyCheckedProxies.Text = "Checked proxies";
            this.tsmiCopyCheckedProxies.Click += new System.EventHandler(this.tsmiCopyCheckedProxies_Click);
            // 
            // tsmiCopySelectedProxies
            // 
            this.tsmiCopySelectedProxies.Name = "tsmiCopySelectedProxies";
            this.tsmiCopySelectedProxies.Size = new System.Drawing.Size(173, 22);
            this.tsmiCopySelectedProxies.Text = "Selected proxies";
            this.tsmiCopySelectedProxies.Click += new System.EventHandler(this.tsmiCopySelectedProxies_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(137, 6);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoadProxiesFromClipboard,
            this.tsmiLoadProxiesFromFile});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.loadToolStripMenuItem.Text = "Load proxies";
            // 
            // tsmiLoadProxiesFromClipboard
            // 
            this.tsmiLoadProxiesFromClipboard.Name = "tsmiLoadProxiesFromClipboard";
            this.tsmiLoadProxiesFromClipboard.Size = new System.Drawing.Size(155, 22);
            this.tsmiLoadProxiesFromClipboard.Text = "From clipboard";
            this.tsmiLoadProxiesFromClipboard.Click += new System.EventHandler(this.tsmiLoadProxiesFromClipboard_Click);
            // 
            // tsmiLoadProxiesFromFile
            // 
            this.tsmiLoadProxiesFromFile.Name = "tsmiLoadProxiesFromFile";
            this.tsmiLoadProxiesFromFile.Size = new System.Drawing.Size(155, 22);
            this.tsmiLoadProxiesFromFile.Text = "From file";
            this.tsmiLoadProxiesFromFile.Click += new System.EventHandler(this.tsmiLoadProxiesFromFile_Click);
            // 
            // tsmiDeleteProxies
            // 
            this.tsmiDeleteProxies.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClearUncheckedProxies,
            this.tsmiClearCheckedProxies,
            this.tsmiDeleteSelectedProxies});
            this.tsmiDeleteProxies.Name = "tsmiDeleteProxies";
            this.tsmiDeleteProxies.Size = new System.Drawing.Size(140, 22);
            this.tsmiDeleteProxies.Text = "Remove";
            // 
            // tsmiClearUncheckedProxies
            // 
            this.tsmiClearUncheckedProxies.Name = "tsmiClearUncheckedProxies";
            this.tsmiClearUncheckedProxies.Size = new System.Drawing.Size(173, 22);
            this.tsmiClearUncheckedProxies.Text = "Unchecked proxies";
            this.tsmiClearUncheckedProxies.Click += new System.EventHandler(this.tsmiClearUncheckedProxies_Click);
            // 
            // tsmiClearCheckedProxies
            // 
            this.tsmiClearCheckedProxies.Name = "tsmiClearCheckedProxies";
            this.tsmiClearCheckedProxies.Size = new System.Drawing.Size(173, 22);
            this.tsmiClearCheckedProxies.Text = "Checked proxies";
            this.tsmiClearCheckedProxies.Click += new System.EventHandler(this.tsmiClearCheckedProxies_Click);
            // 
            // tsmiDeleteSelectedProxies
            // 
            this.tsmiDeleteSelectedProxies.Name = "tsmiDeleteSelectedProxies";
            this.tsmiDeleteSelectedProxies.Size = new System.Drawing.Size(173, 22);
            this.tsmiDeleteSelectedProxies.Text = "Selected proxies";
            this.tsmiDeleteSelectedProxies.Click += new System.EventHandler(this.tsmiDeleteSelectedProxies_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // tsmiJudgeProxy
            // 
            this.tsmiJudgeProxy.Name = "tsmiJudgeProxy";
            this.tsmiJudgeProxy.Size = new System.Drawing.Size(140, 22);
            this.tsmiJudgeProxy.Text = "View judge";
            this.tsmiJudgeProxy.Click += new System.EventHandler(this.tsmiJudgeProxy_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblEliteProxies);
            this.groupBox5.Controls.Add(this.lblAnonProxies);
            this.groupBox5.Controls.Add(this.lblTransProxies);
            this.groupBox5.Controls.Add(this.lblTimeElapsed);
            this.groupBox5.Controls.Add(this.lblDeadSources);
            this.groupBox5.Controls.Add(this.lblWorkingSources);
            this.groupBox5.Controls.Add(this.lblDeadProxies);
            this.groupBox5.Controls.Add(this.lblWorkingProxies);
            this.groupBox5.Controls.Add(this.lblTotalSources);
            this.groupBox5.Controls.Add(this.lblTotalProxies);
            this.groupBox5.Location = new System.Drawing.Point(14, 340);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(908, 67);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Statistics";
            // 
            // lblEliteProxies
            // 
            this.lblEliteProxies.AutoSize = true;
            this.lblEliteProxies.Location = new System.Drawing.Point(790, 14);
            this.lblEliteProxies.Name = "lblEliteProxies";
            this.lblEliteProxies.Size = new System.Drawing.Size(39, 13);
            this.lblEliteProxies.TabIndex = 10;
            this.lblEliteProxies.Text = "Elite: 0";
            // 
            // lblAnonProxies
            // 
            this.lblAnonProxies.AutoSize = true;
            this.lblAnonProxies.Location = new System.Drawing.Point(755, 28);
            this.lblAnonProxies.Name = "lblAnonProxies";
            this.lblAnonProxies.Size = new System.Drawing.Size(74, 13);
            this.lblAnonProxies.TabIndex = 9;
            this.lblAnonProxies.Text = "Anonymous: 0";
            // 
            // lblTransProxies
            // 
            this.lblTransProxies.AutoSize = true;
            this.lblTransProxies.Location = new System.Drawing.Point(753, 43);
            this.lblTransProxies.Name = "lblTransProxies";
            this.lblTransProxies.Size = new System.Drawing.Size(76, 13);
            this.lblTransProxies.TabIndex = 8;
            this.lblTransProxies.Text = "Transparent: 0";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Location = new System.Drawing.Point(553, 40);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(118, 13);
            this.lblTimeElapsed.TabIndex = 7;
            this.lblTimeElapsed.Text = "Time elapsed: 00:00:00";
            // 
            // lblDeadSources
            // 
            this.lblDeadSources.AutoSize = true;
            this.lblDeadSources.Location = new System.Drawing.Point(379, 40);
            this.lblDeadSources.Name = "lblDeadSources";
            this.lblDeadSources.Size = new System.Drawing.Size(85, 13);
            this.lblDeadSources.TabIndex = 5;
            this.lblDeadSources.Text = "Dead sources: 0";
            // 
            // lblWorkingSources
            // 
            this.lblWorkingSources.AutoSize = true;
            this.lblWorkingSources.Location = new System.Drawing.Point(365, 20);
            this.lblWorkingSources.Name = "lblWorkingSources";
            this.lblWorkingSources.Size = new System.Drawing.Size(99, 13);
            this.lblWorkingSources.TabIndex = 4;
            this.lblWorkingSources.Text = "Working sources: 0";
            // 
            // lblDeadProxies
            // 
            this.lblDeadProxies.AutoSize = true;
            this.lblDeadProxies.Location = new System.Drawing.Point(192, 41);
            this.lblDeadProxies.Name = "lblDeadProxies";
            this.lblDeadProxies.Size = new System.Drawing.Size(81, 13);
            this.lblDeadProxies.TabIndex = 3;
            this.lblDeadProxies.Text = "Dead proxies: 0";
            // 
            // lblWorkingProxies
            // 
            this.lblWorkingProxies.AutoSize = true;
            this.lblWorkingProxies.Location = new System.Drawing.Point(178, 20);
            this.lblWorkingProxies.Name = "lblWorkingProxies";
            this.lblWorkingProxies.Size = new System.Drawing.Size(95, 13);
            this.lblWorkingProxies.TabIndex = 2;
            this.lblWorkingProxies.Text = "Working proxies: 0";
            // 
            // lblTotalSources
            // 
            this.lblTotalSources.AutoSize = true;
            this.lblTotalSources.Location = new System.Drawing.Point(7, 40);
            this.lblTotalSources.Name = "lblTotalSources";
            this.lblTotalSources.Size = new System.Drawing.Size(83, 13);
            this.lblTotalSources.TabIndex = 1;
            this.lblTotalSources.Text = "Total sources: 0";
            // 
            // lblTotalProxies
            // 
            this.lblTotalProxies.AutoSize = true;
            this.lblTotalProxies.Location = new System.Drawing.Point(11, 20);
            this.lblTotalProxies.Name = "lblTotalProxies";
            this.lblTotalProxies.Size = new System.Drawing.Size(79, 13);
            this.lblTotalProxies.TabIndex = 0;
            this.lblTotalProxies.Text = "Total proxies: 0";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(928, 345);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(137, 30);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tCounter
            // 
            this.tCounter.Interval = 1000;
            this.tCounter.Tick += new System.EventHandler(this.tCounter_Tick);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem4});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem7});
            this.menuItem2.Text = "Tools";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "URL Harvester";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.Text = "Source Analyzer";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem6});
            this.menuItem4.Text = "Settings";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "General";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "Checker";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ripcord version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "0.2 Beta";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 442);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupFilter);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lvProxies);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ripcord";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedValue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedValue1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.cmsProxyList.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.ComboBox cbLocationFilter;
        private System.Windows.Forms.CheckBox checkPassedFilter;
        private System.Windows.Forms.ComboBox cbTypeFilter;
        private System.Windows.Forms.NumericUpDown numSpeedValue2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkSpeedFilter;
        private System.Windows.Forms.NumericUpDown numSpeedValue1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.CheckBox cbPortFilter;
        private System.Windows.Forms.TextBox txtFilterPorts;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClearSources;
        private System.Windows.Forms.Button btnLoadSources;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox cbTask;
        private System.Windows.Forms.ListView lvProxies;
        private System.Windows.Forms.ColumnHeader cProxy;
        private System.Windows.Forms.ColumnHeader cAnonymityLevel;
        private System.Windows.Forms.ColumnHeader cCountry;
        private System.Windows.Forms.ColumnHeader cResponseTime;
        private System.Windows.Forms.ContextMenuStrip cmsProxyList;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteProxies;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyProxies;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblEliteProxies;
        private System.Windows.Forms.Label lblAnonProxies;
        private System.Windows.Forms.Label lblTransProxies;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.Label lblDeadSources;
        private System.Windows.Forms.Label lblWorkingSources;
        private System.Windows.Forms.Label lblDeadProxies;
        private System.Windows.Forms.Label lblWorkingProxies;
        private System.Windows.Forms.Label lblTotalSources;
        private System.Windows.Forms.Label lblTotalProxies;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tCounter;
        private System.Windows.Forms.ToolStripMenuItem exportProxiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allProxiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedProxiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearUncheckedProxies;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearCheckedProxies;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyUncheckedProxies;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyCheckedProxies;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopySelectedProxies;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteSelectedProxies;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadProxiesFromClipboard;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadProxiesFromFile;
        private System.Windows.Forms.ColumnHeader cRegion;
        private System.Windows.Forms.ColumnHeader cCity;
        private System.Windows.Forms.ColumnHeader cCheckInitiated;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmiJudgeProxy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
    }
}

