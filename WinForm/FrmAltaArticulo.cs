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
    public partial class FrmAltaArticulo : Form {
        public FrmAltaArticulo() {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            Articulo nuevoArticulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try {
                nuevoArticulo.Codigo = tboxCodigo.Text;
                nuevoArticulo.Nombre = tboxNombre.Text;
                nuevoArticulo.Descripcion = tboxDescripcion.Text;
                nuevoArticulo.ImagenUrl = tboxImagenUrl.Text;
                nuevoArticulo.Marca = (Marca)cboxMarca.SelectedItem;
                nuevoArticulo.Categoria = (Categoria)cboxCategoria.SelectedItem;

                negocio.agregar(nuevoArticulo);
                MessageBox.Show("Articulo agregado");
                Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAltaArticulo_Load(object sender, EventArgs e) {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try {
                cboxMarca.DataSource = marcaNegocio.listar();
                cboxCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tboxImagenUrl_Leave(object sender, EventArgs e) {
            cargarImagen(tboxImagenUrl.Text);
        }

        private void cargarImagen(string imagen) {
            try {
                pbxAltaArticulo.Load(imagen);
            }
            catch (Exception) {
                pbxAltaArticulo.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }
    }
}
