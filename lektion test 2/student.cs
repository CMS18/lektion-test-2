using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lektion_test_2
{
    class Student
    {
        public string Efternamn { get; set; }
        public string Email { get; set; }
        public string Fornamn { get; set; }
        public string Telefon { get; set; }
        public string Personnummer { get; set; }

        public Student(string fornamn, string efternamn, string personnummer, string telefon, string email)
        {
            Fornamn = fornamn;
            Efternamn = efternamn;
            Personnummer = personnummer;
            Telefon = telefon;
            Email = email;
        }

        public List<string> KontrolleraVarden()
        {
            List<string> saknadeVarde = new List<string>();
            if (Fornamn == "" || Fornamn == null)
            {
                saknadeVarde.Add("Förnamn");
            }
            if (Efternamn == "" || Efternamn == null)
            {
                saknadeVarde.Add("Efternamn");
            }
            if (Personnummer == "" || Personnummer == null)
            {
                saknadeVarde.Add("Personnummer");
            }
            if (Telefon == "" || Telefon == null)
            {
                saknadeVarde.Add("Telefon");
            }
            if (Email == "" || Email == null)
            {
                saknadeVarde.Add("Email");
            }

            return saknadeVarde;

        }

        public string[,] HamtaBetyg()
        {
            string[,] kurserBetyg = new string[,] { { "Programmering C#", "G" }, { "ASP.NET C#", "VG" }, {"Frontend utveckling", "VG"} };
            return kurserBetyg;
        }
    }
    
}
