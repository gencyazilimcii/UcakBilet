using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Flight
    {
        [Key]
        public int ID { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public int TicketPrice { get; set; }
        public DateTime DepatureDate { get; set; }
        public DateTime ArrivalDate { get; set; }

        

    }

}
