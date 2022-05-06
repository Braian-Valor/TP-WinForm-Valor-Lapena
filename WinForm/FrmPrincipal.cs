using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WinForm {
    public partial class frmArticulos : Form {
        private List<Articulo> listaArticulo;
        public frmArticulos() {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e) {
            cargar();
        }

        private void cargar() {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                dgvArticulos.Columns["ImagenUrl"].Visible = false;
                cargarImagen(listaArticulo[0].ImagenUrl);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e) {
            Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(articuloSeleccionado.ImagenUrl);
        }

        private void cargarImagen(string imagen) {
            try {
                pbxArticulo.Load(imagen);
            }
            catch (Exception) {
                pbxArticulo.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            FrmAltaArticulo alta = new FrmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }
    }
}
