namespace DHEventSystem.BaseClasses
{
    public interface IEventListener<T>
    {
        void OnEventRaised(T parameter);
    }
}