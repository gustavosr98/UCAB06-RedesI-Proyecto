using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using UnityEngine.UI;

public class UI_Apuestas : MonoBehaviour{
    private Button BtnTruco;
    private bool cond;
    public Button BtnTrucoSi;
    private string trucoActual = "Normal";

    void Start(){
        Button BtnTruco = GameObject.Find("BtnTruco").GetComponent<Button>();

        BtnTruco.interactable = false;
        BtnTruco.GetComponentInChildren<Text>().text = "Truco";
        set_string_BtnTruco("Truco");

        Button BtnEnvido = GameObject.Find("BtnEnvido").GetComponent<Button>();
        BtnEnvido.GetComponentInChildren<Text>().text = "Envido";
        BtnEnvido.interactable = false;

        Button BtnTrucoSi = GameObject.Find("BtnTrucoSi").GetComponent<Button>();
        BtnTrucoSi.GetComponentInChildren<Text>().text = "Si";
        BtnTrucoSi.interactable = false;
        BtnTrucoSi.onClick.AddListener(subirApuesta);

        Button BtnTrucoNo = GameObject.Find("BtnTrucoNo").GetComponent<Button>();
        BtnTrucoNo.GetComponentInChildren<Text>().text = "No";
        BtnTrucoNo.onClick.AddListener(reiniciarApuesta);
        BtnTrucoNo.interactable = false;

        Button BtnEnvidoSi = GameObject.Find("BtnEnvidoSi").GetComponent<Button>();
        BtnEnvidoSi.GetComponentInChildren<Text>().text = "Si";
        BtnEnvidoSi.interactable = false;

        Button BtnEnvidoNo = GameObject.Find("BtnEnvidoNo").GetComponent<Button>();
        BtnEnvidoNo.GetComponentInChildren<Text>().text = "No";
        BtnEnvidoNo.interactable = false;

        activarTruco();
        activarBtnTrucoSi();
        activarBtnTrucoNo();
        activarBtnEnvidoNo();
        activarBtnEnvidoSi();
        activarEnvido();
        
    }

    public void set_string_BtnTruco(string x){
        //x e {truco, retruco, vale 9, vale juego}
        BtnTruco = GameObject.Find("BtnTruco").GetComponent<Button>();
        BtnTruco.GetComponentInChildren<Text>().text = x;
        trucoActual = x;
        
    }

    public void subirApuesta(){
        if (trucoActual.Equals("Normal")){
            BtnTruco.GetComponentInChildren<Text>().text = "Truco"; 
            trucoActual =  "Truco";
        } 
        else if(trucoActual.Equals("Truco")) {
            BtnTruco.GetComponentInChildren<Text>().text = "Retruco";
            trucoActual =  "Retruco";
        } 
        else if(trucoActual.Equals("Retruco")){
            BtnTruco.GetComponentInChildren<Text>().text = "Vale 9";
            trucoActual =  "Vale 9";
        }
        else if(trucoActual.Equals("Vale 9")){
            BtnTruco.GetComponentInChildren<Text>().text = "Vale Juego";
            trucoActual =  "Vale Juego";
        }
        else if(trucoActual.Equals("Vale Juego")){
            desactivarBtnTrucoSi();
            desactivarBtnTrucoNo();
            desactivarTruco();
        }
    }
    public void reiniciarApuesta(){
        set_string_BtnTruco("Truco");
    }

    public void activarTruco(){
        Button BtnTruco = GameObject.Find("BtnTruco").GetComponent<Button>();
        BtnTruco.interactable = true;
    }

    public void activarBtnTrucoSi(){
        Button BtnTrucoSi = GameObject.Find("BtnTrucoSi").GetComponent<Button>();
        BtnTrucoSi.interactable = true;
    }

    public void activarBtnTrucoNo(){
        Button BtnTrucoNo = GameObject.Find("BtnTrucoNo").GetComponent<Button>();
        BtnTrucoNo.interactable = true;
    }

    public void desactivarTruco(){
        Button BtnTruco = GameObject.Find("BtnTruco").GetComponent<Button>();
        BtnTruco.interactable = false;
    }

    public void desactivarBtnTrucoSi(){
        Button BtnTrucoSi = GameObject.Find("BtnTrucoSi").GetComponent<Button>();
        BtnTrucoSi.interactable = false;
    }

    public void desactivarBtnTrucoNo(){
        Button BtnTrucoNo = GameObject.Find("BtnTrucoNo").GetComponent<Button>();
        BtnTrucoNo.interactable = false;
    }

    public void activarEnvido(){
        Button BtnEnvido = GameObject.Find("BtnEnvido").GetComponent<Button>();
        BtnEnvido.interactable = true;
    }

    public void activarBtnEnvidoSi(){
        Button BtnEnvidoSi = GameObject.Find("BtnEnvidoSi").GetComponent<Button>();
        BtnEnvidoSi.interactable = true;
    }

    public void activarBtnEnvidoNo(){
        Button BtnEnvidoNo = GameObject.Find("BtnEnvidoNo").GetComponent<Button>();
        BtnEnvidoNo.interactable = true;
    }

    public void desactivarEnvido(){
        Button BtnEnvido = GameObject.Find("BtnEnvido").GetComponent<Button>();
        BtnEnvido.interactable = false;
    }

    public void desactivarBtnEnvidoSi(){
        Button BtnEnvidoSi = GameObject.Find("BtnEnvidoSi").GetComponent<Button>();
        BtnEnvidoSi.interactable = false;
    }

    public void desactivarBtnEnvidoNo(){
        Button BtnEnvidoNo = GameObject.Find("BtnEnvidoNo").GetComponent<Button>();
        BtnEnvidoNo.interactable = false;
    }


}
