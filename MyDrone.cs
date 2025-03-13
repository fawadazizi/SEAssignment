namespace DroneTestingApplicationAssignmentMICT25_26.Models
{
    public class MyDrone : MyDroneBase
    {
        private const int MaxWidth = 5;
        private const int MaxLenght = 5;

        public override void LaunchDrone(int xCoord, int yCoord, Direction facingDirection)
        {
           if(xCoord < 0 || xCoord > MaxWidth || yCoord < 0 || yCoord > MaxLenght)
            {
                throw new Exception("Invalid Launch Coordinates");
            }
            _xCoordinates = xCoord;
            _yCoordinates = yCoord;
            this.facingDirection = facingDirection;
            IsFlying = true;
        }
        public override void Fly()
        {
            if(!IsFlying)
            {
                throw new Exception("Drone is not flying");
            }
            switch (facingDirection)
            {
                case Direction.NORTH:
                   if(_yCoordinates+1 < MaxLenght) _yCoordinates++;
                    break;
                case Direction.SOUTH:
                   if(_yCoordinates - 1 >= 0) _yCoordinates--;
                    break;
                case Direction.EAST:
                   if(_xCoordinates +1 < MaxWidth) _xCoordinates++;
                    break;
                case Direction.WEST:
                   if(_xCoordinates - 1 >=0) _xCoordinates--;
                    break;
            }
        }

        public override void TurnLeft()
        {
            if (!IsFlying) return;
            facingDirection = facingDirection switch
            {
                Direction.NORTH => Direction.WEST,
                Direction.SOUTH => Direction.EAST,
                Direction.EAST => Direction.NORTH,
                Direction.WEST => Direction.SOUTH,
                _ => facingDirection
            };

        }
        public override void TurnRight()
        {
           if(! IsFlying) return;
            facingDirection = facingDirection switch
            {
                Direction.NORTH => Direction.EAST,
                Direction.SOUTH => Direction.WEST,
                Direction.EAST => Direction.SOUTH,
                Direction.WEST => Direction.NORTH,
                _ => facingDirection
            };
        }

        public override string Status()
        {
            return $"Current Coordinates: ({_xCoordinates},{_yCoordinates}) , Facing Direction: {facingDirection}";
        }

       

        
    }
}
