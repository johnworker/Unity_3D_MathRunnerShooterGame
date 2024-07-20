using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 3.0f;
    public Transform[] spawnPoints;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnInterval, spawnInterval);
    }

    void SpawnEnemy()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemyPrefab, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
    }
}
