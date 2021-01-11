using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Tb_Transport
    {
        [Key]
        public int TransportId { get; set; }
        public String CarBrand { get; set; }
        public String VehiclePlate { get; set; }
        public DateTime Date { get; set; }

        public virtual Tb_Companies CompaniesTR { get; set; }
        public virtual Tb_Transportation TRansportationTR { get; set; }
        public int CompaniesTRId { get; set; }
        public int TRansportationTRId { get; set; }
    }
}