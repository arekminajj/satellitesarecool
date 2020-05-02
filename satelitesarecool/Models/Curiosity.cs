using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public Uri img_src { get; set; }
        public string EarthDate { get; set; }
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
        [DisplayName("Landing Date")]
        public string landing_date { get; set; }
        [DisplayName("Launch Date")]
        public string launch_date { get; set; }
        public Status Status { get; set; }
        [DisplayName("Max Sol")]
        public long max_sol { get; set; }
        [DisplayName("Max Date")]
        public DateTimeOffset max_date { get; set; }
        [DisplayName("Total Photos")]
        public long total_photos { get; set; }
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
