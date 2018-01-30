//Vilja Kettunen
//TTK17SP1
//Nuts-For-Winter
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    static float timeLeft = 5.0f;
    bool timerIsOn = true;

    private void Awake()
    {
        ResetTime();
    }

    void Update()
    {
        if (timerIsOn)
        {
            timeLeft -= Time.deltaTime;
        }

    }

    void OnGUI()
    {
        if (timeLeft <= 0)
        {
            timerIsOn = false;
            StartCoroutine(Wait());
            SceneManager.LoadScene("Menu");
        }
        if (timerIsOn)
        {
            int minutes = Mathf.FloorToInt(timeLeft / 60F);
            int seconds = Mathf.FloorToInt(timeLeft - minutes * 60);
            string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 8, 100, 100), "Time Left:" + niceTime);
        }
    }

    public void ResetTime()
    {
        timeLeft = 5.0f;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
    }
}
