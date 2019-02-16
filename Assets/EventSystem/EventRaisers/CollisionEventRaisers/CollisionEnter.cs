using UnityEngine;

namespace DHEventSystem.EventRaisers.CollisionEventRaisers
{
    public class CollisionEnter : CollisionEventRaiser
    {
        private void OnCollisionEnter(Collision other)
        {
            RaiseIfTagMatches(other);
        }
    }
}