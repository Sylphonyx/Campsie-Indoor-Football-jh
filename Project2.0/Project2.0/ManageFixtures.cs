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
    public partial class ManageFixtures : Form
    {
        SqlDataAdapter daTeam, daPlayer;
        DataSet dsCIF = new DataSet();
        SqlCommandBuilder cmdBTeam;
        String conn;
        public ManageFixtures()
        {
            InitializeComponent();
        }

        private void ManageFixtures_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'cIFDataSet.MATCHSTATS' table. You can move, or remove it, as needed.
            this.mATCHSTATSTableAdapter.Fill(this.cIFDataSet.MATCHSTATS);
            // TODO: This line of code loads data into the 'cIFDataSet.PITCH' table. You can move, or remove it, as needed.
            this.pITCHTableAdapter.Fill(this.cIFDataSet.PITCH);
            // TODO: This line of code loads data into the 'cIFDataSet.REFEREE' table. You can move, or remove it, as needed.
            this.rEFEREETableAdapter.Fill(this.cIFDataSet.REFEREE);
            // TODO: This line of code loads data into the 'cIFDataSet.TEAM' table. You can move, or remove it, as needed.
            this.tEAMTableAdapter.Fill(this.cIFDataSet.TEAM);

            String connStr = Properties.Resources.cString;
            String sqlPlayer = @"select * from Player";
            daPlayer = new SqlDataAdapter(sqlPlayer, connStr);
           SqlCommandBuilder cmdBPlayer = new SqlCommandBuilder(daPlayer);
            daPlayer.FillSchema(dsCIF, SchemaType.Source, "Player");
            daPlayer.Fill(dsCIF, "Player");


        }

        private void cmbTeam1_SelectedIndexChanged(object sender, EventArgs e)
        {

            String sqlPlayers = "Select PlayerID, PlayerForename, PlayerSurname, PlayerAge, PlayerStatus, (Playerforename +' '+Playersurname) as FullName from Player where TeamID = " +  cmbTeam1.SelectedValue;
            String connStr = Properties.Resources.cString;
            SqlDataAdapter daPlayer2 = new SqlDataAdapter(sqlPlayers, connStr);
            DataTable dtPlayers = new DataTable();
            daPlayer2.Fill(dtPlayers);

            lbTeam1Goal1.DataSource = dtPlayers;
            lbTeam1Goal1.ValueMember = "PlayerID";
            lbTeam1Goal1.DisplayMember = "FullName";


        }

        private void btnTeam1Save1_Click(object sender, EventArgs e)
        {
            
            //    btnTeam1Add.Enabled = true;
                btnTeam1Add.Visible = true;
                lblTeam1Scorer1.Enabled = false;
                txtTeam1Scorer1.Enabled = false;
                btnTeam1Save1.Visible = false;
                btnTeam1Edit.Visible = true;
                btnTeam1Edit.Enabled = true;
            
           
           

        }

        private void btnTeam1Edit_Click(object sender, EventArgs e)
        {
            btnTeam1Add.Enabled = false;
            btnTeam1Add.Visible = false;
            lblTeam1Scorer1.Enabled = true;
            txtTeam1Scorer1.Enabled = true;
            btnTeam1Save1.Visible = true;
            btnTeam1Edit.Visible = false;
            btnTeam1Edit.Enabled = true;
        }

        private void btnTeam1Add_Click(object sender, EventArgs e)
        {
            String forename, surname;
            DataRow drPlayer;
            drPlayer = dsCIF.Tables["Player"].Rows.Find("" + lbTeam1Goal1.SelectedValue);
            forename = drPlayer["PlayerForename"].ToString();
            surname = drPlayer["PlayerSurname"].ToString();
            lblTeam1Scorer1.Text = forename + " " + surname;

            
            btnTeam1Save1.Enabled = true;
            btnTeam1Save1.Visible = true;

            btnTeam1Add.Enabled = false;
            btnTeam1Add.Visible = false;
        }
    }
}
