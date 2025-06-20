using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{

    public int playerScror; // Player's score
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel; // Panel to show when the game is over
    public GameObject flapButton; // Button to flap the bird


    [ContextMenu("Increment")]
    public void updateScore(int score)
    {
        playerScror += score; // Increment the player's score
        scoreText.text = playerScror.ToString(); // Update the score text
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartGame()
    {
        playerScror = 0; // Reset the player's score
        scoreText.text = playerScror.ToString(); // Update the score text to show reset score
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene to restart the game

    }

    public void gameOver()
    {
        gameOverPanel.SetActive(true); // Show the game over panel
        flapButton.SetActive(false); // Hide the flap button

    }
}
