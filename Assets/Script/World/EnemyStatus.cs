using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyStatus : MonoBehaviour
{
    public int enemyHP;
    public TextMeshPro hudHP;

    public bool bonusDamage;
    public bool bonusRate;
    public bool bonusRange;

    public float bonusValor;
    void Start()
    {

        enemyHP = (int)LevelManager.instance.entityHP;
        hudHP.text = enemyHP.ToString();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Bullet"))
        {
            enemyHP -= (int)LevelManager.instance.bulletDamage;
            hudHP.text = enemyHP.ToString();

            if (enemyHP <= 0)
            {
                ++LevelManager.instance.enemyDestroyed;
                LevelManager.instance.entityHP += LevelManager.instance.enemyDestroyed * 2f;

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

        if (collider.CompareTag("Player"))
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
