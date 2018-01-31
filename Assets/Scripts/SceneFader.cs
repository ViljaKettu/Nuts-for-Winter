//Vilja Kettunen
//TTK17SP1
//Nuts-For-Winter
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneFader : MonoBehaviour
{
    public Image faderImage;
    public Animator anim;

    public void FadeScene()
    {
        StartCoroutine(Fade());

    }

    IEnumerator Fade()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => faderImage.color.a == 1);
        SceneManager.LoadScene("GameOver");
    }
}

