using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


public class Arduino
{
    private System.IO.Ports.SerialPort Ar;

    public Arduino(String puerto)
    {
        Ar = new System.IO.Ports.SerialPort();
        Ar.PortName = puerto;
        Ar.BaudRate = 9600;
        Ar.ReadTimeout = 500;
    }

    public void escribir(String frase)
    {
        if(Ar.IsOpen)
            Ar.Write(frase);
    }

    public Boolean conectar()
    {
        try
        {
            Ar.Open();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public void desconectar()
    {
        if (Ar.IsOpen)
            Ar.Close();
    }

    public void prenderLedNoDetectado(int numLED)
    {
        Ar.Write("encerderDetectado");
    }

    public void prenderLedDetectado(int numLED)
    {
        Ar.Write("encenderNoDetectado");
    }

    public String obtenerDatosArduino() {
        return Ar.ReadLine();
    }

    public Boolean verificarConexion() {
        if (Ar.IsOpen)
            return true;
        else
            return false;
    }
}

