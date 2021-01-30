using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Aula
    {
        private int _idAula;
        private string _codigoAula;
        private string _nombre;
        private int _idEdificio;

        public int IdAula
        {
            get
            {
                return _idAula;
            }

            set
            {
                _idAula = value;
            }
        }

        public string CodigoAula
        {
            get
            {
                return _codigoAula;
            }

            set
            {
                _codigoAula = value;
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
    }
}
