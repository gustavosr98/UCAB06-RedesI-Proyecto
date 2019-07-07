using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// LIBRERIA PARA PUERTO SERIAL
using System.IO.Ports;

// LIBRERIA PARA UI
using UnityEngine.UI;
using System;

public class Comunicacion : MonoBehaviour {
    public Logica logica;
       
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

    // COMPONENTES
    Button btnEnviar, btnConectar;
    Dropdown dropPuertosA, dropPuertosB, dropVelocidad;
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

        dropPuertosA = GameObject.Find("DropPuertosA").GetComponent<Dropdown>();
        dropPuertosB = GameObject.Find("DropPuertosB").GetComponent<Dropdown>();
        dropVelocidad = GameObject.Find("DropVelocidad").GetComponent<Dropdown>();

        inEnviar = GameObject.Find("InEnviar").GetComponent<InputField>();
        inRecibido = GameObject.Find("InRecibido").GetComponent<InputField>();
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
                puertoB.PortName = (
                    dropPuertosB.options[dropPuertosB.value].text
                );
                puertoA.ReadTimeout = puertoB.ReadTimeout = 100;

                try {
                    puertoA.Open();
                    puertoB.Open();
                    btnConectar.gameObject.GetComponentInChildren<Text>().text = "Desconectar";
                    btnEnviar.interactable = true;
                }
                catch (Exception error) {
                    Debug.LogError(error.Message.ToString());
                    throw;
                }
            } else {
                Debug.Log("Comunicacion.desconectar()");
                puertoA.Close();
                puertoB.Close();
                btnConectar.gameObject.GetComponentInChildren<Text>().text = "Conectar";
                btnEnviar.interactable = false;
            }
        } catch (Exception error) {
            Debug.LogError(error.Message.ToString());
            throw;
        }
        
    }

    // ENVIAR DATOS
    public void enviarBtn() {
        try {
            puertoA.DiscardOutBuffer();
            strBufferOut = inEnviar.text;
            Debug.Log("Comunicacion.enviarBtn( " + inEnviar.text + " )");
            puertoA.Write(strBufferOut);
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
            Debug.Log("Comunicacion.enviar( " + x + " )");
            puertoA.Write(strBufferOut);
        }
        catch (Exception error)
        {
            Debug.LogError(error.Message.ToString());
            throw;
        }
    }

    // RECIBIR DATOS
    /* 
    private delegate void DelegadoAcceso( string accion );
    private void AccesoForm( string accion ){
        strBufferIn = accion;
        inRecibido.text = strBufferIn;
    }
    private void AccesoInterrupcion( string accion ){
        DelegadoAcceso delegadoObj = new DelegadoAcceso(AccesoForm);
        object[] arg = { accion };
        delegadoObj.DynamicInvoke( arg );
    }
    private void DatoRecibido(object sender, SerialDataReceivedEventArgs e){
        AccesoInterrupcion( puertoA.ReadExisting() );
    }
    */
    
    void Update(){
        try {
            if (puertoB.IsOpen){
                inRecibido.text = puertoB.ReadExisting();
                if ( inRecibido.text != lastMsj){
                    lastMsj = inRecibido.text;
                    enviar(inRecibido.text);
                }
            }
        } catch (System.Exception ex) { }
    }

        // OPCION 2
        /*
        void Update()
        {
            if (puertoA.IsOpen && puertoA.BytesToRead >= 8) {
                Debug.Log(puertoA.ReadLine());
            }
        }
        */


    }
