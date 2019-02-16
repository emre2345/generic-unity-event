using System;
using DHEventSystem.GameEvents;
using UnityEngine;
using UnityEngine.Events;

namespace DHEventSystem.Proxies
{
    public class TriggerGameEventProxy : GameEventProxy<TriggerGameEvent, Collider>
    {
        [Serializable]
        public class Event : UnityEvent<Collider>
        {
        }

        [SerializeField] private Event OnGameEventTriggered;
        
        protected override void RaiseUnityEvent(Collider parameter)
        {
            OnGameEventTriggered.Invoke(parameter);
        }
    }
}