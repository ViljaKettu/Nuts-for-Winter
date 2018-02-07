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

        Vector2 moveDirection = rbod.velocity;
        if(moveDirection != Vector2.zero)
        {
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rbod.velocity = movement * speed;
    }

}

