using DHEventSystem.BaseClasses;
using DHEventSystem.BaseClasses.GenericEvents;
using DHScriptableVariables.ScriptableVariables;
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