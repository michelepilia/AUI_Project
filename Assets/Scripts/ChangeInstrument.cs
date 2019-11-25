using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeInstrument : MonoBehaviour
{
    public Material full;
    public Material hammond;
    public Material bass;
    public Material drums;
    public Material guitar;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material = full;
        Invoke("m2", 2.0f);
    }

    void m1() {
        GetComponent<Renderer>().material = full;
        Invoke("m2",1.0f);
    }
    void m2() {
        GetComponent<Renderer>().material = bass;
        Invoke("m3",1.0f);
    }
    void m3() {
        GetComponent<Renderer>().material = drums;
        Invoke("m4",1.0f);
    }
    void m4() {
        GetComponent<Renderer>().material = hammond;
        Invoke("m5",1.0f);
    }
    void m5() {
        GetComponent<Renderer>().material = guitar;
        Invoke("m1",1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
