namespace Observer
{
    public class ObserverType2 : IObserver
    {
        string name;

        public ObserverType2(string name)
        {
            this.name = name;
        } 


        public void Update(ICeleberity celeberity)
        {
            System.Console.WriteLine($"{name} has received an notify from {celeberity.Name}. Updated value is {celeberity.Flag}");
        }
    }

}