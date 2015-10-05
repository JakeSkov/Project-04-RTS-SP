using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour 
{
    public void NewGameMenu()
    {
        Application.LoadLevel(1);
    }

    public void LoadGameMenu()
    {
        Application.LoadLevel(3);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
