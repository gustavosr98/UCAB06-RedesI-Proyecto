namespace PruebaConexion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnBuscarPuertos = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.BtnEnviarDatos = new System.Windows.Forms.Button();
            this.LblBaudRate = new System.Windows.Forms.Label();
            this.LblDatosIngreso = new System.Windows.Forms.Label();
            this.TxtDatosRecibidos = new System.Windows.Forms.TextBox();
            this.TxtDatos_a_Enviar = new System.Windows.Forms.TextBox();
            this.CboPuertos = new System.Windows.Forms.ComboBox();
            this.CboBaudRate = new System.Windows.Forms.ComboBox();
            this.SpPuertos = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // BtnBuscarPuertos
            // 
            this.BtnBuscarPuertos.Location = new System.Drawing.Point(88, 76);
            this.BtnBuscarPuertos.Name = "BtnBuscarPuertos";
            this.BtnBuscarPuertos.Size = new System.Drawing.Size(147, 23);
            this.BtnBuscarPuertos.TabIndex = 0;
            this.BtnBuscarPuertos.Text = "BUSCAR PUERTOS";
            this.BtnBuscarPuertos.UseVisualStyleBackColor = true;
            this.BtnBuscarPuertos.Click += new System.EventHandler(this.BtnBuscarPuertos_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(463, 77);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(147, 23);
            this.BtnConectar.TabIndex = 1;
            this.BtnConectar.Text = "CONECTAR";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // BtnEnviarDatos
            // 
            this.BtnEnviarDatos.Location = new System.Drawing.Point(88, 264);
            this.BtnEnviarDatos.Name = "BtnEnviarDatos";
            this.BtnEnviarDatos.Size = new System.Drawing.Size(147, 23);
            this.BtnEnviarDatos.TabIndex = 2;
            this.BtnEnviarDatos.Text = "ENVIAR DATOS";
            this.BtnEnviarDatos.UseVisualStyleBackColor = true;
            this.BtnEnviarDatos.Click += new System.EventHandler(this.BtnEnviarDatos_Click);
            // 
            // LblBaudRate
            // 
            this.LblBaudRate.AutoSize = true;
            this.LblBaudRate.Location = new System.Drawing.Point(85, 184);
            this.LblBaudRate.Name = "LblBaudRate";
            this.LblBaudRate.Size = new System.Drawing.Size(87, 17);
            this.LblBaudRate.TabIndex = 3;
            this.LblBaudRate.Text = "BAUD RATE";
            // 
            // LblDatosIngreso
            // 
            this.LblDatosIngreso.AutoSize = true;
            this.LblDatosIngreso.Location = new System.Drawing.Point(85, 352);
            this.LblDatosIngreso.Name = "LblDatosIngreso";
            this.LblDatosIngreso.Size = new System.Drawing.Size(133, 17);
            this.LblDatosIngreso.TabIndex = 4;
            this.LblDatosIngreso.Text = "DATOS RECIBIDOS";
            // 
            // TxtDatosRecibidos
            // 
            this.TxtDatosRecibidos.Location = new System.Drawing.Point(299, 347);
            this.TxtDatosRecibidos.Name = "TxtDatosRecibidos";
            this.TxtDatosRecibidos.Size = new System.Drawing.Size(311, 22);
            this.TxtDatosRecibidos.TabIndex = 5;
            // 
            // TxtDatos_a_Enviar
            // 
            this.TxtDatos_a_Enviar.Location = new System.Drawing.Point(299, 265);
            this.TxtDatos_a_Enviar.Name = "TxtDatos_a_Enviar";
            this.TxtDatos_a_Enviar.Size = new System.Drawing.Size(311, 22);
            this.TxtDatos_a_Enviar.TabIndex = 6;
            // 
            // CboPuertos
            // 
            this.CboPuertos.FormattingEnabled = true;
            this.CboPuertos.Location = new System.Drawing.Point(299, 76);
            this.CboPuertos.Name = "CboPuertos";
            this.CboPuertos.Size = new System.Drawing.Size(121, 24);
            this.CboPuertos.TabIndex = 7;
            // 
            // CboBaudRate
            // 
            this.CboBaudRate.FormattingEnabled = true;
            this.CboBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "115200"});
            this.CboBaudRate.Location = new System.Drawing.Point(299, 177);
            this.CboBaudRate.Name = "CboBaudRate";
            this.CboBaudRate.Size = new System.Drawing.Size(121, 24);
            this.CboBaudRate.TabIndex = 8;
            this.CboBaudRate.Text = "9600";
            // 
            // SpPuertos
            // 
            this.SpPuertos.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DatoRecibido);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CboBaudRate);
            this.Controls.Add(this.CboPuertos);
            this.Controls.Add(this.TxtDatos_a_Enviar);
            this.Controls.Add(this.TxtDatosRecibidos);
            this.Controls.Add(this.LblDatosIngreso);
            this.Controls.Add(this.LblBaudRate);
            this.Controls.Add(this.BtnEnviarDatos);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.BtnBuscarPuertos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscarPuertos;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Button BtnEnviarDatos;
        private System.Windows.Forms.Label LblBaudRate;
        private System.Windows.Forms.Label LblDatosIngreso;
        private System.Windows.Forms.TextBox TxtDatosRecibidos;
        private System.Windows.Forms.TextBox TxtDatos_a_Enviar;
        private System.Windows.Forms.ComboBox CboPuertos;
        private System.Windows.Forms.ComboBox CboBaudRate;
        private System.IO.Ports.SerialPort SpPuertos;
    }
}

