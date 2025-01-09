using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using JetBrains.Annotations;

public class PopUp : MonoBehaviour
{
    public GameObject PopUpPrefab;
    public int PopUpCount;
    public Image PopUpImage;
    public List<int> PopUpSprites;
    public List<Sprite> sprites;
    public Building b;
    public int cpt;
    // Start is called before the first frame update
    public void createPopUp()
    {
        var canvas = GameObject.Find("devantlechat").transform;
        int x = UnityEngine.Random.Range(0, 1920);
        int y = UnityEngine.Random.Range(0, 1080);
        Vector3 position =  new Vector3 (x, y, 0);
        GameObject popUp = Instantiate(PopUpPrefab, position, quaternion.identity);
        popUp.transform.parent = canvas;
        popUp.tag = "popup";
        
            while(true){
                Debug.Log("caca");
                int randomimage = UnityEngine.Random.Range(0, 5);
            for (int i = 0; i <= 5; i++)
            {
                if(GameObject.Find("Content2").transform.GetChild(i).GetComponent<Building>().level >= 1)
                {
                    cpt++;
                }
            }
            if (cpt == 0) 
            { 
                break;
            }
                if (randomimage == 0 && GameObject.Find("Content2").transform.GetChild(0).GetComponent<Building>().level >= 1)
                {
                    popUp.transform.GetComponent<Image>().sprite = sprites[0];
                    break;
                }
                if (randomimage == 1 && GameObject.Find("Content2").transform.GetChild(1).GetComponent<Building>().level >= 1)
                {
                    popUp.transform.GetComponent<Image>().sprite = sprites[1];
                    break;
                }
                if (randomimage == 2 && GameObject.Find("Content2").transform.GetChild(2).GetComponent<Building>().level >= 1)
                {
                    popUp.transform.GetComponent<Image>().sprite = sprites[2];
                    break;
                }
                if (randomimage == 3 && GameObject.Find("Content2").transform.GetChild(3).GetComponent<Building>().level >= 1)
                {
                    popUp.transform.GetComponent<Image>().sprite = sprites[3];
                    break;
                }
                if (randomimage == 4 && GameObject.Find("Content2").transform.GetChild(4).GetComponent<Building>().level >= 1)
                {
                    popUp.transform.GetComponent<Image>().sprite = sprites[4];
                    break;
                }
                if (randomimage == 5 && GameObject.Find("Content2").transform.GetChild(5).GetComponent<Building>().level >= 1)
                {
                    popUp.transform.GetComponent<Image>().sprite = sprites[5];
                    break;
                }
            }

            StartCoroutine(popuptime(popUp));
        Destroy(popUp,5f);


    }
    IEnumerator popuptime(GameObject popUp)
    {
        popUp.transform.DOScaleY(3, 1);
        popUp.transform.DOScaleX(3, 1);

        yield return new WaitForSeconds(2);
        popUp.transform.DOScaleY(0, 1);
        popUp.transform.DOScaleX(0, 1);

    }

    // Update is called once per frame
    void Start()
    {
        
    }
}
