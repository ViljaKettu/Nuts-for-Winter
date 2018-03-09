//Vilja Kettunen
//TTK17SP1
//Nuts-For-Winter
using UnityEngine;

public class EnemyAttack : MonoBehaviour

    // made by Kiia & Vilja
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
        //damaging player 
        if (playerInRange)
        {
            if (playerHealth.currentHealth > 0)
            {
                playerHealth.TakeDamage(attackDamage);
            }
        }
    }
}