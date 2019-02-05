using System;
using UnityEngine;
using UnityEngine.Events;

namespace EventSystem.Proxies
{
    public class FloatGameEventProxy : MonoBehaviour, IEventListener<float>
    {
        [Serializable]
        public class Event : UnityEvent<float>
        {
        }

        [SerializeField] private FloatGameEvent gameEvent;

        [SerializeField] private Event OnGameEventTriggered;

        private void OnEnable()
        {
            gameEvent.AddListener(this);
        }

        private void OnDisable()
        {
            gameEvent.RemoveListener(this);
        }

        public void OnEventRaised(float parameter)
        {
            OnGameEventTriggered.Invoke(parameter);
        }
    }
}