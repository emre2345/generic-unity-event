namespace BaseClasses.VoidEvents
{
    public interface IEvent
    {
        void AddListener(IEventListener listener);
        void RemoveListener(IEventListener listener);
        void Raise();
    }
}