
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;


    private void Update()
    {
        if (Input.GetKeyDown (KeyCode.Escape) && !_pauseMenu.activeSelf)
        {
            Debug.Log ("Pausa");

            _pauseMenu.SetActive (true);
            Time.timeScale = 0;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }


    public void OnClickResumeGame()
    {
        _pauseMenu.SetActive (false);
        Time.timeScale = 1;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    public void OnClickRestart()
    {
        SceneManager.LoadScene ("Level");

        _pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }


    public void OnClickExit()
    {
        SceneManager.LoadScene ("Main Menu");
    }
}