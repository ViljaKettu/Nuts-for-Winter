using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Slider healthSlider;

    Movement playerMovement;

    bool damaged;
    bool isDead;

    void Awake()
    {
        playerMovement = GetComponent<Movement>();

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
    }
}

