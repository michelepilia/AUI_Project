using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comeBackButton : MonoBehaviour
{
    GameObject father;
    public GameObject wallCamera;
    public GameObject genCanvas;
    public GameObject[] bandArray= new GameObject[4];

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        father = GameObject.Find("QuizObjects");
        wallCamera.SetActive(true);
        genCanvas.SetActive(true);

        for (int i = 0; i<4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                bandArray[i].transform.GetChild(j).gameObject.SetActive(false);
            }
        }
        gameObject.SetActive(false);

    }
}
