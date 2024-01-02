namespace Strategy
{
    public class Vehicle {
        VehicleBehavior vehicleBehavior;
        string vehicleName;

        public Vehicle(string vehicleName)
        {
            this.vehicleName = vehicleName;
            vehicleBehavior = new InitialBehavior();
        }

        public void SerNewBehavioe(VehicleBehavior newBehavior){
            vehicleBehavior = newBehavior;
        }

        public void AboutVehicle(){
            vehicleBehavior.AboutVehicle(vehicleName);
        }

    }

}