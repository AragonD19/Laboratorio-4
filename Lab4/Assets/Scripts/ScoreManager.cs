using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    private int score = 0;

    void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score: " + score);
    }

    public int GetScore()
    {
        return score;
    }
}
