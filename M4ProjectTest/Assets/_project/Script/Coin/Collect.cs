
using UnityEngine;

public class Collect : MonoBehaviour
{
    private void OnCollisionEnter (Collision collision)
    {
        Destroy(this.gameObject);
    }
}
