using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioScript : MonoBehaviour
{
    public AudioClip Sample;
    public AudioSource SampleSource;
    void Start()
    {
    }

    public void OnMouseDown() {
        gameObject.GetComponent<AudioSource>().Play();
    }

    public void AssignSample(AudioClip note) {
        this.SampleSource.clip = note;
        this.Sample = note;

    }
    
}
