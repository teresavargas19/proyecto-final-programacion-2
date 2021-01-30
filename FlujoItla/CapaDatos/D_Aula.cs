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
    public class D_Aula
    {
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnect"].ConnectionString);

        public List<E_Aula> ListarAula(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarAula1", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

                LeerFilas = cmd.ExecuteReader();
         
            List<E_Aula> Listar = new List<E_Aula>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Aula
                {
                    IdAula = LeerFilas.GetInt32(0),
                    CodigoAula = LeerFilas.GetString(1),
                    Nombre = LeerFilas.GetString(2),
                    IdEdificio = LeerFilas.GetInt32(3)

                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }

        public void insertarAula(E_Aula aula)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarAula", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", aula.Nombre);
            cmd.Parameters.AddWithValue("@ID_EDIFICIO", aula.IdEdificio);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarAula(E_Aula aula)
        {
            SqlCommand cmd = new SqlCommand("SP_EditarAula", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_AULA", aula.IdAula);
            cmd.Parameters.AddWithValue("@NOMBRE", aula.Nombre);
            cmd.Parameters.AddWithValue("@ID_EDIFICIO", aula.IdEdificio);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarAula(E_Aula aula)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarAula", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_AULA", aula.IdAula);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
