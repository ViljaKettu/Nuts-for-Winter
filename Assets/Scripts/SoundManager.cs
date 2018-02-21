//Vilja Kettunen
//TTK17SP1
//Nuts-For-Winter
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    //public AudioSource collectSource;
    //public AudioSource hurtSource;
    public AudioSource deathSource;
    public AudioSource source;
    public static SoundManager instance = null;

    private AudioClip music;
    private AudioClip death;

    void Awake()
    {

        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        PlayMenuMusic();
        DontDestroyOnLoad(this.gameObject);
    }


    public void PlayMenuMusic()
    {
        if(instance != null)
        {
            if (instance.source!= null)
            {
                instance.deathSource.Stop();
                instance.source.Play();
            }
        }
    }

    public void PlayEndMusic()
    {
        if(instance != null)
        {
            if (instance.deathSource != null)
            {
                instance.source.Stop();
                instance.deathSource.Play();
            }
        }
       
    }
}
