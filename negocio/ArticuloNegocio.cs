using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio {
    public class ArticuloNegocio {
        public List<Articulo> listar() {

            List<Articulo> lista = new List<Articulo>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Id Id, Codigo, Nombre, A.Descripcion, ImagenUrl, M.Descripcion Marca, C.Descripcion Categoria, M.Id IdMarca, C.Id IdCategoria, A.Precio Precio from Articulos A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read()) {
                    Articulo aux = new Articulo();

                    aux.Id = (int)lector["Id"];
                    if (!(lector["Codigo"] is DBNull))
                        aux.Codigo = (string)lector["Codigo"];
                    if (!(lector["Nombre"] is DBNull))
                        aux.Nombre = (string)lector["Nombre"];
                    if (!(lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)lector["Descripcion"];
                    if (!(lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)lector["ImagenUrl"];
                    if (!(lector["Marca"] is DBNull)) {
                        aux.Marca = new Marca();
                        aux.Marca.Id = (int)lector["IdMarca"];
                        aux.Marca.Descripcion = (string)lector["Marca"];
                    }
                    if (!(lector["Categoria"] is DBNull)) {
                        aux.Categoria = new Categoria();
                        aux.Categoria.Id = (int)lector["IdCategoria"];
                        aux.Categoria.Descripcion = (string)lector["Categoria"];
                    }
                    if (!(lector["Precio"] is DBNull))
                        aux.Precio = (decimal)lector["Precio"];
                    
                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public void agregar(Articulo nuevoArticulo) {
            AccesoDatos datos = new AccesoDatos();

            try {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values ('" + nuevoArticulo.Codigo + "', '" + nuevoArticulo.Nombre + "', '" + nuevoArticulo.Descripcion + "', @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
                datos.setearParametro("@IdMarca", nuevoArticulo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevoArticulo.Categoria.Id);
                datos.setearParametro("@ImagenUrl", nuevoArticulo.ImagenUrl);
                datos.setearParametro("@Precio", nuevoArticulo.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex) {
                throw ex;
            }
            finally {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo articulo) {
            AccesoDatos datos = new AccesoDatos();
            try {
                datos.setearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio where Id = @Id");
                datos.setearParametro("@Codigo", articulo.Codigo);
                datos.setearParametro("@Nombre", articulo.Nombre);
                datos.setearParametro("@Descripcion", articulo.Descripcion);
                datos.setearParametro("@IdMarca", articulo.Marca.Id);
                datos.setearParametro("@IdCategoria", articulo.Categoria.Id);
                datos.setearParametro("@ImagenUrl", articulo.ImagenUrl);
                datos.setearParametro("@Precio", articulo.Precio);
                datos.setearParametro("@Id", articulo.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex) {
                throw ex;
            }
            finally {

            }
        }
    }
}
