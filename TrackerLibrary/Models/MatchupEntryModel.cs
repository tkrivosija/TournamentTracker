namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score for this team.
        /// </summary>
        public int TeamCompetingId { get; set; }
        public int ParentMatchupId { get; set; }
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup this team came from 
        /// as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}