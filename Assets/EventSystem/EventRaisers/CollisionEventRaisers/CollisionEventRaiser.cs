using DHEventSystem.Proxies;
using UnityEngine;

namespace DHEventSystem.EventRaisers.CollisionEventRaisers
{
    public class CollisionEventRaiser : EventRaiser
    {
        [SerializeField]
        protected CollisionGameEventProxy.Event onHappened;

        [SerializeField]
        protected string tag = "Untagged";

        protected void RaiseIfTagMatches(Collision c)
        {
            if(c.gameObject.CompareTag(tag))
                onHappened.Invoke(c);
        }
    }
}