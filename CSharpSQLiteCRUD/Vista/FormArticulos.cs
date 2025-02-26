using CSharpSQLiteCRUD.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSQLiteCRUD.Vista
{
    public partial class FormArticulos : Form
    {
        #region "Propiedades"
        private int articulo_id;
        private int categoria_id;
        private int medida_id;
        private string nombreBtnCRUD;
        #endregion

        public FormArticulos()
        {
            this.articulo_id = 0;
            this.categoria_id = 0;
            this.medida_id = 0;

            InitializeComponent();
        }

        #region "Métodos"
        private void ActivarEscrituraTexto(bool estado)
        {
            this.txtArt.ReadOnly = !estado;
            this.txtMarca.ReadOnly = !estado;
        }

        private void LimpiarTexto()
        {
            this.txtArt.Clear();
            this.txtMarca.Clear();
            this.txtCategoria.Clear();
            this.txtMedida.Clear();
        }

        private void MostrarBotonesProceso(bool mostrar)
        {
            this.btnGuardar.Visible = mostrar;
            this.btnCancelar.Visible = mostrar;
            this.btnLupaCategoria.Visible = mostrar;
            this.btnLupaMedida.Visible = mostrar;

            this.btnBuscar.Enabled = !mostrar;
            this.txtBuscar.Enabled = !mostrar;
            this.dgvListadoArt.Enabled = !mostrar;
        }

        private void MostrarBotonesPrincipales(bool mostrar)
        {
            btnNuevo.Enabled = mostrar;
            btnActualizar.Enabled = mostrar;
            btnEliminar.Enabled = mostrar;
            btnReporte.Enabled = mostrar;
            btnSalir.Enabled = mostrar;
        }
        #endregion

        #region "Eventos"
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.nombreBtnCRUD = ((Button)sender).Name;

            ActivarEscrituraTexto(true);
            MostrarBotonesProceso(true);
            MostrarBotonesPrincipales(false);
            LimpiarTexto();

            this.txtArt.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.nombreBtnCRUD = ((Button)sender).Name;

            ActivarEscrituraTexto(false);
            MostrarBotonesProceso(false);
            MostrarBotonesPrincipales(true);
            LimpiarTexto();

            this.txtBuscar.Focus();
        }

        private void FormArticulos_Load(object sender, EventArgs e)
        {
            this.dgvListadoArt.DataSource = ControladorArticulo.Listar("Prueba");
        }
        #endregion
    }
}
