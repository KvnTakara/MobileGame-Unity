using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public GameObject bullet;

    void Start()
    {
        StartCoroutine(Shoot(LevelManager.instance.bulletSpawnTimer));
    }

    IEnumerator Shoot(float time)
    {
        GameObject bulletInstance = Instantiate(bullet, transform.position, Quaternion.Euler(new Vector3(90,0,0)));

        yield return new WaitForSeconds(time);
        StartCoroutine(Shoot(LevelManager.instance.bulletSpawnTimer));
    }
}
