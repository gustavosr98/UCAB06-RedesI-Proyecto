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

    public int turno = 0;
    public 


    
    System.Random aleatorio = new System.Random();

    public List<Carta> cartas = new List<Carta>();
    public UI_Info info = new UI_Info();

    void Start() {
        ui = GameObject.Find("Interfaz").GetComponent<Interfaz>();
        log = GameObject.Find("Logica").GetComponent<Logica>();
        vira = GameObject.Find("Vira").GetComponent<UI_Vira>();
        ui.info.mano = GameObject.Find("InMano").GetComponent<InputField>();
        ui.info.ronda1 = GameObject.Find("InRonda1").GetComponent<InputField>();
        ui.info.ronda2 = GameObject.Find("InRonda2").GetComponent<InputField>();
        ui.info.ronda3 = GameObject.Find("InRonda3").GetComponent<InputField>();
        ui.mesa.jugador1.goCarta1.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(1,1);} );
        ui.mesa.jugador1.goCarta2.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(1,2);} );
        ui.mesa.jugador1.goCarta3.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(1,3);} );
        ui.mesa.jugador2.goCarta1.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(2,1);} );
        ui.mesa.jugador2.goCarta2.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(2,2);} );
        ui.mesa.jugador2.goCarta3.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(2,3);} );
        ui.mesa.jugador3.goCarta1.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(3,1);} );
        ui.mesa.jugador3.goCarta2.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(3,2);} );
        ui.mesa.jugador3.goCarta3.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(4,3);} );
        ui.mesa.jugador4.goCarta1.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(4,3);} );
        ui.mesa.jugador4.goCarta2.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(4,3);} );
        ui.mesa.jugador4.goCarta3.GetComponent<Button>().onClick.AddListener( () => {jugarCarta(4,3);} );
        //repartirCartasAleatorio();
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
            if( personaGanador == "1" || personaGanador == "3"){
                log.partida.ronda1 = "AC";
                ui.info.set_ronda1(log.partida.ronda1); 
                if(personaGanador == "1")
                    log.partida.mano = "A";
                else
                    log.partida.mano = "C";

            }
            else if (personaGanador == "2" || personaGanador == "4"){
                log.partida.ronda1 = "BD";
                ui.info.set_ronda1(log.partida.ronda1);
                if(personaGanador == "2")
                    log.partida.mano = "B";
                else
                    log.partida.mano = "D";
            }
            else {
                log.partida.ronda1 = "Empate";
                ui.info.set_ronda1(log.partida.ronda1);

            }
        }
        else if ( log.partida.ronda2.ToLower().Contains("Ronda Actual".ToLower()) ){
            if( personaGanador == "1" || personaGanador == "3"){
                log.partida.ronda2 = "AC";
                ui.info.set_ronda2(log.partida.ronda2);       
                if(personaGanador == "1")
                    log.partida.mano = "A";
                else
                    log.partida.mano = "C";       

            }
            else if (personaGanador == "2" || personaGanador == "4"){
                log.partida.ronda2 = "BD";
                ui.info.set_ronda2(log.partida.ronda2);   
                if(personaGanador == "2")
                    log.partida.mano = "B";
                else 
                    log.partida.mano = "D";           

            }
            else{
                log.partida.ronda2 = "Empate";
                ui.info.set_ronda2(log.partida.ronda2);              
            }
        }
        else if ( log.partida.ronda3.ToLower().Contains("Ronda Actual".ToLower()) ){
            if( personaGanador == "1" || personaGanador == "3"){
                log.partida.ronda3 = "AC";
                ui.info.set_ronda3(log.partida.ronda3);              
                
            }
            else if (personaGanador == "2" || personaGanador == "4"){
                log.partida.ronda3 = "BD";
                ui.info.set_ronda3(log.partida.ronda3);              

            }
            else{
                log.partida.ronda3 = "Empate";
                ui.info.set_ronda3(log.partida.ronda3);              
            }
        }
        darTurnoMano();
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
        darTurnoMano();

        /*
            com.ronda.darCartas("A",
                ui.mesa.jugador1.carta1.pinta, ui.mesa.jugador1.carta1.numero,
                ui.mesa.jugador1.carta2.pinta, ui.mesa.jugador1.carta2.numero,
                ui.mesa.jugador1.carta3.pinta, ui.mesa.jugador1.carta3.numero
            )
            com.ronda.darCartas("B"...)
        */
    }

    public void activarJugadores(string x){
        if(x == "A"){
            ui.mesa.jugador1.activarJugador();
        }
        else if(x == "B"){
            ui.mesa.jugador2.activarJugador();
        }
        else if(x == "C"){
            ui.mesa.jugador3.activarJugador();
        }
        else if(x == "D"){
            ui.mesa.jugador4.activarJugador();
        }


    }

    public void darTurnoMano(){
        permitirJugada( log.partida.mano.ToUpper() );
    }

    public void darTurno(int turno){
        if(turno == 1){
            permitirJugada("A");
        }
        else if(turno == 2){
            permitirJugada("B");
        }
        else if(turno == 3){
            permitirJugada("C");
        }
        else if(turno == 4){
            permitirJugada("D");
        }
    }


    public void permitirJugada(string x){
        if(x == "A"){
            ui.mesa.desactivarTurno(2);
            ui.mesa.jugador2.bloquearCartas();
            ui.mesa.desactivarTurno(3);
            ui.mesa.jugador3.bloquearCartas();
            ui.mesa.desactivarTurno(4);
            ui.mesa.jugador4.bloquearCartas();
            ui.mesa.activarTurno(1);
        }
        else if(x == "B"){
            ui.mesa.desactivarTurno(1);
            ui.mesa.jugador1.bloquearCartas();
            ui.mesa.desactivarTurno(3);
            ui.mesa.jugador3.bloquearCartas();
            ui.mesa.desactivarTurno(4);
            ui.mesa.jugador4.bloquearCartas();
            ui.mesa.activarTurno(2);
        }
        else if(x == "C"){
            ui.mesa.desactivarTurno(1);
            ui.mesa.jugador1.bloquearCartas();
            ui.mesa.desactivarTurno(2);
            ui.mesa.jugador2.bloquearCartas();
            ui.mesa.desactivarTurno(4);
            ui.mesa.jugador4.bloquearCartas();
            ui.mesa.activarTurno(3);
        }
        else if(x == "D"){
            ui.mesa.desactivarTurno(1);
            ui.mesa.jugador1.bloquearCartas();
            ui.mesa.desactivarTurno(2);
            ui.mesa.jugador2.bloquearCartas();
            ui.mesa.desactivarTurno(3);
            ui.mesa.jugador3.bloquearCartas();
            ui.mesa.activarTurno(4);
        }
        activarJugadores(x);
    }


    public void jugarCarta(int jugador,int carta){
        cont++;
        Debug.Log(jugador);
        if(jugador == 1){
            turno = 2;

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
            turno = 3;         
            Debug.Log("PERRA2");

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
            turno = 4;
            Debug.Log("PERRA3");
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
            Debug.Log("PERRA4");
            turno = 1;           
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
        if (cont == 4){
            cont = 0;
            terminarRonda();
        }
        else darTurno(turno);
        
    }

}