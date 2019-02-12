using System;
using DHEventSystem.BaseClasses;
using DHEventSystem.GameEvents;
using UnityEngine;
using UnityEngine.Events;

namespace DHEventSystem.Proxies
{
    public class StringGameEventProxy : MonoBehaviour, IEventListener<string>
    {
        [Serializable]
        public class Event : UnityEvent<string>
        {
        }

        [SerializeField] private StringGameEvent gameEvent;

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

        public void OnEventRaised(string parameter)
        {
            OnGameEventTriggered.Invoke(parameter);
        }
    }
}