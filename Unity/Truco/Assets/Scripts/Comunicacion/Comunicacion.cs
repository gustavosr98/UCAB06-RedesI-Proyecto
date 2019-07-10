using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// LIBRERIA PARA PUERTO SERIAL
using System.IO.Ports;

// LIBRERIA PARA UI
using UnityEngine.UI;
using System;

public class Comunicacion : MonoBehaviour {
    public Logica log;
       
    // PUERTO SERIAL
    private string strBufferIn;
    private string strBufferOut;
    SerialPort puertoA = new SerialPort();
    SerialPort puertoB = new SerialPort();

    public string lastMsj = "";
    // DATOS
    public string tipo;    
    public string puertoTx;
    public string puertoRx;
    public string velocidad;
    public bool modoReal = false;

    // COMPONENTES
    Button btnEnviar, btnConectar, btnReal, btnEmpezar;
    Dropdown dropPuertosA, dropPuertosB, dropVelocidad, dropJugador;
    InputField inEnviar, inRecibido;

    void Start(){
        strBufferIn = "";
        strBufferOut = "";
        
        btnEnviar = GameObject.Find("BtnEnviar").GetComponent<Button>();
        btnEnviar.interactable = false;
        btnEnviar.onClick.AddListener(enviarBtn);

        btnConectar = GameObject.Find("BtnConectar").GetComponent<Button>();
        btnConectar.interactable = false;
        btnConectar.onClick.AddListener(conectar);

        btnReal = GameObject.Find("BtnSerialReal").GetComponent<Button>();
        btnReal.onClick.AddListener(toogleReal);

        dropPuertosA = GameObject.Find("DropPuertosA").GetComponent<Dropdown>();
        dropPuertosB = GameObject.Find("DropPuertosB").GetComponent<Dropdown>();
        dropVelocidad = GameObject.Find("DropVelocidad").GetComponent<Dropdown>();

        inEnviar = GameObject.Find("InEnviar").GetComponent<InputField>();
        inRecibido = GameObject.Find("InRecibido").GetComponent<InputField>();

        log = GameObject.Find("Logica").GetComponent<Logica>();
        dropJugador = GameObject.Find("DropJugador").GetComponent<Dropdown>();

        btnEmpezar = GameObject.Find("BtnEmpezar").GetComponent<Button>();
        btnEmpezar.onClick.AddListener(establecerJugador);
        btnEmpezar.interactable = false;
    }

    public void buscarPuertos(){
        Debug.Log("Comunicacion.buscarPuertos()");

        string[] puertosDisponibles = SerialPort.GetPortNames();
        List<string> puertosDisponiblesList = new List<string>();
        foreach (string puerto in puertosDisponibles) {
            puertosDisponiblesList.Add(puerto);
        }

        if (puertosDisponibles.Length > 0)
            btnConectar.interactable = true;

        dropPuertosA.ClearOptions();
        dropPuertosA.AddOptions(puertosDisponiblesList);
        dropPuertosB.ClearOptions();
        dropPuertosB.AddOptions(puertosDisponiblesList);
    }

    public void establecerJugador(){
        log.juego.jugador = dropJugador.options[dropJugador.value].text; 
    }

    public void conectar()
    {

        try {
            if (btnConectar.gameObject.GetComponentInChildren<Text>().text
                    == "Conectar"
            ){
                Debug.Log("Comunicacion.conectar()");
                
                puertoA.BaudRate = puertoB.BaudRate = Int32.Parse(
                    dropVelocidad.options[dropVelocidad.value].text
                );
                //puertoA.DataBits = 8;
                //puertoA.Parity = Parity.None;
                // puertoA.StopBits = StopBits.One;
                // puertoA.Handshake = Handshake.None;
                puertoA.PortName = (
                    dropPuertosA.options[dropPuertosA.value].text
                );
                if (!modoReal)
                    puertoB.PortName = (
                        dropPuertosB.options[dropPuertosB.value].text
                    );
                puertoA.ReadTimeout = puertoB.ReadTimeout = 100;

                try {
                    puertoA.Open();
                    if (!modoReal) puertoB.Open();
                    btnConectar.gameObject.GetComponentInChildren<Text>().text = "Desconectar";
                    btnEnviar.interactable = true;
                    btnEmpezar.interactable = true;
                }
                catch (Exception error) {
                    Debug.LogError(error.Message.ToString());
                    throw;
                }
            } else {
                Debug.Log("Comunicacion.desconectar()");
                puertoA.Close();
                if (!modoReal) puertoB.Close();
                btnConectar.gameObject.GetComponentInChildren<Text>().text = "Conectar";
                btnEnviar.interactable = false;
            }
        } catch (Exception error) {
            Debug.LogError(error.Message.ToString());
            throw;
        }
        
    }

