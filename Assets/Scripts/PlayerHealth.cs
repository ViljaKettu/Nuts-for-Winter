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

    Movement playerMovement;
    SceneFader fader;

    bool damaged;
    bool isDead;

    void Awake()
    {
        playerMovement = GetComponent<Movement>();
        fader = GetComponent<SceneFader>();
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
        //stopping movement
        playerMovement.enabled = false;
        StartCoroutine(Wait());
        SceneManager.LoadScene("GameOver");
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
    }
}


