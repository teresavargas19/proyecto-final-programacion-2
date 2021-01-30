using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_Aula
    {
        D_Aula objdato = new D_Aula();

        public List<E_Aula> ListandoAula(string buscar)
        {
            return objdato.ListarAula(buscar);
        }
        public void InsertandoAula(E_Aula aula)
        {
            objdato.insertarAula(aula);
        }
        public void EditandoAula(E_Aula aula)
        {
            objdato.EditarAula(aula);
        }
        public void EliminandoAula(E_Aula aula)
        {
            objdato.EliminarAula(aula);
        }
    }
}
