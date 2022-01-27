using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Product : MonoBehaviour
{
    public Image thisImage;
    public int price;
    public TextMeshProUGUI PriceText;
    public Button ShopBtn;

    private void Start()
    {
        thisImage = transform.GetChild(1).GetComponent<Image>();
        PriceText = transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>();
        ShopBtn = transform.GetComponent<Button>();
    }


}
