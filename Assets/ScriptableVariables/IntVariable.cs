﻿using UnityEngine;

namespace DHScriptableVariables.ScriptableVariables
{
    [CreateAssetMenu(menuName = "Framework/Variables/" + nameof(IntVariable))]
    public class IntVariable : ScriptableVariable<int>
    {
    }
}