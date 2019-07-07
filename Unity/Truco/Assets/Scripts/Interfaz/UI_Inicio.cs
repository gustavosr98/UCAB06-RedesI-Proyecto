using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class UI_Inicio : MonoBehaviour {
    public GameObject Inicio;
    public Button btnJugar;

    void Start(){
        btnJugar = GameObject.Find("BtnJugar").GetComponent<Button>();
        btnJugar.onClick.AddListener(jugar);
    }

    public void jugar() {
        Debug.Log("jugar");
    }
}

        