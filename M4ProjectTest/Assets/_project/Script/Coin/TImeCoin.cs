
using UnityEngine;

public class TImeCoin : MonoBehaviour
{
    private TimerManager _time;

    [SerializeField] private float _timeBonus = 10;


    private void Awake()
    {
        _time = FindAnyObjectByType<TimerManager>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        _time.AddTime (_timeBonus);
        Destroy(gameObject);
    }
}
