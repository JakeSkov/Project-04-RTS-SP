using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// @author Jake Skov
/// @desc 
/// </summary>
public class PlayerUIController : MonoBehaviour 
{
    public Text woodAmount;
    public Text brickAmount;
    public Text grainAmount;
    public Text sheepAmount;

    public int wood, brick, grain, sheep;

    public Button buildSettlement;
    public Button buildRoad;

    void Awake()
    {
        //Sets the buttons to noninteractable
        buildSettlement.interactable = false;
        buildRoad.interactable = false;
    }

	// Update is called once per frame
	void Update () 
    {
        UpdateUI();
        TestBuildables();
	}

    //Displays the players resources 
    void UpdateUI()
    {
        woodAmount.text = wood.ToString();
        brickAmount.text = brick.ToString();
        grainAmount.text = grain.ToString();
        sheepAmount.text = sheep.ToString();
    }

    void TestBuildables()
    {
        if (wood > 0 && brick > 0)
        {
            buildRoad.interactable = true;
        }
        else
        {
            buildRoad.interactable = false;
        }

        if (wood > 0 && brick > 0 && grain > 0 && sheep > 0)
        {
            buildSettlement.interactable = true;
        }
        else
        {
            buildSettlement.interactable = false;
        }
    }

    public void SettlementOnClick()
    {
            Debug.Log("Built Settlement");
            wood--;
            brick--;
            grain--;
            sheep--;

    }

    public void RoadOnClick()
    {
            Debug.Log("Built Road");
            wood--;
            brick--;

    }
}
