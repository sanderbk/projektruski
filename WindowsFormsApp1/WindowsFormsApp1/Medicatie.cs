using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp1
{
    class Medicatie
    {
        [Key]
        public int MedicatieID { get; set; }
        public string MedicatieNaam { get; set; }
        public int KlantID { get; set; }
        public virtual Klanten Klanten { get; set; }
    }
}
