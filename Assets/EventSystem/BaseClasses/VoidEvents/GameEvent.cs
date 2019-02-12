using System.Collections.Generic;
using DHEventSystem.BaseClasses;
using UnityEngine;

namespace BaseClasses.VoidEvents
{
    public abstract class GameEvent : BaseGameEvent, IEvent
    {
        protected List<IEventListener> listeners;
    
        private void OnEnable()
        {
            listeners = new List<IEventListener>();
        }

        public void AddListener(IEventListener listener)
        {
            if (!listeners.Contains(listener))
                listeners.Add(listener);
        }

        public void RemoveListener(IEventListener listener)
        {
            if (listeners.Contains(listener))
                listeners.Remove(listener);
        }

        public void Raise()
        {
            Debug.Log("[EventRaised]\nRaised Event:\n" + name + "\n");
            for (int i = 0; i < listeners.Count; i++)
            {
                listeners[i].OnEventRaised();
            }
        }
    }
}