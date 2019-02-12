using DHEventSystem.BaseClasses;
using ScriptableVariables;
using UnityEngine;

namespace DHEventSystem.GameEvents
{
    [CreateAssetMenu]
    public class FloatGameEvent : GameEvent<float>
    {
        public override ScriptableObject GetSerializedParameter()
        {
            return CreateInstance(typeof(FloatVariable));
        }
    }
}