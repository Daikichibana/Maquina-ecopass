using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;


namespace Maquina
{
    public partial class Form1 : Form
    {
        public FilterInfoCollection CaptureDevice;
        public VideoCaptureDevice FinalFrame;
        public Arduino ar;

        public Estado estado;
        public viajesActivos viajeActivo;

        public Form1()
        {
            InitializeComponent();
            estado = new Estado();
            viajeActivo = new viajesActivos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                camaras.Items.Add(Device.Name);
            }

            camaras.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[camaras.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            codigoQR.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (codigoQR.Image != null)
            {
                BarcodeReader Reader = new BarcodeReader();
                Result result = Reader.Decode((Bitmap)codigoQR.Image);

                if (result != null)
                {
                    timer1.Stop();
                    string decoded = result.ToString().Trim();

                    String[] datosCliente = decoded.ToString().Split(',');
                    int id = Int32.Parse(datosCliente[0]);
                    String estadoViaje = datosCliente[1];
                    String parada = nombreParada.Text;
                    
                    if (estadoViaje.Equals("Iniciar"))
                    {
                        if(estado.actualizarEstado(true,id))
                        {
                            viajeActivo.insertarViaje(id, parada);
                        }
                    }
                    else if (estadoViaje.Equals("Finalizar"))
                    {
                        if(estado.actualizarEstado(false, id))
                        {
                            viajeActivo.actualizarDestino(id, parada);
                        }
                    }

                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
                FinalFrame.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if(Paradas.Text != "")
                nombreParada.Text = Paradas.Text;
        }

        private void btnCargarPts_Click(object sender, EventArgs e)
        {
            inicioSesion Cp = new inicioSesion();
            Cp.Show();
            this.Hide();
            FinalFrame.Stop();
        }

        private void camaras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
