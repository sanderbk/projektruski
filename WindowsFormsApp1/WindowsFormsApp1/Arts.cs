﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp1
{
    class Arts
    {
        [Key]
        public int ArtsID { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime Einddatum { get; set; }
        public List<Klanten> Klanten { get; set; }
    }
}
