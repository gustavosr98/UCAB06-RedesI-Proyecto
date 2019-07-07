using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ScreenController : MonoBehaviour
{
    public GameObject GOcamara;
    public Vector3 x;

    public int y = 0;
    void Update(){
        irPantalla(y);
    }
    public void irPantalla(int y){
        if(y == 1){
            x = new Vector3(-8222,0,-427);
            moverCanvas(x);
        }
        else if(y == 2){
            x = new Vector3(-3942,-8,-230);
            moverCanvas(x);
        }
        else if(y == 3){
            x = new Vector3(-1,-8,-230);
            moverCanvas(x);
        }
        else if(y == 4){
            x = new Vector3(4259,-8,-230);
            moverCanvas(x);
        }
    }

    public void moverCanvas(Vector3 x){
        GOcamara = GameObject.Find("Main Camera");
        GOcamara.transform.position = x;
    }
    
}
