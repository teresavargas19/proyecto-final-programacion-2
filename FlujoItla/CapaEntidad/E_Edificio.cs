using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Edificio
    {
        private int _idEdificio;
        private string _codigoEdificio;
        private string _Nombre;
        private int _nivel;

        public int IdEdificio
        {
            get
            {
                return _idEdificio;
            }

            set
            {
                _idEdificio = value;
            }
        }

        public string CodigoEdificio
        {
            get
            {
                return _codigoEdificio;
            }

            set
            {
                _codigoEdificio = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public int Nivel
        {
            get
            {
                return _nivel;
            }

            set
            {
                _nivel = value;
            }
        }
    }
}
