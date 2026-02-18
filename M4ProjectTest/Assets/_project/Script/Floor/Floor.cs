
using UnityEngine.SceneManagement;
using UnityEngine;


public class Floor : MonoBehaviour
{
    private void OnCollisionEnter (Collision collision)
    {
        if (collision.collider.TryGetComponent<LifeController> (out var life))
        {
            SceneManager.LoadScene("Fail menu");
        } 
    }
}
