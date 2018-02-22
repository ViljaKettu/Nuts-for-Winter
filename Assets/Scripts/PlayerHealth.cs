//Vilja Kettunen
//TTK17SP1
//Nuts-For-Winter
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Slider healthSlider;

    public AudioSource collectSource;
    //public AudioSource hurtSource;

    CharacterMovement playerMovement;
    SceneFader fadeScene;

    public Image faderImage;
    public Animator anim;

    bool damaged;
    bool isDead = false;

    void Awake()
    {
        playerMovement = FindObjectOfType(typeof(CharacterMovement)) as CharacterMovement;
        fadeScene = GetComponent<SceneFader>();
        
        //setting players starting health
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        damaged = true;

        currentHealth -= amount;

        healthSlider.value = currentHealth;

        if (currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }

    //When player dies
    void Death()
    {
        isDead = true;

        playerMovement.speed = 0;
        StartCoroutine(Fade());
    }


    IEnumerator Fade()
    {
        yield return new WaitForSeconds(1);
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => faderImage.color.a == 1);
        SceneManager.LoadScene("GameOver");
    }
}


