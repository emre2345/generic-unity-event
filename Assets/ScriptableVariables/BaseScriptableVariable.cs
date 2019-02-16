using UnityEngine;

namespace DHScriptableVariables.ScriptableVariables
{
    public abstract class BaseScriptableVariable : ScriptableObject
    {
        public abstract object ObjectValue { get; }
    }
}