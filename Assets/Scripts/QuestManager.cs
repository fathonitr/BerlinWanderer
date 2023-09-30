using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestManager : MonoBehaviour
{
    public GameObject Event1;

    public void OpenInfoScroll()
    {
        if (Event1.activeSelf == false)
        {
            Event1.SetActive(true);
        }
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CloseInfo()
    {
        Event1.SetActive(false);
    }
}