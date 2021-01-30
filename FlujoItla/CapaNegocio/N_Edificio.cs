using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_Edificio
    {
        D_Edificio objDato = new D_Edificio();

        public List<E_Edificio> ListandoEdificio(string buscar)
        {
            return objDato.ListarEdificio(buscar);
        }
        public void InsertandoEdificio(E_Edificio edificio)
        {
            objDato.insertarEdificio(edificio);
        }
        public void EditandoEdificio(E_Edificio edificio)
        {
            objDato.EditarEdificio(edificio);
        }
        public void EliminandoEdificio(E_Edificio edificio)
        {
            objDato.EliminarEdificio(edificio);
        }
    }
}
