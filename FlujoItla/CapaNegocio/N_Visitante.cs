using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class N_Visitante
    {
        D_Visitante objDato = new D_Visitante();

        public List<E_Visitante> ListandoVisitante(string buscar)
        {
            return objDato.ListarVisitante(buscar);
        }
        public void InsertandoVisitante(E_Visitante visitante)
        {
            objDato.insertarVisitante(visitante);
        }
        public void EditandoVisitante(E_Visitante visitante)
        {
            objDato.EditarVisitante(visitante);
        }
        public void EliminandoVisitante(E_Visitante visitante)
        {
            objDato.EliminarVisitante(visitante);
        }
        public DataTable CargandoEdificio()
        {
            return objDato.CargaEdificio();
        }
        public DataTable CargandoAula(E_Aula aula)
        {
            return objDato.CargaAula(aula);
        }
        /* public DataTable CargandoEdificio()
         {
             return objDato.CargarEdificios();
         }
         public DataTable CargandoAula(int idEdificio)
         {
             return objDato.CargarAula(idEdificio);
         }*/
    }
}
