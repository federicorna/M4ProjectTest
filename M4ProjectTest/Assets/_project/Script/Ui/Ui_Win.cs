
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui_Win : MonoBehaviour
{
    [SerializeField] private GameObject _winMenu;

    public void OnClickNewGame()
    {
        SceneManager.LoadScene ("Level");
    }


    public void OnClickMainMenu()
    {
        SceneManager.LoadScene ("Main Menu");
    }
}
