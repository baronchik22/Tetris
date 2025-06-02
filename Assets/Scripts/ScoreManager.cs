using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;  // ������ ���������� ��� ������� �� ������ ��������

    [SerializeField] private Text scoreText;  // ������ �� UI-�����
    private int score;  // ������� ����

    private void Awake()
    {
        // ������� Singleton (����� �� ���� ����������)
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // ���� �� ��������� �����
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

    // ����� ����� ��� ��������
    public void ResetScore()
    {
        score = 0;
        UpdateScoreUI();
    }
}