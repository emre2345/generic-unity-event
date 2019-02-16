using UnityEngine;

namespace DHScriptableVariables.ScriptableVariables
{
    [CreateAssetMenu(menuName = "Framework/Variables/" + nameof(ColliderVariable))]
    public class ColliderVariable : ScriptableVariable<Collider>
    {
        
    }
}