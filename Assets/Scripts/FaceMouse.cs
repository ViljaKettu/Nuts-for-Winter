//Vilja Kettunen
//TTK17SP1
//Nuts-For-Winter
using UnityEngine;

public class FaceMouse : MonoBehaviour
{
  void Update()
    {
        LookAtMouse();
    }

    void LookAtMouse()
    {
        if(Time.timeScale == 1)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

            transform.up = direction;
        }

    }

}