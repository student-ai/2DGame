using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if "Esc" is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                // make menu visible
                GetComponent<Canvas>().enabled = true;
                // also stop game from playing
                Time.timeScale = 0;
            }
            else
            {
                Resume();
            }
        }
    }

    public void Resume()
    {
        // make menu invisable
        GetComponent <Canvas>().enabled = false;
        // reset timescale
        Time.timeScale = 1;
    }

    public void Retry()
    {
        // resume time
        Time.timeScale = 1;
        // reload active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        //quit Application
        Application.Quit();
    }
}
