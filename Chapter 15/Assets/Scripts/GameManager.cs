using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI gameOverText;
    
    int _playerScore;

    void Start()
    {
        gameOverText.enabled = false;
    }

    public void AddScore()
    {
        _playerScore++;
        scoreText.text = _playerScore.ToString();
    }

    public void PlayerDied()
    {
        gameOverText.enabled = true;
        Time.timeScale = 0;
    }
}
