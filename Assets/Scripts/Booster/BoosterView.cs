using UnityEngine;
using UnityEngine.UI;

public class BoosterView : MonoBehaviour
{
    [SerializeField]
    private Text _boosterScores;
    [SerializeField]
    private Text _boosterCoins;
    private BoostersModel _boosterModel;

    private void Awake()
    {
        _boosterModel = FindObjectOfType<BoostersModel>();        
       
       _boosterCoins.text = _boosterModel.BoosterCoins.ToString() + "%";
    }


}
