using DHEventSystem.BaseClasses.VoidEvents;
using DHEventSystem.GameEvents;
using UnityEngine;
using UnityEngine.Events;

namespace DHEventSystem.Proxies
{
    public class VoidGameEventProxy : MonoBehaviour, IEventListener
    {
        [Header("Parameters")] [SerializeField]
        private float delay = 0;

        [SerializeField] private int eventCountToTrigger = 1;
        [SerializeField] private bool raiseOnce = false;

        [SerializeField] private VoidGameEvent gameEvent;

        [SerializeField] private UnityEvent onGameEventTriggered;
        private int eventRepeatCount;

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
            if (--eventRepeatCount <= 0)
            {
                Invoke("RaiseUnityEvent", delay);

                if (raiseOnce)
                {
                    Destroy(gameObject);
                    gameEvent.RemoveListener(this);
                }
            }
        }

        private void RaiseUnityEvent()
        {
            onGameEventTriggered.Invoke();
        }
    }
}