using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.Threading;
public  class ComUI : MonoBehaviour {
    Interfaz ui;
    Logica log;
    Comunicacion com;

    public string pinta;
    public int numero;

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

            com.VIRA(
                cartasRepartidas[12]
            );

            log.ronda.activarJugadores();
        }
    }
    
}