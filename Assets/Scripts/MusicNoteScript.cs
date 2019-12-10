using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNoteScript : MonoBehaviour
{

    [SerializeField] private string noteID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickAction() {
       Debug.Log("playing: " + noteID);
    }
}
