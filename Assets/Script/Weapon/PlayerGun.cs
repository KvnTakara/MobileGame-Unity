using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    GameObject bullet;

    void Start()
    {
        bullet = Resources.Load<GameObject>("Prefabs/Bullet");

        StartCoroutine(Shoot(LevelManager.instance.bulletSpawnTimer));
    }

    IEnumerator Shoot(float time)
    {
        float instancePositionX = transform.position.x + Random.Range(-0.1f, 0.1f);
        float instancePositionY = transform.position.y + Random.Range(-0.1f, 0.1f);
        Vector3 instancePosition = new Vector3(instancePositionX, instancePositionY, transform.position.z);

        GameObject bulletInstance = Instantiate(bullet, instancePosition, Quaternion.Euler(new Vector3(90,0,0)));

        yield return new WaitForSeconds(time);
        StartCoroutine(Shoot(LevelManager.instance.bulletSpawnTimer));
    }
}
