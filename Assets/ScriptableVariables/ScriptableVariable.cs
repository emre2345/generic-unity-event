using UnityEngine;

namespace ScriptableVariables
{
    public class ScriptableVariable<T> : BaseScriptableVariable
    {
        [SerializeField] private T value;

        public override object ObjectValue
        {
            get { return value; }
        }

        public T Value
        {
            get => value;
            set => this.value = value;
        }
    }
}