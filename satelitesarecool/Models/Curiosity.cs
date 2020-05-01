using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace satelitesarecool.Models
{
    public partial class Curiosity
    {
        public Photo[] Photos { get; set; }
    }

    public partial class Photo
    {
        public long Id { get; set; }
        public long Sol { get; set; }
        public PhotoCamera Camera { get; set; }
        public Uri ImgSrc { get; set; }
        public DateTimeOffset EarthDate { get; set; }
        public Rover Rover { get; set; }
    }

    public partial class PhotoCamera
    {
        public long Id { get; set; }
        public CameraName Name { get; set; }
        public long RoverId { get; set; }
        public FullName FullName { get; set; }
    }

    public partial class Rover
    {
        public long Id { get; set; }
        public RoverName Name { get; set; }
        public DateTimeOffset LandingDate { get; set; }
        public DateTimeOffset LaunchDate { get; set; }
        public Status Status { get; set; }
        public long MaxSol { get; set; }
        public DateTimeOffset MaxDate { get; set; }
        public long TotalPhotos { get; set; }
        public CameraElement[] Cameras { get; set; }
    }

    public partial class CameraElement
    {
        public CameraName Name { get; set; }
        public FullName FullName { get; set; }
    }

    public enum FullName { ChemistryAndCameraComplex, FrontHazardAvoidanceCamera, MarsDescentImager, MarsHandLensImager, MastCamera, NavigationCamera, RearHazardAvoidanceCamera };

    public enum CameraName { Chemcam, Fhaz, Mahli, Mardi, Mast, Navcam, Rhaz };

    public enum RoverName { Curiosity };

    public enum Status { Active };

}
