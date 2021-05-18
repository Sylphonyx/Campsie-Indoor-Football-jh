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
    public partial class ManageTeams : Form
    {
        SqlDataAdapter daTeam;
        DataSet dsCIF = new DataSet();
        SqlCommandBuilder cmdBTeam;
        DataRow drTeam;
        String connStr, sqlTeam;
        bool teamSelected = false;
        int teamIDSelected = 0, selectedTab = 0;

     

        public ManageTeams()
        {
            InitializeComponent();
        }

        private void ManageTeams_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cIFDataSet.TEAM' table. You can move, or remove it, as needed.
            this.tEAMTableAdapter.Fill(this.cIFDataSet.TEAM);
            connStr = Properties.Resources.cString;
            sqlTeam = @"select * from Team";
            daTeam = new SqlDataAdapter(sqlTeam, connStr);
            cmdBTeam = new SqlCommandBuilder(daTeam);
            daTeam.FillSchema(dsCIF, SchemaType.Source, "Team");
            daTeam.Fill(dsCIF, "Team");
            DGVTeamManage.DataSource = dsCIF.Tables["Team"];
            DGVTeamManage.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

    
        private void getNumber(int noRows)
        {
            drTeam = dsCIF.Tables["Team"].Rows[noRows - 1];
            txtTPAddTeamID.Text = (int.Parse(drTeam["TeamID"].ToString()) + 1).ToString();
        }

        private void btnTPTeamViewEdit_Click(object sender, EventArgs e)
        {
            //NAVIGATION TO EDIT TAB
            tcTeamManagement.SelectedIndex = 2;
            teamIDSelected = Convert.ToInt32(DGVTeamManage.SelectedRows[0].Cells[0].Value);
            txtTPEditTeamID.Text = teamIDSelected.ToString();
            drTeam = dsCIF.Tables["Team"].Rows.Find(txtTPEditTeamID.Text);
            txtTPEditTeamName.Text = drTeam["TeamName"].ToString();
        }

        private void btnTPTeamViewDelete_Click(object sender, EventArgs e)
        {

            //NAVIGATION TO DELETE TAB
            //if(lstCustomers.SelectedIndices.Count == 0)
            if (DGVTeamManage.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a team from the list.", "Select Team");
            }
            else
            {
                drTeam =
                    dsCIF.Tables["Team"].Rows.Find(DGVTeamManage.SelectedRows[0].Cells[0].Value);

                string tempName = drTeam["TeamName"].ToString();

                if (MessageBox.Show("Are you sure you want to delete " + tempName + " details?", "Delete Team", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drTeam.Delete();
                    daTeam.Update(dsCIF, "Team");
                }
            }
        }

        private void btnTPAddCancel_Click(object sender, EventArgs e)
        {
            //CANCELLING THE ACTIONS ON THE ADD TAB
            txtTPAddTeamName.Clear();
            MessageBox.Show("Action Cancelled");
            tcTeamManagement.SelectedIndex = 0;
        }

        private void btnTPTeamEditCancel_Click(object sender, EventArgs e)
        {
            //CANCELLING THE ACTIONS ON THE EDIT TAB
            String CancelledTeamName = txtTPEditTeamName.Text.Trim();
            MessageBox.Show("Changes Reverted");
            tcTeamManagement.SelectedIndex = 0;
        }

        private void btnTPTeamEditFinalise_Click(object sender, EventArgs e)
        {
            MyTeams MyTeam = new MyTeams();
            bool ok = true;
            errP.Clear();
            try
            {
                MyTeam.TeamID = Convert.ToInt32(txtTPEditTeamID.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtTPEditTeamID, MyEx.toString());
            }

            try
            {
                MyTeam.TeamName = txtTPEditTeamName.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtTPEditTeamName, MyEx.toString());
            }

            try
            {
                if (ok)
                {
                    drTeam.BeginEdit();

                    drTeam["TeamID"] = MyTeam.TeamID;
                    drTeam["TeamName"] = MyTeam.TeamName;


                    // dsCIF.Tables["Team"].Rows.Add(drTeam);

                    drTeam.EndEdit();

                    daTeam.Update(dsCIF, "Team");


                    MessageBox.Show("Team Details Updated", "Team");



                    tcTeamManagement.SelectedIndex = 0;
                    txtTPEditTeamName.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!",
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void btnTPEditEdit_Click(object sender, EventArgs e)
        {
            txtTPEditTeamName.Enabled = true; ;
        }

        private void btnTPTeamViewAdd_Click(object sender, EventArgs e)
        {
            //NAVIGATION TO ADD TAB
            tcTeamManagement.SelectedIndex = 1;
            getNumber(dsCIF.Tables["Team"].Rows.Count);
        }


        private void btnTPAddFinalise_Click(object sender, EventArgs e)
        {
            //ADD BUTTON

            MyTeams team = new MyTeams();
            bool validated = true;
            errP.Clear();

            //TEAM ID
            try
            {
                team.TeamID = Convert.ToInt32(txtTPAddTeamID.Text.Trim());
            }
            catch (MyException MyEx)
            {
                validated = false;
                errP.SetError(txtTPAddTeamID, MyEx.toString());
            }

            //TEAM NAME
            try
            {
                team.TeamName = txtTPAddTeamName.Text.Trim();
            }
            catch (MyException MyEx)
            {
                validated = false;
                errP.SetError(txtTPAddTeamName, MyEx.toString());
            }

            //ADDING TO TEAM DATABASE

            try
            {
                if (validated == true)
                {


                    drTeam = dsCIF.Tables["Team"].NewRow();

                    drTeam["TeamID"] = team.TeamID;
                    drTeam["TeamName"] = team.TeamName;
                    dsCIF.Tables["Team"].Rows.Add(drTeam);
                    daTeam.Update(dsCIF, "Team");
                    
                    MessageBox.Show("Team has been added to the system");

                    txtTPAddTeamName.Clear();
                    tcTeamManagement.SelectedIndex = 0;
                }


                if (MessageBox.Show("Do you wish to add another Team?", "Add Team", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    txtTPAddTeamName.Clear();
                    getNumber(dsCIF.Tables["Team"].Rows.Count);
                }
                else
                    tcTeamManagement.SelectedIndex = 0;
            }
            catch (Exception MyEx)
            {
                MessageBox.Show("" + MyEx.TargetSite + "" + MyEx.Message, "Error!",
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }

        }
    }










    }

