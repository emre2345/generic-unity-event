using UnityEngine;

namespace DHEventSystem.EventRaisers.CollisionEventRaisers
{
    public class CollisionExit : CollisionEventRaiser
    {
        private void OnCollisionExit(Collision other)
        {
            RaiseIfTagMatches(other);
        }
    }
}