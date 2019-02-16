using UnityEngine;

namespace DHScriptableVariables.ScriptableVariables
{
    [CreateAssetMenu(menuName = "Framework/Variables/" + nameof(StringVariable))]
    public class StringVariable : ScriptableVariable<string>
    {
        
    }
}