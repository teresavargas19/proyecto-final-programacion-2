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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        public bool editarse = false;
        E_Visitante objEntidad = new E_Visitante();
        N_Visitante objNegocio = new N_Visitante();
        E_Aula objAula = new E_Aula();

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            carga_Edi();
           
        }
        private void limpiarCajas()
        {
            editarse = false;
            txtCod.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCarrera.Text = "";
            txtCorreo.Text = "";
            ComboxEdificio.Text = "";
            comboxAula.Text = "";
            txtMotivoVisita.Text = "";
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editarse == false)
            {
                try
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();

                    objEntidad.Nombre = txtNombre.Text.ToLowerInvariant();
                    objEntidad.Apellido = txtApellido.Text.ToLowerInvariant();
                    objEntidad.Carrera = txtCarrera.Text.ToLowerInvariant();
                    objEntidad.Correo = txtCorreo.Text.ToLowerInvariant();
                    objEntidad.Edificio = ComboxEdificio.Text.ToLowerInvariant();
                    objEntidad.Aula = comboxAula.Text.ToLowerInvariant();
                    objEntidad.HoraEntrada = Convert.ToDateTime(dateTimeHora.Text);
                    objEntidad.MotivoVisita = txtMotivoVisita.Text.ToLowerInvariant();

                    objNegocio.InsertandoVisitante(objEntidad);

                    MessageBox.Show("Guardo el registro");
                    limpiarCajas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro" + ex);
                }
                if (editarse == true)
                {
                    try
                    {
                        objEntidad.IdVisitante = Convert.ToInt32(idVisitante);
                        objEntidad.Nombre = txtNombre.Text.ToLowerInvariant();
                        objEntidad.Apellido = txtApellido.Text.ToLowerInvariant();
                        objEntidad.Carrera = txtCarrera.Text.ToLowerInvariant();
                        objEntidad.Correo = txtCorreo.Text.ToLowerInvariant();
                        objEntidad.Edificio = ComboxEdificio.Text.ToLowerInvariant();
                        objEntidad.Aula = comboxAula.Text.ToLowerInvariant();
                        objEntidad.HoraEntrada = Convert.ToDateTime(dateTimeHora.Text);
                        objEntidad.MotivoVisita = txtMotivoVisita.Text.ToLowerInvariant();

                        objNegocio.EditandoVisitante(objEntidad);

                        MessageBox.Show("Se edito el registro");
                        limpiarCajas();
                        editarse = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar el registro" + ex);
                    }
                }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCajas();
        }
        private void carga_Edi()
        {
            ComboxEdificio.ValueMember = "ID_EDIFICIO";
            ComboxEdificio.DisplayMember = "NOMBRE";
            ComboxEdificio.DataSource = objNegocio.CargandoEdificio();
        }
        private void carga_Aula(int _idedificio)
        {
            comboxAula.ValueMember = "ID_EDIFICIO";
            comboxAula.DisplayMember = "NOMBRE";
            objAula.IdEdificio = Convert.ToInt32(_idedificio);
            comboxAula.DataSource = objNegocio.CargandoAula(objAula);
        }
        
        private string id_edificio;
        private int _idEdificio_;
        public string idVisitante;

        private void ComboxEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboxEdificio.SelectedValue.ToString() != null)
            {

                id_edificio = ComboxEdificio.SelectedValue.ToString();
                _idEdificio_ = Convert.ToInt32(id_edificio);
                carga_Aula(_idEdificio_);                
            }

        }
    }
}