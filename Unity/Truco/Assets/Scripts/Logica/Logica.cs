using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logica : MonoBehaviour
{
    public Interfaz interfaz;
    public Comunicacion comunicacion;

    public LOG_Ronda ronda;
    public LOG_Partida partida;
    public LOG_Juego juego;

    void Start(){
        ronda = gameObject.GetComponent<LOG_Ronda>();
        juego = gameObject.GetComponent<LOG_Juego>();
        partida = gameObject.GetComponent<LOG_Partida>();
    }
}