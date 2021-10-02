﻿using DAL.Implementaciones.SqlServer.Adapters;
using Dominio.CompositeProducto;
using Servicios.DAL.Contratos;
using Servicios.DAL.Herramientas;
using Servicios.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementaciones.SqlServer
{
    class ProductoRepositorio: IRepositorioGenerico<Producto>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Producto] (Id, Nombre, Unidad, Descripcion, Foto) VALUES (@Id, @Nombre, @Unidad, @Descripcion, @Foto)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Producto] SET (Id, Nombre, Unidad, Descripcion, Foto) WHERE Id = @Id";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Producto] WHERE Id = @Id";
        }

        private string SelectOneStatement
        {
            get => "SELECT Id, Nombre, Unidad FROM [dbo].[Producto] WHERE  = @";
        }

        private string SelectAllStatement
        {
            get => "SELECT Id, Nombre, Unidad, Descripcion, Foto FROM [dbo].[Producto]";
        }
        #endregion

        private String connectionString;
        internal ProductoRepositorio(String oneConnectionString)
        {
            connectionString = oneConnectionString;
        }

        public void Agregar(Producto unObjeto)
        {
            if (unObjeto.Id == Guid.Empty || unObjeto.Nombre.Length == 0)
                throw new Exception("Faltan completar datos");

            try
            {
                SqlHelper sqlHelper = new SqlHelper(connectionString);
                SqlParameter[] sqlParams = new SqlParameter[] {
                    new SqlParameter("@Id", unObjeto.Id),
                    new SqlParameter("@Nombre", unObjeto.Nombre),
                    new SqlParameter("@Unidad", unObjeto.Unidad.ToString()),
                    new SqlParameter("@Descripcion", unObjeto.Nombre),
                    new SqlParameter("@Foto", unObjeto.Nombre) };

                sqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, sqlParams);
            }
            catch (Exception ex)
            {
                ex.RegistrarError();
                if (ex.Message.Contains("PK_Producto"))
                    throw new Exception("Ya existe otro producto con ese mismo identificador");
                throw new Exception("Hubo un problema al agregar un nuevo producto");
            }
        }

        public void Borrar(Producto unObjeto)
        {
            throw new NotImplementedException();
        }

        public Producto BuscarUno(string[] criterios, string[] valores)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> Listar()
        {
            try {
                List<Producto> todosLosProductos= new List<Producto>();
                SqlHelper sqlHelper = new SqlHelper(connectionString);
                //SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@IdAddress", id) };
                using (var dr = sqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        Producto unProducto = ProductoAdapter.Current.Adapt(values);
                        todosLosProductos.Add(unProducto);
                    }
                }
                return todosLosProductos;
            } catch (Exception ex) {
                ex.RegistrarError();
                throw new Exception("Hubo un problema al listar los productos");
            }
        }

        public void Modificar(Producto unObjeto)
        {
            throw new NotImplementedException();
        }
    }
}