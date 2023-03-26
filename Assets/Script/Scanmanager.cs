using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scanmanager : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void ExitGame()
    {
        Application.Quit();
    }
}
