using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioScript : MonoBehaviour
{
    public AudioClip Sample;
    public AudioSource SampleSource;
    public GameObject Wall;
    public GameObject MusicScoreRow;
    public GameObject playerCamera;
    
    void Start()
    {
    }

    void OnMouseDown() {
                    //Wall.GetComponent<HandleInstrumentsSelection>().DeselectAllFromScore();
        gameObject.GetComponent<AudioSource>().Play();
        MusicScoreRow.GetComponent<MusicScoreNote>().Play();
    
    }

    public void AssignSample(AudioClip note) {
        this.SampleSource.clip = note;
        this.Sample = note;

    }

     void OnMouseOver() {
        Debug.Log("MouseOver");
    }
    
}
