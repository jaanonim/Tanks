using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {

    // Use this for initialization
    public static bool IsPause = false;

    public GameObject menu;
    public GameObject load;
    public GameObject settings;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }

            
        }
    }

    public void Resume()
    {
        IsPause = false;
        menu.SetActive(false);
        settings.SetActive(false);
        Time.timeScale = 1;
    }
    public void Pause()
    {
        IsPause = true;
        menu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Garage()
    {
        load.SendMessage("loadlewel", "garage");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Settings()
    {
        settings.SetActive(true);
    }

}
