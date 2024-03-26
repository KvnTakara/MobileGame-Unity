using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    

    void Update()
    {
        transform.Translate(Vector3.up * LevelManager.instance.bulletSpeed * Time.deltaTime);

        if (transform.position.z > LevelManager.instance.bulletRange)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
