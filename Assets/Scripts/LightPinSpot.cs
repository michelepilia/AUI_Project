using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPinSpot : MonoBehaviour
{
  
    public Light myLight;
    float startTime;
    //float startTime;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update() {
        //pause on guitar
        if (Time.time - startTime < 2)
        {
            transform.Translate(Vector3.zero *Time.deltaTime); 
        }
        //moving on hammond 1
        else if (Time.time - startTime >= 2 && Time.time - startTime < 5 )
        {
            transform.Translate(Vector3.left*Time.deltaTime); 
        }
        //moving on hammond 2
        else if (Time.time - startTime >= 5 && Time.time - startTime < 6 )
        {
            transform.Translate(Vector3.up*Time.deltaTime); 
        }
        //pause on hammond
        else if (Time.time - startTime >= 6 && Time.time - startTime < 8 )
        {
            transform.Translate(Vector3.zero*Time.deltaTime); 
        }
        //moving on drums 1
        else if (Time.time - startTime >= 8 && Time.time - startTime < 13 )
        {
            transform.Translate(Vector3.right*Time.deltaTime); 
        }
        //moving on drums 2
        else if (Time.time - startTime >= 13 && Time.time - startTime < 15 )
        {
            transform.Translate(Vector3.up*Time.deltaTime); 
        }
        //pause on drums
        else if (Time.time - startTime >= 15 && Time.time - startTime < 17)
        {
            transform.Translate(Vector3.zero*Time.deltaTime); 
        }
        //Moving to bass 1
        else if (Time.time - startTime >= 17 && Time.time - startTime < 19 )
        {
            transform.Translate(Vector3.down*Time.deltaTime); 
        }
        //Moving to bass 2
        else if (Time.time - startTime >= 19 && Time.time - startTime < 20.5 )
        {
            transform.Translate(Vector3.right*Time.deltaTime); 
        }
        //pause on bass
        else if (Time.time - startTime >= 20.5)
        {
            transform.Translate(Vector3.zero*Time.deltaTime); 
        }
    }

}
