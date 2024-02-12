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
        public List<Absence> Absences { get; set; }

        public UCAbsenceBusiness()
        {
            Absences = new List<Absence>
            {
                new Absence(1),
                new Absence(2),
                new Absence(3)
            };
        }
    }
}
