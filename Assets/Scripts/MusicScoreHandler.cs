using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScoreHandler : MonoBehaviour
{
    [SerializeField] private Material[] materials;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void displayNote(string noteID) {
        int index = 0;
        if (noteID == "C") {
            index = 0;
        }
        else if(noteID == "D") {
            index = 1;
        }
        else if(noteID == "E") {
            index = 2;
        }
        else if(noteID == "F") {
            index = 3;
        }
        else if(noteID == "G") {
            index = 4;
        }
        else if(noteID == "A") {
            index = 5;
        }
        else if(noteID == "B") {
            index = 6;
        }
        gameObject.GetComponent<Renderer>().material = materials[index] ;
    }
}
