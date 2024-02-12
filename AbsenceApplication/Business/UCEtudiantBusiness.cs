using AbsenceApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceApplication.Business
{
    public class UCEtudiantBusiness
    {
        public List<Etudiant> Students { get; set; }

        public UCEtudiantBusiness()
        {
            Students = new List<Etudiant>
            {
                new Etudiant("Le boss", "Junior", "111", "222", new DateTime(1999, 12, 9)),
                new Etudiant("La boss", "Henoux", "333", "444", new DateTime(1999, 07, 15))
            };
        }
    }
}
