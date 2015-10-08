using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameControlScript : MonoBehaviour {

	public GameObject hexPrefab;
	public GameObject settPrefab;

	private List<HexDataScript> hexList;
	private List<PlayerDataScript> playerList;
	private int settCount = 0;

	// Use this for initialization
	void Start () {
		HelperScript.playerCount = 0;
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

		GameObject newSettlement =
			(GameObject)Instantiate(settPrefab, new Vector3(0.5f, 0.25f, 0f), Quaternion.Euler(-90, 0, 0));
		settCount++;
		newSettlement.name = "Settlement" + settCount.ToString();
		newSettlement.GetComponent<SettPrefabData>().SetSettName(newSettlement.name);
		newSettlement.GetComponent<SettPrefabData>().SetSettNumber(settCount);
		newSettlement.GetComponent<SettPrefabData>().SetSettColor(playerList[0].playerColor);
	} // end method Start

	public void AddSettlement(string pHexPrefabName)
	{
		Vector3 UROffset = new Vector3(0.5f, 0.25f, 0f);

		foreach (HexDataScript hexData in hexList)
		{
			if (hexData.hexDataName == pHexPrefabName)
			{
				GameObject newSettlement =
					(GameObject)Instantiate(settPrefab, hexData.hexDataPosition + UROffset, Quaternion.Euler(-90, 0, 0));
				settCount++;
				newSettlement.name = "Settlement" + settCount.ToString();
				newSettlement.GetComponent<SettPrefabData>().SetSettName(newSettlement.name);
				newSettlement.GetComponent<SettPrefabData>().SetSettNumber(settCount);
				newSettlement.GetComponent<SettPrefabData>().SetSettColor(playerList[0].playerColor);
			}
		}
	} // end method AddSettlement

	// Update is called once per frame
//	void Update () {
//	
//	}
} // end class GameControlScript
