using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Seat
    {
        [Key] // Definerer primær nøglen
        public int Id { get; set; }

        public int Row { get; set; } // Eksempel på en egenskab til rækkenummer
        public int Number { get; set; } // Eksempel på en egenskab til sædenummer
    }
}
