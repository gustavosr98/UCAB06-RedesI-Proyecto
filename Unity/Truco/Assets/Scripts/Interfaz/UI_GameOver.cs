using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class UI_GameOver : MonoBehaviour {
    public GameObject GameOver;
    public Text mensaje;
    public Button btnVolver;
    public Button btnSalir;

    void Start(){
        mensaje = GameObject.Find("TxtGameOver").GetComponent<Text>();
        btnVolver = GameObject.Find("BtnVolver").GetComponent<Button>();
        btnSalir = GameObject.Find("BtnSalir").GetComponent<Button>();
        set_mensaje("AC", 30);
        btnVolver.onClick.AddListener(volver);
        btnSalir.onClick.AddListener(salir);
    }

    public void set_mensaje( string equipo, int pts ) {
        Debug.Log("set_mensaje( " + equipo + ", " + pts + " )");
        mensaje.text = "Ha ganado el equipo " + equipo + " con " + pts.ToString() + " puntos";
    }

    public void salir() {
        Application.Quit();
    }

    public void volver() {
        
    }
}

        