using System;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    public static event Action<int> SkinWasBought;
    public static event Action<int> SkinWasSelected;

    [SerializeField]
    private SkinsShop[] _skinsShop;

    public SkinsShop[] SkinsShop => _skinsShop;

    public void BuySkin(int idSkin)
    {
        if (_skinsShop[idSkin].IsBought == false)
        {                
            _skinsShop[idSkin].BoughtStatusChange(true);
            SkinWasBought?.Invoke(idSkin);
        }
        else SelectSkin(idSkin);
    }

    public void SelectSkin(int idSkin)
    {
        if (_skinsShop[idSkin].IsSelected == false)
        {
            for(int i = 0; i < _skinsShop.Length; i++)
            {
                _skinsShop[i].SelectedStatusChange(false);
            }
            _skinsShop[idSkin].SelectedStatusChange(true);
            SkinWasSelected?.Invoke(idSkin); 
        }
    }
}
