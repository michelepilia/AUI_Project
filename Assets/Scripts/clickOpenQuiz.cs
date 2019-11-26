using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class clickOpenQuiz : MonoBehaviour
{
    public GameObject wallCamera;
    public GameObject genCanvas;
    public GameObject[] bandArray = new GameObject[4];
    public Button backButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = backButton.GetComponent<Button>();
        btn.onClick.AddListener(OnClickBackButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GameObject.Find("Wall Camera").SetActive(false);
        GameObject.Find("GeneralCanvas").SetActive(false);
        backButton.gameObject.SetActive(true);
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);
        transform.GetChild(2).gameObject.SetActive(true);
        transform.GetChild(3).gameObject.SetActive(true);
    }

    void OnClickBackButton()
    {
        wallCamera.SetActive(true);
        genCanvas.SetActive(true);

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                bandArray[i].transform.GetChild(j).gameObject.SetActive(false);
            }
        }
        backButton.gameObject.SetActive(false);
    }

}
