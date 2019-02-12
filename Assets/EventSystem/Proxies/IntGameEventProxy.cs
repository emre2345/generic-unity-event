using System;
using DHEventSystem.BaseClasses;
using DHEventSystem.GameEvents;
using UnityEngine;
using UnityEngine.Events;

namespace DHEventSystem.Proxies
{
    public class IntGameEventProxy : MonoBehaviour, IEventListener<int>
    {
        [Serializable]
        public class Event : UnityEvent<int>
        {
        }

        [SerializeField] private IntGameEvent gameEvent;

        [SerializeField] private Event OnGameEventTriggered;

        private void OnValidate()
        {
            if (gameEvent != null)
                gameEvent.AddListener(this);
        }

        private void OnEnable()
        {
            gameEvent.AddListener(this);
        }

        private void OnDisable()
        {
            gameEvent.RemoveListener(this);
        }

        public void OnEventRaised(int parameter)
        {
            OnGameEventTriggered.Invoke(parameter);
        }
    }
}