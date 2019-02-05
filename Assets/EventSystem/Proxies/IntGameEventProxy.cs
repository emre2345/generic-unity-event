using System;
using UnityEngine;
using UnityEngine.Events;

namespace EventSystem.Proxies
{
    public class IntGameEventProxy : MonoBehaviour, IEventListener<int>
    {
        [Serializable]
        public class Event : UnityEvent<int>
        {}
        
        [SerializeField] private IntGameEvent gameEvent;

        [SerializeField] private Event OnGameEventTriggered;

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