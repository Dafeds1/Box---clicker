using UnityEngine;
using UnityEngine.UI;

public class UIGame : MonoBehaviour
{
    [SerializeField]
    private Text _bestScores;
    [SerializeField]
    private Text _coins;

    private void Awake()
    {
        GameEvents.onScoresAdded += DisplayScores;
        GameEvents.onCoinsAdded += DisplayCoins;
    }

    private void OnDisable()
    {
        GameEvents.onScoresAdded -= DisplayScores;
        GameEvents.onCoinsAdded -= DisplayCoins;
    }

    private void DisplayScores(float score)
    {
        _bestScores.text = score.ToString();
    }

    private void DisplayCoins(float coins)
    {
        _coins.text = coins.ToString();
    }

}
