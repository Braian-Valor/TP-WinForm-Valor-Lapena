
namespace WinForm {
    partial class FrmAltaArticulo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tboxCodigo = new System.Windows.Forms.TextBox();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.tboxDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboxMarca = new System.Windows.Forms.ComboBox();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.tboxImagenUrl = new System.Windows.Forms.TextBox();
            this.lblImagenUrl = new System.Windows.Forms.Label();
            this.pbxAltaArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAltaArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(67, 19);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(63, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(44, 71);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // tboxCodigo
            // 
            this.tboxCodigo.Location = new System.Drawing.Point(116, 12);
            this.tboxCodigo.Name = "tboxCodigo";
            this.tboxCodigo.Size = new System.Drawing.Size(158, 20);
            this.tboxCodigo.TabIndex = 3;
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(116, 38);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(158, 20);
            this.tboxNombre.TabIndex = 4;
            // 
            // tboxDescripcion
            // 
            this.tboxDescripcion.Location = new System.Drawing.Point(116, 64);
            this.tboxDescripcion.Name = "tboxDescripcion";
            this.tboxDescripcion.Size = new System.Drawing.Size(158, 20);
            this.tboxDescripcion.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(116, 193);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(292, 193);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(70, 124);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(55, 155);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cboxMarca
            // 
            this.cboxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(116, 116);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(161, 21);
            this.cboxMarca.TabIndex = 10;
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(116, 147);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(161, 21);
            this.cboxCategoria.TabIndex = 11;
            // 
            // tboxImagenUrl
            // 
            this.tboxImagenUrl.Location = new System.Drawing.Point(116, 90);
            this.tboxImagenUrl.Name = "tboxImagenUrl";
            this.tboxImagenUrl.Size = new System.Drawing.Size(158, 20);
            this.tboxImagenUrl.TabIndex = 13;
            this.tboxImagenUrl.Leave += new System.EventHandler(this.tboxImagenUrl_Leave);
            // 
            // lblImagenUrl
            // 
            this.lblImagenUrl.AutoSize = true;
            this.lblImagenUrl.Location = new System.Drawing.Point(49, 97);
            this.lblImagenUrl.Name = "lblImagenUrl";
            this.lblImagenUrl.Size = new System.Drawing.Size(61, 13);
            this.lblImagenUrl.TabIndex = 12;
            this.lblImagenUrl.Text = "Url Imagen:";
            // 
            // pbxAltaArticulo
            // 
            this.pbxAltaArticulo.Location = new System.Drawing.Point(292, 12);
            this.pbxAltaArticulo.Name = "pbxAltaArticulo";
            this.pbxAltaArticulo.Size = new System.Drawing.Size(171, 156);
            this.pbxAltaArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAltaArticulo.TabIndex = 14;
            this.pbxAltaArticulo.TabStop = false;
            // 
            // FrmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 243);
            this.Controls.Add(this.pbxAltaArticulo);
            this.Controls.Add(this.tboxImagenUrl);
            this.Controls.Add(this.lblImagenUrl);
            this.Controls.Add(this.cboxCategoria);
            this.Controls.Add(this.cboxMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tboxDescripcion);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.tboxCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FrmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.FrmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAltaArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox tboxCodigo;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.TextBox tboxDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboxMarca;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.TextBox tboxImagenUrl;
        private System.Windows.Forms.Label lblImagenUrl;
        private System.Windows.Forms.PictureBox pbxAltaArticulo;
    }
}