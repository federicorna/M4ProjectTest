
using UnityEngine;
public class PlayerController : MonoBehaviour
{

    [SerializeField] private float _moveSpeed = 5;
    [SerializeField] private float _jumpForce = 5;

    private Rigidbody _rb;
    private Vector3 _direction;
    private GroundChecker _groundChecker;
    private Camera _cameraRotation;

    private bool _isJumping;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _groundChecker = GetComponentInChildren<GroundChecker>();
    }


    private void Update()
    {
        float horizontal = Input.GetAxisRaw ("Horizontal");
        float vertical = Input.GetAxisRaw ("Vertical");
        _isJumping = Input.GetButtonDown("Jump");

        if (_isJumping && _groundChecker.IsGrounded)
        {
            Jump();
        }

        _direction = (transform.forward * vertical) + (transform.right * horizontal);
        _direction = _direction.normalized;
    }


    private void FixedUpdate()
    {
        Vector3 velocity = CalculateVelocity();
        _rb.velocity = new Vector3 (velocity.x, _rb.velocity.y, velocity.z);

        FarwardPlayer();
    }

    private Vector3 CalculateVelocity()
    {
        return _direction * _moveSpeed;
    }

    private void Jump()
    {
        _rb.AddForce (Vector3.up * _jumpForce, ForceMode.Impulse);
        _isJumping = false;
    }

    private void FarwardPlayer()
    {
        //float cameraRotationYAxis = _camera.transform.rotation.eulerAngles.y;
        //Quaternion targetRotation = Quaternion.Euler(0,_cameraRotation.verticalRotation, 0);
        //_rb.MoveRotation(targetRotation);
    }
}