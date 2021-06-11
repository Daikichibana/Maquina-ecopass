using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;


namespace Maquina
{
    public partial class CargarPuntos : Form
    {

        public FilterInfoCollection CaptureDevice;
        public VideoCaptureDevice FinalFrame;
        public DetectorBotellas b1;
        public Estado estado;

        public String carpetaImagen = @"C:\Users\Chibana\source\repos\Maquina\Maquina\bin\x64\Debug\assets\images\";
        

        public CargarPuntos()
        {
            InitializeComponent();

            b1 = new DetectorBotellas();
            estado = new Estado();
        }

        private void CargarPuntos_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                camaras.Items.Add(Device.Name);
            }

            camaras.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();


            FinalFrame = new VideoCaptureDevice(CaptureDevice[camaras.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();

            //ar.conectar();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            reconocimientoBotellas.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarPuntos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
                FinalFrame.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verificarBotella();
        }

        private void verificarBotella() {
            if (FinalFrame != null && FinalFrame.IsRunning)
            {
                reconocimientoBotellas.Image.Save(carpetaImagen + "imagen.jpg", ImageFormat.Jpeg);

                String[] deteccionImagen = b1.ClasificarImagen().Split(',');
                String objeto = deteccionImagen[0];

                double Probabilidad = double.Parse(deteccionImagen[1]) * 100;
                int idUsuario = int.Parse(lblID.Text);
                int puntos = int.Parse(lblPuntos.Text) + 100; //Aumento 100 puntos

                if (Probabilidad > 87)
                {
                    //El objeto es una botella
                    estado.actualizarPuntos(idUsuario,puntos);
                    lblPuntos.Text = puntos.ToString();

                    MessageBox.Show("Se ha insertado la botella correctamente!");
                    //return true;
                }
                else
                {
                    //Se activa cuando el objeto no es una botella
                    MessageBox.Show("Botella no detectada");
                    //return false;
                }
            }
            else {
                MessageBox.Show("La camara no esta funcionando");
            }
            
        }

    
    }

  
}