    void toogleReal() {
        Text btnRealText = btnReal.gameObject.GetComponentInChildren<Text>();
        if ( btnRealText.text == "ESTA EN PRUEBA" ){
            btnRealText.text = "ESTA EN REAL";
            modoReal = true;
            dropPuertosB.interactable = false;
        }
        else {
            btnRealText.text = "ESTA EN PRUEBA";
            modoReal = false;
            dropPuertosB.interactable = true;
        }
    }
    // ENVIAR DATOS
    public void enviarBtn() {
        try {
            puertoA.DiscardOutBuffer();
            strBufferOut = inEnviar.text;
            Debug.Log("Comunicacion.enviarBtn( " + inEnviar.text + " )");
            lastMsj = COM_UTILS.BinaryToHex(strBufferOut);
            puertoA.Write(
               COM_UTILS.BinaryToHex(strBufferOut)
            );
        }
        catch (Exception error)
        {
            Debug.LogError(error.Message.ToString());
            throw;
        }
    }

    public void enviar(string x) {
        try {
            puertoA.DiscardOutBuffer();
            strBufferOut = x;
            Debug.Log("----> Comunicacion.enviar( " + strBufferOut + " )");
            lastMsj = x;
            puertoA.Write(strBufferOut);
        }
        catch (Exception error)
        {
            Debug.LogError(error.Message.ToString());
            throw;
        }
    }
    
    // RECIBIR DATOS
    void Update(){
        try {
            if (modoReal) puertoB = puertoA;
            if (puertoB.IsOpen){
                inRecibido.text = puertoB.ReadExisting();
                if ( inRecibido.text != lastMsj){
                    lastMsj = inRecibido.text;
                    enviar(lastMsj);
                    decifrarMensaje(lastMsj);
                }
            }
        } catch (System.Exception ex) { }
    }


    void decifrarMensaje(string mensajeStr){
        string mensajeBin = COM_UTILS.HexToBinary(mensajeStr);
        Debug.Log(" <--- decifrarMensaje ( " + mensajeStr + " ) : " + mensajeBin);

        string TT = mensajeBin.Substring(0, 8);

        if (TT == COM_UTILS.c_JUGAR_CARTA) {
            doJUGAR_CARTA(mensajeBin);
        } else if (TT == COM_UTILS.c_PEDIR_CANTO){
            doPEDIR_CANTO(mensajeBin);
        } else if ( TT == COM_UTILS.c_RESPONDER_CANTO){
            doRESPONDER_CANTO(mensajeBin);
        } else if (TT == COM_UTILS.c_REPARTIENDO_CARTAS){
            doREPARTIENDO_CARTAS(mensajeBin);
        } else if (TT == COM_UTILS.c_ELLOS_TIENEN_FLOR){
            doELLOS_TIENEN_FLOR(mensajeBin);
        }
    }

    void doJUGAR_CARTA(string mensajeBin){
        Debug.Log(" <--- doJUGAR_CARTA : " + mensajeBin);
    }
    void doPEDIR_CANTO(string mensajeBin){
        Debug.Log(" <--- doPEDIR_CANTO : " + mensajeBin);
    }
    void doRESPONDER_CANTO(string mensajeBin){
        Debug.Log(" <--- doRESPONDER_CANTO : " + mensajeBin);
    }
    void doREPARTIENDO_CARTAS(string mensajeBin){
        Debug.Log(" <--- doREPARTIENDO_CARTAS : " + mensajeBin);
    }
    void doELLOS_TIENEN_FLOR(string mensajeBin){
        Debug.Log(" <--- doELLOS_TIENEN_FLOR : " + mensajeBin);
    }

}
