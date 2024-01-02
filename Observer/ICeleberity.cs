namespace Observer
{
    public interface ICeleberity {
        string Name {get;}
        int Flag {get; set;}

        void Register(IObserver observer);

        void UnRegister(IObserver observer);

        void NotifyRegisteredusers(); 

    }
}