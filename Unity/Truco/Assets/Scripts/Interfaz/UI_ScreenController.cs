using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ScreenController : MonoBehaviour
{
    public GameObject GOcamara;
    public Vector3 x;

    public int y = 0;
    
    public void irPantalla(int y){
        if(y == 1){
            x = new Vector3(-8900f,0f,0);
            moverCanvas(x);
        }
        else if(y == 2){
            x = new Vector3(-4425f,0f,-383f);
            moverCanvas(x);
        }
        else if(y == 3){
            x = new Vector3(-11f,0f,-383f);
            moverCanvas(x);
        }
        else if(y == 4){
            x = new Vector3(4542f,0f,-383f);
            moverCanvas(x);
        }
    }

    public void moverCanvas(Vector3 x){
        GOcamara = GameObject.Find("Main Camera");
        GOcamara.transform.position = x;
    }
    
}
