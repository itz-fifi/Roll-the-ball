using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Load the main game scene
        SceneManager.LoadScene("Game");
    }
}
