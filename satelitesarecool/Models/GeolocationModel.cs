using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace satelitesarecool.Models
{
    public partial class GeolocationModel
    {
        public Standard Standard { get; set; }
        public string Longt { get; set; }
        public Alt Alt { get; set; }
        public Alt Elevation { get; set; }
        public string Latt { get; set; }
    }

    public partial class Alt
    {
    }

    public partial class Standard
    {
        public string Addresst { get; set; }
        public string City { get; set; }
        public string Prov { get; set; }
        public string Countryname { get; set; }
        public string Postal { get; set; }
        public string Confidence { get; set; }
    }
}
