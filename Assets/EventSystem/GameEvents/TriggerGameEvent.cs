using DHEventSystem.BaseClasses;
using DHEventSystem.BaseClasses.GenericEvents;
using DHScriptableVariables.ScriptableVariables;
using UnityEngine;

namespace DHEventSystem.GameEvents
{
    public class TriggerGameEvent : GameEvent<Collider>
    {
        public override ScriptableObject GetSerializedParameter()
        {
            return CreateInstance(typeof(ColliderVariable));
        }
    }
}