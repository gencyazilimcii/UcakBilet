using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kampanya
    {
        [Key]
        public int ID { get; set; }

        public string KampanyaAdi { get; set; }
        public string KampanyaBaslik { get; set; }

        public string KampanyaBaslik2 { get; set; }
        public string KampanyaAciklama { get; set; }
        public double KampanyaPrice { get; set; }

        public string KampanyaImage { get; set; }

        public string KampanyaAciklama2 { get; set; }

       
    }
}
