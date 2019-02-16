using DHEventSystem.BaseClasses;
using DHEventSystem.BaseClasses.GenericEvents;
using DHScriptableVariables.ScriptableVariables;
using UnityEngine;

namespace DHEventSystem.GameEvents
{
    [CreateAssetMenu]
    public class CollisionGameEvent : GameEvent<Collision>
    {
        public override ScriptableObject GetSerializedParameter()
        {
            return CreateInstance(typeof(CollisionVariable));
        }
    }
}