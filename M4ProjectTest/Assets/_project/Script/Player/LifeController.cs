
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LifeController : MonoBehaviour
{
    [SerializeField] private int _currentHp = 10;
    [SerializeField] private int _maxHp = 10;
    [SerializeField] private bool _fullHpOnStart = true;

    [SerializeField] private UnityEvent <int, int> _onHpChanged;

    
    private void Start()
    {
        if (_fullHpOnStart)
        {
            SetHp(_maxHp);
        }
    }
    
    public int GetHp() => _currentHp;

    public int GetMaxHp() => _maxHp;
    
    public void AddHp(int amount) => SetHp (_currentHp + amount);

    public void SetHp (int hp)
    {
        hp = Mathf.Clamp (hp, 0, _maxHp);

        if (hp != _currentHp)
        {
            _currentHp = hp;
            Debug.Log($"HP: {_currentHp}");

            _onHpChanged.Invoke(_currentHp, _maxHp);    //chiama "UnityEvent <int, int> _onHpChanged;"

            if (_currentHp == 0)
            {
                Debug.Log($"HP: {_currentHp}");

                SceneManager.LoadScene ("Fail menu");
            }
        }
    }

    //test danno
    [ContextMenu("Infliggi 1 danno")]
    public void DamageProva()
    {
        AddHp(-1);
    }
}
