using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class frmVisitante : Form
    {
        public frmVisitante()
        {
            InitializeComponent();
        }
        private bool editarse = false;
        frmRegistro frm1 = new frmRegistro();
        E_Visitante objEntidad = new E_Visitante();
        N_Visitante objNegocio = new N_Visitante();

       
        private void frmVisitante_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
        }

      
        public void mostrarBuscarTabla(string buscar)
        {
            N_Visitante objNegocio = new N_Visitante();
            tablaVisitante.DataSource = objNegocio.ListandoVisitante(buscar);
        }
        public void accionesTabla()
        {
            tablaVisitante.Columns[0].Visible = false;
            tablaVisitante.ClearSelection();

        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscador.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (tablaVisitante.SelectedRows.Count > 0)
            {
                frm1.editarse = true;
                frm1.idVisitante = tablaVisitante.CurrentRow.Cells[0].Value.ToString();
                frm1.txtCod.Text = tablaVisitante.CurrentRow.Cells[1].Value.ToString();
                frm1.txtNombre.Text = tablaVisitante.CurrentRow.Cells[2].Value.ToString();
                frm1.txtApellido.Text = tablaVisitante.CurrentRow.Cells[3].Value.ToString();
                frm1.txtCarrera.Text = tablaVisitante.CurrentRow.Cells[4].Value.ToString();
                frm1.txtCorreo.Text = tablaVisitante.CurrentRow.Cells[5].Value.ToString();
                frm1.ComboxEdificio.Text = tablaVisitante.CurrentRow.Cells[6].Value.ToString();
                frm1.comboxAula.Text = tablaVisitante.CurrentRow.Cells[7].Value.ToString();
                frm1.dateTimeHora.Text = tablaVisitante.CurrentRow.Cells[8].Value.ToString();
                frm1.txtMotivoVisita.Text = tablaVisitante.CurrentRow.Cells[9].Value.ToString();
                frm1.Show();
                
            }
            else
            {
                MessageBox.Show("seleccione la fila que desea editar");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tablaVisitante.SelectedRows.Count > 0)
            {

                objEntidad.IdVisitante = Convert.ToInt32(tablaVisitante.CurrentRow.Cells[0].Value.ToString());
                objNegocio.EliminandoVisitante(objEntidad);

                MessageBox.Show("se elimino correctamente");
                mostrarBuscarTabla("");

            }
            else
            {
                MessageBox.Show("seleccione la fila que desea eliminar");
            }
        }

    }
}
