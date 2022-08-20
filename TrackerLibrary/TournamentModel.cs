using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represnets the name of a Tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the Entry Fee payed by the participants.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents a List of Teams entered in a given tournoment.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents a List of Prizes to be payed 
        /// out to the winners of a given tournoment.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents a list of rounds, which consists of a list of Matchups,
        /// which in turn makes up the tournoments bracket. 
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
