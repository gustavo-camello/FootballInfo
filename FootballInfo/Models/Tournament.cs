using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballInfo.Models
{
    public class Tournament
    {
        private ICollection<Club> _clubs;

        public Tournament()
        {
            _clubs = new List<Club>();
        }

        public int TournamentId { get; set; }
        public string Name { get; set; }
        public DateTime TournamentStart { get; set; }

        public virtual ICollection<Club> Clubs
        {
            get { return _clubs; }
            set { _clubs = value; }
        }
    }
}