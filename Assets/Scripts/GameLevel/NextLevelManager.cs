using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelManager : MonoBehaviour
{
    private Scene activeScene;

    private void Start()
    {
        // Get active scene name.
        activeScene = SceneManager.GetActiveScene();
    }

    public void PlayAgainButton()
    {
        // Load active scene.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextLevelButton() 
    {
        // Next level load.
        int NextLevel = int.Parse(activeScene.name);
        NextLevel++;
        SceneManager.LoadScene(NextLevel);
    }

    public void BackToMenuButton()
    {
        // Load main menu scene.
        SceneManager.LoadScene("MainMenu");
    }
}
