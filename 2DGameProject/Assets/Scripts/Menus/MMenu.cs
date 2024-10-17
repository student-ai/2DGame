using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MMenu : MonoBehaviour
{
    // send to main menu
    public void ToMM()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("MainMenu");
    }

    // send to Level Select
    public void ToLS()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("LevelSelect");
    }

    // quit application
    public void QuitApps()
    {
        Application.Quit();
    }

    // start game at level one
    public void StartOne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
    }

    // start game at level two
    public void StartTwo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1;
    }

    // start game at level three
    public void StartThree()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Level3");
        Time.timeScale = 1;
    }

    // start game at level four
    public void StartFour()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Level4");
        Time.timeScale = 1;
    }

    // start game at level five
    public void StartFive()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Level5");
        Time.timeScale = 1;
    }
}
