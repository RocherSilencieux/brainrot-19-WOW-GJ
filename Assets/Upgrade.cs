using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public int Cost = 10;
    public GameManager manager;
    public GameObject Upgrades;
    public TMP_Text Description;
    public TMP_Text PriceUpgrade;
    public void CursorUpgrade()
    {
       if (manager.Score > Cost)
        {
            manager.Score -= Cost;
            manager.ClickPower += 1;
            Upgrades.transform.GetChild(0).gameObject.SetActive(false);
            
        }
    }
    public void CursorUpgrade2()
    {
        if (manager.Score > Cost)
        {
            manager.Score -= Cost;
            manager.ClickPower += 2;
            Upgrades.transform.GetChild(7).gameObject.SetActive(false);

        }
    }
    public void FirstMemeUpgrade()
    {
        if (manager.Score > Cost)
        {
            manager.Score -= Cost;
            manager.Buildings[0].ScorePerUpgrade *= 2;
            Upgrades.transform.GetChild(1).gameObject.SetActive(false);

        }
    }
    public void FirstMemeUpgrade2()
    {
        if (manager.Score > Cost)
        {
            manager.Score -= Cost;
            manager.Buildings[0].ScorePerUpgrade *= 2;
            Upgrades.transform.GetChild(2).gameObject.SetActive(false);

        }
    }
    public void SecMemeUpgrade()
    {
        if (manager.Score > Cost)
        {
            manager.Score -= Cost;
            manager.Buildings[1].ScorePerUpgrade *= 2;
            Upgrades.transform.GetChild(3).gameObject.SetActive(false);
        }
    }
    public void SecMemeUpgrade2()
    {
        if (manager.Score > Cost)
        {
            manager.Score -= Cost;
            manager.Buildings[1].ScorePerUpgrade *= 2;
            Upgrades.transform.GetChild(4).gameObject.SetActive(false);
        }
    }
    public void ThirdMemeUpgrade()
    {
        if (manager.Score > Cost)
        {
            manager.Score -= Cost;
            manager.Buildings[2].ScorePerUpgrade *= 2;
            Upgrades.transform.GetChild(5).gameObject.SetActive(false);
        }
    }
    public void ThirdMemeUpgrade2()
    {
        if (manager.Score > Cost)
        {
            manager.Score -= Cost;
            manager.Buildings[2].ScorePerUpgrade *= 2;
            Upgrades.transform.GetChild(6).gameObject.SetActive(false);
        }
    }
    public void FourthMemeUpgrade()
    {
        if (manager.Score > Cost)
        {
            manager.Score -= Cost;
            manager.Buildings[3].ScorePerUpgrade *= 2;
            Upgrades.transform.GetChild(8).gameObject.SetActive(false);
        }
    }
    public void FourthMemeUpgrade2()
    {
        if (manager.Score > Cost)
        {
            manager.Score -= Cost;
            manager.Buildings[3].ScorePerUpgrade *= 2;
            Upgrades.transform.GetChild(9).gameObject.SetActive(false);
        }
    }
    public void FifthMemeUpgrade()
    {
        if (manager.Score > Cost)
        {
            manager.Score -= Cost;
            manager.Buildings[4].ScorePerUpgrade *= 2;
            Upgrades.transform.GetChild(10).gameObject.SetActive(false);
        }
    }
    public void FifthMemeUpgrade2()
    {
        if (manager.Score > Cost)
        {
            manager.Score -= Cost;
            manager.Buildings[4].ScorePerUpgrade *= 2;
            Upgrades.transform.GetChild(11).gameObject.SetActive(false);
        }
    }
    public void SixthMemeUpgrade()
    {
        if (manager.Score > Cost)
        {
            manager.Score -= Cost;
            manager.Buildings[5].ScorePerUpgrade *= 2;
            Upgrades.transform.GetChild(12).gameObject.SetActive(false);
        }
    }
    public void SixthMemeUpgrade2()
    {
        if (manager.Score > Cost)
        {
            manager.Score -= Cost;
            manager.Buildings[5].ScorePerUpgrade *= 2;
            Upgrades.transform.GetChild(13).gameObject.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
