using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProyectoDISCOsql;



namespace WindowsFormsApp4
{
    // esta es la clase que nos va a permitir crear los metodos para los pokemon en base de datos // los metodos tiene que ser
    //public para que pueda agrrar de la base de datos 
    internal class DiscoNegocio    {
        public List<Discos> listar()
        {
            List<Discos> lista = new List<Discos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;



            try
            {

                conexion.ConnectionString = "server = .\\SQLEXPRESS; database=DISCOS_DB ; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa ,e.Descripcion  from DISCOS D, ESTILOS E WHERE d.IdEstilo = E.Id";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    Discos aux = new Discos();
                    aux.CantidadCanciones = lector.GetInt32(2);
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.urlImagen = (string)lector["UrlImagenTapa"];
                    aux.tipo = new Estilos();
                    aux.tipo.Descripcion = (string)lector["Descripcion"];





                    lista.Add(aux);
                }

                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


    }
}
