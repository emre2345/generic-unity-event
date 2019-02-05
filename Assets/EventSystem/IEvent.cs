namespace EventSystem
{
    public interface IEvent<T>
    {
        void AddListener(IEventListener<T> listener);
        void RemoveListener(IEventListener<T> listener);
        void Raise(T parameters);
    }
}