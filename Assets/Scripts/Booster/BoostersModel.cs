using UnityEngine;

public class BoostersModel : MonoBehaviour
{
    private const string BOOSTER_COINS = "BoosterCoins";

    private float _boosterCoins
    {
        get => PlayerPrefs.GetFloat(BOOSTER_COINS);
        set => PlayerPrefs.SetFloat(BOOSTER_COINS, value);
    }
    private int _lvlBoosterCoins = 0;
    private float _priceImprovementCoins = 50;

    public float BoosterCoins => _boosterCoins;

    private void Awake()
    {
        BoosterController.NumberCoinsWasBoostered += CalculateBoostersCoins;
    }

    private void OnDisable()
    {
        BoosterController.NumberCoinsWasBoostered -= CalculateBoostersCoins;
    }

    private void CalculateBoostersCoins(int number)
    {
        _boosterCoins += number ;
    }
}
