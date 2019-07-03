﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// LIBRERIA PARA PUERTO SERIAL
using System.IO.Ports;
public class Comandos : MonoBehaviour
{
    private string strBufferIn;
    private string strBufferOut;
    private delegate void DelegadoAcceso(string accion);

    void Start(){
        strBufferIn = "";
        strBufferOut = "";
        /* 
        BtnConectar.Enabled = false;
        BtnEnviarDatos.Enabled = false;
         */
    }

    public void buscarPuertos(){
        string[] puertosDisponibles = SerialPort.GetPortNames();
        foreach (string puerto in puertosDisponibles){
            //CboPuertos.Items.Add(puerto);
            Debug.Log(puerto);
        }
            /* 
                if (CboPuertos.Items.Count > 0)
                {
                    CboPuertos.SelectedItem = 0;
                    MessageBox.Show("SELECCIONAR EL PUERTO DE TRABAJO");
                    BtnConectar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("NINGUN PUERTO DETECTADO");
                    CboPuertos.Items.Clear();
                    CboPuertos.Text = "                  ";

                    strBufferIn = "";
                    strBufferOut = "";
                    BtnConectar.Enabled = false;
                    BtnEnviarDatos.Enabled = false;
                }
            */
    }



    /*
    public Form1()
    {
        InitializeComponent();
    }

    private void AccesoForm(string accion)
    {
        strBufferIn = accion;
        TxtDatosRecibidos.Text = strBufferIn;
    }

    private void AccesoInterrupcion(string accion)
    {
        DelegadoAcceso var_delegadoAcceso = new DelegadoAcceso(AccesoForm);
        object[] arg = { accion };
        base.Invoke(var_delegadoAcceso, arg);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
       

    }

    private void BtnBuscarPuertos_Click(object sender, EventArgs e)
    {
        string[] puertosDisponibles = SerialPort.GetPortNames();
        foreach (string puerto in puertosDisponibles)
        {
            CboPuertos.Items.Add(puerto);
        }

        if (CboPuertos.Items.Count > 0)
        {
            CboPuertos.SelectedItem = 0;
            MessageBox.Show("SELECCIONAR EL PUERTO DE TRABAJO");
            BtnConectar.Enabled = true;
        }
        else
        {
            MessageBox.Show("NINGUN PUERTO DETECTADO");
            CboPuertos.Items.Clear();
            CboPuertos.Text = "                  ";

            strBufferIn = "";
            strBufferOut = "";
            BtnConectar.Enabled = false;
            BtnEnviarDatos.Enabled = false;
        }
    }

    private void BtnConectar_Click(object sender, EventArgs e)
    {
        try
        {
            if (BtnConectar.Text == "CONECTAR")
            {
                SpPuertos.BaudRate = Int32.Parse(CboBaudRate.Text);
                SpPuertos.DataBits = 8;
                SpPuertos.Parity = Parity.None;
                SpPuertos.StopBits = StopBits.One;
                SpPuertos.Handshake = Handshake.None;
                SpPuertos.PortName = CboPuertos.Text;

                try
                {
                    SpPuertos.Open();
                    BtnConectar.Text = "DESCONECTAR";
                    BtnEnviarDatos.Enabled = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message.ToString());
                    throw;
                }

            }
            else if (BtnConectar.Text == "DESCONECTAR")
            {
                SpPuertos.Close();
                BtnConectar.Text = "CONECTAR";
                BtnEnviarDatos.Enabled = false;
            }
        }
        catch (Exception error)
        {
            MessageBox.Show(error.Message.ToString());
            throw;
        }
    }

    private void BtnEnviarDatos_Click(object sender, EventArgs e)
    {
        try
        {
            SpPuertos.DiscardOutBuffer();
            strBufferOut = TxtDatos_a_Enviar.Text;
            SpPuertos.Write(strBufferOut);
        }
        catch (Exception error)
        {
            MessageBox.Show(error.Message.ToString());
            throw;
        }
    }

    private void DatoRecibido(object sender, SerialDataReceivedEventArgs e)
    {
        AccesoInterrupcion(SpPuertos.ReadExisting());
        
    }
     */
}
