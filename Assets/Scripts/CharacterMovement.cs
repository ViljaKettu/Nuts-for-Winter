using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMovement : MonoBehaviour
{
    public float speed;
    public Text ScoreText;
    public Text WinText;

    private Rigidbody2D rb2d;
    private int count;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        SetScoreText();
        WinText.text = ""; //Valinnainen
        //Hahmo ei ala pyöriä törmätessään asioihin.
        rb2d.freezeRotation = true;
    }

    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (moveHorizontal == 0)
        {
        }
        else if (moveHorizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else if (moveHorizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }

        if (moveVertical == 0)
        {
        }
        else if (moveVertical < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, -180);
        }
        else if (moveVertical > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb2d.velocity = movement * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetScoreText();
        }
    }

    void SetScoreText()
    {
        ScoreText.text = "Count: " + count.ToString();

        if (count >= 7) //Valinnainen
        {
            WinText.text = "You win!";
        }
    }
}
