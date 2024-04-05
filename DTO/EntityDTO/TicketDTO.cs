using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.EntityDTO
{
    public class TicketDTO
    {
        public int Id { get; set; }
        public  string? NameAirway { get; set; }
        public  int TicketNumber { get; set; }
        public  string? Direction { get; set; }
        public  string Go_And_Come { get; set; }
        public  string? Baggage { get; set; }
        public  decimal Price { get; set; }
        public DateTime Time { get; set; }
    }
}
