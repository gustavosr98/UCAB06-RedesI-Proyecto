using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Carta : MonoBehaviour {
    public string pinta;
    public int numero;

    public Carta(string pinta, int numero){
        this.pinta = pinta;
        this.numero = numero;
    }
}