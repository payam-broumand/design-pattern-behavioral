namespace Observer
{
    public class Celeberity : ICeleberity
    {
        string name;
        int flag;
        List<IObserver> observers = new List<IObserver>();

        public Celeberity(string name)
        {
            this.name = name;
        } 

        public string Name => name;

        public int Flag { 
            get => flag;
            set => NotifyRegisteredusers();
        } 

        public void NotifyRegisteredusers()
        {
            foreach (var item in observers)
            {
                item.Update(this);
            }
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnRegister(IObserver observer)
        {
            observers.Remove(observer);
        }

    }
}