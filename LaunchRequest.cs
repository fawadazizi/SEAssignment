using Microsoft.AspNetCore.Mvc;

namespace DroneTestingApplicationAssignmentMICT25_26.Models
{
    public class LaunchRequest
    {
        [FromForm]
        public int xCoord { get; set; }
        [FromForm]
        public int yCoord { get; set; }
        [FromForm]
        public string Direction { get; set; }
    }
}
