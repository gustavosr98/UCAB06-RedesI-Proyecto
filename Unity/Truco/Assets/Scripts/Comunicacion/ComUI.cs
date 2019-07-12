using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public  class ComUI : MonoBehaviour {
    Interfaz ui;
    Logica log;
    Comunicacion com;

    void Start(){
        log = GameObject.Find("Logica").GetComponent<Logica>();
        com = GameObject.Find("Comunicacion").GetComponent<Comunicacion>();
        ui = GameObject.Find("Interfaz").GetComponent<Interfaz>();

        GameObject.Find("BtnEmpezar").GetComponent<Button>().onClick.AddListener(repartirCartas);
    }
    public void repartirCartas(){
        StartCoroutine( waitRepartirCartas() );
    }
    IEnumerator waitRepartirCartas(){
        if( log.juego.jugador == "A") {
            List<string> cartasRepartidas = new List<string>();

            cartasRepartidas = log.ronda.repartirCartasAleatorio();
           
            yield return new WaitForSecondsRealtime(1);

            com.REPARTIENDO_CARTAS(
                "B",
                cartasRepartidas[3],
                cartasRepartidas[4],
                cartasRepartidas[5]
            );
            yield return new WaitForSecondsRealtime(1);
                    
            com.REPARTIENDO_CARTAS(
                "C",
                cartasRepartidas[6],
                cartasRepartidas[7],
                cartasRepartidas[8]
            );
            yield return new WaitForSecondsRealtime(1);


            com.REPARTIENDO_CARTAS(
                "D",
                cartasRepartidas[9],
                cartasRepartidas[10],
                cartasRepartidas[11]
            );
            yield return new WaitForSecondsRealtime(1);

            ui.mesa.jugador1.asignarCartas(
                cartasRepartidas[0].Substring(cartasRepartidas[0].Length - 1, 1),
                int.Parse(cartasRepartidas[0].Substring(0, cartasRepartidas[0].Length - 1)),
                cartasRepartidas[1].Substring(cartasRepartidas[1].Length - 1, 1),
                int.Parse(cartasRepartidas[1].Substring(0, cartasRepartidas[1].Length - 1)),
                cartasRepartidas[2].Substring(cartasRepartidas[2].Length - 1, 1),
                int.Parse(cartasRepartidas[2].Substring(0, cartasRepartidas[2].Length - 1))
            );

            yield return new WaitForSecondsRealtime(1);

            com.VIRA(
                cartasRepartidas[12]
            );

            log.ronda.activarJugadores(log.partida.mano);
        }
    }

    public void jugarCarta() {
        if(log.juego.jugador == "A"){
            //com.JUGAR_CARTA("A", );
        }
    }
    
}