namespace EventSystem
{
    public interface IEventListener<T>
    {
        void OnEventRaised(T parameter);
    }
}