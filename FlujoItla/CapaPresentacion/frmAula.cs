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
    public partial class frmAula : Form
    {
        public frmAula()
        {
            InitializeComponent();
        }
        private string idAula;
        private bool editarse = false;
        E_Aula objEntidad = new E_Aula();
        N_Aula objNegocio = new N_Aula();

        private void frmAula_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
        }

        public void mostrarBuscarTabla(string buscar)
        {
            N_Aula objNegocio = new N_Aula();
            tablaAula.DataSource = objNegocio.ListandoAula(buscar);
        }
        public void accionesTabla()
        {
            tablaAula.Columns[0].Visible = false;
            tablaAula.Columns[1].Width = 65;
            tablaAula.Columns[2].Width = 85;
            tablaAula.Columns[3].Width = 85;


            tablaAula.ClearSelection();

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
            txtidEdificio.Text = "";
            txtNombre.Focus();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCajas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaAula.SelectedRows.Count > 0)
            {
                editarse = true;
                idAula = tablaAula.CurrentRow.Cells[0].Value.ToString();
                txtCod.Text = tablaAula.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = tablaAula.CurrentRow.Cells[2].Value.ToString();
                txtidEdificio.Text = tablaAula.CurrentRow.Cells[3].Value.ToString();

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
                    objEntidad.Nombre = txtNombre.Text.ToUpper();
                    objEntidad.IdEdificio = Convert.ToInt32(txtidEdificio.Text);



                    objNegocio.InsertandoAula(objEntidad);

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
                    objEntidad.IdAula = Convert.ToInt32(idAula);
                    objEntidad.Nombre = txtNombre.Text.ToUpper();
                    objEntidad.IdEdificio = Convert.ToInt32(txtidEdificio.Text);

                    objNegocio.EditandoAula(objEntidad);

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
            if (tablaAula.SelectedRows.Count > 0)
            {

                objEntidad.IdAula = Convert.ToInt32(tablaAula.CurrentRow.Cells[0].Value.ToString());
                objNegocio.EliminandoAula(objEntidad);

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
