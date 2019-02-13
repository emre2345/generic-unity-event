using System;
using DHEventSystem.BaseClasses;
using UnityEngine;
using UnityEngine.Events;

namespace DHEventSystem.Proxies
{
    public abstract class GameEventProxy<GameEventType, GameEventParameterType> : MonoBehaviour,
        IEventListener<GameEventParameterType>
        where GameEventType : GameEvent<GameEventParameterType>
    {
        [Header("Parameters")] [SerializeField]
        private float delay = 0;

        [SerializeField] private int eventCountToTrigger = 1;
        [SerializeField] private bool raiseOnce = false;

        [Space]
        [SerializeField] private GameEventType gameEvent;

        private int eventRepeatCount;

        private void OnValidate()
        {
            if(gameEvent != null)
                gameEvent.AddListener(this);
        }

        private void OnEnable()
        {
            gameEvent.AddListener(this);

            eventRepeatCount = eventCountToTrigger;
        }

        private void OnDisable()
        {
            gameEvent.RemoveListener(this);
        }

        public void OnEventRaised(GameEventParameterType parameter)
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

        protected abstract void RaiseUnityEvent(GameEventParameterType parameter);
    }
}