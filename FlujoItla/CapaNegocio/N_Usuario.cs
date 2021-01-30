using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
     public class N_Usuario
    {
        D_Usuario objDatos = new D_Usuario();

        public DataTable Loging_N(E_Usuario Login)
        {
            return objDatos.Loging_D(Login);
        }
        public List<E_Usuario> ListandoUsuario(string buscar)
        {
            return objDatos.ListarUsuarios(buscar);
        }
        public void InsertandoUsuario(E_Usuario usuario)
        {
            objDatos.insertarUsuario(usuario);
        }
        public void EditandoUsuarios(E_Usuario usuario)
        {
            objDatos.EditarUsuario(usuario);
        }
        public void EliminandoUsuario(E_Usuario usuario)
        {
            objDatos.EliminarUsuario(usuario);
        }
    }
}
