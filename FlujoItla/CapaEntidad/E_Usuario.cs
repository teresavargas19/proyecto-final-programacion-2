using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Usuario
    {
        private int _id_usuario;
        private string _codigo_usuario;
        private string _nombre;
        private string _apellido;
        private string _user;
        private string _password;
        private string _Rol;
        private DateTime _fechanac;

        public int Id_usuario
        {
            get
            {
                return _id_usuario;
            }

            set
            {
                _id_usuario = value;
            }
        }

        public string Codigo_usuario
        {
            get
            {
                return _codigo_usuario;
            }

            set
            {
                _codigo_usuario = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return _apellido;
            }

            set
            {
                _apellido = value;
            }
        }

        public string User
        {
            get
            {
                return _user;
            }

            set
            {
                _user = value;
            }
        }

        public string password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

        public string Rol
        {
            get
            {
                return _Rol;
            }

            set
            {
                _Rol = value;
            }
        }

        public DateTime Fechanac
        {
            get
            {
                return _fechanac;
            }

            set
            {
                _fechanac = value;
            }
        }

        
    }
}
