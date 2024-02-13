using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceApplication.Models
{
    public class Absence
    {
        public int? Id { get; set; }

        public Absence()
        {
            
        }

        public Absence(int id)
        {
            Id = id;
        }
    }
}
