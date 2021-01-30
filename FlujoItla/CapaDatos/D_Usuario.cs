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
    public class D_Usuario
    {
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnect"].ConnectionString);

        public DataTable Loging_D(E_Usuario Login)
        {
            SqlCommand Command = new SqlCommand("SP_Loging", conexion);
            Command.CommandType = CommandType.StoredProcedure;

            conexion.Open();
            Command.Parameters.AddWithValue("@USER", Login.User);
            Command.Parameters.AddWithValue("@PASSWORD", Login.password);

            SqlDataAdapter adapter = new SqlDataAdapter(Command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            conexion.Close();
            return dataTable;

        }
        public List<E_Usuario> ListarUsuarios(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_buscarUsuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Usuario> Listar = new List<E_Usuario>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Usuario
                {
                    Id_usuario = LeerFilas.GetInt32(0),
                    Codigo_usuario = LeerFilas.GetString(1),
                    Nombre = LeerFilas.GetString(2),
                    Apellido = LeerFilas.GetString(3),
                    User = LeerFilas.GetString(4),
                    password = LeerFilas.GetString(5),
                    Rol = LeerFilas.GetString(6),
                    Fechanac = LeerFilas.GetDateTime(7)
                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }

        public void insertarUsuario(E_Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarUsuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", usuario.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", usuario.Apellido);
            cmd.Parameters.AddWithValue("@_USER", usuario.User);
            cmd.Parameters.AddWithValue("@_PASSWORD", usuario.password);
            cmd.Parameters.AddWithValue("@ROL", usuario.Rol);
            cmd.Parameters.AddWithValue("@FECHANAC", usuario.Fechanac);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarUsuario(E_Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_EditarUsuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_USUARIO", usuario.Id_usuario);
            cmd.Parameters.AddWithValue("@NOMBRE", usuario.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", usuario.Apellido);
            cmd.Parameters.AddWithValue("@_USER", usuario.User);
            cmd.Parameters.AddWithValue("@_PASSWORD", usuario.password);
            cmd.Parameters.AddWithValue("@ROL", usuario.Rol);
            cmd.Parameters.AddWithValue("@FECHANAC", usuario.Fechanac);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarUsuario(E_Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarUsuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_USUARIO", usuario.Id_usuario);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
