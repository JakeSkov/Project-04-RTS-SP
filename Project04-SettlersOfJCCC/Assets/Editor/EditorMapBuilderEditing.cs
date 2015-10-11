using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;

public class EditorMapBuilderEditing : EditorMapBuilder
{
    public static ResourceTypes[] type;
    static string[] tiles;

    public static void MapRandomize(int side)
    {
        //Sets the array length for each differant side length
        switch (side)
        { 
            case 3:
                type = new ResourceTypes[19];
                break;
            case 4:
                type = new ResourceTypes[37];
                break;
            case 5:
                type = new ResourceTypes[61];
                break;
        }

        int rand;
        for (int i = 0; i < type.Length; i++)
        {
            rand = Random.Range(0, 4);
            if (rand == 0)
            {
                type[i] = ResourceTypes.BRICK;
            }
            else if (rand == 1)
            {
                type[i] = ResourceTypes.GRAIN;
            }
            else if (rand == 2)
            {
                type[i] = ResourceTypes.WOOD;
            }
            else
            {
                type[i] = ResourceTypes.WOOL;
            }
        }
    }

    public static void MapEdit(ResourceTypes type)
    {
        switch (type)
        { 
            case ResourceTypes.BRICK:
                type = ResourceTypes.GRAIN;
                break;
            case ResourceTypes.GRAIN:
                type = ResourceTypes.WOOD;
                break;
            case ResourceTypes.WOOD:
                type = ResourceTypes.WOOL;
                break;
            case ResourceTypes.WOOL:
                type = ResourceTypes.BRICK;
                break;
        }
    }

    public static void Export(ResourceTypes[] tile)
    {
        tiles = new string[tile.Length];
        int lineNum;

        for (int i = 0; i < tile.Length; i++)
        {
            tiles[i] = tile[i].ToString();
        }

        string path = Application.dataPath + "/Maps/Custom";

        

        AssetDatabase.Refresh();
    }
}
