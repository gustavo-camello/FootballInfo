using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballInfo.Models
{
    public class Player
    {
        private ICollection<Club> _clubs;

        public Player()
        {
            _clubs = new List<Club>();
        }

        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
     

        public virtual ICollection<Club> Clubs
        {
            get { return _clubs; }
            set { _clubs = value; }
        }
    }
}