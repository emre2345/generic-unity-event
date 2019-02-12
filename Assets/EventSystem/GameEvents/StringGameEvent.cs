using DHEventSystem.BaseClasses;
using ScriptableVariables;
using UnityEngine;

namespace DHEventSystem.GameEvents
{
    [CreateAssetMenu]
    public class StringGameEvent : GameEvent<string>
    {
        public override ScriptableObject GetSerializedParameter()
        {
            return CreateInstance(typeof(StringVariable));
        }
    }
}