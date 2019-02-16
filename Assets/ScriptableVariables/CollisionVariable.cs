using UnityEngine;

namespace DHScriptableVariables.ScriptableVariables
{
    [CreateAssetMenu(menuName = "Framework/Variables/" + nameof(CollisionVariable))]
    public class CollisionVariable : ScriptableVariable<Collision>
    {
        
    }
}