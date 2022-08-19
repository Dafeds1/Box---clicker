using UnityEngine;

public class Wallet : MonoBehaviour
{
    private const string BALANCE = "Balance";
    private BoostersModel _boosterModel;
    private float coin = 1;
    private int _coins
    { 
        get => PlayerPrefs.GetInt(BALANCE);
        set => PlayerPrefs.SetInt(BALANCE, value);
    }

    private void Awake()
    {
        _boosterModel = FindObjectOfType<BoostersModel>();
    }

    private void OnEnable()
    {
        GameEvents.onCollisionWithPoint += CoinBonusCalculation;
    }

    private void OnDisable()
    {
        GameEvents .onCollisionWithPoint -= CoinBonusCalculation;
    }
    private void CoinBonusCalculation()
    {
        var value = coin +(coin * _boosterModel.BoosterCoins);
        Debug.Log(Mathf.CeilToInt(value));
        _coins = _coins + 1;
        Debug.Log(PlayerPrefs.GetInt(BALANCE));
        
    }
}
