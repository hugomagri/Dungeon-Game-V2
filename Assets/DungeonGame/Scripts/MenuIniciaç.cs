using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuIniciaç : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("Main");
    }
    public void QuitGame() {
        Application.Quit();
    }
}
