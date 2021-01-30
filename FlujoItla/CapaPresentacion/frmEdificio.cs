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
    public partial class frmEdificio : Form
    {
        public frmEdificio()
        {
            InitializeComponent();
        }

        private string idEdificio;
        private bool editarse = false;
        E_Edificio objEntidad = new E_Edificio();
        N_Edificio objNegocio = new N_Edificio();

        private void frmEdificio_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Edificio objNegocio = new N_Edificio();
            tablaEdificio.DataSource = objNegocio.ListandoEdificio(buscar);
        }
        public void accionesTabla()
        {
            tablaEdificio.Columns[0].Visible = false;
            tablaEdificio.Columns[1].Width = 65;
            tablaEdificio.Columns[2].Width = 85;
            tablaEdificio.Columns[3].Width = 85;
            

            tablaEdificio.ClearSelection();

        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscador.Text);
        }

        private void limpiarCajas()
        {
            editarse = false;
            txtCod.Text = "";
            txtNombre.Text = "";
            txtNiveles.Text = "";
            txtNombre.Focus();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCajas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaEdificio.SelectedRows.Count > 0)
            {
                editarse = true;
                idEdificio = tablaEdificio.CurrentRow.Cells[0].Value.ToString();
                txtCod.Text = tablaEdificio.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = tablaEdificio.CurrentRow.Cells[2].Value.ToString();
                txtNiveles.Text = tablaEdificio.CurrentRow.Cells[3].Value.ToString();


            }
            else
            {
                MessageBox.Show("seleccione la fila que desea editar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editarse == false)
            {
                try
                {
                    objEntidad.Nombre = txtNombre.Text.ToLowerInvariant();
                    objEntidad.Nivel = Convert.ToInt32(txtNiveles.Text);

                    objNegocio.InsertandoEdificio(objEntidad);

                    MessageBox.Show("Guardo el registro");
                    mostrarBuscarTabla("");
                    limpiarCajas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro" + ex);
                }
            }
            if (editarse == true)
            {
                try
                {
                    objEntidad.IdEdificio = Convert.ToInt32(idEdificio);
                    objEntidad.Nombre = txtNombre.Text.ToLowerInvariant();
                    objEntidad.Nivel = Convert.ToInt32(txtNiveles.Text);

                    objNegocio.EditandoEdificio(objEntidad);

                    MessageBox.Show("Se edito el registro");
                    mostrarBuscarTabla("");
                    limpiarCajas();
                    editarse = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro" + ex);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tablaEdificio.SelectedRows.Count > 0)
            {

                objEntidad.IdEdificio = Convert.ToInt32(tablaEdificio.CurrentRow.Cells[0].Value.ToString());
                objNegocio.EliminandoEdificio(objEntidad);

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
