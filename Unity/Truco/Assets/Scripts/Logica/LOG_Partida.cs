using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LOG_Partida : MonoBehaviour {
    Comunicacion com;
    Interfaz ui;
    Logica log;
    Carta carta;
    
    // DATOS DEL PARTIDA 
    public string nivelTruco = "Normal";
    public string voz = "Ambos";

    public string mano = "B";

    public bool envido = false;


    public string ronda1 = "Ronda Actual";
    public string ronda2 = "Por jugar";
    public string ronda3 = "Por jugar";

    public UI_Vira vira = new UI_Vira();


    void Start(){
        // com = GameObject.Find("TODAVIA NO RECUERDO").GetComponent<Comunicacion>();
        subirApuesta();
    }

    // METODOS 

    public void calcularEnvido() {
        int ganador1 = carta.envido(ui.mesa.jugador1.carta1.numero, ui.mesa.jugador1.carta1.pinta,
                                    ui.mesa.jugador1.carta2.numero, ui.mesa.jugador1.carta2.pinta,
                                    ui.mesa.jugador1.carta3.numero, ui.mesa.jugador1.carta3.pinta,
                                    ui.mesa.jugador2.carta1.numero, ui.mesa.jugador2.carta1.pinta,
                                    ui.mesa.jugador2.carta2.numero, ui.mesa.jugador2.carta2.pinta,
                                    ui.mesa.jugador2.carta3.numero, ui.mesa.jugador2.carta3.pinta, );

        int ganador2 = carta.envido(ui.mesa.jugador3.carta1.numero, ui.mesa.jugador3.carta1.pinta,
                                    ui.mesa.jugador3.carta2.numero, ui.mesa.jugador3.carta2.pinta,
                                    ui.mesa.jugador3.carta3.numero, ui.mesa.jugador3.carta3.pinta,
                                    ui.mesa.jugador4.carta1.numero, ui.mesa.jugador4.carta1.pinta,
                                    ui.mesa.jugador4.carta2.numero, ui.mesa.jugador4.carta2.pinta,
                                    ui.mesa.jugador4.carta3.numero, ui.mesa.jugador4.carta3.pinta, );

        UI_Jugador gan1, gan2, ganador;
        if(ganador1 == -1) {
            gan1 = ui.mesa.jugador1;
        } else {
            gan1 = ui.mesa.jugador2;
        }
        if(ganador2 == -1) {
            gan2 = ui.mesa.jugador3;
        } else {
            gan2 = ui.mesa.jugador4;
        }
        int ganadorTotal = carta.envido(gan1.carta1.numero, gan1.carta1.pinta,
                                        gan1.carta2.numero, gan1.carta2.pinta,
                                        gan1.carta3.numero, gan1.carta3.pinta,
                                        gan2.carta1.numero, gan2.carta1.pinta,
                                        gan2.carta2.numero, gan2.carta2.pinta,
                                        gan2.carta3.numero, gan2.carta3.pinta, );

        if(ganadorTotal == 1) {
            ganador = gan2;
        } else if(ganadorTotal == -1) {
            ganador = gan1;
        } else {
            //empate
        }
    }

    public void terminarPartida(int ac , int bd){
        // com.enviar(DAR_PUNTOS_PARTIDA)
        /*
            ui.info.set_ptsAC( ac )
            ui.info.set_ptsBD( ac )
            log.juego.ptsAC += ac 
            log.juego.ptsBD += bd
        */
        ui.info.set_ptsAC( this.ac + ac );
        ui.info.set_ptsBD( this.bd + bd );
        log.juego.ptsAC += this.ac + ac;
        log.juego.ptsBD += this.bd + bd;
        // REINICIAR DATOS DE PARTIDA

        if ( log.juego.ptsAC >= 24 ){
            log.juego.terminarJuego( "AC" );
            // com.enviar(HAY GANADOR)
        } else if (bd >= 24){
            log.juego.terminarJuego( "BD" );
        }
    }

    public void set_nivelTruco() {
        nivelTruco = ui.apuesta.trucoActual;
        ui.info.set_nivelTruco(nivelTruco);
    }

    public void actualizarMano(){
        if(mano == "A") {
            mano = "B";
            ui.info.set_mano(mano);
        } else if(mano == "B") {
            mano = "C";
            ui.info.set_mano(mano);
        } else if(mano == "C") {
            mano = "D";
            ui.info.set_mano(mano);
        } else if(mano == "D") {
            mano = "A";
            ui.info.set_mano(mano);
        }
    }

    public void subirApuesta() {
        if(log.juego.jugador == "A" && ui.mesa.btnTurno1.interactable == true) {
            ui.apuesta.activarTruco();
            ui.apuesta.activarBtnTrucoSi();
            ui.apuesta.activarBtnTrucoNo();
            ui.apuesta.activarEnvido();
            ui.apuesta.activarBtnEnvidoSi();
            ui.apuesta.activarBtnEnvidoNo();
            vozActual = "AC";
        } else if (log.juego.jugador == "B" && ui.mesa.btnTurno2.interactable == true) {
            ui.apuesta.activarTruco();
            ui.apuesta.activarBtnTrucoSi();
            ui.apuesta.activarBtnTrucoNo();
            ui.apuesta.activarEnvido();
            ui.apuesta.activarBtnEnvidoSi();
            ui.apuesta.activarBtnEnvidoNo();
            vozActual = "BD";
        } else if (log.juego.jugador == "C" && ui.mesa.btnTurno3.interactable == true) {
            ui.apuesta.activarTruco();
            ui.apuesta.activarBtnTrucoSi();
            ui.apuesta.activarBtnTrucoNo();
            ui.apuesta.activarEnvido();
            ui.apuesta.activarBtnEnvidoSi();
            ui.apuesta.activarBtnEnvidoNo();
            vozActual = "A9";
        } else if (log.juego.jugador == "D" && ui.mesa.btnTurno4.interactable == true) {
            ui.apuesta.activarTruco();
            ui.apuesta.activarBtnTrucoSi();
            ui.apuesta.activarBtnTrucoNo();
            ui.apuesta.activarEnvido();
            ui.apuesta.activarBtnEnvidoSi();
            ui.apuesta.activarBtnEnvidoNo();
            vozActual = "BD";
        }
    }

    public void actualizarVoz(){
        ui.info.set_voz(vozActual);
    }

    public void actualizarEnvido() {
        if(ui.apuesta.envido) {
            ui.info.set_envido("Si");
        } else {
            ui.info.set_envido("No");
        }
    }

    public void actualizarRonda1(string ronda1) {
        ui.info.set_ronda1(ronda1);
    }

    public void actualizarRonda2(string ronda2) {
        ui.info.set_ronda2(ronda2);
    }

    public void actualizarRonda3(string ronda3) {
        ui.info.set_ronda3(ronda3);
    }


    
}