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
        private Articulo articulo = null;
        public FrmAltaArticulo() {
            InitializeComponent();
        }

        public FrmAltaArticulo(Articulo articuloSeleccionado) {
            InitializeComponent();
            articulo = articuloSeleccionado;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            //Articulo nuevoArticulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try {
                articulo.Codigo = tboxCodigo.Text;
                articulo.Nombre = tboxNombre.Text;
                articulo.Descripcion = tboxDescripcion.Text;
                articulo.ImagenUrl = tboxImagenUrl.Text;
                articulo.Marca = (Marca)cboxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboxCategoria.SelectedItem;

                if (articulo.Id != 0) {
                    negocio.modificar(articulo);
                    MessageBox.Show("Articulo modificado");
                }
                else {
                    negocio.agregar(articulo);
                    MessageBox.Show("Articulo agregado");
                }
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
                cboxMarca.ValueMember = "Id";
                cboxMarca.DisplayMember = "Descripcion";
                cboxCategoria.DataSource = categoriaNegocio.listar();
                cboxCategoria.ValueMember = "Id";
                cboxCategoria.DisplayMember = "Descripcion";

                if(articulo != null) {
                    tboxCodigo.Text = articulo.Codigo;
                    tboxNombre.Text = articulo.Nombre;
                    tboxDescripcion.Text = articulo.Descripcion;
                    tboxImagenUrl.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    cboxMarca.SelectedValue = articulo.Marca.Id;
                    cboxCategoria.SelectedValue = articulo.Categoria.Id;
                }
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
