using UnityEngine;

namespace DHEventSystem.EventRaisers.TriggerEventRaisers
{
    public class TriggerExit : TriggerEventRaiser
    {
        private void OnTriggerExit(Collider other)
        {
            RaiseIfTagMatches(other);
        }
    }
}