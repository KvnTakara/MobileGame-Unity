using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntitySpawner : MonoBehaviour
{
    public List<GameObject> entityPrefabs = new List<GameObject>();
    int[] spawnPositionX;

    void Start()
    {
        spawnPositionX = new int[2];
        spawnPositionX[0] = -2;
        spawnPositionX[1] = 2;

        StartCoroutine(spawn(LevelManager.instance.levelSpawnTimer));
    }

    IEnumerator spawn(float time)
    {
        GameObject randomPrefab = entityPrefabs[Random.Range(0, entityPrefabs.Count)];
        float randomIndex = Random.Range(0f, 1f);
        int index = (randomIndex < 0.5f) ? 0 : 1;
        Vector3 instancePosition = new Vector3(spawnPositionX[index], transform.position.y, transform.position.z);
        GameObject randomInstance = Instantiate(randomPrefab, instancePosition, Quaternion.identity);
        yield return new WaitForSeconds(time);

        StartCoroutine(spawn(LevelManager.instance.levelSpawnTimer));
    }
}
