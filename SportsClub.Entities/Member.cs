using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SportsClub.Entities
{
    // sjabloon voor Members table in db
    public class Member
    {
        // memberid --> primary key voor databank
        // [Key] om aan te duiden dat dit de PK is
        [Key]
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // property die link legt met Activity
        // een member kan zich inschrijven voor meerdere activities --> list
        public List<Activity> Activities { get; set; }

        // constructor om te zorgen dat Members altijd met een
        // voornaam en achternaam aangemaakt worden
        public Member(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            // lege list initialiseren
            Activities = new List<Activity>();
        }

        public Member()
        {
            
        }
    }
}
