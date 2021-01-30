using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Visitante
    {
        private int _idVisitante;
        private string _codigoVisitante;
        private string _nombre;
        private string _apellido;
        private string _carrera;
        private string _correo;
        private string _edificio;
        private string _Aula;
        private DateTime _horaEntrada;
        private string _motivoVisita;
        
        public int IdVisitante
        {
            get
            {
                return _idVisitante;
            }

            set
            {
                _idVisitante = value;
            }
        }

        public string CodigoVisitante
        {
            get
            {
                return _codigoVisitante;
            }

            set
            {
                _codigoVisitante = value;
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

        public string Carrera
        {
            get
            {
                return _carrera;
            }

            set
            {
                _carrera = value;
            }
        }

        public string Correo
        {
            get
            {
                return _correo;
            }

            set
            {
                _correo = value;
            }
        }

        public string Edificio
        {
            get
            {
                return _edificio;
            }

            set
            {
                _edificio = value;
            }
        }

        public string Aula
        {
            get
            {
                return _Aula;
            }

            set
            {
                _Aula = value;
            }
        }

        public DateTime HoraEntrada
        {
            get
            {
                return _horaEntrada;
            }

            set
            {
                _horaEntrada = value;
            }
        }

        public string MotivoVisita
        {
            get
            {
                return _motivoVisita;
            }

            set
            {
                _motivoVisita = value;
            }
        }

    }
}
