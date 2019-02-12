using DHEventSystem.BaseClasses;
using ScriptableVariables;
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