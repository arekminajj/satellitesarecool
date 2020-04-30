using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace satelitesarecool.Models
{
    public partial class Epic
    {
        public string Identifier { get; set; }
        public string Caption { get; set; }
        public string Image { get; set; }
        public string Version { get; set; }
        public CentroidCoordinates CentroidCoordinates { get; set; }
        public J2000Position DscovrJ2000Position { get; set; }
        public J2000Position LunarJ2000Position { get; set; }
        public J2000Position SunJ2000Position { get; set; }
        public AttitudeQuaternions AttitudeQuaternions { get; set; }
        public DateTimeOffset Date { get; set; }
        public Coords Coords { get; set; }
        public string ImageUrl { get; set; }
    }

    public partial class AttitudeQuaternions
    {
        public double Q0 { get; set; }
        public double Q1 { get; set; }
        public double Q2 { get; set; }
        public double Q3 { get; set; }
    }

    public partial class CentroidCoordinates
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
    }

    public partial class Coords
    {
        public CentroidCoordinates CentroidCoordinates { get; set; }
        public J2000Position DscovrJ2000Position { get; set; }
        public J2000Position LunarJ2000Position { get; set; }
        public J2000Position SunJ2000Position { get; set; }
        public AttitudeQuaternions AttitudeQuaternions { get; set; }
    }

    public partial class J2000Position
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

}
