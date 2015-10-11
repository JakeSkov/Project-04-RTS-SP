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
        if (levelName != null && authorName != null)
        {
            tiles = new string[tile.Length];
            int numLines = 2;
            int line = 0;

            for (int i = 0; i < tile.Length; i++)
            {
                tiles[i] = tile[i].ToString();
            }

            string path = Application.dataPath + "/Maps/Custom/" + levelName + ".txt";
            
            //Writes all data to the given file under that name declared in the levelName variable 
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i <= numLines; i++)
            {
                Debug.Log(line);
                if (line == 0)
                {
                    Debug.Log(levelName);
                    sw.WriteLine(levelName);
                }
                if (line == 1)
                {
                    Debug.Log(authorName);
                    sw.WriteLine(authorName);
                }
                if (line == 2)
                {
                    for (int j = 0; j < tiles.Length; j++)
                    {
                        Debug.Log(tiles[j]);
                        sw.Write(tiles[j] + " ");
                    }
                }
                line++;
            }
            sw.Close();

            AssetDatabase.Refresh();
        }
        else
        {
            Debug.Log("No level name and/or no author name");
        }
    }
}
