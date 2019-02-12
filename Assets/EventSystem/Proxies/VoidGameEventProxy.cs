using BaseClasses.VoidEvents;
using DHEventSystem.GameEvents;
using UnityEngine;
using UnityEngine.Events;

namespace DHEventSystem.Proxies
{
    public class VoidGameEventProxy : MonoBehaviour, IEventListener
    {
        [SerializeField] private VoidGameEvent gameEvent;

        [SerializeField] private UnityEvent onGameEventTriggered;

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

        public void OnEventRaised()
        {
            onGameEventTriggered.Invoke();
        }
    }
}