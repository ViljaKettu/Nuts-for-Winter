//Vilja Kettunen
//TTK17SP1
//Nuts-For-Winter
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    GameObject[] pauseObjects;

    void Start()
    {
        ResetTime();
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        HidePaused();
    }

    static float timeLeft = 10.0f;
    bool timerIsOn = true;
    public Text timeText;

    public Image faderImage;
    public Animator anim;


    void OnGUI()
    {
        if (timeLeft <= 0)
        {
            timerIsOn = false;
            StartCoroutine(Fade());
            //SceneManager.LoadScene("GameOver");
        }
        else if (timerIsOn)
        {
            int minutes = Mathf.FloorToInt(timeLeft / 60F);
            int seconds = Mathf.FloorToInt(timeLeft - minutes * 60);
            string styleTime = string.Format("{0:0}:{1:00}", minutes, seconds);
            timeText.text = styleTime;
            //GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 8, 100, 100), "Time Left:" + styleTime);
        }
    }

    IEnumerator Fade()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => faderImage.color.a == 1);
        SceneManager.LoadScene("GameOver");
    }

    public void ResetTime()
    {
        timeLeft = 5.0f;
    }

    void Update()
    {
        if (timerIsOn)
        {
            timeLeft -= Time.deltaTime;
        }

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
