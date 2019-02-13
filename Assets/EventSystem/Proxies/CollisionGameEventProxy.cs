using System;
using DHEventSystem.BaseClasses;
using DHEventSystem.GameEvents;
using UnityEngine;
using UnityEngine.Events;

namespace DHEventSystem.Proxies
{
    public class CollisionGameEventProxy : GameEventProxy<CollisionGameEvent, Collision>
    {
        [Serializable]
        public class Event : UnityEvent<Collision>
        {
        }

        [SerializeField] private Event OnGameEventTriggered;

        protected override void RaiseUnityEvent(Collision parameter)
        {
            OnGameEventTriggered.Invoke(parameter);
        }
    }
}