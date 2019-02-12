using UnityEngine;

namespace DHEventSystem.BaseClasses
{
    public abstract class BaseGameEvent : ScriptableObject
    {
        public abstract ScriptableObject GetSerializedParameter();
    }
}