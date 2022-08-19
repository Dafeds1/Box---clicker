using System;
using UnityEngine;

[Serializable]
public class Score : MonoBehaviour
{
    private const string BEST_SCORE = "BestScore";
    private float _currentScore = 0;
    private float _bestScore
    {
        get => PlayerPrefs.GetFloat(BEST_SCORE);
        set => PlayerPrefs.SetFloat(BEST_SCORE, _bestScore);
    }

    public float CurrentScore => _currentScore;
    public float BestScore => _bestScore;
    private void Awake()
    {
        GameEvents.onScoresAdded += Add;
    }

    private void Add(float score)
    {
        _currentScore += score;
    }
}
