using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackLight : MonoBehaviour
{
    public Light myLight;
    float startTime;
    void Start()
    {
        GetComponent<Light>();
        startTime = Time.time;
        Invoke("m1", 4.0f);
    }

    void m1() {
        startTime = Time.time;
        Invoke("m1",4.0f);
    }

    void Update() {
        if (Time.time - startTime < 2)
        {
            transform.Translate(Vector3.down*Time.deltaTime);
        }
        else if(Time.time - startTime >= 2 && Time.time- startTime<4)
        {
            transform.Translate(Vector3.up*Time.deltaTime);
        }
        

    }
}
