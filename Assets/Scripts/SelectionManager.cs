using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    //[SerializeField] private Material highlightMaterial;
    //[SerializeField] private Material defaultMaterial;
    [SerializeField] private Color defaultColor;
    [SerializeField] private Color highlightColor;
    [SerializeField] private Color selectedColor;
    [SerializeField] private GameObject[] instruments;
    private int selectedInstrument;
    private int hoverInstrument;

    private Transform _selection;

    void Start()
    {
        selectedInstrument = -1;
        hoverInstrument = -1;
        
    }
/*
    void Update()
    {   

        //se lo strumento hover e' quello selezionato non faccio niente
        if(_selection != null) {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material.color = defaultColor;
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag)) {
                var selectionRenderer = selection.GetComponent<Renderer>();


                if (selectionRenderer != null ) {
                   selectionRenderer.material.color = highlightColor;
                   hoverInstrument = selection.GetComponent<Clickable>().getId();

                }
                _selection = selection;
            }
        }

    }*/
       
    

    public void Click(int instrumentId) {

        if(selectedInstrument==-1) {
            
            selectedInstrument=instrumentId;
            var instrumentMaterial = instruments[selectedInstrument].GetComponent<Renderer>().material;
            instrumentMaterial.color = selectedColor;

        }
        else if(selectedInstrument==instrumentId) {

            var instrumentMaterial = instruments[selectedInstrument].GetComponent<Renderer>().material;
            instrumentMaterial.color = defaultColor;
            selectedInstrument = -1;

        }
        else if(selectedInstrument!=instrumentId) {

            var instrumentMaterial = instruments[selectedInstrument].GetComponent<Renderer>().material;
            instrumentMaterial.color = defaultColor;
            selectedInstrument = instrumentId;
            instrumentMaterial = instruments[selectedInstrument].GetComponent<Renderer>().material;
            instrumentMaterial.color = selectedColor;

        }

    }

}