namespace Strategy
{
    public class FlyBehavior : VehicleBehavior
    {
        public override void AboutVehicle(string vehicleName)
        {
            System.Console.WriteLine($"{vehicleName} can fly now");
        }
    }

}