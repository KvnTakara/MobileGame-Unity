using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(this);
    }

    public float levelSpeed;

    public float bulletSpawnTimer, bulletSpeed, bulletRange;

    void Start()
    {
        levelSpeed = 10f;

        bulletSpawnTimer = 0.25f;
        bulletSpeed = 20f;
        bulletRange = 20f;
    }
}
