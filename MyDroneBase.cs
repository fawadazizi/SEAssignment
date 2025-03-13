namespace DroneTestingApplicationAssignmentMICT25_26.Models
{
    public abstract class MyDroneBase
    {
        protected int _xCoordinates { get; set; }
        protected int _yCoordinates { get; set; }
        protected Direction facingDirection { get; set; }
        protected bool IsFlying { get; set; } = false;

        public abstract void LaunchDrone(int xCoord , int yCoord , Direction facingDirection);
        public abstract void Fly();
        public abstract void TurnLeft();
        public abstract void TurnRight();
        public abstract string Status();



        public enum Direction
        {
            NORTH
            ,SOUTH
            ,EAST
            ,WEST

        }
    }
}
