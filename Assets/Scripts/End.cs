using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void Home()
    {
        SceneManager.LoadScene("Menu");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }
}
