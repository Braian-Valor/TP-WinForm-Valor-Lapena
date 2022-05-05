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

                negocio.agregar(nuevoArticulo);
                MessageBox.Show("Articulo agregado");
                Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
