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
    //public AudioSource deathSource;

    SoundManager source;

    void Awake()
    {
        source = FindObjectOfType(typeof(SoundManager)) as SoundManager;
        source.PlayEndMusic();
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        //deathSource.Play();
        yield return new WaitForSeconds(2);
        anim.SetBool("Fade", true);
        yield return new WaitUntil(()=>faderImage.color.a==1);
        SceneManager.LoadScene("Menu");
    }
}
