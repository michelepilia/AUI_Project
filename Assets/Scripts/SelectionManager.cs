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
    private int selectedInstrument;
    private int hoverInstrument;

    private Transform _selection;
    // Start is called before the first frame update
    void Start()
    {
        selectedInstrument = -1;
        hoverInstrument = -1;
        
    }

    // Update is called once per frame
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
                    //Debug.Log("OK");
                        selectionRenderer.material.color = highlightColor;
                
                   hoverInstrument = selection.GetComponent<Clickable>().getId();

                }
                _selection = selection;


            }
        }
    }
       
    

    public void Click(int instrumentID) {
        var selectionRenderer = _selection.GetComponent<Renderer>();
        if(selectedInstrument==instrumentID) {
            selectionRenderer.material.color = defaultColor;
            selectedInstrument = -1;
            
        }
        else
        {
            selectionRenderer.material.color = selectedColor;
            selectedInstrument = instrumentID;

        }

    }

}
