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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        private string idUsuario;
        private bool editarse = false;
        E_Usuario objEntidad = new E_Usuario();
        N_Usuario objNegocio = new N_Usuario();

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
        }
        

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Usuario objNegocio = new N_Usuario();
            tablaUsuario.DataSource = objNegocio.ListandoUsuario(buscar);
        }
        public void accionesTabla()
        {
            tablaUsuario.Columns[0].Visible = false;
            tablaUsuario.Columns[1].Width = 65;
            tablaUsuario.Columns[2].Width = 85;
            tablaUsuario.Columns[3].Width = 85;
            tablaUsuario.Columns[4].Width = 85;
            tablaUsuario.Columns[5].Width = 90;
            tablaUsuario.Columns[6].Width = 200; 
            tablaUsuario.Columns[7].Width = 100;

            tablaUsuario.ClearSelection();

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
            txtApellido.Text = "";
            txtUser.Text = "";
            txtPassword.Text = "";
            ComboxRol.Text = "";
            txtNombre.Focus();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCajas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaUsuario.SelectedRows.Count > 0)
            {
                editarse = true;
                idUsuario = tablaUsuario.CurrentRow.Cells[0].Value.ToString();
                txtCod.Text = tablaUsuario.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = tablaUsuario.CurrentRow.Cells[2].Value.ToString();
                txtApellido.Text = tablaUsuario.CurrentRow.Cells[3].Value.ToString();
                txtUser.Text = tablaUsuario.CurrentRow.Cells[4].Value.ToString();
                txtPassword.Text = tablaUsuario.CurrentRow.Cells[5].Value.ToString();
                ComboxRol.Text = tablaUsuario.CurrentRow.Cells[6].Value.ToString();
                dateTimePicker1.Text = tablaUsuario.CurrentRow.Cells[7].Value.ToString();


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
                    objEntidad.Apellido = txtApellido.Text.ToLowerInvariant();
                    objEntidad.User = txtUser.Text.ToLowerInvariant();
                    objEntidad.password = txtPassword.Text.ToLowerInvariant();
                    objEntidad.Rol = ComboxRol.Text.ToLowerInvariant();
                    objEntidad.Fechanac = Convert.ToDateTime(dateTimePicker1.Text);


                    objNegocio.InsertandoUsuario(objEntidad);

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
                    objEntidad.Id_usuario = Convert.ToInt32(idUsuario);
                    objEntidad.Nombre = txtNombre.Text.ToLowerInvariant();
                    objEntidad.Apellido = txtApellido.Text.ToLowerInvariant();
                    objEntidad.User = txtUser.Text.ToLowerInvariant();
                    objEntidad.password = txtPassword.Text.ToLowerInvariant();
                    objEntidad.Rol = ComboxRol.Text.ToLowerInvariant();
                    objEntidad.Fechanac = Convert.ToDateTime(dateTimePicker1.Text);

                    objNegocio.EditandoUsuarios(objEntidad);

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
            if (tablaUsuario.SelectedRows.Count > 0)
            {

                objEntidad.Id_usuario = Convert.ToInt32(tablaUsuario.CurrentRow.Cells[0].Value.ToString());
                objNegocio.EliminandoUsuario(objEntidad);

                MessageBox.Show("se elimino correctamente");
                mostrarBuscarTabla("");

            }
            else
            {
                MessageBox.Show("seleccione la fila que desea eliminar");
            }
        }

        private void tablaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
