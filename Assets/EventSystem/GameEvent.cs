using System.Collections;
using System.Collections.Generic;
using EventSystem;
using UnityEngine;

public class GameEvent<T> : ScriptableObject, IEvent<T>
{
    protected List<IEventListener<T>> listeners;

    private void OnEnable()
    {
        listeners = new List<IEventListener<T>>();
    }

    public void AddListener(IEventListener<T> listener)
    {
        listeners.Add(listener);
    }

    public void RemoveListener(IEventListener<T> listener)
    {
        listeners.Remove(listener);
    }

    public void Raise(T parameters)
    {
        for (int i = 0; i < listeners.Count; i++)
        {
            listeners[i].OnEventRaised(parameters);
        }
    }
}
