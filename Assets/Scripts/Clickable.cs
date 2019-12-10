using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject selectionManager;
    [SerializeField] private int ID;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        //Debug.Log("PRESSED!!");
        selectionManager.GetComponent<SelectionManager>().Click(ID);

    }
    public int getId() {
        return ID;
    }

}
