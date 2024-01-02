namespace Strategy
{
    public class FloatBehavior : VehicleBehavior
    {
        public override void AboutVehicle(string vehicleName)
        {
            System.Console.WriteLine($"{vehicleName} can float now");
        }
    }

}