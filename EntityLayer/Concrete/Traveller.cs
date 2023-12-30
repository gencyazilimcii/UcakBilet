using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Traveller
    {
        [Key]
        public int TravellerID { get; set; }

        public int RegisteredPassenger { get; set; } //kayıtlı yolcu

        public int NumberOfTickets { get; set; } //bilet sayısı
        public int SatisfiedCustomer { get; set; } //memnun müşteri
        public int DissatisfiedCustomer { get; set; } //memnun olmayan müşteri
    }
}
