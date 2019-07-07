using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interfaz : MonoBehaviour {
    public UI_Mesa mesa;
	public UI_Carta carta;
	public UI_Apuestas apuesta;
	public UI_Info info;
	public UI_Vira vira;
	public UI_Inicio inicio;
	public UI_GameOver gameOver;
    public UI_Comunicacion comunicacion;

	void Awake(){
        mesa = GameObject.Find("Mesa").GetComponent<UI_Mesa>();
		info = GameObject.Find("Info").GetComponent<UI_Info>();
		apuesta = GameObject.Find("Apuesta").GetComponent<UI_Apuestas>();
		vira = GameObject.Find("Vira").GetComponent<UI_Vira>();
		inicio = GameObject.Find("UI_Inicio").GetComponent<UI_Inicio>();
		gameOver = GameObject.Find("UI_GameOver").GetComponent<UI_GameOver>();
	}

	
}