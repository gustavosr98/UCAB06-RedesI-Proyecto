using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace PruebaConexion {
    public partial class Form1 : Form{
        private string strBufferIn;
        private string strBufferOut;

        public Form1(){
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
            strBufferIn = "";
            strBufferOut = "";
            BtnConectar.Enabled = false;
            BtnEnviarDatos.Enabled = false;

        }

        private void BtnBuscarPuertos_Click(object sender, EventArgs e){
            string[] puertosDisponibles = SerialPort.GetPortNames();
            foreach( string puerto in puertosDisponibles){
                CboPuertos.Items.Add( puerto );
            }

            if ( CboPuertos.Items.Count > 0 ) {
                CboPuertos.SelectedItem = 0;
                MessageBox.Show("SELECCIONAR EL PUERTO DE TRABAJO");
                BtnConectar.Enabled = true;
            } else {
                MessageBox.Show("NINGUN PUERTO DETECTADO");
                CboPuertos.Items.Clear();
                CboPuertos.Text = "                  ";

                strBufferIn = "";
                strBufferOut = "";
                BtnConectar.Enabled = false;
                BtnEnviarDatos.Enabled = false;
            }
        }

        private void BtnConectar_Click(object sender, EventArgs e){
            try {
                if ( BtnConectar.Text == "CONECTAR") {
                    SpPuertos.BaudRate = Int32.Parse(CboBaudRate.Text);
                    SpPuertos.DataBits = 8;
                    SpPuertos.Parity = Parity.None;
                    SpPuertos.StopBits = StopBits.One;
                    SpPuertos.Handshake = Handshake.None;
                    SpPuertos.PortName = CboPuertos.Text;

                    try {
                        SpPuertos.Open();
                        BtnConectar.Text = "DESCONECTAR";
                        BtnEnviarDatos.Enabled = true;
                    } catch (Exception error) {
                        MessageBox.Show(error.Message.ToString());
                        throw;
                    }

                } else if (BtnConectar.Text == "DESCONECTAR") {
                    SpPuertos.Close();
                    BtnConectar.Text = "CONECTAR";
                    BtnEnviarDatos.Enabled = false;
                }
            } catch (Exception error){
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
            string Data_in = SpPuertos.ReadExisting();
            MessageBox.Show(Data_in);
            TxtDatosRecibidos.Text = Data_in;
        }
    }
}
