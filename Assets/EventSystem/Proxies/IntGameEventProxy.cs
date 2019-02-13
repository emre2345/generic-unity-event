using System;
using DHEventSystem.BaseClasses;
using DHEventSystem.GameEvents;
using UnityEngine;
using UnityEngine.Events;

namespace DHEventSystem.Proxies
{
    public class IntGameEventProxy : GameEventProxy<IntGameEvent, int>
    {
        [Serializable]
        public class Event : UnityEvent<int>
        {
        }

        [SerializeField] private Event OnGameEventTriggered;

        protected override void RaiseUnityEvent(int parameter)
        {
            OnGameEventTriggered.Invoke(parameter);
        }
    }
}