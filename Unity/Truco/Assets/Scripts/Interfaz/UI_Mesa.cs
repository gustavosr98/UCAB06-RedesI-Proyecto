using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Mesa : MonoBehaviour{

    public GameObject jugadorPrefab;
    public GameObject mesa; 
    public GameObject goJugador1;
    public GameObject goJugador2;
    public GameObject goJugador3;
    public GameObject goJugador4;

    public Vector3 posicion;
    
    public Button btnTurno1;
    public Button btnFlor1;
    public Button btnTurno2;
    public Button btnFlor2;
    public Button btnTurno3;
    public Button btnFlor3;
    public Button btnTurno4;
    public Button btnFlor4;

    public UI_Jugador jugador1;
    public UI_Jugador jugador2;
    public UI_Jugador jugador3;
    public UI_Jugador jugador4;

 
    void Start() {
        instanciarJugador(0,-550,1);
        instanciarJugador(1000,0,2);
        instanciarJugador(0,550,3);
        instanciarJugador(-1000,0,4);
    }

    public void instanciarJugador(float x, float y, int jugador) {
        Debug.Log("UI_Mesa.instanciarJugador()");
        switch(jugador) {
            case 1: goJugador1 = Instantiate(jugadorPrefab);
                    goJugador1.transform.SetParent(mesa.transform);
                    posicion = mesa.transform.position;
                    posicion.x += x;
                    posicion.y += y;
                    goJugador1.transform.position = posicion;
                    jugador1 = goJugador1.GetComponent<UI_Jugador>();
                    jugador1.instanciarCarta(-250,0,1);
                    jugador1.instanciarCarta(0,0,2);
                    jugador1.instanciarCarta(250,0,3);
                    btnTurno1 = GameObject.Find("BtnTurno1").GetComponent<Button>();
                    btnFlor1 = GameObject.Find("BtnFlor1").GetComponent<Button>();
                    break;
            case 2: goJugador2 = Instantiate(jugadorPrefab);
                    goJugador2.transform.SetParent(mesa.transform);
                    posicion = mesa.transform.position;
                    posicion.x += x;
                    posicion.y += y;
                    goJugador2.transform.position = posicion;
                    jugador2 = goJugador2.GetComponent<UI_Jugador>();
                    jugador2.instanciarCarta(-250,0,1);
                    jugador2.instanciarCarta(0,0,2);
                    jugador2.instanciarCarta(250,0,3);
                    btnTurno2 = GameObject.Find("BtnTurno2").GetComponent<Button>();
                    btnFlor2 = GameObject.Find("BtnFlor2").GetComponent<Button>();
                    break;
            case 3: goJugador3 = Instantiate(jugadorPrefab);
                    goJugador3.transform.SetParent(mesa.transform);
                    posicion = mesa.transform.position;
                    posicion.x += x;
                    posicion.y += y;
                    goJugador3.transform.position = posicion;
                    jugador3 = goJugador3.GetComponent<UI_Jugador>();
                    jugador3.instanciarCarta(-250,0,1);
                    jugador3.instanciarCarta(0,0,2);
                    jugador3.instanciarCarta(250,0,3);
                    btnTurno3 = GameObject.Find("BtnTurno3").GetComponent<Button>();
                    btnFlor3 = GameObject.Find("BtnFlor3").GetComponent<Button>();
                    break;
            case 4: goJugador4 = Instantiate(jugadorPrefab);
                    goJugador4.transform.SetParent(mesa.transform);
                    posicion = mesa.transform.position;
                    posicion.x += x;
                    posicion.y += y;
                    goJugador4.transform.position = posicion;
                    jugador4 = goJugador4.GetComponent<UI_Jugador>();
                    jugador4.instanciarCarta(-250,0,1);
                    jugador4.instanciarCarta(0,0,2);
                    jugador4.instanciarCarta(250,0,3);
                    btnTurno4 = GameObject.Find("BtnTurno4").GetComponent<Button>();
                    btnFlor4 = GameObject.Find("BtnFlor4").GetComponent<Button>();
                    break;
        }
    }
    public void desactivarTurno(int jugador) {
        Debug.Log("UI_Mesa.desactivarTurno()");
        switch(jugador) {
            case 1: btnTurno1.interactable = false;
                    break;
            case 2: btnTurno2.interactable = false;
                    break;
            case 3: btnTurno3.interactable = false;
                    break;
            case 4: btnTurno4.interactable = false;
                    break;
        }
    }
    public void activarTurno(int jugador) {
        Debug.Log("UI_Mesa.activarTurno()");
        switch(jugador) {
            case 1: btnTurno1.interactable = true;
                    break;
            case 2: btnTurno2.interactable = true;
                    break;
            case 3: btnTurno3.interactable = true;
                    break;
            case 4: btnTurno4.interactable = true;
                    break;
        }
    }
    public void desactivarFlor(int jugador) {
        Debug.Log("UI_Mesa.desactivarFlor()");
        switch(jugador) {
            case 1: btnFlor1.interactable = false;
                    break;
            case 2: btnFlor2.interactable = false;
                    break;
            case 3: btnFlor3.interactable = false;
                    break;
            case 4: btnFlor4.interactable = false;
                    break;
        }
    }
    public void activarFlor(int jugador) {
        Debug.Log("UI_Mesa.activarFlor()");
        switch(jugador) {
            case 1: btnFlor1.interactable = true;
                    break;
            case 2: btnFlor2.interactable = true;
                    break;
            case 3: btnFlor3.interactable = true;
                    break;
            case 4: btnFlor4.interactable = true;
                    break;
        }
    }
}
