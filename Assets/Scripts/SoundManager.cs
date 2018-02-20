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
    //public AudioSource deathSource;
    public AudioSource musicSource;
    public static SoundManager instance = null;

    PlayerHealth currentHealth;

    void Awake()
    {
        currentHealth = GetComponent<PlayerHealth>();

        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);


        DontDestroyOnLoad(this.gameObject);
    }



    //public void PlayCollect(AudioClip clip)
    //{
    //    collectSource.clip = clip;

    //    collectSource.Play();
    //}

    //public void PlayDeath(AudioClip clip)
    //{
    //    deathSource.clip = clip;

    //    deathSource.Play();
    //}
    //public void PlayHurt(AudioClip clip)
    //{
    //    hurtSource.clip = clip;

    //    hurtSource.Play();
    //}
}
