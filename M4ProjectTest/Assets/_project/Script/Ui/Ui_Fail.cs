
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui_Fail : MonoBehaviour
{
    [SerializeField] private GameObject _failMenu;

    public void OnClickRetray()
    {
        SceneManager.LoadScene ("Level");
    }


    public void OnClickMainMenu()
    {
        SceneManager.LoadScene ("Main Menu");
    }
}
