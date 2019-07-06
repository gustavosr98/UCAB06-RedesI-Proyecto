using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// LIBRERIA PARA UI
using UnityEngine.UI;


public class DropdownPort : MonoBehaviour {
    Dropdown dropdown;
    
    void Start(){
        dropdown = GetComponent<Dropdown>();
        dropdown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(dropdown);
        });

    }

    // Update is called once per frame
    void Update(){
    }

    void DropdownValueChanged(Dropdown change){
    }
}
