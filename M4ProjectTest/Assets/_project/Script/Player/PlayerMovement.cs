using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Mover3D _mover;
    private Vector3 _direction;

    private float _horizontal;
    private float _vertical;

    private void Awake()
    {
        _mover = GetComponent<Mover3D>();
    }

    private void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");

        _direction = new Vector3(_horizontal, 0, _vertical);
        _mover.SetAndNormalizeInput(_direction);

        if (Input.GetButtonDown("Jump"))
        {
            _mover.Jump();
        }

        bool isRunning = Input.GetButtonDown("Run");
        _mover.SetSpeedMultiplier(isRunning ? 2f : 1f);
    }

    private void FixedUpdate()
    {
        _mover.Move();
    }
}