using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace satelitesarecool.Models
{
    public partial class Asteroid
    {
        public AsteroidLinks Links { get; set; }
        public long ElementCount { get; set; }
        public Dictionary<string, NearEarthObject[]> NearEarthObjects { get; set; }
    }

    public partial class AsteroidLinks
    {
        public Uri Next { get; set; }
        public Uri Prev { get; set; }
        public Uri Self { get; set; }
    }

    public partial class NearEarthObject
    {
        public NearEarthObjectLinks Links { get; set; }
        public long Id { get; set; }
        public long NeoReferenceId { get; set; }
        public string Name { get; set; }
        public Uri NasaJplUrl { get; set; }
        public double AbsoluteMagnitudeH { get; set; }
        public EstimatedDiameter EstimatedDiameter { get; set; }
        public bool IsPotentiallyHazardousAsteroid { get; set; }
        public CloseApproachDatum[] CloseApproachData { get; set; }
        public bool IsSentryObject { get; set; }
    }

    public partial class CloseApproachDatum
    {
        public DateTimeOffset CloseApproachDate { get; set; }
        public string CloseApproachDateFull { get; set; }
        public long EpochDateCloseApproach { get; set; }
        public RelativeVelocity RelativeVelocity { get; set; }
        public MissDistance MissDistance { get; set; }
        public OrbitingBody OrbitingBody { get; set; }
    }

    public partial class MissDistance
    {
        public string Astronomical { get; set; }
        public string Lunar { get; set; }
        public string Kilometers { get; set; }
        public string Miles { get; set; }
    }

    public partial class RelativeVelocity
    {
        public string KilometersPerSecond { get; set; }
        public string KilometersPerHour { get; set; }
        public string MilesPerHour { get; set; }
    }

    public partial class EstimatedDiameter
    {
        public Feet Kilometers { get; set; }
        public Feet Meters { get; set; }
        public Feet Miles { get; set; }
        public Feet Feet { get; set; }
    }

    public partial class Feet
    {
        public double EstimatedDiameterMin { get; set; }
        public double EstimatedDiameterMax { get; set; }
    }

    public partial class NearEarthObjectLinks
    {
        public Uri Self { get; set; }
    }

    public enum OrbitingBody { Earth };
}
