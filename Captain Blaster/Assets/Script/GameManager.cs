using UnityEngine;
using UnityEngine.UI; // Note this new line is needed for UI

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Text gameOverText;


    int playerScore = 0;


    public void AddScore()
    {
        playerScore++;
        // This converts the score (a number) into a string
        scoreText.text = playerScore.ToString();
    }

    void Start()
    {
        if (gameOverText.enabled == true)
        {
            gameOverText.enabled = false;
        }
    }

    public void PlayerDied()
    {
        gameOverText.enabled = true;
        // This freezes the game
        Time.timeScale = 0;
    }
}
