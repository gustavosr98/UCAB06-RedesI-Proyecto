using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LOG_Partida : MonoBehaviour {
    Comunicacion com;
    Interfaz ui;
    Logica log;
    
    // DATOS DEL PARTIDA 
    public string nivelTruco = "Normal";
    public string voz = "Ambos";

   

    public bool envido = false;

    public string ronda1 = "Ronda Actual";
    public string ronda2 = "Por jugar";
    public string ronda3 = "Por jugar";
    public string mano = "B";

    public UI_Vira vira = new UI_Vira();
    public UI_Info info = new UI_Info();

    void Start(){
        // com = GameObject.Find("TODAVIA NO RECUERDO").GetComponent<Comunicacion>();
    }

    public void setearRondas(){

    }

    // METODOS 

    public void terminarPartida(int ac , int bd){
        // com.enviar(DAR_PUNTOS_PARTIDA)
        /*
            ui.info.set_ptsAC( ac )
            ui.info.set_ptsBD( ac )
            log.juego.ptsAC += ac 
            log.juego.ptsBD += bd
        */
        ui.info.set_ptsAC( ac );
        ui.info.set_ptsBD( bd );
        log.juego.ptsAC += ac;
        log.juego.ptsBD += bd;
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

    public void actualizarVoz(string voz){
        ui.info.set_voz(voz);
    }

    public void actualizarEnvido(bool envido) {
        if(envido) {
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