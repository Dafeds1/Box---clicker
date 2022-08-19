using UnityEngine;

public class ShopView : MonoBehaviour
{
    [SerializeField] private GameObject[] _checkMarks;
    [SerializeField] private GameObject[] _price;

    private ShopController _shopController;
    private void Awake()
    {
        ShopController.SkinWasBought += SetPurchaseStatus;
        ShopController.SkinWasSelected += SetSelectionStatus;
        _shopController = FindObjectOfType<ShopController>();
    }

    private void OnDestroy()
    {
        ShopController.SkinWasBought -= SetPurchaseStatus;
        ShopController.SkinWasSelected -= SetSelectionStatus;
    }



    private void SetPurchaseStatus(int id)
    {
        for (int i = 0; i < _price.Length; i++)
        {
            _price[i].SetActive(!_shopController.SkinsShop[i].IsBought);        
        }
        _price[id].SetActive(!_shopController.SkinsShop[id].IsBought);
        
    }

    private void SetSelectionStatus(int id)
    {
        for (int i = 0; i < _checkMarks.Length; i++)
        {
            _checkMarks[i].SetActive(_shopController.SkinsShop[i].IsSelected);
        }
        _checkMarks[id].SetActive(!_shopController.SkinsShop[id].IsSelected);
    }
}
