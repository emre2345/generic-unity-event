using System;
using DHEventSystem.BaseClasses;
using DHEventSystem.GameEvents;
using UnityEngine;
using UnityEngine.Events;

namespace DHEventSystem.Proxies
{
    public class StringGameEventProxy : GameEventProxy<StringGameEvent, string>
    {
        [Serializable]
        public class Event : UnityEvent<string>
        {
        }

        [SerializeField] private Event OnGameEventTriggered;

        protected override void RaiseUnityEvent(string parameter)
        {
            OnGameEventTriggered.Invoke(parameter);
        }
    }
}