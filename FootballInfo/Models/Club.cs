using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballInfo.Models
{
    public class Club
    {
        private ICollection<Player> _players;

        public Club()
        {
            _players = new List<Player>();
        }

        public int ClubId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Player> Players
        {
            get { return _players; }
            set { _players = value; }
        }
    }
}