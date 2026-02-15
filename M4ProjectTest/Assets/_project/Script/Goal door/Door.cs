
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject _door;

    private void OnTriggerEnter (Collider player)
    {
        SceneManager.LoadScene ("Win menu");
    }
}
