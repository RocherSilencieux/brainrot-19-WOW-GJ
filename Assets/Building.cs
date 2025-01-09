using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    public TMP_Text PriceText;
    public TMP_Text IncomeInfoText;
    public int StartPrice = 15;
    public float PriceMultiplier = 1.15f;
    public float ScorePerUpgrade = 0.1f;
    public int level = 0;
    public GameManager manager;
    public PopUp PopUp;
    public Image image;

    int calculatePrice()
    {
        int Price = Mathf.RoundToInt(StartPrice * Mathf.Pow(PriceMultiplier, level));
        return Price;
    }

    public float calculateIncomePerSeconde()
    {
        return ScorePerUpgrade * level;
    }
    void updateUI()
    {
        PriceText.text = calculatePrice().ToString();
        IncomeInfoText.text = level.ToString() + " x " + ScorePerUpgrade.ToString() + "/s";
    }
    public void clickAction()
    {
        int price = calculatePrice();
        bool PurchaseSuccess = manager.PurchaseAction(price);
        if (PurchaseSuccess)
        {
            level++;
            updateUI();
            PopUp.PopUpSprites.Append(image.sprite);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        updateUI();
    }
}