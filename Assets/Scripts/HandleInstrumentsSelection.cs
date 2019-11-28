using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleInstrumentsSelection : MonoBehaviour
{

    public GameObject[] instruments;
    // Start is called before the first frame update
    void Start()
    {

  
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DeselectAllExcept() {
        foreach (GameObject item in instruments)  
        {
            item.GetComponent<InstrumentSelection>().Deselect();
        }
    }
}
