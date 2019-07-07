using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class UI_Info : MonoBehaviour {
    public GameObject Info;
    public InputField ptsAC; 
    public InputField ptsBD;
    public InputField nivelTruco;
    public InputField voz;
    public InputField mano;
    public InputField envido;
    public InputField ronda1;
    public InputField ronda2;
    public InputField ronda3;

    void Start(){
        ptsAC = GameObject.Find("InPtsAC").GetComponent<InputField>();
        ptsBD = GameObject.Find("InPtsBD").GetComponent<InputField>();
        nivelTruco = GameObject.Find("InNivel").GetComponent<InputField>();
        voz = GameObject.Find("InVoz").GetComponent<InputField>();
        mano = GameObject.Find("InMano").GetComponent<InputField>();
        envido = GameObject.Find("InEnvido").GetComponent<InputField>();
        ronda1 = GameObject.Find("InRonda1").GetComponent<InputField>();
        ronda2 = GameObject.Find("InRonda2").GetComponent<InputField>();
        ronda3 = GameObject.Find("InRonda3").GetComponent<InputField>();
        set_ptsAC(10);
        set_ptsBD(15);
        set_nivelTruco("Vale Juego");
        set_voz("AC");
        set_mano("A");
        set_envido("Si");
        set_ronda1("BD");
        set_ronda2("Ronda Actual");
        set_ronda3("Por Jugar");
    }
    
    public void set_ptsAC( int x ) {
        Debug.Log("set_ptsAC( " + x + " )");
        ptsAC.text = "AC (" + x.ToString() + "pts)";
    }

	public void set_ptsBD( int x ){
        Debug.Log("set_ptsBD( " + x + " )");
        ptsBD.text = "BD (" + x.ToString() + "pts)";
    }

    public void set_nivelTruco( string x ){
        Debug.Log("set_nivelTruco( " + x + " )");
        nivelTruco.text = x;
    }
		
	public void set_voz( string x ){
        Debug.Log("set_voz( " + x + " )");
        voz.text = x;
    }  		
    
    public void set_mano( string x ){
        Debug.Log("set_mano( " + x + " )");
        mano.text = x;
    } 

    public void set_envido( string x ){
        Debug.Log("set_envido( " + x + " )");
        envido.text = x;
    } 

    public void set_ronda1( string x ){
        Debug.Log("set_ronda1( " + x + " )");
        ronda1.text = x;
    }

    public void set_ronda2( string x ){
        Debug.Log("set_ronda2( " + x + " )");
        ronda2.text = x;
    }

    public void set_ronda3( string x ){
        Debug.Log("set_ronda3( " + x + " )");
        ronda3.text = x;
    }

}

        