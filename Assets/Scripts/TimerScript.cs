//Vilja Kettunen
//TTK17SP1
//Nuts-For-Winter
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    static float timeLeft = 10.0f;
    bool timerIsOn = true;
    public Text timeText;

    public Image faderImage;
    public Animator anim;

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
        else
        {
            StartCoroutine(Fade());
        }
    }

    void OnGUI()
    {
        if (timeLeft <= 0)
        {
            timerIsOn = false;
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

}
