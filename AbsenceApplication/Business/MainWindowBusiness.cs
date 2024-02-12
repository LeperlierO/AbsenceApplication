using AbsenceApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceApplication.Business
{
    public class MainWindowBusiness
    {
        public string Title { get; set; }
        public List<Etudiant> Students { get; set; }

        public MainWindowBusiness()
        {
            Title = "Absence application";
            Students = new List<Etudiant>
            {
                new Etudiant("Le boss", "Junior", "111", "222", new DateTime(1999,12,09)),
                new Etudiant("La boss", "Henoux", "333", "444", new DateTime(1999,07,15)),
                new Etudiant("Le chignon", "Soeurette", "555", "666", new DateTime(1996,07,06)),
                new Etudiant("La madre", "André", "777", "888", new DateTime(1961,05,25)),
                new Etudiant("Le chef", "Domi", "999", "123", new DateTime(1698,04,01))
            };
        }
    }
}
