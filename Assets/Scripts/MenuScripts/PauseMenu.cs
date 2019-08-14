using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused = false;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }
    public void TogglePause()
    {
        //defines the pause button as something that opens up and closes the pause menu
        if (isPaused)
        {
            Time.timeScale = 1;
            //unpauses the game and gets rid of the pause menu
            pauseMenu.SetActive(false);
            isPaused = false;
            return;
        }
        else
        {
            Time.timeScale = 1;
            //pauses the game and brings up the pause menu
            pauseMenu.SetActive(true);
            isPaused = true;
            return;
        }
    }
}
