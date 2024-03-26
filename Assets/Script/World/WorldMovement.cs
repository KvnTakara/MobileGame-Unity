using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMovement : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.back * LevelManager.instance.levelSpeed * Time.deltaTime);
    }
}
