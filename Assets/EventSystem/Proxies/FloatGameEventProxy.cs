using System;
using DHEventSystem.BaseClasses;
using DHEventSystem.GameEvents;
using UnityEngine;
using UnityEngine.Events;

namespace DHEventSystem.Proxies
{
    public class FloatGameEventProxy : GameEventProxy<FloatGameEvent, float>
    {
        [Serializable]
        public class Event : UnityEvent<float>
        {
        }

        [SerializeField] private Event OnGameEventTriggered;

        protected override void RaiseUnityEvent(float parameter)
        {
            OnGameEventTriggered.Invoke(parameter);
        }
    }
}