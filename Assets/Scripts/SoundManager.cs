//Vilja Kettunen
//TTK17SP1
//Nuts-For-Winter
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    public AudioSource collectSource;
    public AudioSource stepsSource;
    public AudioSource deathSource;
    public AudioSource musicSource;
    public static SoundManager instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        

        DontDestroyOnLoad(this.gameObject);
    }


    public void PlayCollect(AudioClip clip)
    {
        collectSource.clip = clip;

        collectSource.Play();
    }
    public void PlaySteps()
    {
        //stepsSource.clip = clip;

        stepsSource.Play();
    }
    public void PlayDeath(AudioClip clip)
    {
        deathSource.clip = clip;

        deathSource.Play();
    }

}
