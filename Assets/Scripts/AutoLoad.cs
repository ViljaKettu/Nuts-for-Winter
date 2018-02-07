//Vilja Kettunen
//TTK17SP1
//Nuts-For-Winter
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AutoLoad : MonoBehaviour
{
    public Image faderImage;
    public Animator anim;

    void Awake()
    {
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        yield return new WaitForSeconds(2);
        anim.SetBool("Fade", true);
        yield return new WaitUntil(()=>faderImage.color.a==1);
        SceneManager.LoadScene("Menu");
    }
}
