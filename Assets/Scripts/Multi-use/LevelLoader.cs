using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void LoadPast()
    {
        SceneManager.LoadScene(1);
    }
}
