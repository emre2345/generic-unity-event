using DHEventSystem.BaseClasses;
using UnityEngine;

namespace DHEventSystem.GameEvents
{
    [CreateAssetMenu]
    public class IntGameEvent : GameEvent<int>
    {
        public override ScriptableObject GetSerializedParameter()
        {
            return CreateInstance(typeof(IntVariable));
        }
    }
}