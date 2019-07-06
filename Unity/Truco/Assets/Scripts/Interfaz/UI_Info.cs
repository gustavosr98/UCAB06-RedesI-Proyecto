using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class UI_Info : MonoBehaviour {
    public GameObject Info;
    public Text ptsAC; 
    public Text ptsBD;
    public Text nivelTruco;
    public Text voz;
    public Text mano;
    public Text ronda1;
    public Text ronda2;
    public Text ronda3;
    
    public void set_ptsAC( int x ) {

    }

	public void set_ptsBD( int x ){

    }
		
	public void set_voz( string x ){
        // x e { AC, BD, Ambos }

    }  		
    
    public void set_mano( string x ){
        // x e { A, B, C , D}
    } 

    public void set_ronda1( string x ){
        // x e { ronda actual, por jugar, AC, BD, empate }
    }

    public void set_ronda2( string x ){

    }

    public void set_ronda3( string x ){

    }

}

        