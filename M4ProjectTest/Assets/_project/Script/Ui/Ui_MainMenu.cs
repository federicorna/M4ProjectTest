
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject _newGameButton;
    [SerializeField] private GameObject _exitButton;

    public void OnClickNewGame()
    {
        SceneManager.LoadScene ("Level");
    }


    public void OnClickExit()
    {
        Debug.Log ("Exit");
        Application.Quit();
    }
}
