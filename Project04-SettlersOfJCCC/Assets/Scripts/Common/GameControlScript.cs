using UnityEngine;
using System.Collections;

public class GameControlScript : MonoBehaviour {

	public GameObject hexPrefab;

	// Use this for initialization
	void Start () {
		for (int i = -5; i < 6; i++)
		{
			GameObject newHex = (GameObject)Instantiate(hexPrefab, new Vector3(i, 0, 0), Quaternion.identity);
			newHex.name = "HexNumber" + (i + 6).ToString();
			newHex.GetComponent<HexPrefabData>().SetHexName(newHex.name);
		}
	}
	
	// Update is called once per frame
//	void Update () {
//	
//	}
} // end class GameControlScript
