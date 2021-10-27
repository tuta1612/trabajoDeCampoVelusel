﻿using Dominio;
using Servicios.BLL;
using Servicios.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinApp.Vendedor
{
    public partial class FormPedidos : Form, IIdiomasObservador
    {
        Pedido pedidoSeleccionado;
        public FormPedidos()
        {
            InitializeComponent();
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            ActualizarTraducciones();
            GestorIdiomas.Current.SuscribirObservador(this);
            grillaPedidos.DataSource = BLL.GestorPedidos.Current.ListarPedidos();


        }
        private void FormPedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            GestorIdiomas.Current.DesuscribirObservador(this);
        }
        public void ActualizarTraducciones()
        {
            Text = "ABM Clientes".Traducir();
            btnCancelar.Text = "Cancelar pedido".Traducir();
        }

        private void grillaPedidos_SelectionChanged(object sender, EventArgs e)
        {
            if (grillaPedidos.SelectedRows.Count > 0)
            {
                int index = grillaPedidos.SelectedRows[0].Index;
                IEnumerable<Pedido> pedidos = (IEnumerable<Pedido>)grillaPedidos.DataSource;
                pedidoSeleccionado = pedidos.ElementAt(index);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try {
                BLL.GestorPedidos.Current.CancelarPedido(pedidoSeleccionado);
            } catch (Exception ex) {
                ex.MostrarEnAlert();
            }
        }
    }
}