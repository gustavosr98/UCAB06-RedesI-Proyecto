using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;


public class LOG_Ronda : MonoBehaviour {
    public Logica log;
    public Comunicacion com;
    public Interfaz ui;

    public int cont = 0;
    public string pinta;
    public int numero;

    public UI_Carta cartaFuerte;

    public bool empate = false;

    public UI_Vira vira;


    
    System.Random aleatorio = new System.Random();

    public List<Carta> cartas = new List<Carta>();

    void Start() {
        ui = GameObject.Find("Interfaz").GetComponent<Interfaz>();
        log = GameObject.Find("Logica").GetComponent<Logica>();
        vira = GameObject.Find("Vira").GetComponent<UI_Vira>();
        ui.mesa.jugador1.goCarta1.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(1,1);} );
        ui.mesa.jugador1.goCarta2.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(1,2);} );
        ui.mesa.jugador1.goCarta3.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(1,3);} );
        ui.mesa.jugador2.goCarta1.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(2,1);} );
        ui.mesa.jugador2.goCarta2.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(2,2);} );
        ui.mesa.jugador2.goCarta3.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(2,3);} );
        ui.mesa.jugador3.goCarta1.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(3,1);} );
        ui.mesa.jugador3.goCarta2.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(3,2);} );
        ui.mesa.jugador3.goCarta3.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(3,3);} );
        ui.mesa.jugador4.goCarta1.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(3,3);} );
        ui.mesa.jugador4.goCarta2.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(3,3);} );
        ui.mesa.jugador4.goCarta3.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(3,3);} );
        repartirCartasAleatorio();
    }

    public void revisarMasFuerte(UI_Carta carta){
        if(!cartaFuerte){
            cartaFuerte = carta;
        }
        else{
            int res = Carta.duelo(carta.numero,carta.pinta,cartaFuerte.numero,cartaFuerte.pinta,vira.pinta);
            if(res == -1){
                cartaFuerte = carta;
                empate = false;
            }
            else if(res==1){}
            else{
                empate = true;
                cartaFuerte = carta;
            } 
            
        }
    }
    public void terminarRonda(){
        string personaGanador = cartaFuerte.gameObject.name.Substring(7,1);
        Debug.Log( personaGanador);
        if ( log.partida.ronda1.ToLower().Contains("Ronda Actual".ToLower()) ){
            if( personaGanador == "1" || personaGanador == "3")
                log.partida.ronda1 = "AC";
            else if (personaGanador == "2" || personaGanador == "4")
                log.partida.ronda1 = "BD";
            else log.partida.ronda1 = "Empate";
        }
        else if ( log.partida.ronda2.ToLower().Contains("Ronda Actual".ToLower()) ){
            if( personaGanador == "1" || personaGanador == "3")
                log.partida.ronda2 = "AC";
            else if (personaGanador == "2" || personaGanador == "4")
                log.partida.ronda2 = "BD";
            else log.partida.ronda2 = "Empate";
        }
        else if ( log.partida.ronda3.ToLower().Contains("Ronda Actual".ToLower()) ){
            if( personaGanador == "1" || personaGanador == "3")
                log.partida.ronda3 = "AC";
            else if (personaGanador == "2" || personaGanador == "4")
                log.partida.ronda3 = "BD";
            else log.partida.ronda3 = "Empate";
        }
        Debug.Log( log.partida.ronda1 );

        

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
        carta = generarRandom();
        ui.vira.darValor(carta.pinta,carta.numero);

        /*
            com.ronda.darCartas("A",
                ui.mesa.jugador1.carta1.pinta, ui.mesa.jugador1.carta1.numero,
                ui.mesa.jugador1.carta2.pinta, ui.mesa.jugador1.carta2.numero,
                ui.mesa.jugador1.carta3.pinta, ui.mesa.jugador1.carta3.numero
            )
            com.ronda.darCartas("B"...)
        */
    }

    public void activarJugadores(){
        /*
            com.ronda.darCartas("A",
                ui.mesa.jugador1.carta1.pinta, ui.mesa.jugador1.carta1.numero,
                ui.mesa.jugador1.carta2.pinta, ui.mesa.jugador1.carta2.numero,
                ui.mesa.jugador1.carta3.pinta, ui.mesa.jugador1.carta3.numero
            )
            com.ronda.darCartas("B"...)
        */
        if(log.juego.jugador == "A"){
            ui.mesa.jugador1.activarJugador();
        }
        else if(log.juego.jugador == "B"){
            ui.mesa.jugador2.activarJugador();
        }
        else if(log.juego.jugador == "C"){
            ui.mesa.jugador3.activarJugador();
        }
        else if(log.juego.jugador == "D"){
            ui.mesa.jugador4.activarJugador();
        }


    }

    public void darTurno(){
        if(log.juego.jugador == "A"){
            ui.mesa.desactivarTurno(2);
            ui.mesa.jugador2.bloquearCartas();
            ui.mesa.desactivarTurno(3);
            ui.mesa.jugador3.bloquearCartas();
            ui.mesa.desactivarTurno(4);
            ui.mesa.jugador4.bloquearCartas();
            ui.mesa.activarTurno(1);
        }
        else if(log.juego.jugador == "B"){
            ui.mesa.desactivarTurno(1);
            ui.mesa.jugador1.bloquearCartas();
            ui.mesa.desactivarTurno(3);
            ui.mesa.jugador3.bloquearCartas();
            ui.mesa.desactivarTurno(4);
            ui.mesa.jugador4.bloquearCartas();
            ui.mesa.activarTurno(2);
        }
        else if(log.juego.jugador == "C"){
            ui.mesa.desactivarTurno(1);
            ui.mesa.jugador1.bloquearCartas();
            ui.mesa.desactivarTurno(2);
            ui.mesa.jugador2.bloquearCartas();
            ui.mesa.desactivarTurno(4);
            ui.mesa.jugador4.bloquearCartas();
            ui.mesa.activarTurno(3);
        }
        else if(log.juego.jugador == "D"){
            ui.mesa.desactivarTurno(1);
            ui.mesa.jugador1.bloquearCartas();
            ui.mesa.desactivarTurno(2);
            ui.mesa.jugador2.bloquearCartas();
            ui.mesa.desactivarTurno(3);
            ui.mesa.jugador3.bloquearCartas();
            ui.mesa.activarTurno(4);
        }
        activarJugadores();
    }


    public void jugarCarta(int jugador,int carta){
        cont++;
        if(jugador == 1){
            if(carta == 1){
                pinta = ui.mesa.jugador1.carta1.pinta;
                numero = ui.mesa.jugador1.carta1.numero;
                revisarMasFuerte(ui.mesa.jugador1.carta1);
                //mandar por com
            }
            else if(carta == 2){
                pinta = ui.mesa.jugador1.carta2.pinta;
                numero = ui.mesa.jugador1.carta2.numero;
                revisarMasFuerte(ui.mesa.jugador1.carta2);
            }
            else if(carta == 3){
                pinta = ui.mesa.jugador1.carta3.pinta;
                numero = ui.mesa.jugador1.carta3.numero;
                revisarMasFuerte(ui.mesa.jugador1.carta3);
            }

        }
        else if(jugador == 2){
            
            if(carta == 1){
                pinta = ui.mesa.jugador2.carta1.pinta;
                numero = ui.mesa.jugador2.carta1.numero;
                revisarMasFuerte(ui.mesa.jugador2.carta1);

                //mandar por com
            }
            else if(carta == 2){
                pinta = ui.mesa.jugador2.carta2.pinta;
                numero = ui.mesa.jugador2.carta2.numero;
                revisarMasFuerte(ui.mesa.jugador2.carta2);

            }
            else if(carta == 3){
                pinta = ui.mesa.jugador2.carta3.pinta;
                numero = ui.mesa.jugador2.carta3.numero;
                revisarMasFuerte(ui.mesa.jugador2.carta3);

            }
        }
        else if(jugador == 3){
            
            if(carta == 1){
                pinta = ui.mesa.jugador3.carta1.pinta;
                numero = ui.mesa.jugador3.carta1.numero;
                revisarMasFuerte(ui.mesa.jugador3.carta1);
                
                //mandar por com
            }
            else if(carta == 2){
                pinta = ui.mesa.jugador3.carta2.pinta;
                numero = ui.mesa.jugador3.carta2.numero;
                revisarMasFuerte(ui.mesa.jugador3.carta2);

            }
            else if(carta == 3){
                pinta = ui.mesa.jugador3.carta3.pinta;
                numero = ui.mesa.jugador3.carta3.numero;
                revisarMasFuerte(ui.mesa.jugador3.carta3);

            }
        }
        else if(jugador == 4){
            
            if(carta == 1){
                pinta = ui.mesa.jugador4.carta1.pinta;
                numero = ui.mesa.jugador4.carta1.numero;
                revisarMasFuerte(ui.mesa.jugador4.carta1);

                //mandar por com
            }
            else if(carta == 2){
                pinta = ui.mesa.jugador4.carta2.pinta;
                numero = ui.mesa.jugador4.carta2.numero;
                revisarMasFuerte(ui.mesa.jugador4.carta2);

            }
            else if(carta == 3){
                pinta = ui.mesa.jugador4.carta3.pinta;
                numero = ui.mesa.jugador4.carta3.numero;
                revisarMasFuerte(ui.mesa.jugador4.carta3);

            }
        }
        ui.mesa.desactivarTurno(jugador);
        if (cont == 4) terminarRonda();
        
    }

}