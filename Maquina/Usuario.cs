using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Usuario : Postgresql
{
    private String id;
    private String nombre;
    private String apellido;
    private String clave;

    public Usuario()
    {
        id = "";
        nombre = "";
        apellido = "";
        clave = "";
    }

    public Usuario(string id, string nombre, string apellido, string clave)
    {
        this.id = id;
        this.nombre = nombre;
        this.apellido = apellido;
        this.clave = clave;
    }

    public string Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public string Clave { get => clave; set => clave = value; }

    public void cargarDatos(int ID)
    {
        
        String peticion = "select * from \"usuario\" where \"id\"= '" + ID + "'";

        DataRow fila = Select(peticion);

        id = fila.ItemArray[0].ToString();
        nombre = fila.ItemArray[1].ToString();
        apellido = fila.ItemArray[2].ToString();
        clave = fila.ItemArray[3].ToString();

    }


}

