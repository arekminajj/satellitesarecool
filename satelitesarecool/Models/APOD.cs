using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace satelitesarecool.Models
{
    public partial class Apod
    {
        public string Copyright { get; set; }
        public string Date { get; set; }
        public string Explanation { get; set; }
        public string Hdurl { get; set; }
        public string MediaType { get; set; }
        public string ServiceVersion { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
