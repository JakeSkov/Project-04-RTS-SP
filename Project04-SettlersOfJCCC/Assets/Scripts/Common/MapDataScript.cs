// MapDataScript.cs
// Author: Craig Broskow
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapDataScript : MonoBehaviour {

	const float VERTICAL_SEPARATION = 0.8593752f;

	public List<HexDataScript> hexList;

	public List<HexDataScript> LoadMapData()
	{
		hexList = new List<HexDataScript>();
		HexDataScript tempHexData;

		for (int i = 1; i <= 19; i++)
		{
			tempHexData = new HexDataScript();
			switch (i)
			{
			case 1:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(-1f, 2f);
//				tempHexData.hexDataGridLocation = new Vector2(-10f, 2f);
				tempHexData.hexDataNumber = 2;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOD;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 2:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(0f, 2f);
//				tempHexData.hexDataNumber = 2;
				tempHexData.hexDataNumber = 3;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
//				tempHexData.hexDataResourceType = ResourceTypes.WOOD;
				tempHexData.hexDataResourceType = ResourceTypes.WOOL;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 3:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(1f, 2f);
				tempHexData.hexDataNumber = 6;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.GRAIN;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 4:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(-1.5f, 1f);
				tempHexData.hexDataNumber = 4;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.BRICK;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 5:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(-0.5f, 1f);
				tempHexData.hexDataNumber = 6;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.GRAIN;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 6:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(0.5f, 1f);
				tempHexData.hexDataNumber = 5;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.BRICK;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 7:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(1.5f, 1f);
				tempHexData.hexDataNumber = 2;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOL;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 8:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(-2f, 0f);
				tempHexData.hexDataNumber = 2;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOL;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 9:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(-1f, 0f);
				tempHexData.hexDataNumber = 3;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOD;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 10:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(0f, 0f);
				tempHexData.hexDataNumber = 1;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.GRAIN;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 11:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(1f, 0f);
				tempHexData.hexDataNumber = 4;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOD;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 12:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(2f, 0f);
				tempHexData.hexDataNumber = 1;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.GRAIN;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 13:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(-1.5f, -1f);
				tempHexData.hexDataNumber = 1;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.BRICK;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 14:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(-0.5f, -1f);
				tempHexData.hexDataNumber = 4;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOL;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 15:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(0.5f, -1f);
				tempHexData.hexDataNumber = 5;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOL;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 16:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(1.5f, -1f);
				tempHexData.hexDataNumber = 3;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.BRICK;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 17:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(-1f, -2f);
				tempHexData.hexDataNumber = 5;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOD;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 18:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(0f, -2f);
				tempHexData.hexDataNumber = 2;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.GRAIN;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			case 19:
				tempHexData.hexDataColor = Color.red;
				tempHexData.hexDataName = "HexNumber" + i.ToString();
				tempHexData.hexDataID = i;
				tempHexData.hexDataGridLocation = new Vector2(1f, -2f);
				tempHexData.hexDataNumber = 6;
				tempHexData.hexDataPlayer = "None";
				tempHexData.hexDataPosition =
					new Vector3(tempHexData.hexDataGridLocation.x, tempHexData.hexDataGridLocation.y * VERTICAL_SEPARATION, 0f);
				tempHexData.hexDataResourceType = ResourceTypes.WOOD;
				tempHexData.hexDataNeighbors = CalcNeighbors(tempHexData.hexDataGridLocation);
				hexList.Add(tempHexData);
				break;
			} // end switch
			LogMapData(tempHexData);
		} // end for (int i = 1; i <= 19; i++)...

		if (MapIsValid())
			return hexList;
		else
			return null;
	} // end method LoadMapData

	public void LogMapData(HexDataScript pHexData)
	{
		string outputString;

		outputString = "Color: " + pHexData.hexDataColor.ToString() +
			" Name: " + pHexData.hexDataName.ToString() +
			" ID: " + pHexData.hexDataID.ToString() +
			" Grid Location: " + pHexData.hexDataGridLocation.ToString() +
			" Number: " + pHexData.hexDataNumber.ToString() +
			" Player: " + pHexData.hexDataPlayer.ToString() +
			" Resource: " + pHexData.hexDataResourceType.ToString() +
			" Position: " + pHexData.hexDataPosition.ToString() +
			" Neighbor 1: " + pHexData.hexDataNeighbors[0] +
			" Neighbor 5: " + pHexData.hexDataNeighbors[4];

		Debug.Log(outputString);
	} // end method LogMapData

	public Vector2[] CalcNeighbors(Vector2 pGridLocation)
	{
		Vector2[] tempNeighbors = new Vector2[6];

		tempNeighbors[0] = new Vector2(pGridLocation.x - 1f, pGridLocation.y);
		tempNeighbors[1] = new Vector2(pGridLocation.x - 0.5f, pGridLocation.y + 1f);
		tempNeighbors[2] = new Vector2(pGridLocation.x + 0.5f, pGridLocation.y + 1f);
		tempNeighbors[3] = new Vector2(pGridLocation.x + 1f, pGridLocation.y);
		tempNeighbors[4] = new Vector2(pGridLocation.x + 0.5f, pGridLocation.y - 1f);
		tempNeighbors[5] = new Vector2(pGridLocation.x - 0.5f, pGridLocation.y - 1f);
		return tempNeighbors;
	} // end method CalcNeighbors
	
	public bool HasANeighbor(HexDataScript pHexData)
	{
		const float MAX_VECTOR_DIFF = 0.01f;
		string outputString;
		
		foreach (HexDataScript hexData in hexList)
		{
			if (hexData.hexDataName != pHexData.hexDataName)
			{
				for (int i = 0; i < pHexData.hexDataNeighbors.Length; i++)
				{
					if ((hexData.hexDataGridLocation - pHexData.hexDataNeighbors[i]).magnitude < MAX_VECTOR_DIFF)
					{
						return true;
					}
				}
			}
		}
		
		outputString = "Hex name: " + pHexData.hexDataName.ToString() +
			" is not connected to any other Hex grids!";
		Debug.Log(outputString);
		return false;
	} // end method HasANeighbor
	
	public bool MapIsValid()
	{
		bool validMap = true;
		int[] hexNumberCount = new int[6];
		int[] hexResourceCount = new int[4];
		string outputString;
		int minResourceCount = 1000;
		int maxResourceCount = 0;
		int minNumberCount = 1000;
		int maxNumberCount = 0;

		for (int i = 0; i < hexNumberCount.Length; i++)
			hexNumberCount[i] = 0;
		for (int i = 0; i < hexResourceCount.Length; i++)
			hexResourceCount[i] = 0;

		foreach (HexDataScript hexData in hexList)
		{
			if (validMap)
			{
				if (!HasANeighbor(hexData))
				{
					validMap = false;
				}
				else if (hexData.hexDataNumber < 1 || hexData.hexDataNumber > 6)
				{
					outputString = "Hex name " + hexData.hexDataName.ToString() +
						" has an invalid Hex number: " + hexData.hexDataNumber.ToString();
					Debug.Log(outputString);
					validMap = false;
				}
				else
				{
					hexNumberCount[hexData.hexDataNumber - 1]++;
					switch (hexData.hexDataResourceType)
						{
							case ResourceTypes.BRICK:
								hexResourceCount[0]++;
								break;
							case ResourceTypes.GRAIN:
								hexResourceCount[1]++;
								break;
							case ResourceTypes.WOOD:
								hexResourceCount[2]++;
								break;
							case ResourceTypes.WOOL:
								hexResourceCount[3]++;
								break;
							default:
								outputString = "Hex name " + hexData.hexDataName.ToString() +
									" has an invalid resource type!";
								Debug.Log(outputString);
								validMap = false;
								break;
						} // end switch
				} // if (!HasANeighbor(hexData))...else...
			} // if (validMap)...
		} // foreach (HexDataScript hexData in hexList)...

		if (!validMap)
		{
			Debug.Log("This map is invalid!");
			return false;
		}

		for (int i = 0; i < hexResourceCount.Length; i++)
		{
			if (hexResourceCount[i] == 0)
			{
				switch (i)
				{
					case 0:
						outputString = "The Brick resource type is missing from the map!";
						break;
					case 1:
						outputString = "The Grain resource type is missing from the map!";
						break;
					case 2:
						outputString = "The Wood resource type is missing from the map!";
						break;
					case 3:
						outputString = "The Wool resource type is missing from the map!";
						break;
					default:
						outputString = "An unknown resource type is missing from the map!";
						break;
				} // end switch
				Debug.Log(outputString);
				Debug.Log("This map is invalid!");
				return false;
			}
			else
			{
				if (hexResourceCount[i] < minResourceCount)
					minResourceCount = hexResourceCount[i];
				if (hexResourceCount[i] > maxResourceCount)
					maxResourceCount = hexResourceCount[i];
			}
		} // end for (int i = 0; i < hexResourceCount.Length; i++)...

		if ((maxResourceCount - minResourceCount) > 1)
		{
			Debug.Log("The discrepancy between resources is too great!");
			Debug.Log("This map is invalid!");
			return false;
		}

		for (int i = 0; i < hexNumberCount.Length; i++)
		{
			if (hexNumberCount[i] < minNumberCount)
				minNumberCount = hexNumberCount[i];
			if (hexNumberCount[i] > maxNumberCount)
				maxNumberCount = hexNumberCount[i];
		}
		
		if ((maxNumberCount - minNumberCount) > 1)
		{
			Debug.Log("The discrepancy between hex numbers is too great!");
			Debug.Log("This map is invalid!");
			return false;
		}

		if (!validMap)
			Debug.Log("This map is invalid!");
		return validMap;
	} // end method MapIsValid

		// Use this for initialization
//	void Start () {
//	
//	}
	
	// Update is called once per frame
//	void Update () {
//	
//	}
} // end class MapDataScript
