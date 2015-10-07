using UnityEngine;
using UnityEditor;
using System.Collections;

public class EditorMapBuilder : EditorWindow
{
    ResourceTypes[] tileTypes;
    public static string levelName;
    public static string authorName;

    [MenuItem("Editor Tools/Map Creator")]

    static void Init()
    {
        EditorMapBuilder mapCreator = (EditorMapBuilder)EditorWindow.GetWindow(typeof(EditorMapBuilder));
        mapCreator.Show();
    }

    static void OnGui()
    {
        EditorGUILayout.LabelField("Map Builder");
        EditorGUILayout.Separator();

        EditorGUILayout.BeginVertical();
        levelName = EditorGUILayout.TextField("Level Name:\t", levelName);
        authorName = EditorGUILayout.TextField("Created by:\t", authorName);
        EditorGUILayout.EndVertical();


    }
}
