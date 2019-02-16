using UnityEngine;

namespace DHEventSystem.EventRaisers.TriggerEventRaisers
{
    public class TriggerEnter : TriggerEventRaiser
    {
        private void OnTriggerEnter(Collider other)
        {
            RaiseIfTagMatches(other);
        }
    }
}