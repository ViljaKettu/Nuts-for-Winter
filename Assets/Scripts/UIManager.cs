//Vilja Kettunen
//TTK17SP1
//Nuts-For-Winter
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
        //checking if pause has been pushed to pause
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //checking timeScale to see if scene is pauset or not
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

    // script for using pause button to unpause
    public void PauseControl()
    {
        if (Time.timeScale == 0)
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
}
