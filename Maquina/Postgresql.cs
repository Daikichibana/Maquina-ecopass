using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Data;

public class Postgresql
{
    private NpgsqlConnection _con;

    //Datos de la bases de datos
    String cons = String.Format("Server={0};Port={1};" +
    "User Id ={2};Password={3};Database={4};SSL Mode={5};Trust Server Certificate={6}",
    "ec2-34-232-147-86.compute-1.amazonaws.com;", "5432", "lvjblrokumxyjv",
    "8e2f721210f39e592ace1dc70cc94114454914ddff80adc762617b8c01ae41f6", "d20om5579n24hk", "Require", "true");

    public Postgresql()
    {
        _con = new NpgsqlConnection(cons);
    }

    public void conectarseBD()
    {

        try
        {
            _con.Open();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error" + ex.Message);
        }
    }

    public void desconectarseBD()
    {
        _con.Close();
    }

    //Consultas

    public DataRow Select(String peticion)
    {
        try
        {
            String query = peticion;

            NpgsqlCommand conector = new NpgsqlCommand(query, _con);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            DataRow fila = tabla.Rows[0];

            _con.Open();
            conector.ExecuteNonQuery();
            _con.Close();

            return fila;
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public Boolean Delete(int UsuarioID, String consulta)
    {
        try
        {
            String query = consulta;

            NpgsqlCommand ejecutor = new NpgsqlCommand(query, _con);

            _con.Open();
            ejecutor.ExecuteNonQuery();

            _con.Close();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public Boolean Insert(String consulta)
    {
        try
        {
            String query = consulta;

            NpgsqlCommand ejecutor = new NpgsqlCommand(query, _con);

            _con.Open();
            ejecutor.ExecuteNonQuery();

            _con.Close();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public Boolean Update(String consulta)
    {
        try
        {
            String query = consulta;

            NpgsqlCommand ejecutor = new NpgsqlCommand(query, _con);

            _con.Open();
            ejecutor.ExecuteNonQuery();

            _con.Close();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

}