using DHEventSystem.BaseClasses.VoidEvents;
using UnityEngine;

namespace DHEventSystem.GameEvents
{
    [CreateAssetMenu(menuName = "Framework/Game Events/" + nameof(VoidGameEvent))]
    public class VoidGameEvent : GameEvent
    {
        public override ScriptableObject GetSerializedParameter()
        {
            throw new System.NotImplementedException();
        }
    }
}