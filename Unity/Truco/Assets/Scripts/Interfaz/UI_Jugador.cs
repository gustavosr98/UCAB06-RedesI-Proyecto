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
                    posicion.x += -250;
                    posicion.y += 0;
                    goCarta1.transform.position = posicion;
                    carta1 = goCarta1.GetComponent<UI_Carta>();
                    carta1.noMostrarCarta();
                    carta1.desactivarCarta();
                    break;
            case 2: goCarta2 = Instantiate(cartaPrefab);
                    goCarta2.transform.SetParent(jugador.transform);
                    posicion = jugador.transform.position;
                    posicion.x += 0;
                    posicion.y += 0;
                    goCarta2.transform.position = posicion;
                    carta2 = goCarta2.GetComponent<UI_Carta>();
                    carta2.noMostrarCarta();
                    carta2.desactivarCarta();
                    break;
            case 3: goCarta3 = Instantiate(cartaPrefab);
                    goCarta3.transform.SetParent(jugador.transform);
                    posicion = jugador.transform.position;
                    posicion.x += 250;
                    posicion.y += 0;
                    goCarta3.transform.position = posicion;
                    carta3 = goCarta3.GetComponent<UI_Carta>();
                    carta3.noMostrarCarta();
                    carta3.desactivarCarta();
                    break;
        }
    }

    public void asignarCartas(string pinta1, int numero1, string pinta2, int numero2, string pinta3, int numero3) {
        carta1.darValor(pinta1, numero1);
        carta2.darValor(pinta2, numero2);
        carta3.darValor(pinta3, numero3);
    }

    public void activarJugador(){
        carta1.mostrarCarta();
        carta2.mostrarCarta();
        carta3.mostrarCarta();
        carta1.activarCarta();
        carta2.activarCarta();
        carta3.activarCarta();
    }
    public void reiniciarJuego(int carta) {
        Debug.Log("UI_Jugador.reiniciarJuego()");
        switch(carta) {
            case 1: posicion = jugador.transform.position;
                    posicion.x += -250;
                    posicion.y += 0;
                    goCarta1.transform.position = posicion;
                    carta1.noMostrarCarta();
                    carta1.desactivarCarta();
                    break;
            case 2: posicion = jugador.transform.position;
                    posicion.x += 0;
                    posicion.y += 0;
                    goCarta2.transform.position = posicion;
                    carta2.noMostrarCarta();
                    carta2.desactivarCarta();
                    break;
            case 3: posicion = jugador.transform.position;
                    posicion.x += 250;
                    posicion.y += 0;
                    goCarta3.transform.position = posicion;
                    carta3.noMostrarCarta();
                    carta3.desactivarCarta();
                    break;
        }
    }

    public void jugarCarta( int jugador, int carta ){
        Debug.Log("UI_Jugador.jugarCarta()");
        switch(jugador) {
            case 1: posicion.x += -250;
                    posicion.y += 350;
                    switch(carta) {
                        case 1: goCarta1.transform.position = posicion;
                                carta1.mostrarCarta();
                                carta1.desactivarCarta();
                                break;
                        case 2: goCarta2.transform.position = posicion;
                                carta2.mostrarCarta();
                                carta2.desactivarCarta();
                                break;
                        case 3: goCarta3.transform.position = posicion;
                                carta3.mostrarCarta();
                                carta3.desactivarCarta();
                                break;
                    }
                    break;
            case 2: posicion.x += -850;
                    posicion.y += 0;
                    switch(carta) {
                        case 1: goCarta1.transform.position = posicion;
                                carta1.mostrarCarta();
                                carta1.desactivarCarta();
                                break;
                        case 2: goCarta2.transform.position = posicion;
                                carta2.mostrarCarta();
                                carta2.desactivarCarta();
                                break;
                        case 3: goCarta3.transform.position = posicion;
                                carta3.mostrarCarta();
                                carta3.desactivarCarta();
                                break;
                    }
                    break;
            case 3: posicion.x += -250;
                    posicion.y += -350;
                    switch(carta) {
                        case 1: goCarta1.transform.position = posicion;
                                carta1.mostrarCarta();
                                carta1.desactivarCarta();
                                break;
                        case 2: goCarta2.transform.position = posicion;
                                carta2.mostrarCarta();
                                carta2.desactivarCarta();
                                break;
                        case 3: goCarta3.transform.position = posicion;
                                carta3.mostrarCarta();
                                carta3.desactivarCarta();
                                break;
                    }
                    break;
            case 4: posicion.x += 350;
                    posicion.y += 0;
                    switch(carta) {
                        case 1: goCarta1.transform.position = posicion;
                                carta1.mostrarCarta();
                                carta1.desactivarCarta();
                                break;
                        case 2: goCarta2.transform.position = posicion;
                                carta2.mostrarCarta();
                                carta2.desactivarCarta();
                                break;
                        case 3: goCarta3.transform.position = posicion;
                                carta3.mostrarCarta();
                                carta3.desactivarCarta();
                                break;
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