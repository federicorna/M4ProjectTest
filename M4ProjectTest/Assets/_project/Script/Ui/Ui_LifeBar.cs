
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ui_LifeBar : MonoBehaviour
{
    [SerializeField] private Image _fillableLifeBar;
    [SerializeField] private TextMeshProUGUI _hpText;

    public void UpdateGraphics (int currentHp, int maxHp)
    {
        _hpText.text = $"{currentHp}/{maxHp}";
        _fillableLifeBar.fillAmount = (float) currentHp / maxHp;
    }
}
