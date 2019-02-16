using UnityEngine;

namespace DHEventSystem.EventRaisers.TriggerEventRaisers
{
    public class TriggerStay : TriggerEventRaiser
    {
        private void OnTriggerStay(Collider other)
        {
            RaiseIfTagMatches(other);
        }
    }
}