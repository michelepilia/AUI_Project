﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickOpenQuiz : MonoBehaviour
{
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
        GameObject.Find("Wall Camera").SetActive(false);
        GameObject.Find("GeneralCanvas").SetActive(false);
        //GameObject.Find("BackButtonCanvas").SetActive(true);
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);
        transform.GetChild(2).gameObject.SetActive(true);
        transform.GetChild(3).gameObject.SetActive(true);
    }

}
