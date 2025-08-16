using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Target _target;
    [SerializeField] private Enemy _enemyPrefab;

    public void SpawnEnemy()
    {
        if (_target == null || _enemyPrefab == null) return;
        
        var newEnemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
        newEnemy.SetTarget(_target);
    }
}
