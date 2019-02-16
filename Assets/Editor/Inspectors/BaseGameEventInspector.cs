using System;
using System.Reflection;
using DHEventSystem.BaseClasses;
using DHEventSystem.BaseClasses.VoidEvents;
using DHEventSystem.GameEvents;
using DHScriptableVariables.ScriptableVariables;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace DHEventSystem.Inspectors
{
    [CustomEditor(typeof(BaseGameEvent), true)]
    public class BaseGameEventInspector : Editor
    {
        private Type type;
        private Type[] genericArguments;
        private bool isGeneric;
        private MethodInfo raiseMethod;

        private SerializedObject[] parameters;

        private void OnEnable()
        {
            type = target.GetType();
            isGeneric = !typeof(IEvent).IsAssignableFrom(type);

            if (isGeneric)
            {
                genericArguments = type.BaseType.GetGenericArguments();
                parameters = new SerializedObject[genericArguments.Length];
                for (int i = 0; i < parameters.Length; i++)
                {
                    parameters[i] = new SerializedObject((target as BaseGameEvent).GetSerializedParameter());
                }

                raiseMethod = target.GetType().GetMethod("Raise");
            }
        }

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            EditorGUILayout.Space();

            GUILayout.BeginVertical();

            if (isGeneric)
            {
                for (int i = 0; i < genericArguments.Length; i++)
                {
                    EditorGUILayout.PropertyField(parameters[i].FindProperty("value"), false);
                    parameters[i].ApplyModifiedProperties();
                }
                
                if (GUILayout.Button("Raise"))
                {
                    object[] parameters = new object[this.parameters.Length];
                    for (int i = 0; i < this.parameters.Length; i++)
                    {
                        parameters[i] = (this.parameters[i].targetObject as BaseScriptableVariable).ObjectValue;
                    }
                    raiseMethod.Invoke(target, parameters);
                }
            }
            else
            {
                if (GUILayout.Button("Raise"))
                {
                    (target as GameEvent).Raise();
                }
            }


            GUILayout.EndVertical();
        }
    }
}