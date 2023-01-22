using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private float spawnRate = 1f;

    [SerializeField]
    private GameObject enemyPrefab;


    private void Start()
    {
        StartCoroutine(Spawner(spawnRate, enemyPrefab));
    }

    private IEnumerator Spawner(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(Spawner(interval, enemy));
    }
}
