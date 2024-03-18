using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClub.Entities
{
    public class Activity
    {
        [Key]
        public int ActivityId { get; set; }
        public string Name { get; set; }
        public int MaxParticipants { get; set; }

        // link met member
        public List<Member> Members { get; set; }

        public Activity(string name, int maxParticipants)
        {
            Name = name;
            MaxParticipants = maxParticipants;
            // list initialiseren
            Members = new List<Member>();
        }

        public Activity()
        {
            
        }
    }
}
