using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Ticket
    {
        public int Id { get; set; }
        public  string? NameAirway { get; set; }
        public  int TicketNumber { get; set; }
        public  string? Direction { get; set; }
        public  string Go_And_Come { get; set; }
        public  string? Baggage { get; set; }
        [Range(1,100)]
        [Column(TypeName = "decimal(10,2)")]
        public  decimal Price { get; set; }
        public DateTime Time { get; set; }
    }
}
