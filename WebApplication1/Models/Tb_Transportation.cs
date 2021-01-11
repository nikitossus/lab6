using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Tb_Transportation
    {
        [Key]
        public int TransportationId { get; set; }
        public String DriverName { get; set; }
        public String GoodsComp { get; set; }
        public int Distance { get; set; }
        public virtual ICollection<Tb_Transport> tb_Transport { get; set; }
    }
}