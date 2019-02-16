using UnityEngine;

namespace DHScriptableVariables.ScriptableVariables
{
    [CreateAssetMenu(menuName = "Framework/Variables/" + nameof(StringVariable))]
    public class IntVariable : ScriptableVariable<int>
    {
    }
}