using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P620223_StevenVargas.Formularios
{
    public partial class FrmUsuariosGestion : Form
    {
        public Logica.Models.Usuario MiUsuarioLocal  { get; set; }

        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincioal;

            CargarRolesDeUsuario();
            CargarEmpresas();
        }
    
        private void CargarRolesDeUsuario()
        {
            Logica.Models.UsuarioRol MiRolUsuario = new Logica.Models.UsuarioRol();
            DataTable dt= new DataTable();
            dt = MiRolUsuario.listar();

            if (dt!= null && dt.Rows.Count>0)
            {
                CbxTipousuario.ValueMember = "IDUsuarioRol";
                CbxTipousuario.DisplayMember = "Rol";
                CbxTipousuario.DataSource = dt;
                CbxTipousuario.SelectedIndex = -1;
            }
        }
        private void CargarEmpresas()
        {
            Logica.Models.Empresa MiEmpresa = new Logica.Models.Empresa();
            DataTable dt = new DataTable();
            dt = MiEmpresa.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbxEmpresa.ValueMember = "ID";
                CbxEmpresa.DisplayMember = "D";
                CbxEmpresa.DataSource = dt;
                CbxEmpresa.SelectedIndex = -1;
            }
        }


    }
}
