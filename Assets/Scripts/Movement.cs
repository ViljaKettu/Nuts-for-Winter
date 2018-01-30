//Vilja Kettunen
//TTK17SP1
//Nuts-For-Winter
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rbod;

    void Start()
    {
        rbod = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rbod.velocity = movement * speed;
    }

}

