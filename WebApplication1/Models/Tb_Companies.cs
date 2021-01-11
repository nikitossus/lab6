using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Tb_Companies
    {
        [Key]
        public int CompaniesId { get; set; }
        public String CompName { get; set; }
        public String Director { get; set; }
        public int CountOfTransp { get; set; }
        public virtual ICollection<Tb_Transport> tb_Transport { get; set; }
    }
}