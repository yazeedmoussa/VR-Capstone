using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour
{
    public void ShowGame()
    {
        SceneManager.LoadScene("GameShow"); // Replace with your actual scene name
    }

    public void ShowHorse() 
    { 
        // Logic to open settings menu or load settings scene
        SceneManager.LoadScene("HorseGame");
    }

    public void ShowMatch()
    {
        // Logic to open stats menu or load stats scene
        SceneManager.LoadScene("MatchGame");
    }
    public void ShowMaze()
    {
        // Logic to open stats menu or load stats scene
        SceneManager.LoadScene("MazeGame");
    }
}
