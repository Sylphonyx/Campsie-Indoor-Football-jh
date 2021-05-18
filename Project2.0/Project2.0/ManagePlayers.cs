using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2._0
{
    public partial class ManagePlayers : Form
    {

        SqlDataAdapter daPlayer;
        DataSet dsCIF = new DataSet();
        SqlCommandBuilder cmdBPlayer;
        DataRow drPlayer;
        String connStr, sqlPlayer;
        bool playerSelected = false;
        int playerIDSelected = 0, selectedTab = 0;

        

        public ManagePlayers()
        {
            InitializeComponent();
        }

        private void btnTPPlayerAddFinalise_Click(object sender, EventArgs e)
        {
            MyPlayers player = new MyPlayers();
            bool validated = true;
            errP.Clear();

            //VALIDATING FIELDS
            try
            {
                player.PlayerID = Convert.ToInt32(txtTPPlayerAddID.Text.Trim());
            }
            catch (MyException MyEx)
            {
                validated = false;
                errP.SetError(lblTPAddPlayerID2, MyEx.toString());
            }

            try
            {
                player.PlayerForename = txtTPAddPlayerForename.Text.Trim();
            }
            catch (MyException MyEx)
            {
                validated = false;
                errP.SetError(txtTPAddPlayerForename, MyEx.toString());
            }


            try
            {
                player.PlayerSurname = txtTPAddPlayerSurname.Text.Trim();
            }
            catch (MyException MyEx)
            {
                validated = false;
                errP.SetError(txtTPAddPlayerSurname, MyEx.toString());
            }

            try
            {
                player.PlayerAge = Convert.ToInt32(txtTPAddPlayerAge.Text.Trim());
            }
            catch (MyException MyEx)
            {
                validated = false;
                errP.SetError(txtTPAddPlayerAge, MyEx.toString());
            }


            try
            {
                player.TeamID = Convert.ToInt32(txtTPPlayerAddTeam.Text.Trim());
            }
            catch (MyException MyEx)
            {
                validated = false;
                errP.SetError(txtTPPlayerAddTeam, MyEx.toString());
            }

            player.PlayerStatus = "FIT";
            try
            {
                if (validated == true)
                {


                    drPlayer = dsCIF.Tables["Player"].NewRow();
                    MessageBox.Show("Help");
                    drPlayer["PlayerID"] = player.PlayerID;
                    drPlayer["PlayerForename"] = player.PlayerForename;
                    drPlayer["PlayerSurname"] = player.PlayerSurname;
                    drPlayer["PlayerAge"] = player.PlayerAge;
                    drPlayer["TeamID"] = player.TeamID;
                    drPlayer["PlayerStatus"] = player.PlayerStatus;
                    dsCIF.Tables["Player"].Rows.Add(drPlayer);
                    daPlayer.Update(dsCIF, "Player");
                    MessageBox.Show("Player has been added to the system");
                    txtTPAddPlayerForename.Clear();
                    txtTPAddPlayerSurname.Clear();
                    txtTPAddPlayerAge.Clear();
                    txtTPPlayerAddTeam.Clear();
                    tcPlayerManagement.SelectedIndex = 0;
                }


                if (MessageBox.Show("Do you wish to add another Player?", "Add Player", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    txtTPAddPlayerForename.Clear();
                    txtTPAddPlayerSurname.Clear();
                    txtTPAddPlayerAge.Clear();
                    txtTPPlayerAddTeam.Clear();
                    getNumber(dsCIF.Tables["Player"].Rows.Count);
                }
                else
                    tcPlayerManagement.SelectedIndex = 0;
            }
            catch (Exception MyEx)
            {
                MessageBox.Show("" + MyEx.TargetSite + "" + MyEx.Message, "Error!",
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }

        
    }

        private void ManagePlayers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cIFDataSet.PLAYER' table. You can move, or remove it, as needed.
            this.pLAYERTableAdapter.Fill(this.cIFDataSet.PLAYER);
            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = CIF; Integrated Security = true";
            sqlPlayer = @"select * from Player";
            daPlayer = new SqlDataAdapter(sqlPlayer, connStr);
            cmdBPlayer = new SqlCommandBuilder(daPlayer);
            daPlayer.FillSchema(dsCIF, SchemaType.Source, "Player");
            daPlayer.Fill(dsCIF, "Player");
            DGVPlayerManagementViewPlayers.DataSource = dsCIF.Tables["Player"];
            DGVPlayerManagementViewPlayers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnTPPlayerEditFinalise_Click(object sender, EventArgs e)
        {

            MyPlayers player = new MyPlayers();
            bool ok = true;
            errP.Clear();
            try
            {
                player.PlayerID = Convert.ToInt32(txtTPPlayerEditID.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtTPPlayerEditID, MyEx.toString());
            }

            try
            {
                player.PlayerForename = txtTPEditPlayerForename.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtTPEditPlayerForename, MyEx.toString());
            }


            try
            {
                player.PlayerSurname = txtTPEditPlayerSurname.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtTPEditPlayerSurname, MyEx.toString());
            }

            try
            {
                player.PlayerAge = Convert.ToInt32(txtTPEditPlayerAge.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtTPEditPlayerAge, MyEx.toString());
            }


            try
            {
                player.TeamID = Convert.ToInt32(txtTPPlayerEditTeam.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtTPPlayerEditTeam, MyEx.toString());
            }

            player.PlayerStatus = "FIT";
            try
            {
                if (ok)
                {
                    player.PlayerStatus = "FIT";
                    drPlayer.BeginEdit();

                    drPlayer["PlayerID"] = player.PlayerID;
                    drPlayer["PlayerForename"] = player.PlayerForename;
                    drPlayer["PlayerSurname"] = player.PlayerSurname;
                    drPlayer["PlayerAge"] = player.PlayerAge;
                    drPlayer["TeamID"] = player.TeamID;
                    drPlayer["PlayerStatus"] = player.PlayerStatus;
                    drPlayer.EndEdit();
                    daPlayer.Update(dsCIF, "Player");

                    MessageBox.Show("Player Details Updated", "Player");



                    tcPlayerManagement.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!",
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void btnTPPlayerViewDelete_Click(object sender, EventArgs e)
        {
            if (DGVPlayerManagementViewPlayers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a team from the list.", "Select Team");
            }
            else
            {
                drPlayer =
                    dsCIF.Tables["Player"].Rows.Find(DGVPlayerManagementViewPlayers.SelectedRows[0].Cells[0].Value);

                string tempName = drPlayer["PlayerForename"].ToString() + drPlayer["PlayerSurname"].ToString();

                if (MessageBox.Show("Are you sure you want to delete " + tempName + " details?", "Delete Player", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drPlayer.Delete();
                    daPlayer.Update(dsCIF, "Player");
                }
            }
        }

        private void btnTPPlayerViewAdd_Click(object sender, EventArgs e)
        {
            getNumber(dsCIF.Tables["Player"].Rows.Count);
            tcPlayerManagement.SelectedIndex = 1;
        }

        private void btnTPPlayerViewEdit_Click(object sender, EventArgs e)
        {
            tcPlayerManagement.SelectedIndex = 2;

            playerIDSelected = Convert.ToInt32(DGVPlayerManagementViewPlayers.SelectedRows[0].Cells[0].Value);

            txtTPPlayerEditID.Text = "" + playerIDSelected;


            drPlayer = dsCIF.Tables["Player"].Rows.Find(txtTPPlayerEditID.Text);


            txtTPEditPlayerForename.Text = drPlayer["PlayerForename"].ToString();
            txtTPEditPlayerSurname.Text = drPlayer["PlayerSurname"].ToString();
            txtTPEditPlayerAge.Text = drPlayer["PlayerAge"].ToString();
            txtTPPlayerEditTeam.Text = drPlayer["TeamID"].ToString();
        }

        private void btnTPTeamBackToViewTab_Click(object sender, EventArgs e)
        {
            tcPlayerManagement.SelectedIndex = 0;
        }

        private void getNumber(int noRows)
        {
            drPlayer = dsCIF.Tables["Player"].Rows[noRows - 1];
            txtTPPlayerAddID.Text = (int.Parse(drPlayer["PlayerID"].ToString()) + 1).ToString();
        }
    }
}
