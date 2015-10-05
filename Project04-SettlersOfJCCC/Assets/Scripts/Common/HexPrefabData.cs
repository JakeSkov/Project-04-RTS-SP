using UnityEngine;
using System.Collections;

public class HexPrefabData : MonoBehaviour {

	public string hexName;
	public int hexNumber;
	public ResourceTypes hexResourceType;

	// Use this for initialization
	void Start ()
	{
		int tempHexNumber = Random.Range(1, 7);
		SetHexNumber(tempHexNumber);
		ResourceTypes tempResourceType =
			(ResourceTypes)Random.Range((int)ResourceTypes.GRAIN, (int)ResourceTypes.WOOL + 1);
		SetHexResourceType(tempResourceType);
	}
	
	// Update is called once per frame
//	void Update () {
//	
//	}
	
	public void SetHexName(string pHexName)
	{
		hexName = pHexName;
	}
	
	public void SetHexNumber(int pHexNumber)
	{
		hexNumber = pHexNumber;
		GetComponentInChildren<HexNumberHandlerScript>().SetHexNumberText(pHexNumber);
	}
	
	public void SetHexResourceType(ResourceTypes pResourceType)
	{
		hexResourceType = pResourceType;
		GetComponentInChildren<BackgroundHandlerScript>().SetBackgroundImage(pResourceType);
	}
}// end class HexPrefabData
