namespace DHEventSystem.BaseClasses.GenericEvents
{
    public interface IEvent<T>
    {
        void AddListener(IEventListener<T> listener);
        void RemoveListener(IEventListener<T> listener);
        void Raise(T parameter);
    }

}