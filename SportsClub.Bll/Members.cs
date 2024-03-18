using SportsClub.Dal;
using SportsClub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClub.Bll
{
    public static class Members
    {
        // CREATE
        public static bool Create(string firstName, string lastName)
        {
            // nieuwe member aanmaken met gegevens uit parameters
            Member m = new Member(firstName, lastName);
            // create methode uit dal uitvoeren
            bool createSuccessful = MemberDal.Create(m);
            // true of false als return geven
            return createSuccessful;
        }

        // READ ALL
        public static List<Member> Read()
        {
            // read methode uit Dal gebruiken
            List<Member> lstMembers = MemberDal.Read();
            return lstMembers;
        }

        // READ SINGLE
        public static Member Read(int id)
        {
            // member opzoeken met dal methode
            Member m = MemberDal.Read(id);

            // als member niet bestaat (null) dan blanco member aanmaken
            if (m == null)
            {
                m = new Member();
            }

            // member als return geven
            return m;
        }

        // UPDATE

        // DELETE
    }
}
