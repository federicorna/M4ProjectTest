
using UnityEngine;
using UnityEngine.UI;

public class Mover3D : MonoBehaviour
{
    [SerializeField] private GroundCheker _groundChek;
    [SerializeField] private float _baseSpeed = 4f;
    [SerializeField] private float _maxAngleRotation = 360f;
    [SerializeField] private float _jumpForce = 2f;
    [SerializeField] private int _maxJumps = 2;

    private Rigidbody _rb;
    private Vector3 _input;

    private float _speedMultiplier;
    private int _jumpCount;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }


    private void SetInput(Vector3 input)
    {
        _input = input;
    }

    public void SetAndNormalizeInput(Vector3 input)
    {
        float sqrMagnitude = input.sqrMagnitude;

        if (sqrMagnitude > 1)
        {
            input = input.normalized;
        }

        SmoothRotation(input);
        SetInput(input);

    }

    private void SmoothRotation(Vector3 input)
    {
        if (input == Vector3.zero) return;

        Quaternion targetRotation = Quaternion.LookRotation(input);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, _maxAngleRotation * Time.deltaTime);
    }

    public void Jump()
    {
        if (_groundChek.IsGrounded())
        {
            _jumpCount = 0;
        }

        if (_jumpCount < _maxJumps)
        {
            _rb.AddForce(Vector3.up * _jumpForce, ForceMode.VelocityChange);
            _jumpCount++;
        }
    }

    public void SetSpeedMultiplier(float multiplier)
    {
        _speedMultiplier = multiplier;
    }

    public void Move()
    {
        if (_input != Vector3.zero)
        {
            float currentSpeed = _baseSpeed * _speedMultiplier;
            _rb.MovePosition(_rb.position + _input * (currentSpeed * Time.fixedDeltaTime));
        }
    }

}