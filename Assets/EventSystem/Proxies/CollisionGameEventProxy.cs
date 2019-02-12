using System;
using DHEventSystem.BaseClasses;
using DHEventSystem.GameEvents;
using UnityEngine;
using UnityEngine.Events;

namespace DHEventSystem.Proxies
{
    public class CollisionGameEventProxy : MonoBehaviour, IEventListener<Collision>
    {
        [Serializable]
        public class Event : UnityEvent<Collision>
        {
        }

        [SerializeField] private CollisionGameEvent gameEvent;

        [SerializeField] private Event OnGameEventTriggered;

        private void OnEnable()
        {
            gameEvent.AddListener(this);
        }

        private void OnDisable()
        {
            gameEvent.RemoveListener(this);
        }

        public void OnEventRaised(Collision parameter)
        {
            OnGameEventTriggered.Invoke(parameter);
        }
    }
}