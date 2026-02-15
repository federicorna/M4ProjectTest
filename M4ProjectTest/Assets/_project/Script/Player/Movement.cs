
using UnityEngine;
public class Movement : MonoBehaviour
{

    [SerializeField] private float _moveSpeed = 5;
    [SerializeField] private float _rotationSpeed = 120;
    [SerializeField] private float _jumpHeight = 2;

    //[SerializeField] private float _jumpForce = 5;

    private Rigidbody _rb;
    private GroundChecker _groundChecker;

    //private Vector3 _direction;

    private float v, h;
    private bool _isJumping;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _groundChecker = GetComponentInChildren<GroundChecker>();
    }

    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        _isJumping = Input.GetButtonDown("Jump");

        if (_isJumping && _groundChecker.IsGrounded)
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        Quaternion deltaRot = Quaternion.Euler (Vector3.up * h * (_rotationSpeed * Time.deltaTime));

        _rb.MovePosition (_rb.position + transform.forward * v * (_moveSpeed * Time.deltaTime));
        _rb.MoveRotation (_rb.rotation * deltaRot);

    }

    private void Jump()
    {
        //_rb.AddForce (Vector3.up * _jumpForce, ForceMode.Impulse);
        _rb.AddForce (Vector3.up * Mathf.Sqrt (_jumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
        _isJumping = false;
    }

}