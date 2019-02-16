using DHEventSystem.Proxies;
using UnityEngine;

namespace DHEventSystem.EventRaisers.TriggerEventRaisers
{
    public class TriggerEventRaiser : EventRaiser
    {
        [SerializeField]
        protected TriggerGameEventProxy.Event onHappened;

        [SerializeField]
        protected string tag = "Untagged";

        protected void RaiseIfTagMatches(Collider other)
        {
            if (other.CompareTag(tag))
                onHappened.Invoke(other);
        }
    }
}