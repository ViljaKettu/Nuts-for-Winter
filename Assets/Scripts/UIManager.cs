using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    GameObject[] pauseObjects;

    void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        HidePaused();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                ShowPaused();
            }
            else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                HidePaused();
            }
             
        }
    }

    public void Reload()
    {
        SceneManager.LoadScene("testi");
    }

    public void PauseControl()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            ShowPaused();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            HidePaused();
        }
    }

    public void ShowPaused()
    {
        foreach(GameObject button in pauseObjects)
        {
            button.SetActive(true);
        }
    }

    public void HidePaused()
    {
        foreach (GameObject button in pauseObjects)
        {
            button.SetActive(false);
        }
    }

    public void LoadLevel (string level)
    {
       SceneManager.LoadScene(level);
    }
}
