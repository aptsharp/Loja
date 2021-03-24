using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class CustomerModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Description = "Name")]
        public string Name { get; set; }

        [Display(Description ="Bithday")]
        public string Birthday { get; set; }

        [Display(Description ="Address")]
        public string Address { get; set; }
    }
}
