using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the numerical standing of a given team.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name (or nickname) of a given standing.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the monetary value of the prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of winnings to be payed out to winners.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
