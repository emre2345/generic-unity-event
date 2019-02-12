using System.Runtime.CompilerServices;

namespace DHEventSystem.BaseClasses
{
    public interface IEvent<T>
    {
        void AddListener(IEventListener<T> listener);
        void RemoveListener(IEventListener<T> listener);
        void Raise(T parameter);
    }

}