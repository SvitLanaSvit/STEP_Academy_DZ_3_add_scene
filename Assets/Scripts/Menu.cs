using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    public void ExitGame()
    {
        Application.Quit();
    }

    public void GetInfo()
    {
        SceneManager.LoadScene(4);
    }

    public void ExitFromInfo()
    {
        SceneManager.LoadScene(0);
    }
}
