using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CS7
{
    
    public class Shipper
    {
        [Column("ShipperID")]
        public int ShipVia { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}