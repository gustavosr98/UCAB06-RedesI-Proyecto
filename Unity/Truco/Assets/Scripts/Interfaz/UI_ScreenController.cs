using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ScreenController : MonoBehaviour
{
    public GameObject goCamara;
    public GameObject[] canvasList;

    public int y = 0;
    public void irPortada(){
        irPantalla(1);
    }
    public void irConfiguracion(){
        irPantalla(2);
    }

    public void irJuego(){
        irPantalla(3);
    }

    public void irGameOver(){
        irPantalla(4);
    }
    public void irPantalla(int y){
        if(y == 1){
            Vector3 x = new Vector3(-35835f,1760.158f,0);
            moverCamara(x);
        }
        else if(y == 2){
            Vector3 x = new Vector3(-9888f,1760.158f,-383f);
            moverCamara(x);
        }
        else if(y == 3){
            Vector3 x = new Vector3(13878f,1760.158f,-383f);
            moverCamara(x);
        }
        else if(y == 4){
            Vector3 x = new Vector3(38895f,1760.158f,-383f);
            moverCamara(x);
        }
    }
    
    public void moverCamara(Vector3 vector){
        Debug.Log("moverCamara(" + vector.x + ")");
        goCamara = GameObject.Find("Main Camera");
        goCamara.GetComponent<Transform>().position = vector; 
    }
    
}
