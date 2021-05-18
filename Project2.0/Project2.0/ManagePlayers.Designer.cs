namespace Project2._0
{
    partial class ManagePlayers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePlayers));
            this.btnTPTeamBackToViewTab = new System.Windows.Forms.Button();
            this.tcPlayerManagement = new System.Windows.Forms.TabControl();
            this.tpPlayerManagementView = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnTPPlayerViewDelete = new System.Windows.Forms.Button();
            this.btnTPPlayerViewEdit = new System.Windows.Forms.Button();
            this.btnTPPlayerViewAdd = new System.Windows.Forms.Button();
            this.DGVPlayerManagementViewPlayers = new System.Windows.Forms.DataGridView();
            this.tpPlayerManagementAdd = new System.Windows.Forms.TabPage();
            this.txtTPPlayerAddTeam = new System.Windows.Forms.TextBox();
            this.txtTPPlayerAddID = new System.Windows.Forms.TextBox();
            this.txtTPAddPlayerAge = new System.Windows.Forms.TextBox();
            this.txtTPAddPlayerSurname = new System.Windows.Forms.TextBox();
            this.txtTPAddPlayerForename = new System.Windows.Forms.TextBox();
            this.lblTPPlayerTeamID = new System.Windows.Forms.Label();
            this.btnTPPlayerAddFinalise = new System.Windows.Forms.Button();
            this.btnTPPlayerAddCancel = new System.Windows.Forms.Button();
            this.lblTPAddPlayerAge = new System.Windows.Forms.Label();
            this.lblTPAddPlayerSurname = new System.Windows.Forms.Label();
            this.lblTPAddPlayerForename = new System.Windows.Forms.Label();
            this.lblTPAddPlayerID2 = new System.Windows.Forms.Label();
            this.lblTPAddPlayerID = new System.Windows.Forms.Label();
            this.tpPlayerManagementEdit = new System.Windows.Forms.TabPage();
            this.txtTPPlayerEditID = new System.Windows.Forms.TextBox();
            this.txtTPPlayerEditTeam = new System.Windows.Forms.TextBox();
            this.lblTPPlayerEditTeam = new System.Windows.Forms.Label();
            this.btnTPPlayerEditFinalise = new System.Windows.Forms.Button();
            this.btnTPPlayerEditCancel = new System.Windows.Forms.Button();
            this.txtTPEditPlayerAge = new System.Windows.Forms.TextBox();
            this.txtTPEditPlayerSurname = new System.Windows.Forms.TextBox();
            this.txtTPEditPlayerForename = new System.Windows.Forms.TextBox();
            this.lblTPEditPlayerAge = new System.Windows.Forms.Label();
            this.lblTPEditPlayerSurname = new System.Windows.Forms.Label();
            this.lblTPEditPlayerForename = new System.Windows.Forms.Label();
            this.lblTPEditPlayerID = new System.Windows.Forms.Label();
            this.btnPlayerMenuBack = new System.Windows.Forms.Button();
            this.lblPlayerMenu = new System.Windows.Forms.Label();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.cIFDataSet = new Project2._0.CIFDataSet();
            this.pLAYERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLAYERTableAdapter = new Project2._0.CIFDataSetTableAdapters.PLAYERTableAdapter();
            this.playerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerForenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcPlayerManagement.SuspendLayout();
            this.tpPlayerManagementView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPlayerManagementViewPlayers)).BeginInit();
            this.tpPlayerManagementAdd.SuspendLayout();
            this.tpPlayerManagementEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYERBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.btnTPTeamBackToViewTab.Location = new System.Drawing.Point(707, 49);
            this.btnTPTeamBackToViewTab.Name = "btnTPTeamBackToViewTab";
            this.btnTPTeamBackToViewTab.Size = new System.Drawing.Size(58, 34);
            this.btnTPTeamBackToViewTab.TabIndex = 14;
            this.btnTPTeamBackToViewTab.UseVisualStyleBackColor = false;
            this.btnTPTeamBackToViewTab.Click += new System.EventHandler(this.btnTPTeamBackToViewTab_Click);
            // 
            // tcPlayerManagement
            // 
            this.tcPlayerManagement.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcPlayerManagement.Controls.Add(this.tpPlayerManagementView);
            this.tcPlayerManagement.Controls.Add(this.tpPlayerManagementAdd);
            this.tcPlayerManagement.Controls.Add(this.tpPlayerManagementEdit);
            this.tcPlayerManagement.Location = new System.Drawing.Point(38, 85);
            this.tcPlayerManagement.Name = "tcPlayerManagement";
            this.tcPlayerManagement.SelectedIndex = 0;
            this.tcPlayerManagement.Size = new System.Drawing.Size(700, 318);
            this.tcPlayerManagement.TabIndex = 13;
            // 
            // tpPlayerManagementView
            // 
            this.tpPlayerManagementView.BackColor = System.Drawing.Color.Blue;
            this.tpPlayerManagementView.Controls.Add(this.label2);
            this.tpPlayerManagementView.Controls.Add(this.label1);
            this.tpPlayerManagementView.Controls.Add(this.lbl1);
            this.tpPlayerManagementView.Controls.Add(this.btnTPPlayerViewDelete);
            this.tpPlayerManagementView.Controls.Add(this.btnTPPlayerViewEdit);
            this.tpPlayerManagementView.Controls.Add(this.btnTPPlayerViewAdd);
            this.tpPlayerManagementView.Controls.Add(this.DGVPlayerManagementViewPlayers);
            this.tpPlayerManagementView.Location = new System.Drawing.Point(4, 25);
            this.tpPlayerManagementView.Name = "tpPlayerManagementView";
            this.tpPlayerManagementView.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlayerManagementView.Size = new System.Drawing.Size(692, 289);
            this.tpPlayerManagementView.TabIndex = 0;
            this.tpPlayerManagementView.Text = "View";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(332, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "DELETE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(202, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "EDIT";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(58, 212);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(38, 20);
            this.lbl1.TabIndex = 16;
            this.lbl1.Text = "ADD";
            // 
            // btnTPPlayerViewDelete
            // 
            this.btnTPPlayerViewDelete.BackColor = System.Drawing.Color.White;
            this.btnTPPlayerViewDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTPPlayerViewDelete.BackgroundImage")));
            this.btnTPPlayerViewDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTPPlayerViewDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTPPlayerViewDelete.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnTPPlayerViewDelete.FlatAppearance.BorderSize = 10;
            this.btnTPPlayerViewDelete.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPPlayerViewDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTPPlayerViewDelete.Location = new System.Drawing.Point(308, 235);
            this.btnTPPlayerViewDelete.Name = "btnTPPlayerViewDelete";
            this.btnTPPlayerViewDelete.Size = new System.Drawing.Size(81, 48);
            this.btnTPPlayerViewDelete.TabIndex = 13;
            this.btnTPPlayerViewDelete.UseVisualStyleBackColor = false;
            this.btnTPPlayerViewDelete.Click += new System.EventHandler(this.btnTPPlayerViewDelete_Click);
            // 
            // btnTPPlayerViewEdit
            // 
            this.btnTPPlayerViewEdit.BackColor = System.Drawing.Color.White;
            this.btnTPPlayerViewEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTPPlayerViewEdit.BackgroundImage")));
            this.btnTPPlayerViewEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTPPlayerViewEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTPPlayerViewEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTPPlayerViewEdit.FlatAppearance.BorderSize = 10;
            this.btnTPPlayerViewEdit.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPPlayerViewEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTPPlayerViewEdit.Location = new System.Drawing.Point(180, 235);
            this.btnTPPlayerViewEdit.Name = "btnTPPlayerViewEdit";
            this.btnTPPlayerViewEdit.Size = new System.Drawing.Size(81, 48);
            this.btnTPPlayerViewEdit.TabIndex = 12;
            this.btnTPPlayerViewEdit.UseVisualStyleBackColor = false;
            this.btnTPPlayerViewEdit.Click += new System.EventHandler(this.btnTPPlayerViewEdit_Click);
            // 
            // btnTPPlayerViewAdd
            // 
            this.btnTPPlayerViewAdd.BackColor = System.Drawing.Color.White;
            this.btnTPPlayerViewAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTPPlayerViewAdd.BackgroundImage")));
            this.btnTPPlayerViewAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTPPlayerViewAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTPPlayerViewAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTPPlayerViewAdd.FlatAppearance.BorderSize = 10;
            this.btnTPPlayerViewAdd.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPPlayerViewAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTPPlayerViewAdd.Location = new System.Drawing.Point(37, 235);
            this.btnTPPlayerViewAdd.Name = "btnTPPlayerViewAdd";
            this.btnTPPlayerViewAdd.Size = new System.Drawing.Size(81, 48);
            this.btnTPPlayerViewAdd.TabIndex = 11;
            this.btnTPPlayerViewAdd.UseVisualStyleBackColor = false;
            this.btnTPPlayerViewAdd.Click += new System.EventHandler(this.btnTPPlayerViewAdd_Click);
            // 
            // DGVPlayerManagementViewPlayers
            // 
            this.DGVPlayerManagementViewPlayers.AutoGenerateColumns = false;
            this.DGVPlayerManagementViewPlayers.BackgroundColor = System.Drawing.Color.White;
            this.DGVPlayerManagementViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPlayerManagementViewPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIDDataGridViewTextBoxColumn,
            this.playerForenameDataGridViewTextBoxColumn,
            this.playerSurnameDataGridViewTextBoxColumn,
            this.playerAgeDataGridViewTextBoxColumn,
            this.playerStatusDataGridViewTextBoxColumn,
            this.PlayerStatus,
            this.teamIDDataGridViewTextBoxColumn});
            this.DGVPlayerManagementViewPlayers.DataSource = this.pLAYERBindingSource;
            this.DGVPlayerManagementViewPlayers.Location = new System.Drawing.Point(19, 20);
            this.DGVPlayerManagementViewPlayers.Name = "DGVPlayerManagementViewPlayers";
            this.DGVPlayerManagementViewPlayers.Size = new System.Drawing.Size(644, 129);
            this.DGVPlayerManagementViewPlayers.TabIndex = 10;
            // 
            // tpPlayerManagementAdd
            // 
            this.tpPlayerManagementAdd.BackColor = System.Drawing.Color.Blue;
            this.tpPlayerManagementAdd.Controls.Add(this.txtTPPlayerAddTeam);
            this.tpPlayerManagementAdd.Controls.Add(this.txtTPPlayerAddID);
            this.tpPlayerManagementAdd.Controls.Add(this.txtTPAddPlayerAge);
            this.tpPlayerManagementAdd.Controls.Add(this.txtTPAddPlayerSurname);
            this.tpPlayerManagementAdd.Controls.Add(this.txtTPAddPlayerForename);
            this.tpPlayerManagementAdd.Controls.Add(this.lblTPPlayerTeamID);
            this.tpPlayerManagementAdd.Controls.Add(this.btnTPPlayerAddFinalise);
            this.tpPlayerManagementAdd.Controls.Add(this.btnTPPlayerAddCancel);
            this.tpPlayerManagementAdd.Controls.Add(this.lblTPAddPlayerAge);
            this.tpPlayerManagementAdd.Controls.Add(this.lblTPAddPlayerSurname);
            this.tpPlayerManagementAdd.Controls.Add(this.lblTPAddPlayerForename);
            this.tpPlayerManagementAdd.Controls.Add(this.lblTPAddPlayerID2);
            this.tpPlayerManagementAdd.Controls.Add(this.lblTPAddPlayerID);
            this.tpPlayerManagementAdd.Location = new System.Drawing.Point(4, 25);
            this.tpPlayerManagementAdd.Name = "tpPlayerManagementAdd";
            this.tpPlayerManagementAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlayerManagementAdd.Size = new System.Drawing.Size(692, 289);
            this.tpPlayerManagementAdd.TabIndex = 1;
            this.tpPlayerManagementAdd.Text = "Add";
            // 
            // txtTPPlayerAddTeam
            // 
            this.txtTPPlayerAddTeam.ForeColor = System.Drawing.Color.Red;
            this.txtTPPlayerAddTeam.Location = new System.Drawing.Point(153, 202);
            this.txtTPPlayerAddTeam.Name = "txtTPPlayerAddTeam";
            this.txtTPPlayerAddTeam.Size = new System.Drawing.Size(181, 20);
            this.txtTPPlayerAddTeam.TabIndex = 14;
            // 
            // txtTPPlayerAddID
            // 
            this.txtTPPlayerAddID.Enabled = false;
            this.txtTPPlayerAddID.ForeColor = System.Drawing.Color.Red;
            this.txtTPPlayerAddID.Location = new System.Drawing.Point(153, 35);
            this.txtTPPlayerAddID.Name = "txtTPPlayerAddID";
            this.txtTPPlayerAddID.Size = new System.Drawing.Size(181, 20);
            this.txtTPPlayerAddID.TabIndex = 12;
            // 
            // txtTPAddPlayerAge
            // 
            this.txtTPAddPlayerAge.ForeColor = System.Drawing.Color.Red;
            this.txtTPAddPlayerAge.Location = new System.Drawing.Point(153, 158);
            this.txtTPAddPlayerAge.Name = "txtTPAddPlayerAge";
            this.txtTPAddPlayerAge.Size = new System.Drawing.Size(181, 20);
            this.txtTPAddPlayerAge.TabIndex = 8;
            // 
            // txtTPAddPlayerSurname
            // 
            this.txtTPAddPlayerSurname.ForeColor = System.Drawing.Color.Red;
            this.txtTPAddPlayerSurname.Location = new System.Drawing.Point(153, 119);
            this.txtTPAddPlayerSurname.Name = "txtTPAddPlayerSurname";
            this.txtTPAddPlayerSurname.Size = new System.Drawing.Size(181, 20);
            this.txtTPAddPlayerSurname.TabIndex = 7;
            // 
            // txtTPAddPlayerForename
            // 
            this.txtTPAddPlayerForename.ForeColor = System.Drawing.Color.Red;
            this.txtTPAddPlayerForename.Location = new System.Drawing.Point(153, 73);
            this.txtTPAddPlayerForename.Name = "txtTPAddPlayerForename";
            this.txtTPAddPlayerForename.Size = new System.Drawing.Size(181, 20);
            this.txtTPAddPlayerForename.TabIndex = 6;
            // 
            // lblTPPlayerTeamID
            // 
            this.lblTPPlayerTeamID.AutoSize = true;
            this.lblTPPlayerTeamID.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPPlayerTeamID.ForeColor = System.Drawing.Color.White;
            this.lblTPPlayerTeamID.Location = new System.Drawing.Point(102, 201);
            this.lblTPPlayerTeamID.Name = "lblTPPlayerTeamID";
            this.lblTPPlayerTeamID.Size = new System.Drawing.Size(49, 19);
            this.lblTPPlayerTeamID.TabIndex = 13;
            this.lblTPPlayerTeamID.Text = "Team:";
            // 
            // btnTPPlayerAddFinalise
            // 
            this.btnTPPlayerAddFinalise.BackColor = System.Drawing.Color.White;
            this.btnTPPlayerAddFinalise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTPPlayerAddFinalise.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTPPlayerAddFinalise.FlatAppearance.BorderSize = 10;
            this.btnTPPlayerAddFinalise.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPPlayerAddFinalise.ForeColor = System.Drawing.Color.Blue;
            this.btnTPPlayerAddFinalise.Location = new System.Drawing.Point(495, 242);
            this.btnTPPlayerAddFinalise.Name = "btnTPPlayerAddFinalise";
            this.btnTPPlayerAddFinalise.Size = new System.Drawing.Size(173, 44);
            this.btnTPPlayerAddFinalise.TabIndex = 11;
            this.btnTPPlayerAddFinalise.Text = "Finalise";
            this.btnTPPlayerAddFinalise.UseVisualStyleBackColor = false;
            this.btnTPPlayerAddFinalise.Click += new System.EventHandler(this.btnTPPlayerAddFinalise_Click);
            // 
            // btnTPPlayerAddCancel
            // 
            this.btnTPPlayerAddCancel.BackColor = System.Drawing.Color.White;
            this.btnTPPlayerAddCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTPPlayerAddCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTPPlayerAddCancel.FlatAppearance.BorderSize = 10;
            this.btnTPPlayerAddCancel.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPPlayerAddCancel.ForeColor = System.Drawing.Color.Blue;
            this.btnTPPlayerAddCancel.Location = new System.Drawing.Point(416, 242);
            this.btnTPPlayerAddCancel.Name = "btnTPPlayerAddCancel";
            this.btnTPPlayerAddCancel.Size = new System.Drawing.Size(73, 44);
            this.btnTPPlayerAddCancel.TabIndex = 10;
            this.btnTPPlayerAddCancel.Text = "Cancel";
            this.btnTPPlayerAddCancel.UseVisualStyleBackColor = false;
            // 
            // lblTPAddPlayerAge
            // 
            this.lblTPAddPlayerAge.AutoSize = true;
            this.lblTPAddPlayerAge.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPAddPlayerAge.ForeColor = System.Drawing.Color.White;
            this.lblTPAddPlayerAge.Location = new System.Drawing.Point(61, 159);
            this.lblTPAddPlayerAge.Name = "lblTPAddPlayerAge";
            this.lblTPAddPlayerAge.Size = new System.Drawing.Size(86, 19);
            this.lblTPAddPlayerAge.TabIndex = 5;
            this.lblTPAddPlayerAge.Text = "Player Age:";
            // 
            // lblTPAddPlayerSurname
            // 
            this.lblTPAddPlayerSurname.AutoSize = true;
            this.lblTPAddPlayerSurname.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPAddPlayerSurname.ForeColor = System.Drawing.Color.White;
            this.lblTPAddPlayerSurname.Location = new System.Drawing.Point(27, 118);
            this.lblTPAddPlayerSurname.Name = "lblTPAddPlayerSurname";
            this.lblTPAddPlayerSurname.Size = new System.Drawing.Size(120, 19);
            this.lblTPAddPlayerSurname.TabIndex = 4;
            this.lblTPAddPlayerSurname.Text = "Player Surname:";
            // 
            // lblTPAddPlayerForename
            // 
            this.lblTPAddPlayerForename.AutoSize = true;
            this.lblTPAddPlayerForename.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPAddPlayerForename.ForeColor = System.Drawing.Color.White;
            this.lblTPAddPlayerForename.Location = new System.Drawing.Point(19, 74);
            this.lblTPAddPlayerForename.Name = "lblTPAddPlayerForename";
            this.lblTPAddPlayerForename.Size = new System.Drawing.Size(128, 19);
            this.lblTPAddPlayerForename.TabIndex = 3;
            this.lblTPAddPlayerForename.Text = "Player Forename:";
            // 
            // lblTPAddPlayerID2
            // 
            this.lblTPAddPlayerID2.AutoSize = true;
            this.lblTPAddPlayerID2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPAddPlayerID2.ForeColor = System.Drawing.Color.White;
            this.lblTPAddPlayerID2.Location = new System.Drawing.Point(153, 34);
            this.lblTPAddPlayerID2.Name = "lblTPAddPlayerID2";
            this.lblTPAddPlayerID2.Size = new System.Drawing.Size(0, 19);
            this.lblTPAddPlayerID2.TabIndex = 2;
            // 
            // lblTPAddPlayerID
            // 
            this.lblTPAddPlayerID.AutoSize = true;
            this.lblTPAddPlayerID.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPAddPlayerID.ForeColor = System.Drawing.Color.White;
            this.lblTPAddPlayerID.Location = new System.Drawing.Point(74, 34);
            this.lblTPAddPlayerID.Name = "lblTPAddPlayerID";
            this.lblTPAddPlayerID.Size = new System.Drawing.Size(73, 19);
            this.lblTPAddPlayerID.TabIndex = 1;
            this.lblTPAddPlayerID.Text = "Player ID:";
            // 
            // tpPlayerManagementEdit
            // 
            this.tpPlayerManagementEdit.Controls.Add(this.txtTPPlayerEditID);
            this.tpPlayerManagementEdit.Controls.Add(this.txtTPPlayerEditTeam);
            this.tpPlayerManagementEdit.Controls.Add(this.lblTPPlayerEditTeam);
            this.tpPlayerManagementEdit.Controls.Add(this.btnTPPlayerEditFinalise);
            this.tpPlayerManagementEdit.Controls.Add(this.btnTPPlayerEditCancel);
            this.tpPlayerManagementEdit.Controls.Add(this.txtTPEditPlayerAge);
            this.tpPlayerManagementEdit.Controls.Add(this.txtTPEditPlayerSurname);
            this.tpPlayerManagementEdit.Controls.Add(this.txtTPEditPlayerForename);
            this.tpPlayerManagementEdit.Controls.Add(this.lblTPEditPlayerAge);
            this.tpPlayerManagementEdit.Controls.Add(this.lblTPEditPlayerSurname);
            this.tpPlayerManagementEdit.Controls.Add(this.lblTPEditPlayerForename);
            this.tpPlayerManagementEdit.Controls.Add(this.lblTPEditPlayerID);
            this.tpPlayerManagementEdit.Location = new System.Drawing.Point(4, 25);
            this.tpPlayerManagementEdit.Name = "tpPlayerManagementEdit";
            this.tpPlayerManagementEdit.Size = new System.Drawing.Size(692, 289);
            this.tpPlayerManagementEdit.TabIndex = 2;
            this.tpPlayerManagementEdit.Text = "Edit";
            this.tpPlayerManagementEdit.UseVisualStyleBackColor = true;
            // 
            // txtTPPlayerEditID
            // 
            this.txtTPPlayerEditID.Enabled = false;
            this.txtTPPlayerEditID.Location = new System.Drawing.Point(147, 21);
            this.txtTPPlayerEditID.Name = "txtTPPlayerEditID";
            this.txtTPPlayerEditID.Size = new System.Drawing.Size(181, 20);
            this.txtTPPlayerEditID.TabIndex = 24;
            // 
            // txtTPPlayerEditTeam
            // 
            this.txtTPPlayerEditTeam.Location = new System.Drawing.Point(147, 206);
            this.txtTPPlayerEditTeam.Name = "txtTPPlayerEditTeam";
            this.txtTPPlayerEditTeam.Size = new System.Drawing.Size(181, 20);
            this.txtTPPlayerEditTeam.TabIndex = 23;
            // 
            // lblTPPlayerEditTeam
            // 
            this.lblTPPlayerEditTeam.AutoSize = true;
            this.lblTPPlayerEditTeam.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPPlayerEditTeam.Location = new System.Drawing.Point(92, 207);
            this.lblTPPlayerEditTeam.Name = "lblTPPlayerEditTeam";
            this.lblTPPlayerEditTeam.Size = new System.Drawing.Size(49, 19);
            this.lblTPPlayerEditTeam.TabIndex = 22;
            this.lblTPPlayerEditTeam.Text = "Team:";
            // 
            // btnTPPlayerEditFinalise
            // 
            this.btnTPPlayerEditFinalise.BackColor = System.Drawing.Color.White;
            this.btnTPPlayerEditFinalise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTPPlayerEditFinalise.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTPPlayerEditFinalise.FlatAppearance.BorderSize = 10;
            this.btnTPPlayerEditFinalise.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPPlayerEditFinalise.ForeColor = System.Drawing.Color.Lime;
            this.btnTPPlayerEditFinalise.Location = new System.Drawing.Point(498, 245);
            this.btnTPPlayerEditFinalise.Name = "btnTPPlayerEditFinalise";
            this.btnTPPlayerEditFinalise.Size = new System.Drawing.Size(173, 44);
            this.btnTPPlayerEditFinalise.TabIndex = 21;
            this.btnTPPlayerEditFinalise.Text = "Finalise";
            this.btnTPPlayerEditFinalise.UseVisualStyleBackColor = false;
            this.btnTPPlayerEditFinalise.Click += new System.EventHandler(this.btnTPPlayerEditFinalise_Click);
            // 
            // btnTPPlayerEditCancel
            // 
            this.btnTPPlayerEditCancel.BackColor = System.Drawing.Color.White;
            this.btnTPPlayerEditCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTPPlayerEditCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTPPlayerEditCancel.FlatAppearance.BorderSize = 10;
            this.btnTPPlayerEditCancel.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPPlayerEditCancel.ForeColor = System.Drawing.Color.Red;
            this.btnTPPlayerEditCancel.Location = new System.Drawing.Point(419, 245);
            this.btnTPPlayerEditCancel.Name = "btnTPPlayerEditCancel";
            this.btnTPPlayerEditCancel.Size = new System.Drawing.Size(73, 44);
            this.btnTPPlayerEditCancel.TabIndex = 20;
            this.btnTPPlayerEditCancel.Text = "Cancel";
            this.btnTPPlayerEditCancel.UseVisualStyleBackColor = false;
            // 
            // txtTPEditPlayerAge
            // 
            this.txtTPEditPlayerAge.Location = new System.Drawing.Point(147, 156);
            this.txtTPEditPlayerAge.Name = "txtTPEditPlayerAge";
            this.txtTPEditPlayerAge.Size = new System.Drawing.Size(181, 20);
            this.txtTPEditPlayerAge.TabIndex = 19;
            // 
            // txtTPEditPlayerSurname
            // 
            this.txtTPEditPlayerSurname.Location = new System.Drawing.Point(147, 105);
            this.txtTPEditPlayerSurname.Name = "txtTPEditPlayerSurname";
            this.txtTPEditPlayerSurname.Size = new System.Drawing.Size(181, 20);
            this.txtTPEditPlayerSurname.TabIndex = 18;
            // 
            // txtTPEditPlayerForename
            // 
            this.txtTPEditPlayerForename.Location = new System.Drawing.Point(147, 59);
            this.txtTPEditPlayerForename.Name = "txtTPEditPlayerForename";
            this.txtTPEditPlayerForename.Size = new System.Drawing.Size(181, 20);
            this.txtTPEditPlayerForename.TabIndex = 17;
            // 
            // lblTPEditPlayerAge
            // 
            this.lblTPEditPlayerAge.AutoSize = true;
            this.lblTPEditPlayerAge.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPEditPlayerAge.Location = new System.Drawing.Point(55, 155);
            this.lblTPEditPlayerAge.Name = "lblTPEditPlayerAge";
            this.lblTPEditPlayerAge.Size = new System.Drawing.Size(86, 19);
            this.lblTPEditPlayerAge.TabIndex = 16;
            this.lblTPEditPlayerAge.Text = "Player Age:";
            // 
            // lblTPEditPlayerSurname
            // 
            this.lblTPEditPlayerSurname.AutoSize = true;
            this.lblTPEditPlayerSurname.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPEditPlayerSurname.Location = new System.Drawing.Point(21, 104);
            this.lblTPEditPlayerSurname.Name = "lblTPEditPlayerSurname";
            this.lblTPEditPlayerSurname.Size = new System.Drawing.Size(120, 19);
            this.lblTPEditPlayerSurname.TabIndex = 15;
            this.lblTPEditPlayerSurname.Text = "Player Surname:";
            // 
            // lblTPEditPlayerForename
            // 
            this.lblTPEditPlayerForename.AutoSize = true;
            this.lblTPEditPlayerForename.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPEditPlayerForename.Location = new System.Drawing.Point(13, 60);
            this.lblTPEditPlayerForename.Name = "lblTPEditPlayerForename";
            this.lblTPEditPlayerForename.Size = new System.Drawing.Size(128, 19);
            this.lblTPEditPlayerForename.TabIndex = 14;
            this.lblTPEditPlayerForename.Text = "Player Forename:";
            // 
            // lblTPEditPlayerID
            // 
            this.lblTPEditPlayerID.AutoSize = true;
            this.lblTPEditPlayerID.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPEditPlayerID.Location = new System.Drawing.Point(68, 20);
            this.lblTPEditPlayerID.Name = "lblTPEditPlayerID";
            this.lblTPEditPlayerID.Size = new System.Drawing.Size(73, 19);
            this.lblTPEditPlayerID.TabIndex = 12;
            this.lblTPEditPlayerID.Text = "Player ID:";
            // 
            // btnPlayerMenuBack
            // 
            this.btnPlayerMenuBack.BackColor = System.Drawing.Color.White;
            this.btnPlayerMenuBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayerMenuBack.BackgroundImage")));
            this.btnPlayerMenuBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlayerMenuBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayerMenuBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPlayerMenuBack.FlatAppearance.BorderSize = 10;
            this.btnPlayerMenuBack.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerMenuBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPlayerMenuBack.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPlayerMenuBack.Location = new System.Drawing.Point(707, 11);
            this.btnPlayerMenuBack.Name = "btnPlayerMenuBack";
            this.btnPlayerMenuBack.Size = new System.Drawing.Size(58, 34);
            this.btnPlayerMenuBack.TabIndex = 12;
            this.btnPlayerMenuBack.UseVisualStyleBackColor = false;
            // 
            // lblPlayerMenu
            // 
            this.lblPlayerMenu.AutoSize = true;
            this.lblPlayerMenu.Font = new System.Drawing.Font("Franklin Gothic Medium", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerMenu.ForeColor = System.Drawing.Color.MintCream;
            this.lblPlayerMenu.Location = new System.Drawing.Point(24, 8);
            this.lblPlayerMenu.Name = "lblPlayerMenu";
            this.lblPlayerMenu.Size = new System.Drawing.Size(691, 81);
            this.lblPlayerMenu.TabIndex = 11;
            this.lblPlayerMenu.Text = "PLAYER MANAGEMENT";
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
            // pLAYERBindingSource
            // 
            this.pLAYERBindingSource.DataMember = "PLAYER";
            this.pLAYERBindingSource.DataSource = this.cIFDataSet;
            // 
            // pLAYERTableAdapter
            // 
            this.pLAYERTableAdapter.ClearBeforeFill = true;
            // 
            // playerIDDataGridViewTextBoxColumn
            // 
            this.playerIDDataGridViewTextBoxColumn.DataPropertyName = "PlayerID";
            this.playerIDDataGridViewTextBoxColumn.HeaderText = "PlayerID";
            this.playerIDDataGridViewTextBoxColumn.Name = "playerIDDataGridViewTextBoxColumn";
            // 
            // playerForenameDataGridViewTextBoxColumn
            // 
            this.playerForenameDataGridViewTextBoxColumn.DataPropertyName = "PlayerForename";
            this.playerForenameDataGridViewTextBoxColumn.HeaderText = "PlayerForename";
            this.playerForenameDataGridViewTextBoxColumn.Name = "playerForenameDataGridViewTextBoxColumn";
            // 
            // playerSurnameDataGridViewTextBoxColumn
            // 
            this.playerSurnameDataGridViewTextBoxColumn.DataPropertyName = "PlayerSurname";
            this.playerSurnameDataGridViewTextBoxColumn.HeaderText = "PlayerSurname";
            this.playerSurnameDataGridViewTextBoxColumn.Name = "playerSurnameDataGridViewTextBoxColumn";
            // 
            // playerAgeDataGridViewTextBoxColumn
            // 
            this.playerAgeDataGridViewTextBoxColumn.DataPropertyName = "PlayerAge";
            this.playerAgeDataGridViewTextBoxColumn.HeaderText = "PlayerAge";
            this.playerAgeDataGridViewTextBoxColumn.Name = "playerAgeDataGridViewTextBoxColumn";
            // 
            // playerStatusDataGridViewTextBoxColumn
            // 
            this.playerStatusDataGridViewTextBoxColumn.DataPropertyName = "PlayerStatus";
            this.playerStatusDataGridViewTextBoxColumn.HeaderText = "PlayerStatus";
            this.playerStatusDataGridViewTextBoxColumn.Name = "playerStatusDataGridViewTextBoxColumn";
            // 
            // PlayerStatus
            // 
            this.PlayerStatus.DataPropertyName = "PlayerStatus";
            this.PlayerStatus.HeaderText = "Status";
            this.PlayerStatus.Name = "PlayerStatus";
            // 
            // teamIDDataGridViewTextBoxColumn
            // 
            this.teamIDDataGridViewTextBoxColumn.DataPropertyName = "TeamID";
            this.teamIDDataGridViewTextBoxColumn.HeaderText = "TeamID";
            this.teamIDDataGridViewTextBoxColumn.Name = "teamIDDataGridViewTextBoxColumn";
            // 
            // ManagePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(788, 415);
            this.Controls.Add(this.btnTPTeamBackToViewTab);
            this.Controls.Add(this.tcPlayerManagement);
            this.Controls.Add(this.btnPlayerMenuBack);
            this.Controls.Add(this.lblPlayerMenu);
            this.Name = "ManagePlayers";
            this.Text = "ManagePlayers";
            this.Load += new System.EventHandler(this.ManagePlayers_Load);
            this.tcPlayerManagement.ResumeLayout(false);
            this.tpPlayerManagementView.ResumeLayout(false);
            this.tpPlayerManagementView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPlayerManagementViewPlayers)).EndInit();
            this.tpPlayerManagementAdd.ResumeLayout(false);
            this.tpPlayerManagementAdd.PerformLayout();
            this.tpPlayerManagementEdit.ResumeLayout(false);
            this.tpPlayerManagementEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTPTeamBackToViewTab;
        private System.Windows.Forms.TabControl tcPlayerManagement;
        private System.Windows.Forms.TabPage tpPlayerManagementView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnTPPlayerViewDelete;
        private System.Windows.Forms.Button btnTPPlayerViewEdit;
        private System.Windows.Forms.Button btnTPPlayerViewAdd;
        private System.Windows.Forms.DataGridView DGVPlayerManagementViewPlayers;
        private System.Windows.Forms.TabPage tpPlayerManagementAdd;
        private System.Windows.Forms.TextBox txtTPPlayerAddTeam;
        private System.Windows.Forms.TextBox txtTPPlayerAddID;
        private System.Windows.Forms.TextBox txtTPAddPlayerAge;
        private System.Windows.Forms.TextBox txtTPAddPlayerSurname;
        private System.Windows.Forms.TextBox txtTPAddPlayerForename;
        private System.Windows.Forms.Label lblTPPlayerTeamID;
        private System.Windows.Forms.Button btnTPPlayerAddFinalise;
        private System.Windows.Forms.Button btnTPPlayerAddCancel;
        private System.Windows.Forms.Label lblTPAddPlayerAge;
        private System.Windows.Forms.Label lblTPAddPlayerSurname;
        private System.Windows.Forms.Label lblTPAddPlayerForename;
        private System.Windows.Forms.Label lblTPAddPlayerID2;
        private System.Windows.Forms.Label lblTPAddPlayerID;
        private System.Windows.Forms.TabPage tpPlayerManagementEdit;
        private System.Windows.Forms.TextBox txtTPPlayerEditID;
        private System.Windows.Forms.TextBox txtTPPlayerEditTeam;
        private System.Windows.Forms.Label lblTPPlayerEditTeam;
        private System.Windows.Forms.Button btnTPPlayerEditFinalise;
        private System.Windows.Forms.Button btnTPPlayerEditCancel;
        private System.Windows.Forms.TextBox txtTPEditPlayerAge;
        private System.Windows.Forms.TextBox txtTPEditPlayerSurname;
        private System.Windows.Forms.TextBox txtTPEditPlayerForename;
        private System.Windows.Forms.Label lblTPEditPlayerAge;
        private System.Windows.Forms.Label lblTPEditPlayerSurname;
        private System.Windows.Forms.Label lblTPEditPlayerForename;
        private System.Windows.Forms.Label lblTPEditPlayerID;
        private System.Windows.Forms.Button btnPlayerMenuBack;
        private System.Windows.Forms.Label lblPlayerMenu;
        private System.Windows.Forms.ErrorProvider errP;
        private CIFDataSet cIFDataSet;
        private System.Windows.Forms.BindingSource pLAYERBindingSource;
        private CIFDataSetTableAdapters.PLAYERTableAdapter pLAYERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerForenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIDDataGridViewTextBoxColumn;
    }
}