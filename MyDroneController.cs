using DroneTestingApplicationAssignmentMICT25_26.Models;
using Microsoft.AspNetCore.Mvc;
using static DroneTestingApplicationAssignmentMICT25_26.Models.MyDroneBase;

namespace DroneTestingApplicationAssignmentMICT25_26.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyDroneController : ControllerBase
    {
        private readonly MyDrone _dronService;
        public MyDroneController(MyDrone droneService)
        {
            _dronService = droneService;
        }
        [HttpPost("launch")]

        public IActionResult Launch([FromForm] LaunchRequest request)
        {
            if(Request == null || !Enum.TryParse(request.Direction,true, out Direction facing))
            {
                return BadRequest("Invalid Request");
            }
            _dronService.LaunchDrone(request.xCoord , request.yCoord ,facing);
                return Ok("Drone Launched");
 
        }
        [HttpPost("fly")]
        public IActionResult Fly()
        {
            _dronService.Fly();
            return Ok(_dronService.Status());
        }
        [HttpPost("left")]
        public IActionResult TurnLeft()
        {
            _dronService.TurnLeft();
            return Ok(_dronService.Status());
        }
        [HttpPost("right")]
        public IActionResult TurnRight()
        {
            _dronService.TurnRight();
            return Ok(_dronService.Status());
        }
        [HttpGet("status")]
        public IActionResult Status()
        {
            return Ok(_dronService.Status());
        }

    }
}
