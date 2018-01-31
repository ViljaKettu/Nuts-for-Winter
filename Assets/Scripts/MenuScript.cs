//Vilja Kettunen
//TTK17SP1
//Nuts-For-Winter
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class MenuScript : MonoBehaviour
{
    public Image faderImade;
    public Animator anim;

    //Load first level
    public void OnClickPlay()
    {
        StartCoroutine(Fade());

    }

    //Quiting game
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    //Use to load scene by giving name in unity inspector
    public void LoadLevel(string level)
    {
        StartCoroutine(Fade());
        SceneManager.LoadScene(level);
    }

    IEnumerator Fade()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => faderImade.color.a == 1);
        SceneManager.LoadScene("testi");
    }
}

