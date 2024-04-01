using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UpgradeStatus : MonoBehaviour
{
    public bool bonusDamage;
    public bool bonusRate;
    public bool bonusRange;

    public float bonusValor;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            if (bonusDamage)
            {
                LevelManager.instance.bulletDamage += bonusValor;
            }
            if (bonusRate)
            {
                LevelManager.instance.bulletSpawnTimer += -bonusValor * LevelManager.instance.bulletSpawnTimer;
                LevelManager.instance.bulletSpeed += bonusValor * 2;
            }
            if (bonusRange)
            {
                LevelManager.instance.bulletRange += bonusValor;
            }

            Destroy(transform.parent.gameObject);
        }
    }
}
