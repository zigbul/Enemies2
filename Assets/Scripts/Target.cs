using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed = 2f;
    [SerializeField] private float _reachDistance = 0.1f;

    private int _currentIndex = 0;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (_waypoints.Length == 0) return;

        var currentWaypoint = _waypoints[_currentIndex];

        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, _speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, currentWaypoint.position) < _reachDistance)
        {
            _currentIndex = (_currentIndex + 1) % _waypoints.Length;
        }
    }
}
