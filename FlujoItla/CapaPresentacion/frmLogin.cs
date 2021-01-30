using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        E_Usuario ObjE = new E_Usuario();
        N_Usuario ObjN = new N_Usuario();
        string puesto = "Administrador";
        

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                ObjE.User = txtUser.Text;
                ObjE.password = txtPass.Text;
                //ObjE.Rol = puesto;

                dt = ObjN.Loging_N(ObjE);

                if (dt.Rows.Count > 0)
                {
                    ObjE.User = dt.Rows[0][0].ToString();
                    ObjE.password = dt.Rows[0][1].ToString();
                    ObjE.Rol = dt.Rows[0][2].ToString();
                    MessageBox.Show($"BIENVENIDO!! {ObjE.User}");
                    this.Hide();
                    if (ObjE.Rol == puesto)
                    {
                        frmPagPrincipal FRM = new frmPagPrincipal();
                        FRM.Show();
                    }else
                    {
                        frmPagPrincipal FRM = new frmPagPrincipal();
                        FRM.btnConfigurar.Enabled = false;
                        FRM.Show();
                    }
                    
                }
                else
                {
                    MessageBox.Show($"DATOS INCORRECTOS, VERIFIQUE SU USUARIO O SU CONTACEÑA... ");
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show($"{Error.Message}");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
