using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleInstrumentsSelection : MonoBehaviour
{

    public GameObject[] instruments;
    public GameObject playingInstrument;
    public GameObject[] gridCells;
    public GameObject[] musicRows;
    public Material playedNoteMaterial;
    public Material defaultNoteMaterial;

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

    public void SetActive(GameObject active) {
        playingInstrument = active;
        SetSamples();
    }

    private void SetSamples() {
        //Once the instrument has been selected each ceel of the grid
        //receives as audio sample the correct one (in note and instrument sound)
        int i = 0;
        foreach (GameObject item in gridCells)
        {
            if (i >6)
            {
                break;
            }
            item.GetComponent<AudioScript>().AssignSample(playingInstrument.GetComponent<InstrumentSelection>().notes[i]);
            i++;
        }
    }

    public void DeselectAllFromScore() {
        
        for (int i = 0; i < 6; i++)
        {
            musicRows[i].GetComponent<MusicScoreNote>().UnPlay();
            //musicRows[i].GetComponent<Renderer>().material.color = Color.white;      
        }
    }
}
