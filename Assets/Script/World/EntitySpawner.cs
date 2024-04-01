using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum SpawnMode { enemy, upgrade };

public class EntitySpawner : MonoBehaviour
{
    public List<GameObject> enemyPrefabs = new List<GameObject>();
    int[] spawnPositionX;

    public List<GameObject> upgradePrefabs = new List<GameObject>();

    SpawnMode spawnMode;

    void Start()
    {
        spawnPositionX = new int[3];
        spawnPositionX[0] = -4;
        spawnPositionX[1] = 0;
        spawnPositionX[2] = 4;

        StartCoroutine(spawn(LevelManager.instance.levelSpawnTimer));
    }

    IEnumerator spawn(float time)
    {
        if (spawnMode == SpawnMode.enemy)
        {
            GameObject randomPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Count)];
            int randomIndex = Random.Range(0, spawnPositionX.Length);
            Vector3 instancePosition = new Vector3(spawnPositionX[randomIndex], transform.position.y, transform.position.z);
            GameObject randomInstance = Instantiate(randomPrefab, instancePosition, Quaternion.identity);

            spawnMode = SpawnMode.upgrade;
        }
        else
        {
            GameObject randomPrefab = upgradePrefabs[Random.Range(0, upgradePrefabs.Count)];
            int randomIndex = Random.Range(0, spawnPositionX.Length);
            Vector3 instancePosition = new Vector3(spawnPositionX[randomIndex], transform.position.y, transform.position.z);
            GameObject randomInstance = Instantiate(randomPrefab, instancePosition, Quaternion.identity);

            spawnMode = SpawnMode.enemy;
        }

        yield return new WaitForSeconds(time);

        StartCoroutine(spawn(LevelManager.instance.levelSpawnTimer));
    }
}
