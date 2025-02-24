using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour

{
    public TextMeshProUGUI ScoreUI;
    public TextMeshProUGUI SPSUI;
    public float Score;
    public float SPS;
    public UnityEngine.UI.Image Catimage;
    public int Catnb;
    public List<Sprite> Sprites;
    public float MaxScore;
    public int niveau;
    public GameObject Content;
    float NextTimeCheck = 1;
    float NextTimeCheck2 = 1;
    public Building[] Buildings;
    public int ClickPower = 1;
    public PopUp PopUp;
    public int cpt = 0;
    public bool cat = true;


    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        SPS = 0;
        Catnb = 0;
        MaxScore = 0;
        niveau = 0;
    }

    private void Awake()
    {
        updateSPSUI();
        updateTotalScoreUI();
    }

    private void clicked()
    {
        Score += ClickPower;
    }

    public void OnClick()
    {
        clicked();
        Catnb++;
        if (Catnb == 24)
        {
            Catnb = 0;
        }
        Catimage.sprite = Sprites[Catnb];
    }
    public bool PurchaseAction(int cost)
    {
        if (Score >= cost)
        {
            Score -= cost;
            updateTotalScoreUI();
            return true;
        }
        return false;
    }
    void IdleCalculate()
    {
        float sum = 0;
        foreach (var Building in Buildings)
        {
            sum += Building.calculateIncomePerSeconde();
        }
        Score += sum;
        SPS = sum;
        updateSPSUI();
    }
    public void updateTotalScoreUI()
    {
        ScoreUI.text = Mathf.RoundToInt(Score).ToString();
    }
    public void updateSPSUI()
    {
        SPSUI.text = SPS.ToString() + " P/S";
    }

    public void updateMaxScore()
    {
        if (MaxScore < Score)
        {
            MaxScore = Score;
        }
    }

    IEnumerator end()
    {
        Destroy(GameObject.Find("devantlechat"));
        GameObject.Find("1").transform.GetChild(0).gameObject.SetActive(true);
        GameObject.Find("1").transform.GetChild(1).gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        GameObject.Find("2").transform.GetChild(0).gameObject.SetActive(true);
        GameObject.Find("2").transform.GetChild(1).gameObject.SetActive(true);
        GameObject.Find("2").transform.GetChild(2).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("popup").Length > 75 && cat)
        {
            StartCoroutine(end());
            cat = false;
        }
        updateSPSUI();
        updateTotalScoreUI();
        updateMaxScore();
        if (NextTimeCheck < Time.timeSinceLevelLoad)
        {
            IdleCalculate();
            NextTimeCheck = Time.timeSinceLevelLoad + 1f;
        }
        if (NextTimeCheck2 < Time.timeSinceLevelLoad)
        {
            if (SPS != 0)
            {
                for (int i = 0; i < SPS / 10; i++)
                {
                    PopUp.createPopUp();
                }
                NextTimeCheck2 = Time.timeSinceLevelLoad + 1f;
            }
        }
        //    if (MaxScore >= 15 && niveau < 1)
        //{
        //    Content.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        //    niveau++;
        //}
        //else if (MaxScore > 100 && niveau < 2)
        //{
        //    Content.transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
        //    niveau++;
        //}
        //else if (MaxScore > 200 && niveau < 3)
        //{
        //    Content.transform.GetChild(0).GetChild(2).gameObject.SetActive(true);
        //    niveau++;
        //}
        //else if (MaxScore > 1000 && niveau < 4)
        //{
        //    Content.transform.GetChild(0).GetChild(3).gameObject.SetActive(true);
        //    niveau++;
        //}
        //else if (MaxScore > 10000 && niveau < 5)
        //{
        //    Content.transform.GetChild(0).GetChild(4).gameObject.SetActive(true);
        //    niveau++;
        //}
        //else if (MaxScore > 100000 && niveau < 6)
        //{
        //    Content.transform.GetChild(0).GetChild(5).gameObject.SetActive(true);
        //    niveau++;
        //}
    }
}
