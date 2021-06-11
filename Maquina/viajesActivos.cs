using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class viajesActivos : Postgresql
{
    int nro_viaje;
    String id_usuario;
    String parada_inicial;
    String parada_final;

    public viajesActivos(int nro_viaje, string id_usuario, string parada_inicial, string parada_final)
    {
        this.nro_viaje = nro_viaje;
        this.id_usuario = id_usuario;
        this.parada_inicial = parada_inicial;
        this.parada_final = parada_final;
    }

    public viajesActivos()
    {
        nro_viaje = 0;
        id_usuario = "";
        parada_inicial = "";
        parada_final = "";
    }

    public int Nro_viaje { get => nro_viaje; set => nro_viaje = value; }
    public string Id_usuario { get => id_usuario; set => id_usuario = value; }
    public string Parada_inicial { get => parada_inicial; set => parada_inicial = value; }
    public string Parada_final { get => parada_final; set => parada_final = value; }

    public Boolean insertarViaje(int id, String parada_inicial)
    {
        String peticion = "Insert into \"viajesactivos\" (id_usuario, parada_init) values ("
                + id + ",'" + parada_inicial + "')";

        return Update(peticion);
    }

    public Boolean actualizarDestino(int id, String parada_final)
    {
        String peticion = "Update \"viajesactivos" +
                "\" set \"parada_final\"='" + parada_final + "'" +
                "where \"id_usuario\" = '" + id + "'";

        return Update(peticion);
    }
}
