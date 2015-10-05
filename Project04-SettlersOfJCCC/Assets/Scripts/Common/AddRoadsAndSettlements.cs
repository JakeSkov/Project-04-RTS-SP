using UnityEngine;
using System.Collections;
//using UnityEngine.Events;
//using UnityEngine.EventSystems;

public class AddRoadsAndSettlements : MonoBehaviour {

	private string outputString;
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
	}
	
	// Use this for initialization
//	void Start () {
//		
//	}
	
	// Update is called once per frame
//	void Update () {
//	
//	}
} // end class AddRoadsAndSettlements
