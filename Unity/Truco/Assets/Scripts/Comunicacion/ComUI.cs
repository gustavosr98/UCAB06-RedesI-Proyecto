using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public  class ComUI : MonoBehaviour {

    Logica log;
    Comunicacion com;

    void Start(){
        log = GameObject.Find("Logica").GetComponent<Logica>();
        com = GameObject.Find("Comunicacion").GetComponent<Comunicacion>();

        GameObject.Find("BtnEmpezar").GetComponent<Button>().onClick.AddListener(repartirCartas);
    }
    public void repartirCartas(){
        if( log.juego.jugador == "A")
            Debug.Log("------------> OK");
            //log.ronda.repartirCartasAleatorio();
    }
}