using UnityEngine;
using UnityEditor;
using System.Collections;

public enum TileTypes
{
    CLAY,
    WHEAT,
    LUMBER,
    SHEEP
}

public class EditorMapBuilder : EditorWindow
{
    public TileTypes[] tiles = new TileTypes[19];

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
