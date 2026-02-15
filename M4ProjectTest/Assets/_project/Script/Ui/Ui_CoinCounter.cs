
using UnityEngine;
using TMPro;

public class Ui_CoinCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinsCounterText;

    public void OnCoinsCounterChanged(int coins, int maxCoins)
    {
        _coinsCounterText.text = $"{coins}/{maxCoins}";
    }
}
