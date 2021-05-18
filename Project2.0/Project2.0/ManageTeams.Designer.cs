namespace Project2._0
{
    partial class ManageTeams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTeams));
            this.lblTeamMenu = new System.Windows.Forms.Label();
            this.tcTeamManagement = new System.Windows.Forms.TabControl();
            this.tpViewTeam = new System.Windows.Forms.TabPage();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTeamOptions = new System.Windows.Forms.Label();
            this.btnTPTeamViewDelete = new System.Windows.Forms.Button();
            this.btnTPTeamViewEdit = new System.Windows.Forms.Button();
            this.btnTPTeamViewAdd = new System.Windows.Forms.Button();
            this.DGVTeamManage = new System.Windows.Forms.DataGridView();
            this.tpAddTeam = new System.Windows.Forms.TabPage();
            this.txtTPAddTeamID = new System.Windows.Forms.TextBox();
            this.btnTPAddFinalise = new System.Windows.Forms.Button();
            this.btnTPAddCancel = new System.Windows.Forms.Button();
            this.txtTPAddTeamName = new System.Windows.Forms.TextBox();
            this.lblTPAddTeamName = new System.Windows.Forms.Label();
            this.lblTPAddTeamID = new System.Windows.Forms.Label();
            this.tpEditTeams = new System.Windows.Forms.TabPage();
            this.btnTPEditEdit = new System.Windows.Forms.Button();
            this.txtTPEditTeamID = new System.Windows.Forms.TextBox();
            this.btnTPTeamEditFinalise = new System.Windows.Forms.Button();
            this.btnTPTeamEditCancel = new System.Windows.Forms.Button();
            this.txtTPEditTeamName = new System.Windows.Forms.TextBox();
            this.lblTPEditTeamName = new System.Windows.Forms.Label();
            this.lblTPEditTeamID = new System.Windows.Forms.Label();
            this.btnTPTeamBackToViewTab = new System.Windows.Forms.Button();
            this.btnTeamMenuBack = new System.Windows.Forms.Button();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.cIFDataSet = new Project2._0.CIFDataSet();
            this.tEAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEAMTableAdapter = new Project2._0.CIFDataSetTableAdapters.TEAMTableAdapter();
            this.teamIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcTeamManagement.SuspendLayout();
            this.tpViewTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTeamManage)).BeginInit();
            this.tpAddTeam.SuspendLayout();
            this.tpEditTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeamMenu
            // 
            this.lblTeamMenu.AutoSize = true;
            this.lblTeamMenu.Font = new System.Drawing.Font("Franklin Gothic Medium", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamMenu.ForeColor = System.Drawing.Color.White;
            this.lblTeamMenu.Location = new System.Drawing.Point(51, 2);
            this.lblTeamMenu.Name = "lblTeamMenu";
            this.lblTeamMenu.Size = new System.Drawing.Size(625, 81);
            this.lblTeamMenu.TabIndex = 7;
            this.lblTeamMenu.Text = "TEAM MANAGEMENT";
            // 
            // tcTeamManagement
            // 
            this.tcTeamManagement.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcTeamManagement.Controls.Add(this.tpViewTeam);
            this.tcTeamManagement.Controls.Add(this.tpAddTeam);
            this.tcTeamManagement.Controls.Add(this.tpEditTeams);
            this.tcTeamManagement.Location = new System.Drawing.Point(61, 86);
            this.tcTeamManagement.Name = "tcTeamManagement";
            this.tcTeamManagement.SelectedIndex = 0;
            this.tcTeamManagement.Size = new System.Drawing.Size(700, 331);
            this.tcTeamManagement.TabIndex = 9;
            this.tcTeamManagement.TabStop = false;
            // 
            // tpViewTeam
            // 
            this.tpViewTeam.BackColor = System.Drawing.Color.Blue;
            this.tpViewTeam.Controls.Add(this.lbl3);
            this.tpViewTeam.Controls.Add(this.lbl2);
            this.tpViewTeam.Controls.Add(this.lbl1);
            this.tpViewTeam.Controls.Add(this.lblTeamOptions);
            this.tpViewTeam.Controls.Add(this.btnTPTeamViewDelete);
            this.tpViewTeam.Controls.Add(this.btnTPTeamViewEdit);
            this.tpViewTeam.Controls.Add(this.btnTPTeamViewAdd);
            this.tpViewTeam.Controls.Add(this.DGVTeamManage);
            this.tpViewTeam.Location = new System.Drawing.Point(4, 25);
            this.tpViewTeam.Name = "tpViewTeam";
            this.tpViewTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tpViewTeam.Size = new System.Drawing.Size(692, 302);
            this.tpViewTeam.TabIndex = 0;
            this.tpViewTeam.Text = "View";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(565, 123);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(57, 20);
            this.lbl3.TabIndex = 17;
            this.lbl3.Text = "DELETE";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(476, 123);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(38, 20);
            this.lbl2.TabIndex = 16;
            this.lbl2.Text = "EDIT";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(370, 123);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(38, 20);
            this.lbl1.TabIndex = 15;
            this.lbl1.Text = "ADD";
            // 
            // lblTeamOptions
            // 
            this.lblTeamOptions.AutoSize = true;
            this.lblTeamOptions.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamOptions.ForeColor = System.Drawing.Color.White;
            this.lblTeamOptions.Location = new System.Drawing.Point(389, 86);
            this.lblTeamOptions.Name = "lblTeamOptions";
            this.lblTeamOptions.Size = new System.Drawing.Size(207, 37);
            this.lblTeamOptions.TabIndex = 11;
            this.lblTeamOptions.Text = "TEAM OPTIONS";
            // 
            // btnTPTeamViewDelete
            // 
            this.btnTPTeamViewDelete.BackColor = System.Drawing.Color.White;
            this.btnTPTeamViewDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTPTeamViewDelete.BackgroundImage")));
            this.btnTPTeamViewDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTPTeamViewDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTPTeamViewDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTPTeamViewDelete.FlatAppearance.BorderSize = 10;
            this.btnTPTeamViewDelete.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPTeamViewDelete.ForeColor = System.Drawing.Color.White;
            this.btnTPTeamViewDelete.Location = new System.Drawing.Point(546, 146);
            this.btnTPTeamViewDelete.Name = "btnTPTeamViewDelete";
            this.btnTPTeamViewDelete.Size = new System.Drawing.Size(91, 53);
            this.btnTPTeamViewDelete.TabIndex = 10;
            this.btnTPTeamViewDelete.UseVisualStyleBackColor = false;
            this.btnTPTeamViewDelete.Click += new System.EventHandler(this.btnTPTeamViewDelete_Click);
            // 
            // btnTPTeamViewEdit
            // 
            this.btnTPTeamViewEdit.BackColor = System.Drawing.Color.White;
            this.btnTPTeamViewEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTPTeamViewEdit.BackgroundImage")));
            this.btnTPTeamViewEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTPTeamViewEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTPTeamViewEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTPTeamViewEdit.FlatAppearance.BorderSize = 10;
            this.btnTPTeamViewEdit.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPTeamViewEdit.ForeColor = System.Drawing.Color.White;
            this.btnTPTeamViewEdit.Location = new System.Drawing.Point(449, 146);
            this.btnTPTeamViewEdit.Name = "btnTPTeamViewEdit";
            this.btnTPTeamViewEdit.Size = new System.Drawing.Size(91, 53);
            this.btnTPTeamViewEdit.TabIndex = 9;
            this.btnTPTeamViewEdit.UseVisualStyleBackColor = false;
            this.btnTPTeamViewEdit.Click += new System.EventHandler(this.btnTPTeamViewEdit_Click);
            // 
            // btnTPTeamViewAdd
            // 
            this.btnTPTeamViewAdd.BackColor = System.Drawing.Color.White;
            this.btnTPTeamViewAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTPTeamViewAdd.BackgroundImage")));
            this.btnTPTeamViewAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTPTeamViewAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTPTeamViewAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTPTeamViewAdd.FlatAppearance.BorderSize = 10;
            this.btnTPTeamViewAdd.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPTeamViewAdd.ForeColor = System.Drawing.Color.White;
            this.btnTPTeamViewAdd.Location = new System.Drawing.Point(352, 146);
            this.btnTPTeamViewAdd.Name = "btnTPTeamViewAdd";
            this.btnTPTeamViewAdd.Size = new System.Drawing.Size(91, 53);
            this.btnTPTeamViewAdd.TabIndex = 8;
            this.btnTPTeamViewAdd.UseVisualStyleBackColor = false;
            this.btnTPTeamViewAdd.Click += new System.EventHandler(this.btnTPTeamViewAdd_Click);
            // 
            // DGVTeamManage
            // 
            this.DGVTeamManage.AutoGenerateColumns = false;
            this.DGVTeamManage.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVTeamManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTeamManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamIDDataGridViewTextBoxColumn,
            this.teamNameDataGridViewTextBoxColumn});
            this.DGVTeamManage.DataSource = this.tEAMBindingSource;
            this.DGVTeamManage.Location = new System.Drawing.Point(20, 10);
            this.DGVTeamManage.Name = "DGVTeamManage";
            this.DGVTeamManage.Size = new System.Drawing.Size(290, 269);
            this.DGVTeamManage.TabIndex = 0;
            // 
            // tpAddTeam
            // 
            this.tpAddTeam.Controls.Add(this.txtTPAddTeamID);
            this.tpAddTeam.Controls.Add(this.btnTPAddFinalise);
            this.tpAddTeam.Controls.Add(this.btnTPAddCancel);
            this.tpAddTeam.Controls.Add(this.txtTPAddTeamName);
            this.tpAddTeam.Controls.Add(this.lblTPAddTeamName);
            this.tpAddTeam.Controls.Add(this.lblTPAddTeamID);
            this.tpAddTeam.Location = new System.Drawing.Point(4, 25);
            this.tpAddTeam.Name = "tpAddTeam";
            this.tpAddTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddTeam.Size = new System.Drawing.Size(692, 302);
            this.tpAddTeam.TabIndex = 1;
            this.tpAddTeam.Text = "Add";
            this.tpAddTeam.UseVisualStyleBackColor = true;
            // 
            // txtTPAddTeamID
            // 
            this.txtTPAddTeamID.Location = new System.Drawing.Point(133, 48);
            this.txtTPAddTeamID.Name = "txtTPAddTeamID";
            this.txtTPAddTeamID.Size = new System.Drawing.Size(175, 20);
            this.txtTPAddTeamID.TabIndex = 10;
            // 
            // btnTPAddFinalise
            // 
            this.btnTPAddFinalise.BackColor = System.Drawing.Color.White;
            this.btnTPAddFinalise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTPAddFinalise.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTPAddFinalise.FlatAppearance.BorderSize = 10;
            this.btnTPAddFinalise.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPAddFinalise.ForeColor = System.Drawing.Color.Lime;
            this.btnTPAddFinalise.Location = new System.Drawing.Point(513, 255);
            this.btnTPAddFinalise.Name = "btnTPAddFinalise";
            this.btnTPAddFinalise.Size = new System.Drawing.Size(173, 44);
            this.btnTPAddFinalise.TabIndex = 9;
            this.btnTPAddFinalise.Text = "Finalise";
            this.btnTPAddFinalise.UseVisualStyleBackColor = false;
            this.btnTPAddFinalise.Click += new System.EventHandler(this.btnTPAddFinalise_Click);
            // 
            // btnTPAddCancel
            // 
            this.btnTPAddCancel.BackColor = System.Drawing.Color.White;
            this.btnTPAddCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTPAddCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTPAddCancel.FlatAppearance.BorderSize = 10;
            this.btnTPAddCancel.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPAddCancel.ForeColor = System.Drawing.Color.Red;
            this.btnTPAddCancel.Location = new System.Drawing.Point(434, 255);
            this.btnTPAddCancel.Name = "btnTPAddCancel";
            this.btnTPAddCancel.Size = new System.Drawing.Size(73, 44);
            this.btnTPAddCancel.TabIndex = 8;
            this.btnTPAddCancel.Text = "Cancel";
            this.btnTPAddCancel.UseVisualStyleBackColor = false;
            this.btnTPAddCancel.Click += new System.EventHandler(this.btnTPAddCancel_Click);
            // 
            // txtTPAddTeamName
            // 
            this.txtTPAddTeamName.Location = new System.Drawing.Point(133, 86);
            this.txtTPAddTeamName.Name = "txtTPAddTeamName";
            this.txtTPAddTeamName.Size = new System.Drawing.Size(175, 20);
            this.txtTPAddTeamName.TabIndex = 4;
            // 
            // lblTPAddTeamName
            // 
            this.lblTPAddTeamName.AutoSize = true;
            this.lblTPAddTeamName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPAddTeamName.Location = new System.Drawing.Point(31, 85);
            this.lblTPAddTeamName.Name = "lblTPAddTeamName";
            this.lblTPAddTeamName.Size = new System.Drawing.Size(92, 19);
            this.lblTPAddTeamName.TabIndex = 1;
            this.lblTPAddTeamName.Text = "Team Name:";
            // 
            // lblTPAddTeamID
            // 
            this.lblTPAddTeamID.AutoSize = true;
            this.lblTPAddTeamID.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPAddTeamID.Location = new System.Drawing.Point(57, 47);
            this.lblTPAddTeamID.Name = "lblTPAddTeamID";
            this.lblTPAddTeamID.Size = new System.Drawing.Size(66, 19);
            this.lblTPAddTeamID.TabIndex = 0;
            this.lblTPAddTeamID.Text = "Team ID:";
            // 
            // tpEditTeams
            // 
            this.tpEditTeams.Controls.Add(this.btnTPEditEdit);
            this.tpEditTeams.Controls.Add(this.txtTPEditTeamID);
            this.tpEditTeams.Controls.Add(this.btnTPTeamEditFinalise);
            this.tpEditTeams.Controls.Add(this.btnTPTeamEditCancel);
            this.tpEditTeams.Controls.Add(this.txtTPEditTeamName);
            this.tpEditTeams.Controls.Add(this.lblTPEditTeamName);
            this.tpEditTeams.Controls.Add(this.lblTPEditTeamID);
            this.tpEditTeams.Location = new System.Drawing.Point(4, 25);
            this.tpEditTeams.Name = "tpEditTeams";
            this.tpEditTeams.Size = new System.Drawing.Size(692, 302);
            this.tpEditTeams.TabIndex = 2;
            this.tpEditTeams.Text = "Edit";
            this.tpEditTeams.UseVisualStyleBackColor = true;
            // 
            // btnTPEditEdit
            // 
            this.btnTPEditEdit.BackColor = System.Drawing.Color.White;
            this.btnTPEditEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTPEditEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTPEditEdit.FlatAppearance.BorderSize = 10;
            this.btnTPEditEdit.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPEditEdit.ForeColor = System.Drawing.Color.Red;
            this.btnTPEditEdit.Location = new System.Drawing.Point(608, 48);
            this.btnTPEditEdit.Name = "btnTPEditEdit";
            this.btnTPEditEdit.Size = new System.Drawing.Size(73, 44);
            this.btnTPEditEdit.TabIndex = 19;
            this.btnTPEditEdit.Text = "EDIT";
            this.btnTPEditEdit.UseVisualStyleBackColor = false;
            this.btnTPEditEdit.Click += new System.EventHandler(this.btnTPEditEdit_Click);
            // 
            // txtTPEditTeamID
            // 
            this.txtTPEditTeamID.Enabled = false;
            this.txtTPEditTeamID.Location = new System.Drawing.Point(142, 49);
            this.txtTPEditTeamID.Name = "txtTPEditTeamID";
            this.txtTPEditTeamID.Size = new System.Drawing.Size(175, 20);
            this.txtTPEditTeamID.TabIndex = 18;
            // 
            // btnTPTeamEditFinalise
            // 
            this.btnTPTeamEditFinalise.BackColor = System.Drawing.Color.White;
            this.btnTPTeamEditFinalise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTPTeamEditFinalise.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTPTeamEditFinalise.FlatAppearance.BorderSize = 10;
            this.btnTPTeamEditFinalise.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPTeamEditFinalise.ForeColor = System.Drawing.Color.Lime;
            this.btnTPTeamEditFinalise.Location = new System.Drawing.Point(508, 244);
            this.btnTPTeamEditFinalise.Name = "btnTPTeamEditFinalise";
            this.btnTPTeamEditFinalise.Size = new System.Drawing.Size(173, 44);
            this.btnTPTeamEditFinalise.TabIndex = 17;
            this.btnTPTeamEditFinalise.Text = "Finalise";
            this.btnTPTeamEditFinalise.UseVisualStyleBackColor = false;
            this.btnTPTeamEditFinalise.Click += new System.EventHandler(this.btnTPTeamEditFinalise_Click);
            // 
            // btnTPTeamEditCancel
            // 
            this.btnTPTeamEditCancel.BackColor = System.Drawing.Color.White;
            this.btnTPTeamEditCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTPTeamEditCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTPTeamEditCancel.FlatAppearance.BorderSize = 10;
            this.btnTPTeamEditCancel.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPTeamEditCancel.ForeColor = System.Drawing.Color.Red;
            this.btnTPTeamEditCancel.Location = new System.Drawing.Point(429, 244);
            this.btnTPTeamEditCancel.Name = "btnTPTeamEditCancel";
            this.btnTPTeamEditCancel.Size = new System.Drawing.Size(73, 44);
            this.btnTPTeamEditCancel.TabIndex = 16;
            this.btnTPTeamEditCancel.Text = "Cancel";
            this.btnTPTeamEditCancel.UseVisualStyleBackColor = false;
            this.btnTPTeamEditCancel.Click += new System.EventHandler(this.btnTPTeamEditCancel_Click);
            // 
            // txtTPEditTeamName
            // 
            this.txtTPEditTeamName.Enabled = false;
            this.txtTPEditTeamName.Location = new System.Drawing.Point(142, 84);
            this.txtTPEditTeamName.Name = "txtTPEditTeamName";
            this.txtTPEditTeamName.Size = new System.Drawing.Size(175, 20);
            this.txtTPEditTeamName.TabIndex = 14;
            // 
            // lblTPEditTeamName
            // 
            this.lblTPEditTeamName.AutoSize = true;
            this.lblTPEditTeamName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPEditTeamName.Location = new System.Drawing.Point(40, 83);
            this.lblTPEditTeamName.Name = "lblTPEditTeamName";
            this.lblTPEditTeamName.Size = new System.Drawing.Size(92, 19);
            this.lblTPEditTeamName.TabIndex = 11;
            this.lblTPEditTeamName.Text = "Team Name:";
            // 
            // lblTPEditTeamID
            // 
            this.lblTPEditTeamID.AutoSize = true;
            this.lblTPEditTeamID.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPEditTeamID.Location = new System.Drawing.Point(66, 48);
            this.lblTPEditTeamID.Name = "lblTPEditTeamID";
            this.lblTPEditTeamID.Size = new System.Drawing.Size(66, 19);
            this.lblTPEditTeamID.TabIndex = 10;
            this.lblTPEditTeamID.Text = "Team ID:";
            // 
            // btnTPTeamBackToViewTab
            // 
            this.btnTPTeamBackToViewTab.BackColor = System.Drawing.Color.White;
            this.btnTPTeamBackToViewTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTPTeamBackToViewTab.BackgroundImage")));
            this.btnTPTeamBackToViewTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTPTeamBackToViewTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTPTeamBackToViewTab.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTPTeamBackToViewTab.FlatAppearance.BorderSize = 10;
            this.btnTPTeamBackToViewTab.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPTeamBackToViewTab.ForeColor = System.Drawing.Color.Red;
            this.btnTPTeamBackToViewTab.Location = new System.Drawing.Point(703, 50);
            this.btnTPTeamBackToViewTab.Name = "btnTPTeamBackToViewTab";
            this.btnTPTeamBackToViewTab.Size = new System.Drawing.Size(58, 34);
            this.btnTPTeamBackToViewTab.TabIndex = 21;
            this.btnTPTeamBackToViewTab.UseVisualStyleBackColor = false;
            // 
            // btnTeamMenuBack
            // 
            this.btnTeamMenuBack.BackColor = System.Drawing.Color.White;
            this.btnTeamMenuBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTeamMenuBack.BackgroundImage")));
            this.btnTeamMenuBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTeamMenuBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeamMenuBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTeamMenuBack.FlatAppearance.BorderSize = 10;
            this.btnTeamMenuBack.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeamMenuBack.ForeColor = System.Drawing.Color.Red;
            this.btnTeamMenuBack.Location = new System.Drawing.Point(703, 12);
            this.btnTeamMenuBack.Name = "btnTeamMenuBack";
            this.btnTeamMenuBack.Size = new System.Drawing.Size(58, 34);
            this.btnTeamMenuBack.TabIndex = 20;
            this.btnTeamMenuBack.UseVisualStyleBackColor = false;
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // cIFDataSet
            // 
            this.cIFDataSet.DataSetName = "CIFDataSet";
            this.cIFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tEAMBindingSource
            // 
            this.tEAMBindingSource.DataMember = "TEAM";
            this.tEAMBindingSource.DataSource = this.cIFDataSet;
            // 
            // tEAMTableAdapter
            // 
            this.tEAMTableAdapter.ClearBeforeFill = true;
            // 
            // teamIDDataGridViewTextBoxColumn
            // 
            this.teamIDDataGridViewTextBoxColumn.DataPropertyName = "TeamID";
            this.teamIDDataGridViewTextBoxColumn.HeaderText = "TeamID";
            this.teamIDDataGridViewTextBoxColumn.Name = "teamIDDataGridViewTextBoxColumn";
            // 
            // teamNameDataGridViewTextBoxColumn
            // 
            this.teamNameDataGridViewTextBoxColumn.DataPropertyName = "TeamName";
            this.teamNameDataGridViewTextBoxColumn.HeaderText = "TeamName";
            this.teamNameDataGridViewTextBoxColumn.Name = "teamNameDataGridViewTextBoxColumn";
            // 
            // ManageTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(828, 429);
            this.Controls.Add(this.btnTPTeamBackToViewTab);
            this.Controls.Add(this.tcTeamManagement);
            this.Controls.Add(this.btnTeamMenuBack);
            this.Controls.Add(this.lblTeamMenu);
            this.Name = "ManageTeams";
            this.Text = "ManageTeams";
            this.Load += new System.EventHandler(this.ManageTeams_Load);
            this.tcTeamManagement.ResumeLayout(false);
            this.tpViewTeam.ResumeLayout(false);
            this.tpViewTeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTeamManage)).EndInit();
            this.tpAddTeam.ResumeLayout(false);
            this.tpAddTeam.PerformLayout();
            this.tpEditTeams.ResumeLayout(false);
            this.tpEditTeams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeamMenu;
        private System.Windows.Forms.TabControl tcTeamManagement;
        private System.Windows.Forms.TabPage tpViewTeam;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTeamOptions;
        private System.Windows.Forms.Button btnTPTeamViewDelete;
        private System.Windows.Forms.Button btnTPTeamViewEdit;
        private System.Windows.Forms.Button btnTPTeamViewAdd;
        private System.Windows.Forms.DataGridView DGVTeamManage;
        private System.Windows.Forms.TabPage tpAddTeam;
        private System.Windows.Forms.TextBox txtTPAddTeamID;
        private System.Windows.Forms.Button btnTPAddFinalise;
        private System.Windows.Forms.Button btnTPAddCancel;
        private System.Windows.Forms.TextBox txtTPAddTeamName;
        private System.Windows.Forms.Label lblTPAddTeamName;
        private System.Windows.Forms.Label lblTPAddTeamID;
        private System.Windows.Forms.TabPage tpEditTeams;
        private System.Windows.Forms.Button btnTPEditEdit;
        private System.Windows.Forms.TextBox txtTPEditTeamID;
        private System.Windows.Forms.Button btnTPTeamEditFinalise;
        private System.Windows.Forms.Button btnTPTeamEditCancel;
        private System.Windows.Forms.TextBox txtTPEditTeamName;
        private System.Windows.Forms.Label lblTPEditTeamName;
        private System.Windows.Forms.Label lblTPEditTeamID;
        private System.Windows.Forms.Button btnTPTeamBackToViewTab;
        private System.Windows.Forms.Button btnTeamMenuBack;
        private System.Windows.Forms.ErrorProvider errP;
        private CIFDataSet cIFDataSet;
        private System.Windows.Forms.BindingSource tEAMBindingSource;
        private CIFDataSetTableAdapters.TEAMTableAdapter tEAMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamNameDataGridViewTextBoxColumn;
    }
}