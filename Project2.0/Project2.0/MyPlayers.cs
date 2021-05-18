using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2._0
{
    class MyPlayers
    {

        private int playerID, playerAge, teamID;
        private String playerForename, playerSurname, playerStatus;

        public MyPlayers()
        {
            this.playerID = 0;
            this.playerForename = "";
            this.playerSurname = "";
            this.playerAge = 0;
            this.playerStatus = "";
            this.teamID = 0;
        }

        public MyPlayers(int playerID, String playerForename, String playerSurname, int playerAge, String playerStatus, int teamID)
        {
            this.playerID = playerID;
            this.playerForename = playerForename;
            this.playerSurname = playerSurname;
            this.playerAge = playerAge;
            this.playerStatus = "";
            this.teamID = 0;
        }

        public int PlayerID
        {
            get { return playerID; }
            set { playerID = value; }
        }

        public String PlayerForename
        {

            get { return playerForename; }

            set
            {
                if (MyValidation3.validForename(value) == false)
                {
                    throw new Exception("Please Enter A Valid Forename");
                }
                else
                    playerForename = MyValidation3.firstLetterEachWordToUpper(value);
            }

        }

        public String PlayerSurname
        {

            get { return playerSurname; }

            set
            {
                if (MyValidation3.validSurname(value) == false)
                {
                    throw new Exception("Please Enter A Valid Surname");
                }
                else
                    playerSurname = MyValidation3.firstLetterEachWordToUpper(value);
            }

        }

        public int PlayerAge
        {

            get { return playerAge; }

            set
            {
                if (value < 16)
                {
                    throw new Exception("Players Under 16 Cannot Participate In The League");
                }
                else
                    playerAge = value;

            }

        }
        public String PlayerStatus
        {

            get { return playerStatus; }

            set
            {


                playerStatus = MyValidation3.firstLetterEachWordToUpper(value);

            }

        }
        public int TeamID
        {

            get { return teamID; }

            set
            {


                teamID = value;

            }

        }

    }
}
