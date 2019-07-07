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

    // DATOS
    public string tipo;    
    public string puertoTx;
    public string puertoRx;
    public string velocidad;

    // COMPONENTES
    Button btnEnviar, btnConectar;
    Dropdown dropPuertos, dropVelocidad;
    InputField inEnviar, inRecibido;

    void Start(){
        strBufferIn = "";
        strBufferOut = "";
           
        btnEnviar = GameObject.Find("BtnEnviar").GetComponent<Button>();
        btnEnviar.interactable = false;
        btnEnviar.onClick.AddListener(enviar);

        btnConectar = GameObject.Find("BtnConectar").GetComponent<Button>();
        btnConectar.interactable = false;
        btnConectar.onClick.AddListener(conectar);

        dropPuertos = GameObject.Find("DropPuertos").GetComponent<Dropdown>();
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

        dropPuertos.ClearOptions();
        dropPuertos.AddOptions(puertosDisponiblesList);
    }


    public void conectar()
    {

        try {
            if (btnConectar.gameObject.GetComponentInChildren<Text>().text
                    == "Conectar"
            ){
                Debug.Log("Comunicacion.conectar()");

                puertoA.BaudRate = Int32.Parse(
                    dropVelocidad.options[dropVelocidad.value].text
                );
                puertoA.DataBits = 8;
                puertoA.Parity = Parity.None;
                puertoA.StopBits = StopBits.One;
                puertoA.Handshake = Handshake.None;
                puertoA.PortName = (
                    dropPuertos.options[dropPuertos.value].text
                );

                try {
                    puertoA.Open();
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
                btnConectar.gameObject.GetComponentInChildren<Text>().text = "Conectar";
                btnEnviar.interactable = false;
            }
        } catch (Exception error) {
            Debug.LogError(error.Message.ToString());
            throw;
        }
        
    }

    // ENVIAR DATOS
    public void enviar() {
        try {
            puertoA.DiscardOutBuffer();
            strBufferOut = inEnviar.text;
            Debug.Log("Comunicacion.enviar( " + inEnviar.text + " )");
            puertoA.Write(strBufferOut);
        }
        catch (Exception error)
        {
            Debug.LogError(error.Message.ToString());
            throw;
        }
    }

    // RECIBIR DATOS
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
