
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private Transform _pointA;
    [SerializeField] private Transform _pointB;
    [SerializeField] private float _speed = 3f;

    private Vector3 _target;

    void Start()
    {
        _target = _pointB.position;
    }

    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards (transform.position, _target, _speed * Time.fixedDeltaTime);

        if (Vector3.Distance(transform.position, _target) < 0.1f)
        {
            _target = _target == _pointA.position ? _pointB.position : _pointA.position;
        }
    }
}