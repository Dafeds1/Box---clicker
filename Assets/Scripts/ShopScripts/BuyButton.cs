using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    [SerializeField]
    private int _idButton;
    private ShopController _shopController;

    private void Awake()
    {
        _shopController = FindObjectOfType<ShopController>();

        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        _shopController.BuySkin(_idButton);
    }
}
