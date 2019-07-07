using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Vira : MonoBehaviour {
    
    public string pinta;   // { O, B, E, C }
    public int numero;     // { 1, 2 ... 12 } - { 8, 9 }

    void Start(){
        
    }

    public void darValor( string pinta, int numero ){
        Debug.Log("UI_Carta.darValor( " + pinta + " , " + numero + " )");
        this.pinta = pinta;
        this.numero = numero;
        Image imagenCarta = GameObject.Find("ImgVira").GetComponent<Image>();
        imagenCarta.sprite = Resources.Load<Sprite>("Sprites/" + pinta + numero);
    }

}
