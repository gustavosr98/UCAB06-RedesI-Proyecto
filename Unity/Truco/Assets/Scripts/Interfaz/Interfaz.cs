using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interfaz : MonoBehaviour {
    public UI_Mesa mesa;
	public UI_Carta carta;
	public UI_Apuestas apuesta;
	public UI_Info info;
    public UI_Comunicacion comunicacion;


	void Awake(){
        mesa = GameObject.Find("Mesa").GetComponent<UI_Mesa>();
		info = GameObject.Find("UI_Info").GetComponent<UI_Info>();
	}
}