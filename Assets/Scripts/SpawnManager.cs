using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private float _spawnInterval = 2f;

    private bool isSpawning = true;

    private void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    private IEnumerator SpawnLoop()
    {
        while (isSpawning)
        {
            var randomSpawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
            randomSpawnPoint.SpawnEnemy();

            yield return new WaitForSeconds(_spawnInterval);
        }
    }
}
