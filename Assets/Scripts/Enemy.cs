using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 3;

    private Target _target;

    private void Update()
    {
        if (_target != null)
        {
            MoveToTarget();
        }
    }

    public void SetTarget(Target target)
    {
        _target = target;
    }

    private void MoveToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
    }
}
