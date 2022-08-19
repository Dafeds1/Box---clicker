using UnityEngine;

[CreateAssetMenu(order = 51, fileName = "New Skin", menuName = "Shop/Create new Skin")]
public class SkinsShop : ScriptableObject
{
    //
    private const string BOUGHT_KEY = "isBought";
    private const int TRUE_BOUGHT = 1;
    private const int FALSE_BOUGHT = 0;
    //
    private const string SELECTED_KEY = "isSelected";
    private const int TRUE_SELECTED = 1;
    private const int FALSE_SELECTED = 0;

    [SerializeField]
    private int _id;
    public int Id => _id;

    [SerializeField]
    private int _price;
    [SerializeField]
    private Material _skin;

    private bool _isBought
    {
        get => PlayerPrefs.GetInt(BOUGHT_KEY + _id) == TRUE_BOUGHT;
        set => PlayerPrefs.SetInt(BOUGHT_KEY + _id, value == true ? TRUE_BOUGHT : FALSE_BOUGHT);
    }
    public bool IsBought => _isBought;

    private bool _isSelected 
    {
        get => PlayerPrefs.GetInt(SELECTED_KEY + _id) == TRUE_SELECTED;
        set => PlayerPrefs.SetInt(SELECTED_KEY + _id, value == true ? TRUE_SELECTED : FALSE_SELECTED);
    }

    public bool IsSelected => _isSelected;
    public void BoughtStatusChange(bool status)
    {
        _isBought = status;
    }

    public void SelectedStatusChange(bool status)
    {
        _isSelected = status;
    }
}
