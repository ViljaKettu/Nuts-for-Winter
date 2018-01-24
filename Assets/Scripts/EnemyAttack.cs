using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int attackDamage = 10;

    GameObject player;
    PlayerHealth playerHealth;
    bool playerInRange;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            playerInRange = true;
            playerHealth.TakeDamage(attackDamage);
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            playerInRange = false;
        }
    }

    void Update()
    {
        if (playerInRange)
        {
            if (playerHealth.currentHealth > 0)
            {
                playerHealth.TakeDamage(attackDamage);
            }
        }
    }
}