using System;
using UnityEngine;

public class BoosterController : MonoBehaviour
{
    public static event Action<int> NumberCoinsWasBoostered;

    public void BoosteringCoins(int number)
    {
        NumberCoinsWasBoostered?.Invoke(number);
    }
}
