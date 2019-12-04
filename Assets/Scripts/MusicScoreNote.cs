using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScoreNote : MonoBehaviour
{
    // Start is called before the first frame update
    //private Color playedNote;
    //private Color unPlayedNote;

    void Start()
    {
        //playedNote = Color.green;
        //unPlayedNote = Color.white;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play() {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
    public void UnPlay() {
       gameObject.GetComponent<Renderer>().material.color = Color.white;    
    }
}
