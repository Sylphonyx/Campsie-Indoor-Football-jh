namespace Project2._0
{
    partial class ManageFixtures
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
            this.cmbReferee = new System.Windows.Forms.ComboBox();
            this.rEFEREEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cIFDataSet = new Project2._0.CIFDataSet();
            this.txtTeam2Goals = new System.Windows.Forms.TextBox();
            this.txtTeam1Goals = new System.Windows.Forms.TextBox();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tEAMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTeam1 = new System.Windows.Forms.ComboBox();
            this.tEAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTPFixtureDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtFixtureTime = new System.Windows.Forms.TextBox();
            this.lblPitch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFixtures = new System.Windows.Forms.Label();
            this.btnFixturesLeft = new System.Windows.Forms.Button();
            this.btnFixturesRight = new System.Windows.Forms.Button();
            this.btnFixtureSave = new System.Windows.Forms.Button();
            this.btnFixtureEdit = new System.Windows.Forms.Button();
            this.tEAMTableAdapter = new Project2._0.CIFDataSetTableAdapters.TEAMTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.rEFEREETableAdapter = new Project2._0.CIFDataSetTableAdapters.REFEREETableAdapter();
            this.cmbPitch = new System.Windows.Forms.ComboBox();
            this.pITCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pITCHTableAdapter = new Project2._0.CIFDataSetTableAdapters.PITCHTableAdapter();
            this.tcFixture1 = new System.Windows.Forms.TabControl();
            this.tpFixture1 = new System.Windows.Forms.TabPage();
            this.btnTeam1Save1 = new System.Windows.Forms.Button();
            this.btnTeam1Add = new System.Windows.Forms.Button();
            this.txtTeam1Scorer1 = new System.Windows.Forms.TextBox();
            this.lblTeam1Scorer1 = new System.Windows.Forms.Label();
            this.lbTeam1Goal1 = new System.Windows.Forms.ListBox();
            this.tpFixture2 = new System.Windows.Forms.TabPage();
            this.fkTeam1IDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tcFixture2 = new System.Windows.Forms.TabControl();
            this.tpFixture3 = new System.Windows.Forms.TabPage();
            this.tpFixture4 = new System.Windows.Forms.TabPage();
            this.fkTeam1IDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mATCHSTATSTableAdapter = new Project2._0.CIFDataSetTableAdapters.MATCHSTATSTableAdapter();
            this.fkTeam2IDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTeam1Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rEFEREEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pITCHBindingSource)).BeginInit();
            this.tcFixture1.SuspendLayout();
            this.tpFixture1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fkTeam1IDBindingSource1)).BeginInit();
            this.tcFixture2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fkTeam1IDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkTeam2IDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbReferee
            // 
            this.cmbReferee.DataSource = this.rEFEREEBindingSource;
            this.cmbReferee.DisplayMember = "RefereeForename";
            this.cmbReferee.FormattingEnabled = true;
            this.cmbReferee.Location = new System.Drawing.Point(107, 355);
            this.cmbReferee.Name = "cmbReferee";
            this.cmbReferee.Size = new System.Drawing.Size(176, 21);
            this.cmbReferee.TabIndex = 73;
            this.cmbReferee.ValueMember = "RefereeID";
            // 
            // rEFEREEBindingSource
            // 
            this.rEFEREEBindingSource.DataMember = "REFEREE";
            this.rEFEREEBindingSource.DataSource = this.cIFDataSet;
            // 
            // cIFDataSet
            // 
            this.cIFDataSet.DataSetName = "CIFDataSet";
            this.cIFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTeam2Goals
            // 
            this.txtTeam2Goals.Location = new System.Drawing.Point(301, 125);
            this.txtTeam2Goals.Name = "txtTeam2Goals";
            this.txtTeam2Goals.Size = new System.Drawing.Size(34, 20);
            this.txtTeam2Goals.TabIndex = 72;
            this.txtTeam2Goals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTeam1Goals
            // 
            this.txtTeam1Goals.Location = new System.Drawing.Point(249, 125);
            this.txtTeam1Goals.Name = "txtTeam1Goals";
            this.txtTeam1Goals.Size = new System.Drawing.Size(34, 20);
            this.txtTeam1Goals.TabIndex = 71;
            this.txtTeam1Goals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTeam2
            // 
            this.lblTeam2.AutoSize = true;
            this.lblTeam2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2.ForeColor = System.Drawing.Color.MintCream;
            this.lblTeam2.Location = new System.Drawing.Point(494, 77);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(52, 17);
            this.lblTeam2.TabIndex = 70;
            this.lblTeam2.Text = "TEAM2";
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVS.ForeColor = System.Drawing.Color.MintCream;
            this.lblVS.Location = new System.Drawing.Point(281, 101);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(24, 17);
            this.lblVS.TabIndex = 69;
            this.lblVS.Text = "VS";
            // 
            // lblTeam1
            // 
            this.lblTeam1.AutoSize = true;
            this.lblTeam1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1.ForeColor = System.Drawing.Color.MintCream;
            this.lblTeam1.Location = new System.Drawing.Point(35, 78);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(52, 17);
            this.lblTeam1.TabIndex = 68;
            this.lblTeam1.Text = "TEAM1";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tEAMBindingSource1;
            this.comboBox2.DisplayMember = "TeamName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(301, 77);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(176, 21);
            this.comboBox2.TabIndex = 67;
            this.comboBox2.ValueMember = "TeamID";
            // 
            // tEAMBindingSource1
            // 
            this.tEAMBindingSource1.DataMember = "TEAM";
            this.tEAMBindingSource1.DataSource = this.cIFDataSet;
            // 
            // cmbTeam1
            // 
            this.cmbTeam1.DataSource = this.tEAMBindingSource;
            this.cmbTeam1.DisplayMember = "TeamName";
            this.cmbTeam1.FormattingEnabled = true;
            this.cmbTeam1.Location = new System.Drawing.Point(107, 77);
            this.cmbTeam1.Name = "cmbTeam1";
            this.cmbTeam1.Size = new System.Drawing.Size(176, 21);
            this.cmbTeam1.TabIndex = 66;
            this.cmbTeam1.ValueMember = "TeamID";
            this.cmbTeam1.SelectedIndexChanged += new System.EventHandler(this.cmbTeam1_SelectedIndexChanged);
            // 
            // tEAMBindingSource
            // 
            this.tEAMBindingSource.DataMember = "TEAM";
            this.tEAMBindingSource.DataSource = this.cIFDataSet;
            // 
            // DTPFixtureDate
            // 
            this.DTPFixtureDate.Location = new System.Drawing.Point(346, 351);
            this.DTPFixtureDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.DTPFixtureDate.MinDate = new System.DateTime(2018, 2, 16, 0, 0, 0, 0);
            this.DTPFixtureDate.Name = "DTPFixtureDate";
            this.DTPFixtureDate.Size = new System.Drawing.Size(200, 20);
            this.DTPFixtureDate.TabIndex = 65;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.MintCream;
            this.lblDate.Location = new System.Drawing.Point(298, 354);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 64;
            this.lblDate.Text = "DATE";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.MintCream;
            this.lblTime.Location = new System.Drawing.Point(298, 393);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(38, 17);
            this.lblTime.TabIndex = 63;
            this.lblTime.Text = "TIME";
            // 
            // txtFixtureTime
            // 
            this.txtFixtureTime.Location = new System.Drawing.Point(346, 390);
            this.txtFixtureTime.Name = "txtFixtureTime";
            this.txtFixtureTime.Size = new System.Drawing.Size(200, 20);
            this.txtFixtureTime.TabIndex = 62;
            // 
            // lblPitch
            // 
            this.lblPitch.AutoSize = true;
            this.lblPitch.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPitch.ForeColor = System.Drawing.Color.MintCream;
            this.lblPitch.Location = new System.Drawing.Point(35, 390);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(46, 17);
            this.lblPitch.TabIndex = 61;
            this.lblPitch.Text = "PITCH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(35, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "REFEREE";
            // 
            // lblFixtures
            // 
            this.lblFixtures.AutoSize = true;
            this.lblFixtures.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixtures.ForeColor = System.Drawing.Color.MintCream;
            this.lblFixtures.Location = new System.Drawing.Point(144, 28);
            this.lblFixtures.Name = "lblFixtures";
            this.lblFixtures.Size = new System.Drawing.Size(296, 37);
            this.lblFixtures.TabIndex = 56;
            this.lblFixtures.Text = "MATCH STATISTICS";
            // 
            // btnFixturesLeft
            // 
            this.btnFixturesLeft.BackColor = System.Drawing.Color.White;
            this.btnFixturesLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFixturesLeft.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFixturesLeft.FlatAppearance.BorderSize = 10;
            this.btnFixturesLeft.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixturesLeft.ForeColor = System.Drawing.Color.Black;
            this.btnFixturesLeft.Location = new System.Drawing.Point(597, 299);
            this.btnFixturesLeft.Name = "btnFixturesLeft";
            this.btnFixturesLeft.Size = new System.Drawing.Size(58, 44);
            this.btnFixturesLeft.TabIndex = 55;
            this.btnFixturesLeft.Text = "<";
            this.btnFixturesLeft.UseVisualStyleBackColor = false;
            // 
            // btnFixturesRight
            // 
            this.btnFixturesRight.BackColor = System.Drawing.Color.White;
            this.btnFixturesRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFixturesRight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFixturesRight.FlatAppearance.BorderSize = 10;
            this.btnFixturesRight.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixturesRight.ForeColor = System.Drawing.Color.Black;
            this.btnFixturesRight.Location = new System.Drawing.Point(597, 249);
            this.btnFixturesRight.Name = "btnFixturesRight";
            this.btnFixturesRight.Size = new System.Drawing.Size(58, 44);
            this.btnFixturesRight.TabIndex = 54;
            this.btnFixturesRight.Text = ">";
            this.btnFixturesRight.UseVisualStyleBackColor = false;
            // 
            // btnFixtureSave
            // 
            this.btnFixtureSave.BackColor = System.Drawing.Color.White;
            this.btnFixtureSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFixtureSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFixtureSave.FlatAppearance.BorderSize = 10;
            this.btnFixtureSave.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixtureSave.ForeColor = System.Drawing.Color.Lime;
            this.btnFixtureSave.Location = new System.Drawing.Point(597, 199);
            this.btnFixtureSave.Name = "btnFixtureSave";
            this.btnFixtureSave.Size = new System.Drawing.Size(58, 44);
            this.btnFixtureSave.TabIndex = 53;
            this.btnFixtureSave.Text = "Save";
            this.btnFixtureSave.UseVisualStyleBackColor = false;
            // 
            // btnFixtureEdit
            // 
            this.btnFixtureEdit.BackColor = System.Drawing.Color.White;
            this.btnFixtureEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFixtureEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFixtureEdit.FlatAppearance.BorderSize = 10;
            this.btnFixtureEdit.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixtureEdit.ForeColor = System.Drawing.Color.Yellow;
            this.btnFixtureEdit.Location = new System.Drawing.Point(597, 149);
            this.btnFixtureEdit.Name = "btnFixtureEdit";
            this.btnFixtureEdit.Size = new System.Drawing.Size(58, 44);
            this.btnFixtureEdit.TabIndex = 52;
            this.btnFixtureEdit.Text = "Edit";
            this.btnFixtureEdit.UseVisualStyleBackColor = false;
            // 
            // tEAMTableAdapter
            // 
            this.tEAMTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(289, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "-";
            // 
            // rEFEREETableAdapter
            // 
            this.rEFEREETableAdapter.ClearBeforeFill = true;
            // 
            // cmbPitch
            // 
            this.cmbPitch.DataSource = this.pITCHBindingSource;
            this.cmbPitch.DisplayMember = "Description";
            this.cmbPitch.FormattingEnabled = true;
            this.cmbPitch.Location = new System.Drawing.Point(107, 389);
            this.cmbPitch.Name = "cmbPitch";
            this.cmbPitch.Size = new System.Drawing.Size(176, 21);
            this.cmbPitch.TabIndex = 75;
            this.cmbPitch.ValueMember = "PitchID";
            // 
            // pITCHBindingSource
            // 
            this.pITCHBindingSource.DataMember = "PITCH";
            this.pITCHBindingSource.DataSource = this.cIFDataSet;
            // 
            // pITCHTableAdapter
            // 
            this.pITCHTableAdapter.ClearBeforeFill = true;
            // 
            // tcFixture1
            // 
            this.tcFixture1.Controls.Add(this.tpFixture1);
            this.tcFixture1.Controls.Add(this.tpFixture2);
            this.tcFixture1.Location = new System.Drawing.Point(38, 151);
            this.tcFixture1.Name = "tcFixture1";
            this.tcFixture1.SelectedIndex = 0;
            this.tcFixture1.Size = new System.Drawing.Size(245, 181);
            this.tcFixture1.TabIndex = 76;
            // 
            // tpFixture1
            // 
            this.tpFixture1.Controls.Add(this.btnTeam1Edit);
            this.tpFixture1.Controls.Add(this.btnTeam1Save1);
            this.tpFixture1.Controls.Add(this.btnTeam1Add);
            this.tpFixture1.Controls.Add(this.txtTeam1Scorer1);
            this.tpFixture1.Controls.Add(this.lblTeam1Scorer1);
            this.tpFixture1.Controls.Add(this.lbTeam1Goal1);
            this.tpFixture1.Location = new System.Drawing.Point(4, 22);
            this.tpFixture1.Name = "tpFixture1";
            this.tpFixture1.Padding = new System.Windows.Forms.Padding(3);
            this.tpFixture1.Size = new System.Drawing.Size(237, 155);
            this.tpFixture1.TabIndex = 0;
            this.tpFixture1.Text = "GOALS";
            this.tpFixture1.UseVisualStyleBackColor = true;
            // 
            // btnTeam1Save1
            // 
            this.btnTeam1Save1.Enabled = false;
            this.btnTeam1Save1.Location = new System.Drawing.Point(190, 132);
            this.btnTeam1Save1.Name = "btnTeam1Save1";
            this.btnTeam1Save1.Size = new System.Drawing.Size(41, 20);
            this.btnTeam1Save1.TabIndex = 0;
            this.btnTeam1Save1.Text = "S";
            this.btnTeam1Save1.UseVisualStyleBackColor = true;
            this.btnTeam1Save1.Visible = false;
            this.btnTeam1Save1.Click += new System.EventHandler(this.btnTeam1Save1_Click);
            // 
            // btnTeam1Add
            // 
            this.btnTeam1Add.Location = new System.Drawing.Point(188, 6);
            this.btnTeam1Add.Name = "btnTeam1Add";
            this.btnTeam1Add.Size = new System.Drawing.Size(31, 20);
            this.btnTeam1Add.TabIndex = 79;
            this.btnTeam1Add.Text = "+";
            this.btnTeam1Add.UseVisualStyleBackColor = true;
            this.btnTeam1Add.Click += new System.EventHandler(this.btnTeam1Add_Click);
            // 
            // txtTeam1Scorer1
            // 
            this.txtTeam1Scorer1.Location = new System.Drawing.Point(149, 50);
            this.txtTeam1Scorer1.Name = "txtTeam1Scorer1";
            this.txtTeam1Scorer1.Size = new System.Drawing.Size(33, 20);
            this.txtTeam1Scorer1.TabIndex = 78;
            // 
            // lblTeam1Scorer1
            // 
            this.lblTeam1Scorer1.AutoSize = true;
            this.lblTeam1Scorer1.Location = new System.Drawing.Point(35, 53);
            this.lblTeam1Scorer1.Name = "lblTeam1Scorer1";
            this.lblTeam1Scorer1.Size = new System.Drawing.Size(10, 13);
            this.lblTeam1Scorer1.TabIndex = 0;
            this.lblTeam1Scorer1.Text = "-";
            // 
            // lbTeam1Goal1
            // 
            this.lbTeam1Goal1.FormattingEnabled = true;
            this.lbTeam1Goal1.Location = new System.Drawing.Point(46, 6);
            this.lbTeam1Goal1.Name = "lbTeam1Goal1";
            this.lbTeam1Goal1.Size = new System.Drawing.Size(136, 30);
            this.lbTeam1Goal1.TabIndex = 0;
            // 
            // tpFixture2
            // 
            this.tpFixture2.Location = new System.Drawing.Point(4, 22);
            this.tpFixture2.Name = "tpFixture2";
            this.tpFixture2.Padding = new System.Windows.Forms.Padding(3);
            this.tpFixture2.Size = new System.Drawing.Size(237, 155);
            this.tpFixture2.TabIndex = 1;
            this.tpFixture2.Text = "BOOKINGS";
            this.tpFixture2.UseVisualStyleBackColor = true;
            // 
            // fkTeam1IDBindingSource1
            // 
            this.fkTeam1IDBindingSource1.DataMember = "fkTeam1ID";
            this.fkTeam1IDBindingSource1.DataSource = this.tEAMBindingSource;
            // 
            // tcFixture2
            // 
            this.tcFixture2.Controls.Add(this.tpFixture3);
            this.tcFixture2.Controls.Add(this.tpFixture4);
            this.tcFixture2.Location = new System.Drawing.Point(301, 151);
            this.tcFixture2.Name = "tcFixture2";
            this.tcFixture2.SelectedIndex = 0;
            this.tcFixture2.Size = new System.Drawing.Size(245, 181);
            this.tcFixture2.TabIndex = 77;
            // 
            // tpFixture3
            // 
            this.tpFixture3.Location = new System.Drawing.Point(4, 22);
            this.tpFixture3.Name = "tpFixture3";
            this.tpFixture3.Padding = new System.Windows.Forms.Padding(3);
            this.tpFixture3.Size = new System.Drawing.Size(237, 155);
            this.tpFixture3.TabIndex = 0;
            this.tpFixture3.Text = "GOALS";
            this.tpFixture3.UseVisualStyleBackColor = true;
            // 
            // tpFixture4
            // 
            this.tpFixture4.Location = new System.Drawing.Point(4, 22);
            this.tpFixture4.Name = "tpFixture4";
            this.tpFixture4.Padding = new System.Windows.Forms.Padding(3);
            this.tpFixture4.Size = new System.Drawing.Size(237, 155);
            this.tpFixture4.TabIndex = 1;
            this.tpFixture4.Text = "BOOKINGS";
            this.tpFixture4.UseVisualStyleBackColor = true;
            // 
            // fkTeam1IDBindingSource
            // 
            this.fkTeam1IDBindingSource.DataMember = "fkTeam1ID";
            this.fkTeam1IDBindingSource.DataSource = this.tEAMBindingSource;
            // 
            // mATCHSTATSTableAdapter
            // 
            this.mATCHSTATSTableAdapter.ClearBeforeFill = true;
            // 
            // fkTeam2IDBindingSource
            // 
            this.fkTeam2IDBindingSource.DataMember = "fkTeam2ID";
            this.fkTeam2IDBindingSource.DataSource = this.tEAMBindingSource;
            // 
            // btnTeam1Edit
            // 
            this.btnTeam1Edit.Enabled = false;
            this.btnTeam1Edit.Location = new System.Drawing.Point(190, 132);
            this.btnTeam1Edit.Name = "btnTeam1Edit";
            this.btnTeam1Edit.Size = new System.Drawing.Size(41, 20);
            this.btnTeam1Edit.TabIndex = 78;
            this.btnTeam1Edit.Text = "EDIT";
            this.btnTeam1Edit.UseVisualStyleBackColor = true;
            this.btnTeam1Edit.Visible = false;
            this.btnTeam1Edit.Click += new System.EventHandler(this.btnTeam1Edit_Click);
            // 
            // ManageFixtures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(691, 438);
            this.Controls.Add(this.tcFixture2);
            this.Controls.Add(this.tcFixture1);
            this.Controls.Add(this.cmbPitch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbReferee);
            this.Controls.Add(this.txtTeam2Goals);
            this.Controls.Add(this.txtTeam1Goals);
            this.Controls.Add(this.lblTeam2);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.lblTeam1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cmbTeam1);
            this.Controls.Add(this.DTPFixtureDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtFixtureTime);
            this.Controls.Add(this.lblPitch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFixtures);
            this.Controls.Add(this.btnFixturesLeft);
            this.Controls.Add(this.btnFixturesRight);
            this.Controls.Add(this.btnFixtureSave);
            this.Controls.Add(this.btnFixtureEdit);
            this.Name = "ManageFixtures";
            this.Text = "ManageFixtures";
            this.Load += new System.EventHandler(this.ManageFixtures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rEFEREEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pITCHBindingSource)).EndInit();
            this.tcFixture1.ResumeLayout(false);
            this.tpFixture1.ResumeLayout(false);
            this.tpFixture1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fkTeam1IDBindingSource1)).EndInit();
            this.tcFixture2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fkTeam1IDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkTeam2IDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbReferee;
        private System.Windows.Forms.TextBox txtTeam2Goals;
        private System.Windows.Forms.TextBox txtTeam1Goals;
        private System.Windows.Forms.Label lblTeam2;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Label lblTeam1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cmbTeam1;
        private System.Windows.Forms.DateTimePicker DTPFixtureDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtFixtureTime;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFixtures;
        private System.Windows.Forms.Button btnFixturesLeft;
        private System.Windows.Forms.Button btnFixturesRight;
        private System.Windows.Forms.Button btnFixtureSave;
        private System.Windows.Forms.Button btnFixtureEdit;
        private CIFDataSet cIFDataSet;
        private System.Windows.Forms.BindingSource tEAMBindingSource;
        private CIFDataSetTableAdapters.TEAMTableAdapter tEAMTableAdapter;
        private System.Windows.Forms.BindingSource tEAMBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource rEFEREEBindingSource;
        private CIFDataSetTableAdapters.REFEREETableAdapter rEFEREETableAdapter;
        private System.Windows.Forms.ComboBox cmbPitch;
        private System.Windows.Forms.BindingSource pITCHBindingSource;
        private CIFDataSetTableAdapters.PITCHTableAdapter pITCHTableAdapter;
        private System.Windows.Forms.TabControl tcFixture1;
        private System.Windows.Forms.TabPage tpFixture1;
        private System.Windows.Forms.TabPage tpFixture2;
        private System.Windows.Forms.TabControl tcFixture2;
        private System.Windows.Forms.TabPage tpFixture3;
        private System.Windows.Forms.TabPage tpFixture4;
        private System.Windows.Forms.ListBox lbTeam1Goal1;
        private System.Windows.Forms.BindingSource fkTeam1IDBindingSource;
        private CIFDataSetTableAdapters.MATCHSTATSTableAdapter mATCHSTATSTableAdapter;
        private System.Windows.Forms.BindingSource fkTeam1IDBindingSource1;
        private System.Windows.Forms.BindingSource fkTeam2IDBindingSource;
        private System.Windows.Forms.Button btnTeam1Add;
        private System.Windows.Forms.TextBox txtTeam1Scorer1;
        private System.Windows.Forms.Label lblTeam1Scorer1;
        private System.Windows.Forms.Button btnTeam1Save1;
        private System.Windows.Forms.Button btnTeam1Edit;
    }
}