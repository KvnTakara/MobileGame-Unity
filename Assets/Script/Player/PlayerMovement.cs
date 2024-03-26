using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed = 5f;

    void Update()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            MoveLeft();
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            MoveRight();
        }
    }

    public void MoveLeft()
    {
        if (transform.position.x < -4) return;
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    public void MoveRight()
    {
        if (transform.position.x > 4) return;
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
