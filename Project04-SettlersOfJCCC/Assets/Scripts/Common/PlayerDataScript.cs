using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerDataScript
{
// ALSO NEED:
	// list of player settlements
	// list of player roads
	// list of player resources

	public string playerName;
	public int playerNumber;
	public string playerPhase;
	public string playerColor;
	public List<HexDataScript> playerHexList;

	// Use this for initialization
	//	void Start () {
	//	
	//	}
	
	// Update is called once per frame
	//	void Update () {
	//	
	//	}

	public void LogPlayerData()
	{
		string outputString;
		
		outputString = "Player name: " + playerName.ToString() +
				" Number: " + playerNumber.ToString() +
				" Color: " + playerColor.ToString() +
				" Phase: " + playerPhase.ToString() +
				" Hex Count: " + playerHexList.Count.ToString();

		Debug.Log(outputString);
	} // end method LogPlayerData
} // end class PlayerDataScript
