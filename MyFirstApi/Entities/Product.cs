using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApi.Entities
{
    public class Product
    {
        [Key]
        public int Pid { get; set; }
        [Required]
        public string Pname { get; set; }
        [Required]
        public int? Price { get; set; }
        [Required]
        public int? Stock { get; set; }
    }
}
