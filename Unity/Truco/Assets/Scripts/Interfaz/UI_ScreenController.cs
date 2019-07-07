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
            x = new Vector3(468f,155f,-210f);
            moverCanvas(x);
        }
        else if(y == 2){
            x = new Vector3(-1227f,107f,-230f);
            moverCanvas(x);
        }
        else if(y == 3){
            x = new Vector3(700f,700f,700f);
            moverCanvas(x);
        }
        else if(y == 4){
            x = new Vector3(700f,700f,700f);
            moverCanvas(x);
        }
    }

    public void moverCanvas(Vector3 x){
        GOcamara = GameObject.Find("Main Camera");
        GOcamara.transform.position = x;
    }
    
}
