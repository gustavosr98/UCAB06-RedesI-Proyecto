using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// LIBRERIA PARA UI
using UnityEngine.UI;


public class DropdownPort : MonoBehaviour {
    public Comunicacion com;
    public Dropdown dropdown;

    public bool Tx;
    public bool Rx;

    void Start(){
        dropdown = GetComponent<Dropdown>();
        dropdown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(dropdown);
        });

    }

    void DropdownValueChanged(Dropdown change){
    }
}
