using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioScript : MonoBehaviour
{
    public AudioClip Sample;
    public AudioSource SampleSource;
    void Start()
    {
        SampleSource.clip = Sample;
    }
    /*
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            gameObject.GetComponent<AudioSource>().Play();
            //SampleSource.Play();
        }
    }*/
    void OnMouseDown() {
        gameObject.GetComponent<AudioSource>().Play();
    }
    
}
