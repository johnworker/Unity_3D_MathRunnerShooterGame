using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;
    private int score;
    private bool isGameOver;

    public bool IsGameOver { get { return isGameOver; } }

    void Start()
    {
        score = 0;
        isGameOver = false;
        UpdateScoreText();
        gameOverPanel.SetActive(false);
    }

    public void AddScore(int points)
    {
        if (!isGameOver)
        {
            score += points;
            UpdateScoreText();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "分數: " + score;
    }

    public void GameOver()
    {
        isGameOver = true;
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
