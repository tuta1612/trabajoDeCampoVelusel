﻿using Dominio.CompositeProducto;
using Servicios.BLL;
using Servicios.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp.Fabricante
{
    public partial class FormMateriales : Form, IIdiomasObservador
    {
        private Material materialSeleccionado = null;
        public FormMateriales()
        {
            InitializeComponent();
        }

        private void Materiales_Load(object sender, EventArgs e)
        {
            ActualizarTraducciones();
            GestorIdiomas.Current.SuscribirObservador(this);
            grillaMateriales.DataSource = BLL.GestorFabricacion.Current.ListarMateriales();
            /*Material unMaterial = new Material();
            unMaterial.Id = Guid.NewGuid();
            unMaterial.Nombre = "Vaso whisky";
            unMaterial.Unidad = Unidades.Un;
            BLL.GestorFabricacion.Current.RegistrarMaterial(unMaterial);*/
        }

        private void Materiales_FormClosing(object sender, FormClosingEventArgs e)
        {
            GestorIdiomas.Current.DesuscribirObservador(this);
        }

        public void ActualizarTraducciones()
        {
            btnAgregar.Text = "Agregar".Traducir();
            btnBorrar.Text = "Borrar".Traducir();
            btnModificar.Text = "Modificar".Traducir();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormMaterial form = new FormMaterial(new Material());
            DialogResult resultado = form.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                grillaMateriales.DataSource = BLL.GestorFabricacion.Current.ListarMateriales();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro?".Traducir(), "Borrar".Traducir(), MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    BLL.GestorFabricacion.Current.BorrarMaterial(materialSeleccionado);
                    grillaMateriales.DataSource = BLL.GestorFabricacion.Current.ListarMateriales();
                    materialSeleccionado = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.Traducir());
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormMaterial form = new FormMaterial(materialSeleccionado);
            DialogResult resultado = form.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                grillaMateriales.DataSource = BLL.GestorFabricacion.Current.ListarMateriales();
            }
        }

        private void grillaMateriales_SelectionChanged(object sender, EventArgs e)
        {
            if (grillaMateriales.SelectedRows.Count > 0)
            {
                int index = grillaMateriales.SelectedRows[0].Index;
                IEnumerable<Material> patentes = (IEnumerable<Material>)grillaMateriales.DataSource;
                materialSeleccionado = patentes.ElementAt(index);
            }
        }
    }
}