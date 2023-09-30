using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        // load next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitApp()
    {
        Application.Quit();
    }

    public GameObject pauseMenuUI;

    // pause menu
    public void OpenMenu()
    {
        pauseMenuUI.SetActive(true);
    }

    public void CloseMenu()
    {
        pauseMenuUI.SetActive(false);
    }

}
