﻿using System.Collections.Generic;
using UnityEngine;

namespace DHEventSystem.BaseClasses
{
    public abstract class GameEvent<T> : BaseGameEvent, IEvent<T>
    {
        protected List<IEventListener<T>> listeners;
    
        private void OnEnable()
        {
            listeners = new List<IEventListener<T>>();
        }

        public void AddListener(IEventListener<T> listener)
        {
            if (!listeners.Contains(listener))
                listeners.Add(listener);
        }

        public void RemoveListener(IEventListener<T> listener)
        {
            if (listeners.Contains(listener))
                listeners.Remove(listener);
        }

        public void Raise(T parameters)
        {
            Debug.Log("[EventRaised]\nRaised Event:\n" + name + "\n\nParameters:\n" + parameters + "\n");
            for (int i = 0; i < listeners.Count; i++)
            {
                listeners[i].OnEventRaised(parameters);
            }
        }
    }
}