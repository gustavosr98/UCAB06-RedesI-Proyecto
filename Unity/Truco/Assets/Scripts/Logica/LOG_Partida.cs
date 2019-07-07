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

    public string mano = "B";

    public bool envido = false;

    public string ronda1 = "Ronda actual";
    public string ronda2 = "Por jugar";
    public string ronda3 = "Por jugar";

    public UI_Vira vira = new UI_Vira();

    void Start(){
        // com = GameObject.Find("TODAVIA NO RECUERDO").GetComponent<Comunicacion>();
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
        
        // REINICIAR DATOS DE PARTIDA

        if ( /* log.juego.ptsAC >= 24 */ true ){
            // log.juego.terminarJuego( "AC" )
            // com.enviar(HAY GANADOR)
        } else if (bd >= 24){

        }
    }

    public void actualizarMano(){
        
    }





    
}