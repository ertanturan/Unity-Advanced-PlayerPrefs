namespace CustomTools.CustomPlayerPrefs.Demo.Editor
{
    using UnityEditor;
    using UnityEngine;
    using Demo = global::Demo;

    [CustomEditor(typeof(Demo))]
    public class DemoEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            Demo demo = target as Demo;

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Save All"))
            {
                demo.SaveAll();
            }

            if (GUILayout.Button("Load All"))
            {
                demo.LoadAll();
            }

            GUILayout.EndHorizontal();
        }
    }
}