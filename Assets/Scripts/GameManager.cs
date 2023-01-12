using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Restart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Debug.Log ("You've left the game");
        Application.Quit();
    }

}
