using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AspNetMVCExample.Models {
    public class TorneoModel {
        [Required]
        public string Nome {get; set;}
        
        [Required]
        public string Descrizione {get; set;}

        [Required]
        [Range(10000, 15000)]
        public double Premio {get; set;}

    }
}