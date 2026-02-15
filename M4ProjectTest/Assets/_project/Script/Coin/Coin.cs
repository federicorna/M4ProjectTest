
using UnityEngine;

public class Coin : MonoBehaviour
{
    private CoinManager _coinManager;


    private void Awake()
    {
        _coinManager = FindAnyObjectByType<CoinManager>();
        _coinManager.TotalLevelCoin();
    }
    private void OnTriggerEnter (Collider collision)
    {
        _coinManager.AddCoinCollected();
        Destroy(gameObject);
    }
}
