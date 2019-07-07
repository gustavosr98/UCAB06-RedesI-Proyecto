using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class UI_Jugador : MonoBehaviour{
    
    public GameObject cartaPrefab;
    public GameObject jugador; 
    public GameObject goCarta1;
    public GameObject goCarta2;
    public GameObject goCarta3;

    public Vector3 posicion;

    public UI_Carta cartaJugada;
    public UI_Carta carta1;
    public UI_Carta carta2;
    public UI_Carta carta3;

    void Start() {
        
    }

    public void instanciarCarta(float x, float y, int carta) {
        Debug.Log("UI_Jugador.instanciarCarta()");
        switch(carta) {
            case 1: goCarta1 = Instantiate(cartaPrefab);
                    goCarta1.transform.SetParent(jugador.transform);
                    posicion = jugador.transform.position;
                    posicion.x += x;
                    posicion.y += y;
                    goCarta1.transform.position = posicion;
                    carta1 = goCarta1.GetComponent<UI_Carta>();
                    carta1.noMostrarCarta();
                    break;
            case 2: goCarta2 = Instantiate(cartaPrefab);
                    goCarta2.transform.SetParent(jugador.transform);
                    posicion = jugador.transform.position;
                    posicion.x += x;
                    posicion.y += y;
                    goCarta2.transform.position = posicion;
                    carta2 = goCarta2.GetComponent<UI_Carta>();
                    carta2.noMostrarCarta();
                    break;
            case 3: goCarta3 = Instantiate(cartaPrefab);
                    goCarta3.transform.SetParent(jugador.transform);
                    posicion = jugador.transform.position;
                    posicion.x += x;
                    posicion.y += y;
                    goCarta3.transform.position = posicion;
                    carta3 = goCarta3.GetComponent<UI_Carta>();
                    carta3.noMostrarCarta();
                    break;
        }
    }

    public void activarJugador(){
        carta1.mostrarCarta();
        carta2.mostrarCarta();
        carta3.mostrarCarta();
        carta1.activarCarta();
        carta2.activarCarta();
        carta3.activarCarta();
    }
    public void jugarCarta( int carta, float x, float y, bool reiniciar ){
        Debug.Log("UI_Jugador.jugarCarta()");
        switch(carta) {
            case 1: posicion.x += x;
                    posicion.y += y;
                    goCarta1.transform.position = posicion;
                    if (reiniciar) {
                        carta1.noMostrarCarta();
                        carta1.activarCarta();
                    } else {
                        carta1.mostrarCarta();
                        carta1.desactivarCarta();
                    }
                    break;
            case 2: posicion.x += x;
                    posicion.y += y;
                    goCarta2.transform.position = posicion;
                    if (reiniciar) {
                        carta2.noMostrarCarta();
                        carta2.activarCarta();
                    } else {
                        carta2.mostrarCarta();
                        carta2.desactivarCarta();
                    }
                    break;
            case 3: posicion.x += x;
                    posicion.y += y;
                    goCarta3.transform.position = posicion;
                    if (reiniciar) {
                        carta3.noMostrarCarta();
                        carta3.activarCarta();
                    } else {
                        carta3.mostrarCarta();
                        carta3.desactivarCarta();
                    }
                    break;
        }
    }
    /* public void desactivarTurno() {
        Debug.Log("UI_Jugador.desactivarTurno()");
        btnTurno.interactable = false;
    }
    public void activarTurno() {
        Debug.Log("UI_Jugador.activarTurno()");
        btnTurno.interactable = true;
    }
    public void desactivarFlor() {
        Debug.Log("UI_Jugador.desactivarFlor()");
        btnFlor.interactable = false;
    }
    public void activarFlor() {
        Debug.Log("UI_Jugador.activarFlor()");
        btnFlor.interactable = true;
    } */
}