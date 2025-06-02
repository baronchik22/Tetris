using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;  // делаем глобальным для доступа из других скриптов

    [SerializeField] private Text scoreText;  // ссылка на UI-текст
    private int score;  // текущие очки

    private void Awake()
    {
        // паттерн Singleton (чтобы не было дубликатов)
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // очки за очищенные линии
    public void AddScore(int clearedLines)
    {
        switch (clearedLines)
        {
            case 1:
                score += 100;
                break;
            case 2:
                score += 300;
                break;
            case 3:
                score += 500;
                break;
            case 4:
                score += 800; 
                break;
        }

        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    // сброс очков при рестарте
    public void ResetScore()
    {
        score = 0;
        UpdateScoreUI();
    }
}