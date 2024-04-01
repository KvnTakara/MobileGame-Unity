using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public float worldSpeed, enemyDestroyed, entityHP, levelSpawnTimer;
    
    public float bulletDamage, bulletSpawnTimer, bulletSpeed, bulletRange;

    void Start()
    {
        worldSpeed = 3f;
        entityHP = 20f;
        levelSpawnTimer = 5f;

        bulletDamage = 1;
        bulletSpawnTimer = 0.3f;
        bulletSpeed = 30f;
        bulletRange = 20f;
    }
}
