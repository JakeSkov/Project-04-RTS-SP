using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapDataScript : MonoBehaviour {

//	public List<HexDataScript> hexList;

//	public void LoadMapData()
	public List<HexDataScript> LoadMapData()
	{
		List<HexDataScript> hexList = new List<HexDataScript>();
		HexDataScript tempHexData;

		for (int i = 1; i <= 19; i++)
		{
			tempHexData = new HexDataScript();
			switch (i)
			{
			case 1:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(-1f, 2f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 11;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOD;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 2:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(0f, 2f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 12;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOL;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 3:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(1f, 2f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 9;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.GRAIN;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 4:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(-1.5f, 1f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 4;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.BRICK;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 5:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(-0.5f, 1f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 6;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.GRAIN;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 6:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(0.5f, 1f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 5;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.BRICK;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 7:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(1.5f, 1f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 10;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOL;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 8:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(-2f, 0f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 2;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOL;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 9:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(-1f, 0f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 3;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOD;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 10:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(0f, 0f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 11;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.GRAIN;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 11:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(1f, 0f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 4;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOD;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 12:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(2f, 0f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 8;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.GRAIN;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 13:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(-1.5f, -1f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 8;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.BRICK;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 14:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(-0.5f, -1f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 10;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOL;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 15:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(0.5f, -1f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 9;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOL;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 16:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(1.5f, -1f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 3;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.BRICK;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 17:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(-1f, -2f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 5;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOD;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 18:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(0f, -2f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 2;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.GRAIN;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 19:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataGridLocation = new Vector2(1f, -2f);
				//tempHexData.hexDataNeighbors = 
				tempHexData.hexDataNumber = 6;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOD;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			} // end switch
			LogMapData(tempHexData);
//			Debug.Log(tempHexData.ToString());

//			GameObject newHex = (GameObject)Instantiate(hexPrefab, new Vector3(i, 0, 0), Quaternion.identity);
//			newHex.name = "HexNumber" + (i + 6).ToString();
//			newHex.GetComponent<HexPrefabData>().SetHexName(newHex.name);
		} // end for (int i = 1; i <= 19; i++)...

		return hexList;

	} // end method LoadMapData

	public void LogMapData(HexDataScript pHexData)
	{
		string outputString;

		outputString = "Color: " + pHexData.hexDataColor.ToString() +
			" Name: " + pHexData.hexDataName.ToString() +
				" Grid Location: " + pHexData.hexDataGridLocation.ToString() +
				" Number: " + pHexData.hexDataNumber.ToString() +
				" Player: " + pHexData.hexDataPlayer.ToString() +
				" Resource: " + pHexData.hexDataResourceType.ToString() +
				" Position: " + pHexData.hexDataPosition.ToString() +
				" Neighbor 1: " + pHexData.hexDataNeighbors[0] +
				" Neighbor 5: " + pHexData.hexDataNeighbors[4];

		Debug.Log(outputString);

//		tempHexData.hexDataColor = Color.red;
//		tempHexData.hexDataName = "HexNumber" + i.ToString();
//		tempHexData.hexDataGridLocation = new Vector2(-2f, 2f);
//		//tempHexData.hexDataNeighbors = 
//		tempHexData.hexDataNumber = 11;
//		tempHexData.hexDataPlayer = "None";
//		//				tempHexData.hexDataPosition =
//		//					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y, 0f);
//		tempHexData.hexDataResourceType = ResourceTypes.WOOD;
	} // end method LogMapData

	public Vector2[] CalcNeighbors(Vector2 pGridLocation)
	{
		Vector2[] tempNeighbors = new Vector2[6];

		tempNeighbors[0] = new Vector2(pGridLocation.x - 2f, pGridLocation.y);
		tempNeighbors[1] = new Vector2(pGridLocation.x - 1f, pGridLocation.y + 1f);
		tempNeighbors[2] = new Vector2(pGridLocation.x + 1f, pGridLocation.y + 1f);
		tempNeighbors[3] = new Vector2(pGridLocation.x + 2f, pGridLocation.y);
		tempNeighbors[4] = new Vector2(pGridLocation.x + 1f, pGridLocation.y - 1f);
		tempNeighbors[5] = new Vector2(pGridLocation.x - 1f, pGridLocation.y - 1f);
		return tempNeighbors;
	}

	// Use this for initialization
//	void Start () {
//	
//	}
	
	// Update is called once per frame
//	void Update () {
//	
//	}
} // end class MapDataScript
