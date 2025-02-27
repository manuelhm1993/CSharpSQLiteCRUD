using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CSharpSQLiteCRUD.Controlador;

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

        public DataGridView DevolverDataGridView() => this.dgvListadoArt;

        public void CargarDataGridView(DataTable dt) => this.dgvListadoArt.DataSource = dt;

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

        private void FormatoArticulos()
        {
            this.dgvListadoArt.Columns["id"].Width = 90;
            this.dgvListadoArt.Columns["id"].HeaderText = "#";

            this.dgvListadoArt.Columns["descripcion"].Width = 220;
            this.dgvListadoArt.Columns["descripcion"].HeaderText = "DESCRIPCION";

            this.dgvListadoArt.Columns["marca"].Width = 120;
            this.dgvListadoArt.Columns["marca"].HeaderText = "MARCA";

            bool medida = !(this.dgvListadoArt.Columns["medida_desc"] is null);
            bool categoria = !(this.dgvListadoArt.Columns["categoria_desc"] is null);

            string comando = (medida) ? "medida_desc" : "medida_id";

            this.dgvListadoArt.Columns[comando].Width = 100;
            this.dgvListadoArt.Columns[comando].HeaderText = comando.ToUpper();

            comando = (medida) ? "categoria_desc" : "categoria_id";

            this.dgvListadoArt.Columns[comando].Width = 150;
            this.dgvListadoArt.Columns[comando].HeaderText = comando.ToUpper();

            this.dgvListadoArt.Columns["medida_id"].Visible = false;
            this.dgvListadoArt.Columns["categoria_id"].Visible = false;
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
            ControladorArticulo.Listar(this, "%");

            FormatoArticulos();
        }
        #endregion
    }
}
