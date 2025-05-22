using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathMenu : MonoBehaviour
{
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private bool idkyet;

    public void DeathScreenOn()
    {
        deathScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void RestartingPresentLevel()
    {
        SceneManager.LoadScene(3);
        //Don't forget to update if more scenes are added before it
    }

    public void End()
    {
        SceneManager.LoadScene(0);
    }


    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
