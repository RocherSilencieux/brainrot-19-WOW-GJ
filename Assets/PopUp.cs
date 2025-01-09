using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UIElements;
using DG.Tweening;

public class PopUp : MonoBehaviour
{
    public GameObject PopUpPrefab;
    public int PopUpCount;
    public Image PopUpImage;
    public Sprite[] PopUpSprites;
    // Start is called before the first frame update
    public void createPopUp()
    {
        var canvas = GameObject.Find("devantlechat").transform;
        int x = UnityEngine.Random.Range(0, 1920);
        int y = UnityEngine.Random.Range(0, 1080);
        Vector3 position =  new Vector3 (x, y, 0);
        GameObject popUp = Instantiate(PopUpPrefab, position, quaternion.identity);
        popUp.transform.parent = canvas;
        PopUpImage.sprite = PopUpSprites[UnityEngine.Random.Range(0, PopUpSprites.Length)];
        StartCoroutine(popuptime(popUp));
        Destroy(popUp,5f);


    }
    IEnumerator popuptime(GameObject popUp)
    {
        popUp.transform.DOScaleY(3, 2);
        popUp.transform.DOScaleX(3, 2);
        yield return new WaitForSeconds(3);
        popUp.transform.DOScaleY(0, 2);
        popUp.transform.DOScaleX(0, 2);

    }

    // Update is called once per frame
    void Start()
    {
    }
}
