namespace DHEventSystem.BaseClasses.GenericEvents
{
    public interface IEventListener<T>
    {
        void OnEventRaised(T parameter);
    }
}