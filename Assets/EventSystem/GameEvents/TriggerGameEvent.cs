using DHEventSystem.BaseClasses;
using DHEventSystem.BaseClasses.GenericEvents;
using DHScriptableVariables.ScriptableVariables;
using UnityEngine;

namespace DHEventSystem.GameEvents
{
    [CreateAssetMenu(menuName = "Framework/Game Events/" + nameof(TriggerGameEvent))]
    public class TriggerGameEvent : GameEvent<Collider>
    {
        public override ScriptableObject GetSerializedParameter()
        {
            return CreateInstance(typeof(ColliderVariable));
        }
    }
}