using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static event Action<float> onCoinsAdded;
    public static event Action<float> onScoresAdded;
    public event Action onStartGame;
    public event Action onGameOver;
    public static event Action onCollisionWithPoint;


    public void CoinsAdded(float coins)
    {
        onCoinsAdded?.Invoke(coins);    
    }

    public void ScoresAdded(float score)
    {
        onScoresAdded?.Invoke(score);
    }

    public void StartedGame()
    {
        onStartGame?.Invoke();
    }

    public void EndedGame()
    {
        onGameOver?.Invoke();
    }

    public void CollisionWithPoint()
    {
        onCollisionWithPoint?.Invoke();
    }
}
