//Vilja Kettunen
//TTK17SP1
//Nuts-For-Winter
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed, moveHor, moveVer;
    AudioClip footsteps;
    AudioSource source;
    private Rigidbody2D rbod;

    void Start()
    {
        rbod = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {

        Vector2 moveDirection = rbod.velocity;
        if(moveDirection != Vector2.zero)
        {
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

        moveHor = Input.GetAxis("Horizontal");
        moveVer = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHor, moveVer);

        rbod.velocity = movement * speed;

        PlaySteps();
    }

    public void PlaySteps()
    {
        if (!source.isPlaying)
        {
            if (Mathf.Abs(moveHor) > 0 || Mathf.Abs(moveVer) > 0)
            {
                source.Play();
            }
        }
        else if (moveHor == 0 && moveVer == 0)
        {
            source.Stop();
        }
    }
}

