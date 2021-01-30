using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;

namespace CapaDatos
{
    public class D_Edificio
    {
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnect"].ConnectionString);

        public List<E_Edificio> ListarEdificio(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarEdificio", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Edificio> Listar = new List<E_Edificio>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Edificio
                {
                    IdEdificio = LeerFilas.GetInt32(0),
                    CodigoEdificio = LeerFilas.GetString(1),
                    Nombre = LeerFilas.GetString(2),
                    Nivel = LeerFilas.GetInt32(3)
                    
                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }

        public void insertarEdificio(E_Edificio edificio)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarEdificio", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", edificio.Nombre);
            cmd.Parameters.AddWithValue("@NIVEL", edificio.Nivel);
            
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarEdificio(E_Edificio edificio)
        {
            SqlCommand cmd = new SqlCommand("SP_EditarEdificio", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_EDIFICIO", edificio.IdEdificio);
            cmd.Parameters.AddWithValue("@NOMBRE", edificio.Nombre);
            cmd.Parameters.AddWithValue("@NIVEL", edificio.Nivel);
            
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarEdificio(E_Edificio edificio)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarEdificio", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_EDIFICIO", edificio.IdEdificio);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
