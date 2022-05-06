﻿using System;
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
                comando.CommandText = "select Codigo, Nombre, A.Descripcion, ImagenUrl, M.Descripcion Marca, C.Descripcion Categoria from Articulos A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read()) {
                    Articulo aux = new Articulo();

                    if (!(lector["Codigo"] is DBNull))
                        aux.Codigo = (string)lector["Codigo"];
                    if (!(lector["Nombre"] is DBNull))
                        aux.Nombre = (string)lector["Nombre"];
                    if (!(lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)lector["Descripcion"];
                    if (!(lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)lector["ImagenUrl"];
                    if (!(lector["Marca"] is DBNull))
                        aux.Marca = new Marca();
                        aux.Marca.Descripcion = (string)lector["Marca"];
                    if (!(lector["Categoria"] is DBNull))
                        aux.Categoria = new Categoria();
                        aux.Categoria.Descripcion = (string)lector["Categoria"];

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
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl) values ('" + nuevoArticulo.Codigo + "', '" + nuevoArticulo.Nombre + "', '" + nuevoArticulo.Descripcion + "', @IdMarca, @IdCategoria, @ImagenUrl)");
                datos.setearParametro("@IdMarca", nuevoArticulo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevoArticulo.Categoria.Id);
                datos.setearParametro("@ImagenUrl", nuevoArticulo.ImagenUrl);
                datos.ejecutarAccion();
            }
            catch (Exception ex) {
                throw ex;
            }
            finally {
                datos.cerrarConexion();
            }
        }
    }
}
