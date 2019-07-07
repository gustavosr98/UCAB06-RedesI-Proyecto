using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class LOG_Ronda : MonoBehaviour {
    public Logica log;
    public Comunicacion com;
    public Interfaz ui;
    
    System.Random aleatorio = new System.Random();
    /* 
        public string masFuerte;
        masFuerte e { A, B, C, D, empate }

        public UI_Carta carta1
        public UI_Carta carta2
        public UI_Carta carta3
        public UI_Carta carta4
    */

    public void revisarMasFuerte(){

    }
    public List<Carta> cartas = new List<Carta>();

    void Start() {
        ui = GameObject.Find("Interfaz").GetComponent<Interfaz>();
        log = GameObject.Find("Logica").GetComponent<Logica>();
    }

    public void crearArray() {
        Carta x;
        cartas = new List<Carta>();
        x = new Carta( "O", 1 );
        cartas.Add(x);
        x = new Carta( "O", 2 );
        cartas.Add(x);
        x = new Carta( "O", 3 );
        cartas.Add(x);
        x = new Carta( "O", 4 );
        cartas.Add(x);
        x = new Carta( "O", 5 );
        cartas.Add(x);
        x = new Carta( "O", 6 );
        cartas.Add(x);
        x = new Carta( "O", 7 );
        cartas.Add(x);
        x = new Carta( "O", 10 );
        cartas.Add(x);
        x = new Carta( "O", 11 );
        cartas.Add(x);
        x = new Carta( "O", 12 );
        cartas.Add(x);
        x = new Carta( "E", 1 );
        cartas.Add(x);
        x = new Carta( "E", 2 );
        cartas.Add(x);
        x = new Carta( "E", 3 );
        cartas.Add(x);
        x = new Carta( "E", 4 );
        cartas.Add(x);
        x = new Carta( "E", 5 );
        cartas.Add(x);
        x = new Carta( "E", 6 );
        cartas.Add(x);
        x = new Carta( "E", 7 );
        cartas.Add(x);
        x = new Carta( "E", 10 );
        cartas.Add(x);
        x = new Carta( "E", 11 );
        cartas.Add(x);
        x = new Carta( "E", 12 );
        cartas.Add(x);
        x = new Carta( "C", 1 );
        cartas.Add(x);
        x = new Carta( "C", 2 );
        cartas.Add(x);
        x = new Carta( "C", 3 );
        cartas.Add(x);
        x = new Carta( "C", 4 );
        cartas.Add(x);
        x = new Carta( "C", 5 );
        cartas.Add(x);
        x = new Carta( "C", 6 );
        cartas.Add(x);
        x = new Carta( "C", 7 );
        cartas.Add(x);
        x = new Carta( "C", 10 );
        cartas.Add(x);
        x = new Carta( "C", 11 );
        cartas.Add(x);
        x = new Carta( "C", 12 );
        cartas.Add(x);
        x = new Carta( "B", 1 );
        cartas.Add(x);
        x = new Carta( "B", 2 );
        cartas.Add(x);
        x = new Carta( "B", 3 );
        cartas.Add(x);
        x = new Carta( "B", 4 );
        cartas.Add(x);
        x = new Carta( "B", 5 );
        cartas.Add(x);
        x = new Carta( "B", 6 );
        cartas.Add(x);
        x = new Carta( "B", 7 );
        cartas.Add(x);
        x = new Carta( "B", 10 );
        cartas.Add(x);
        x = new Carta( "B", 11 );
        cartas.Add(x);
        x = new Carta( "B", 12 );
        cartas.Add(x);
    }

    public Carta generarRandom(){
        int index = aleatorio.Next(cartas.Count-1);
        Carta carta = cartas[index];
        cartas.RemoveAt(index);
        return carta;
    }
    
    IEnumerator Esperar(int x){
        yield return new WaitForSeconds(x);
    }

    public void repartirCartasAleatorio(){
        Carta carta;
        crearArray();
        carta = generarRandom();
        ui.mesa.jugador1.carta1.darValor(carta.pinta,carta.numero);
        carta = generarRandom();
        ui.mesa.jugador1.carta2.darValor(carta.pinta,carta.numero);
        carta = generarRandom();
        ui.mesa.jugador1.carta3.darValor(carta.pinta,carta.numero);
        carta = generarRandom();
        ui.mesa.jugador2.carta1.darValor(carta.pinta,carta.numero);
        carta = generarRandom();
        ui.mesa.jugador2.carta2.darValor(carta.pinta,carta.numero);
        carta = generarRandom();
        ui.mesa.jugador2.carta3.darValor(carta.pinta,carta.numero);
        carta = generarRandom();
        ui.mesa.jugador3.carta1.darValor(carta.pinta,carta.numero);
        carta = generarRandom();
        ui.mesa.jugador3.carta2.darValor(carta.pinta,carta.numero);
        carta = generarRandom();
        ui.mesa.jugador3.carta3.darValor(carta.pinta,carta.numero);
        carta = generarRandom();
        ui.mesa.jugador4.carta1.darValor(carta.pinta,carta.numero);
        carta = generarRandom();
        ui.mesa.jugador4.carta2.darValor(carta.pinta,carta.numero);
        carta = generarRandom();
        ui.mesa.jugador4.carta3.darValor(carta.pinta,carta.numero);

        /*
            com.ronda.darCartas("A",
                ui.mesa.jugador1.carta1.pinta, ui.mesa.jugador1.carta1.numero,
                ui.mesa.jugador1.carta2.pinta, ui.mesa.jugador1.carta2.numero,
                ui.mesa.jugador1.carta3.pinta, ui.mesa.jugador1.carta3.numero
            )
            com.ronda.darCartas("B"...)
        */
    }

    public void jugarCarta_e(){
        // YUCA
        revisarMasFuerte();
        // ui.bloquearJugador("")
    }

    public void jugar(){

    }


}