
using UnityEngine;
using TMPro;

public class Ui_Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _timer;

    public void UpdateTimer (float timeLeft)    //tempo float
    {
        _timer.text = $"{(int)timeLeft}";   //visualizzato int
    }

}
