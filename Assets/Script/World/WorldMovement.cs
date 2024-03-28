using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMovement : MonoBehaviour
{
    void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.Translate(Vector3.back * LevelManager.instance.worldSpeed * Time.deltaTime);
    }
}
