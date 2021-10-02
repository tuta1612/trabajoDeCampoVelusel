﻿using Servicios.Domain;
using Servicios.Domain.CompositeSeguridad;
using System.Configuration;
using Servicios.DAL.Contratos;
using Dominio.CompositeProducto;

namespace DAL
{
    public class FabricaDAL
    {
        #region Singleton
        private readonly static FabricaDAL _instance = new FabricaDAL();

        public static FabricaDAL Current
        {
            get
            {
                return _instance;
            }
        }

        private FabricaDAL()
        {
            bbddVelusel = ConfigurationManager.ConnectionStrings["VeluselConString"].ConnectionString;
        }
        #endregion
        private string bbddVelusel;

        public IRepositorioGenerico<Material> ObtenerRepositorioDeMateriales()
        {
            return new Implementaciones.SqlServer.MaterialRepositorio(bbddVelusel);
        }
        public IRepositorioGenerico<Producto> ObtenerRepositorioDeProductos()
        {
            return new Implementaciones.SqlServer.ProductoRepositorio(bbddVelusel);
        }
        public IRelacionGenerica<Producto, Material> ObtenerProductoMaterialRelacion()
        {
            return null;
        }
        public IRelacionGenerica<Producto, Producto> ObtenerProductoProductoRelacion()
        {
            return null;
        }

        
    }
}