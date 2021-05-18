using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2._0
{
    class MyTeams
    {
        private int teamID;
        private String teamName;

        public MyTeams()
        {
            this.teamID = 0;
            this.teamName = "";
        }

        public MyTeams(int teamID, String teamName)
        {
            this.teamID = teamID;
            this.teamName = teamName;

        }

        public int TeamID
        {
            get { return teamID; }
            set { teamID = value; }
        }

        public string TeamName
        {
            get { return teamName; }
            set
            {
                //  if (MyValidation3.validLetter(value) == false)
                //  {
                //      throw new Exception("The Team Name Cannot Contains Numerals");
                //  }
                //else
                teamName = MyValidation3.firstLetterEachWordToUpper(value);
            }
        }

    }
}
