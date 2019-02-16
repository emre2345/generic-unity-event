using UnityEngine;

namespace DHEventSystem.EventRaisers.CollisionEventRaisers
{
    public class CollisionStay : CollisionEventRaiser
    {
        private void OnCollisionStay(Collision other)
        {
            RaiseIfTagMatches(other);
        }
    }
}