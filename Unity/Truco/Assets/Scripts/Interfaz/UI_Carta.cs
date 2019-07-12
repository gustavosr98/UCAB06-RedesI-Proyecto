using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Carta : MonoBehaviour {

    public Button carta;
    
    // VALOR DE LA CARTA
    public string pinta;   // { O, B, E, C }
    public int numero;     // { 1, 2 ... 12 } - { 8, 9 }
    public bool visible;   // AL REVES O AL DERECHO
    public bool clickeable;

    void Start(){
        carta = gameObject.GetComponent<Button>();
    }

    public void darValor( string pinta, int numero ){
        Debug.Log("UI_Carta.darValor( " + pinta + " , " + numero + " )");
        this.pinta = pinta;
        this.numero = numero;
    }
    
    public void activarCarta(){
        carta.interactable = true;
    }

    public void desactivarCarta(){
        carta = gameObject.GetComponent<Button>();
        carta.interactable = false;
    }

    public void mostrarCarta(){
        Image imagenCarta = gameObject.GetComponent<Image>();
        imagenCarta.sprite = Resources.Load<Sprite>("Sprites/" + pinta + numero);
    }

    public void noMostrarCarta(){
        Image imagenCarta = gameObject.GetComponent<Image>();
        imagenCarta.sprite = Resources.Load<Sprite>("Sprites/revez");
    }

}
