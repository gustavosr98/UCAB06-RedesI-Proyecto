using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class UI_Jugador : MonoBehaviour{
    public Text turno;
    public Text flor;
    public UI_Carta cartaJugada;
    public UI_Carta carta1;
    public UI_Carta carta2;
    public UI_Carta carta3;

    public void jugarCarta( int cartaJugada ){
        // cartaJugada e { 1 , 2 , 3 }
    }

    public void activarTurno(){
        /*
            ponerle color rojo a turno
            activar las cartas para poder usar
        */
    }

    public void desactivarTurno(){

    }

    public void activarFlor(){

    }

    public void desactivarFlor(){

    }
}