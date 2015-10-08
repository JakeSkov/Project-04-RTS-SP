using UnityEngine;
using System.Collections;
//using UnityEngine.Events;
//using UnityEngine.EventSystems;

public class AddRoadsAndSettlements : MonoBehaviour {

	private string outputString;
	private GameControlScript gameControlScript;
//	private PointerEventData buttonData;
//	private GameObject parentObject;

	public void OnMouseDown()
	{
		outputString = "Parent Name: " + gameObject.GetComponentInParent<HexPrefabData>().name
			+ "  Side: " + gameObject.name + " was clicked!";
//		outputString = gameObject.name + ": Mouse was clicked!";
//		outputString = gameObject.name + ": " + gameObject.transform.localScale.ToString();
//		buttonData = UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData;
//			PointerInputModule.MouseButtonEventData;
//		PointerEventData
//		outputString = gameObject.name + ": " + buttonData;
		Debug.Log(outputString);

		if (gameObject.name == "URVertex")
		{
			gameControlScript.AddSettlement(gameObject.GetComponentInParent<HexPrefabData>().name);
		}
	}
	
	// Use this for initialization
	void Start () {
		gameControlScript = Camera.main.GetComponent<GameControlScript>();
	}
	
	// Update is called once per frame
//	void Update () {
//	
//	}
} // end class AddRoadsAndSettlements
