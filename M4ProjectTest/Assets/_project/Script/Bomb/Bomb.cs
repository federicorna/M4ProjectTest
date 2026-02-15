
using UnityEngine;
using UnityEngine.Events;


public class Bomb : MonoBehaviour
{
    [SerializeField] private int _damage = -2;
    private LifeController _lifeController;


    private void OnTriggerEnter (Collider collision)
    {
        _lifeController.AddHp(_damage);
        Destroy(gameObject);

    }
}
