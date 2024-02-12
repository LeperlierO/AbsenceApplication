using AbsenceApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceApplication.Business
{
    public class UCAbsenceBusiness
    {
        public string BusinessLabel { get; set; }
        public string AddButtonLabel { get; set; }
        public string EditButtonLabel { get; set; }
        public string DeleteButtonLabel { get; set; }

        public List<Absence> ListOfData { get; set; }

        public UCAbsenceBusiness()
        {
            BusinessLabel = "Gestion absences";
            AddButtonLabel = "Ajouter absence";
            EditButtonLabel = "Modifier absence";
            DeleteButtonLabel = "Supprimer absence";

            ListOfData = new List<Absence>
            {
                new Absence(1),
                new Absence(2),
                new Absence(3)
            };
        }
    }
}
