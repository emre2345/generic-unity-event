using UnityEngine;

namespace ScriptableVariables
{
    public abstract class BaseScriptableVariable : ScriptableObject
    {
        public abstract object ObjectValue { get; }
    }
}