
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class TimerManager : MonoBehaviour
{
    [SerializeField] private int _levelTime;
    [SerializeField] private UnityEvent <float> _onTimeChanged;

    private float _timeRemaning;

    private void Start()
    {
        _timeRemaning = _levelTime;
    }

    private void Update()
    {
        if (_timeRemaning > 0)
        {
            _timeRemaning -= Time.deltaTime;
            _onTimeChanged.Invoke (_timeRemaning);
        }
        else
        {
            SceneManager.LoadScene("Fail menu");
        }
    }

    public void AddTime(float time)
    {
        _timeRemaning += time;
    }
}
