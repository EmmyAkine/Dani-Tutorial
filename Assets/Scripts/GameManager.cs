using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool isGameOver; // Flag to track game state

    public GameObject gameOverPanel; // Reference to the game over panel GameObject


    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false); // Initially hide the game over panel
    }

    public void OnObjectFall() // Method to be called when object falls
    {
        isGameOver = true;
        gameOverPanel.SetActive(true); // Show the game over panel
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}