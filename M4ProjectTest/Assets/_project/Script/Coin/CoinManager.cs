
using UnityEngine;
using UnityEngine.Events;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int _totalCoin;
    [SerializeField] private int _coinCollected;
    [SerializeField] private UnityEvent <int, int> _onCoinCounter;

    [SerializeField] private GameObject _door;


    private void Start()    //per l'inizio dove non ho nessuna coin
    {
        _coinCollected = 0;
        _onCoinCounter.Invoke(_coinCollected, _totalCoin);
    }

    private void Update()
    {
        if (_coinCollected == _totalCoin)
        {
            _door.SetActive(true);
        }
    }

    public void TotalLevelCoin()   //monete totali nel livello
    {
        _totalCoin++;
        _onCoinCounter.Invoke(_coinCollected, _totalCoin);
    }

    public void AddCoinCollected()  //monete collezionate
    {
        _coinCollected++;
        _onCoinCounter.Invoke(_coinCollected, _totalCoin);
    }


}
