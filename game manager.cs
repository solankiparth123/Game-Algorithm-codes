using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;  // Singleton for global access

    public int currentLevel = 1;
    public int maxLevels = 100;
    public int score = 0;
    public int playerLives = 3;

    private void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        InitializeGame();
    }

    void Update()
    {
        // Game loop logic, e.g., listening for player input or checking conditions
        if (playerLives <= 0)
        {
            GameOver();
        }
    }

    void InitializeGame()
    {
        Debug.Log("Game Initialized!");
        LoadLevel(currentLevel);
    }

    public void LoadLevel(int level)
    {
        if (level > maxLevels)
        {
            Debug.Log("All levels completed! Game Finished!");
            return;
        }

        Debug.Log($"Loading Level {level}...");
        SceneManager.LoadScene("Level" + level);  // Ensure level scenes are named like "Level1", "Level2", etc.
    }

    public void AddScore(int points)
    {
        score += points;
        Debug.Log($"Score: {score}");
    }

    public void ReduceLives()
    {
        playerLives--;
        Debug.Log($"Lives Remaining: {playerLives}");

        if (playerLives <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over! Final Score: " + score);
        // Show Game Over UI or restart the game
        SceneManager.LoadScene("GameOverScene");
    }
}
