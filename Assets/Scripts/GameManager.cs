using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour

{
    public TextMeshProUGUI ScoreUI;
    public TextMeshProUGUI SPSUI;
    public int score;
    public int SPS;
    

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        SPS = 0;
    }

    private void Awake()
    {
        updateSPSUI();
        updateTotalScoreUI();
    }

    private void clicked()
    {
        score ++;
    }

    public void OnClick()
    {
        clicked();
    }

    public void updateTotalScoreUI()
    {
        ScoreUI.text = score.ToString();
    }
    public void updateSPSUI()
    {
        SPSUI.text = SPS.ToString() + " P/S";
    }


    // Update is called once per frame
    void Update()
    {
        updateSPSUI();
        updateTotalScoreUI();
    }
}
