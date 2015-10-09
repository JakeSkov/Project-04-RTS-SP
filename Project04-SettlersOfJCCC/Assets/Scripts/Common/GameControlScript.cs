// GameControlScript.cs
// Author: Craig Broskow
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameControlScript : MonoBehaviour {

	public GameObject hexPrefab;
	public GameObject settPrefab;

	private List<HexDataScript> hexList;
	private List<PlayerDataScript> playerList;
	private List<SettDataScript> settList;

	// Use this for initialization
	void Start () {
		hexList = gameObject.GetComponent<MapDataScript>().LoadMapData();

		if (hexList != null)
		{
			foreach (HexDataScript hexData in hexList)
			{
				GameObject newHex = (GameObject)Instantiate(hexPrefab, hexData.hexDataPosition, Quaternion.identity);
				newHex.name = hexData.hexDataName;
				newHex.GetComponent<HexPrefabData>().SetHexName(newHex.name);
				newHex.GetComponent<HexPrefabData>().SetHexNumber(hexData.hexDataNumber);
				newHex.GetComponent<HexPrefabData>().SetHexResourceType(hexData.hexDataResourceType);
			}
		}

		playerList = new List<PlayerDataScript>();

		PlayerDataScript tempPlayerData = new PlayerDataScript();
		tempPlayerData.playerColor = "Yellow";
		tempPlayerData.playerHexList = new List<HexDataScript>();
		tempPlayerData.playerName = "Test Player";
		tempPlayerData.playerNumber = playerList.Count + 1;
		tempPlayerData.playerPhase = "Phase0";
		playerList.Add(tempPlayerData);

		Debug.Log("Player Count: " + playerList.Count.ToString());
		foreach (PlayerDataScript playerData in playerList)
		{
			playerData.LogPlayerData();
		}

		settList = new List<SettDataScript>();
	} // end method Start

	public void AddSettlement(string pHexPrefabName, string vertexName)
	{
		bool foundHex = false;
		bool validVertex = true;
		bool lowVertex = true;
		string outputString;
		string settlementName;
		Vector3 vertexPosition = new Vector3(-100f, 100f, 0f);
		Vector3 vertexOffset;
		SettDataScript tempSettlementData;

		settlementName = "Settlement" + (settList.Count + 1).ToString();
		switch (vertexName)
		{
			case "TopVertex":
				vertexOffset = new Vector3(0f, 0.5546875f, 0f);
				lowVertex = true;
				break;
			case "URVertex":
				vertexOffset = new Vector3(0.5f, 0.3046875f, 0f);
				lowVertex = false;
				break;
			case "LRVertex":
				vertexOffset = new Vector3(0.5f, -0.3046875f, 0f);
				lowVertex = true;
				break;
			case "BottomVertex":
				vertexOffset = new Vector3(0f, -0.5546875f, 0f);
				lowVertex = false;
				break;
			case "LLVertex":
				vertexOffset = new Vector3(-0.5f, -0.3046875f, 0f);
				lowVertex = true;
				break;
			case "ULVertex":
				vertexOffset = new Vector3(-0.5f, 0.3046875f, 0f);
				lowVertex = false;
				break;
			default:
				validVertex = false;
				vertexOffset = new Vector3(-100f, 100f, 0f);
				outputString = "GameControlScript method AddSettlement was passed " +
					"the following invalid vertex name: " + vertexName;
				Debug.Log(outputString);
				break;
		} // end switch

		if (!validVertex)
			return;

		foreach (HexDataScript hexData in hexList)
		{
			if (!foundHex && hexData.hexDataName == pHexPrefabName)
			{
				Vector3 newPosition = hexData.hexDataPosition + vertexOffset;
				if (!SettPositionEmpty(newPosition))
				{
					return;
				}
				else
				{
					GameObject newSettlement = (GameObject)Instantiate(settPrefab, newPosition,
						Quaternion.Euler(-90, 0, 0));
	//					hexData.hexDataPosition + vertexOffset, Quaternion.Euler(-90, 0, 0));
					newSettlement.name = settlementName;
					newSettlement.GetComponent<SettPrefabData>().SetSettName(newSettlement.name);
					newSettlement.GetComponent<SettPrefabData>().SetSettNumber(settList.Count + 1);
					newSettlement.GetComponent<SettPrefabData>().SetSettColor(playerList[0].playerColor);
					vertexPosition = newSettlement.transform.position;
					foundHex = true;
				}
			}
		}

		tempSettlementData = new SettDataScript();
		tempSettlementData.settDataName = settlementName;
		tempSettlementData.settDataNumber = settList.Count + 1;
		tempSettlementData.settDataColor = playerList[0].playerColor;
		tempSettlementData.settDataPosition = vertexPosition;
		tempSettlementData.settDataPlayer = playerList[0].playerName;
		tempSettlementData.settHexNeighbors = CalcHexNeighbors(vertexPosition, lowVertex);
		settList.Add(tempSettlementData);

		Debug.Log("Settlement Count: " + settList.Count.ToString());
		tempSettlementData.LogSettlementData();
	} // end method AddSettlement

	private bool SettPositionEmpty(Vector3 pNewPosition)
	{
		const float MAX_VECTOR_DIFF = 0.01f;
		string outputString;

		if (settList.Count == 0)
			return true;
		foreach (SettDataScript settData in settList)
		{
			if ((settData.settDataPosition - pNewPosition).magnitude < MAX_VECTOR_DIFF)
			{
				outputString = "Settlement position is already occupied!";
				Debug.Log(outputString);
				return false;
			}
		}
		
		return true;
	} // end method SettPositionEmpty
	
	private int[] CalcHexNeighbors(Vector3 pSettDataPosition, bool lowVertex)
	{
		const float MAX_VECTOR_DIFF = 0.01f;
		int[] tempNeighbors = new int[3];
		Vector3[] tempHexPositions = new Vector3[3];

		if (lowVertex)
		{
			tempHexPositions[0] = pSettDataPosition + new Vector3(0f, -0.5546875f, 0f);
			tempHexPositions[1] = pSettDataPosition + new Vector3(0.5f, 0.3046875f, 0f);
			tempHexPositions[2] = pSettDataPosition + new Vector3(-0.5f, 0.3046875f, 0f);
		}
		else
		{
			tempHexPositions[0] = pSettDataPosition + new Vector3(0f, 0.5546875f, 0f);
			tempHexPositions[1] = pSettDataPosition + new Vector3(0.5f, -0.3046875f, 0f);
			tempHexPositions[2] = pSettDataPosition + new Vector3(-0.5f, -0.3046875f, 0f);
		}

		for (int i = 0; i < 3; i++)
		{
			tempNeighbors[i] = 0;
			foreach (HexDataScript hexData in hexList)
			{
				if ((hexData.hexDataPosition - tempHexPositions[i]).magnitude < MAX_VECTOR_DIFF)
				{
					tempNeighbors[i] = hexData.hexDataID;
					Debug.Log("Matching Hex positions: ");
					Debug.Log(hexData.hexDataPosition.ToString());
					Debug.Log(tempHexPositions[i].ToString());
				}
			}
		}
		return tempNeighbors;
	} // end method CalcHexNeighbors

	// Update is called once per frame
//	void Update () {
//	
//	}
} // end class GameControlScript
