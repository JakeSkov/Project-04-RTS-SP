using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameControlScript : MonoBehaviour {

	public GameObject hexPrefab;

	private List<HexDataScript> hexList;

	// Use this for initialization
	void Start () {
//		gameObject.GetComponent<MapDataScript>().LoadMapData();
		hexList = gameObject.GetComponent<MapDataScript>().LoadMapData();

		foreach (HexDataScript hexData in hexList)
		{
			GameObject newHex = (GameObject)Instantiate(hexPrefab, hexData.hexDataPosition, Quaternion.identity);
			newHex.name = hexData.hexDataName;
			newHex.GetComponent<HexPrefabData>().SetHexName(newHex.name);
			newHex.GetComponent<HexPrefabData>().SetHexNumber(hexData.hexDataNumber);
			newHex.GetComponent<HexPrefabData>().SetHexResourceType(hexData.hexDataResourceType);
		}

//		for (int i = -5; i < 6; i++)
//		{
//			GameObject newHex = (GameObject)Instantiate(hexPrefab, new Vector3(i, 0, 0), Quaternion.identity);
//			newHex.name = "HexNumber" + (i + 6).ToString();
//			newHex.GetComponent<HexPrefabData>().SetHexName(newHex.name);
//		}
	}
	
	// Update is called once per frame
//	void Update () {
//	
//	}
} // end class GameControlScript
