using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverQuiz : MonoBehaviour
{
    

    public bool isCorrect;
    public Material correctMaterial;
    public Material wrongMaterial;
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
        if (isCorrect)
        {
            GetComponent<Renderer>().material = correctMaterial;
        }
        else
        {
            GetComponent<Renderer>().material = wrongMaterial;
        }
    }

    private void OnMouseUp()
    {
        
    }
}
