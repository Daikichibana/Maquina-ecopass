using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Estado : Postgresql
{
    String id;
    String puntos;
    String Viajando;

    public Estado(string id, string puntos, string viajando)
    {
        this.id = id;
        this.puntos = puntos;
        Viajando = viajando;
    }

    public Estado()
    {
        id = "";
        puntos = "";
        Viajando = "";
    }

    public string Id { get => id; set => id = value; }
    public string Puntos { get => puntos; set => puntos = value; }
    public string Viajando1 { get => Viajando; set => Viajando = value; }

    public void cargarEstado(int ID)
    {
        String peticion = "select * from \"estadousuario\" where \"id\"= '" + ID + "'";

        DataRow fila = Select(peticion);

        id = fila.ItemArray[0].ToString();
        puntos = fila.ItemArray[1].ToString();
        Viajando = fila.ItemArray[2].ToString();
    }

    public bool actualizarEstado(bool estado, int id)
    {
        String consulta = "Update \"estadousuario\" set \"viajando\"='" + estado + "'" +
                "where \"id\" = '" + id + "'";

        return Update(consulta);
    }

    public bool actualizarPuntos(int puntos, int UsuarioID)
    {
        String consulta = "Update \"estadousuario" +
                "\" set \"puntos\"='" + puntos + "'" +
                "where \"id\" = '" + UsuarioID + "'";

        return Update(consulta);
    }

}
