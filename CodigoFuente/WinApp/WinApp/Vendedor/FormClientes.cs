﻿using Servicios.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Servicios.Extensions;
using Servicios.Domain.CompositeSeguridad;

namespace WinApp.Vendedor
{
    public partial class FormClientes : Form, IIdiomasObservador
    {
        private Cliente clienteSeleccionado = null;
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            ActualizarTraducciones();
            GestorIdiomas.Current.SuscribirObservador(this);
            grillaClientes.DataSource = BLL.GestorClientes.Current.ListarClientes();
            btnHabilitar.Visible = GestorSesion.Current.TieneRolGerente();
        }
        private void FormClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            GestorIdiomas.Current.DesuscribirObservador(this);
        }
        public void ActualizarTraducciones()
        {
            Text = "ABM Clientes".Traducir();
            btnAgregar.Text = "Agregar".Traducir();
            btnHabilitar.Text = "Habilitar".Traducir();
            btnModificar.Text = "Modificar".Traducir();
        }

        private void grillaClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (grillaClientes.SelectedRows.Count > 0)
            {
                int index = grillaClientes.SelectedRows[0].Index;
                IEnumerable<Cliente> clientes = (IEnumerable<Cliente>)grillaClientes.DataSource;
                clienteSeleccionado = clientes.ElementAt(index);
                if (clienteSeleccionado.Habilitado) {
                    btnHabilitar.Text = "Deshabilitar".Traducir();
                } else {
                    btnHabilitar.Text = "Habilitar".Traducir();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormCliente form = new FormCliente(new Cliente());
            DialogResult resultado = form.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                grillaClientes.DataSource = BLL.GestorClientes.Current.ListarClientes();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormCliente form = new FormCliente(clienteSeleccionado);
            DialogResult resultado = form.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                grillaClientes.DataSource = BLL.GestorClientes.Current.ListarClientes();
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro?".Traducir(), btnHabilitar.Text, MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    clienteSeleccionado.Habilitado = !clienteSeleccionado.Habilitado;
                    BLL.GestorClientes.Current.ModificarCliente(clienteSeleccionado);
                    grillaClientes.DataSource = BLL.GestorClientes.Current.ListarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.Traducir());
                }
            }
        }
    }
}
