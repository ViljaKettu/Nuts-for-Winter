using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    public float speed = 2.0f;

    void Update()
    {
        float interpolation = speed * Time.deltaTime;

        Vector3 position = this.transform.position;
        position.y = Mathf.Lerp(this.transform.position.y, player.transform.position.y, interpolation);
        position.x = Mathf.Lerp(this.transform.position.x, player.transform.position.x, interpolation);

        this.transform.position = position;
    }
}
