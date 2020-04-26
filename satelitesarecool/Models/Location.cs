using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace satelitesarecool.Models
{
    public class Location
    {
        [Required]
        public string Place { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Month { get; set; }
        [Required]
        public string Day { get; set; }
        public float Dim { get; set; }
        [DisplayName("Photo")]
        public string Url { get; set; }
    }
}
