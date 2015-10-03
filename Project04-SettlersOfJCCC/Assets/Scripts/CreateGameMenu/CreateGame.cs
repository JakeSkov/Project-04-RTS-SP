using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CreateGame : MonoBehaviour 
{
    void Awake()
    {
        GameObject.Find("btn_Continue").GetComponent<Button>().enabled = false;
    }

    public void SelectedLevel()
    {
        GameObject.Find("btn_Continue").GetComponent<Button>().enabled = true;
    }

    public void BackToMain()
    {
        Application.LoadLevel(0);
    }

    public void InformationMenu()
    {
        CreateDataScript.ShowWindow();
    }
}
