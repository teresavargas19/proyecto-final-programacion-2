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
    public class D_Visitante
    {
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnect"].ConnectionString);

        public List<E_Visitante> ListarVisitante(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarVisitante", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Visitante> Listar = new List<E_Visitante>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Visitante
                {
                    IdVisitante = LeerFilas.GetInt32(0),
                    CodigoVisitante = LeerFilas.GetString(1),
                    Nombre = LeerFilas.GetString(2),
                    Apellido = LeerFilas.GetString(3),
                    Carrera = LeerFilas.GetString(4),
                    Correo = LeerFilas.GetString(5),
                    Edificio = LeerFilas.GetString(6),
                    Aula = LeerFilas.GetString(7),
                    HoraEntrada = LeerFilas.GetDateTime(8),
                    MotivoVisita = LeerFilas.GetString(9)
                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }

        public void insertarVisitante(E_Visitante visitante)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarVisitante", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", visitante.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", visitante.Apellido);
            cmd.Parameters.AddWithValue("@CARRERA", visitante.Carrera);
            cmd.Parameters.AddWithValue("@CORREO", visitante.Correo);
            cmd.Parameters.AddWithValue("@EDIFICIO", visitante.Edificio);
            cmd.Parameters.AddWithValue("@AULA", visitante.Aula);
            cmd.Parameters.AddWithValue("@HORA_ENTRADA", visitante.HoraEntrada);
            cmd.Parameters.AddWithValue("@MOTIVO_VISITA", visitante.MotivoVisita);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarVisitante(E_Visitante visitante)
        {
            SqlCommand cmd = new SqlCommand("SP_EditarVisitante", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_VISITANTE", visitante.IdVisitante);
            cmd.Parameters.AddWithValue("@NOMBRE", visitante.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", visitante.Apellido);
            cmd.Parameters.AddWithValue("@CARRERA", visitante.Carrera);
            cmd.Parameters.AddWithValue("@CORREO", visitante.Correo);
            cmd.Parameters.AddWithValue("@EDIFICIO", visitante.Edificio);
            cmd.Parameters.AddWithValue("@AULA", visitante.Aula);
            cmd.Parameters.AddWithValue("@HORA_ENTRADA", visitante.HoraEntrada);
            cmd.Parameters.AddWithValue("@MOTIVO_VISITA", visitante.MotivoVisita);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarVisitante(E_Visitante visitante)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarVisitante", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_VISITANTE", visitante.IdVisitante);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public DataTable CargaEdificio()
        {
            SqlCommand Command = new SqlCommand("SP_ComboxEdificio", conexion);
            Command.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(Command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            conexion.Close();
            return dataTable;

        }
        public DataTable CargaAula(E_Aula aula)
        {
            SqlCommand Command = new SqlCommand("SP_ComboxAula", conexion);
            Command.CommandType = CommandType.StoredProcedure;

            conexion.Open();
            Command.Parameters.AddWithValue("@ID_EDIFICIO", aula.IdEdificio);

            SqlDataAdapter adapter = new SqlDataAdapter(Command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            conexion.Close();
            return dataTable;

        }
     
    }
}
