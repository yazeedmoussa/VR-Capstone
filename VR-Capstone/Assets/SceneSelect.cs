using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour
{
    public void LoadGamesScene()
    {
        SceneManager.LoadScene("GamesScene"); // Replace with your actual scene name
    }

    public void OpenSettings()
    {
        // Logic to open settings menu or load settings scene
        SceneManager.LoadScene("SettingsScene");
    }

    public void ShowStats()
    {
        // Logic to open stats menu or load stats scene
        SceneManager.LoadScene("StatsScene");
    }
}
