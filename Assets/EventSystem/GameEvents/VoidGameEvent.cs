using BaseClasses.VoidEvents;
using UnityEngine;

namespace DHEventSystem.GameEvents
{
    [CreateAssetMenu]
    public class VoidGameEvent : GameEvent
    {
        public override ScriptableObject GetSerializedParameter()
        {
            throw new System.NotImplementedException();
        }
    }
}