using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneMenu : MonoBehaviour {


    public void Backtomenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void Startgame()
    {
        SceneManager.LoadScene("ARTattooNew");
    }

    public void Exitgame()
    {
        Application.Quit();
        Debug.Log("Exit button pressed.");
    }
}
