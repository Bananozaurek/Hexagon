using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class endMenu : MonoBehaviour
{
    public static bool gameEnd = false;

    public GameObject MenuUI;

    // Update is called once per frame
    void Update()
    {
        if(gameEnd==true)
        {
            Pause();
        }
    }

    void Pause()
    {
        MenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Restart()
    {
        gameEnd = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Player.points = 0;
    }
    public void MainMenu()
    {
        Debug.Log("MAIN MENU");
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        gameEnd = false;
        Player.points = 0;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
