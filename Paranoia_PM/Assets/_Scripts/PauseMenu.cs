using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
	
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else 
            {
                Pause();
            }

        }
	}

    public void Resume () 
    {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
    }

    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        GameIsPaused = true;
    }

    public void LoadMenu ()
    {
        Debug.Log("Loading Menu.");
    }

    public void QuitGame ()
    {
        Debug.Log("Quitting the Game.");
    }
}
