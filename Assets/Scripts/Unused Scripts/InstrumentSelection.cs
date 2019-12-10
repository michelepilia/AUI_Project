using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentSelection : MonoBehaviour
{
    public bool selected;
    public Material material;
    public GameObject wall;
    public AudioClip[] notes;
    // Start is called before the first frame update
    void Start()
    {
        selected=false;
        material = GetComponent<Renderer>().material;

    }

    void Update() {

    }

    void OnMouseDown() {
        wall.GetComponent<HandleInstrumentsSelection>().DeselectAllExcept();

        selected = !selected;
        if (selected)
        {
            material.color = Color.green;  
            wall.GetComponent<HandleInstrumentsSelection>().SetActive(gameObject);
        }
        else
        {
            material.color= Color.white;
        }
    }

    public void Deselect() {
        selected = false;
        material.color = Color.white;
    }




   
}
