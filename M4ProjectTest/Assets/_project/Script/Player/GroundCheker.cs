
using UnityEngine;

public class GroundCheker : MonoBehaviour
{
    [SerializeField] private float _groundDistance = 0.2f;
    [SerializeField] private LayerMask _groundMask;

    public bool IsGrounded()
    {
        return Physics.CheckSphere(transform.position, _groundDistance, _groundMask);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = IsGrounded() ? Color.green : Color.blue;
        Gizmos.DrawWireSphere(transform.position, _groundDistance);
    }
}