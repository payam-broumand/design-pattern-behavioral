namespace Strategy
{
    public class InitialBehavior : VehicleBehavior
    { 

        public override void AboutVehicle(string vehicleName)
        {
            System.Console.WriteLine($"{vehicleName} has initial behavior");
        }
        
    }

}