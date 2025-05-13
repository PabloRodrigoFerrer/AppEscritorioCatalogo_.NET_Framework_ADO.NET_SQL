using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Microsoft.SqlServer.Server;
using Negocio;

namespace frmTiendaPrincipal
{
    public partial class frmPrincipal : Form
    {
        List<Articulo> listaArticulos;
        //prueba cambio git
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Precio");
        }

        private void cargarImagen(string UrlImagen) 
        {
            try
            {
                pbxPrincipal.Load(UrlImagen);
            }
            catch (Exception ex)
            {
                pbxPrincipal.Load("https://cdn-icons-png.freepik.com/512/85/85488.png");             
            }
        }

        private void cargar()
        {
            NegocioArticulo negocio = new NegocioArticulo();
            try
            { 
                listaArticulos = negocio.listar();                
                dgvArticulos.DataSource = listaArticulos;
                redondearPrecio();
                ocultarCols();
                cargarImagen(listaArticulos[0].UrlImagen);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }                

        private void redondearPrecio() 
        {
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "N2";        
        }


        private void ocultarCols() 
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["UrlImagen"].Visible = false;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);

                lblID.Text = "Id: " + seleccionado.Id.ToString();
                txtCuerpoNombre.Text = seleccionado.Nombre;
                txtCuerpoDescripcion.Text = seleccionado.Descripcion;
                txtCuerpoCodigo.Text = seleccionado.Codigo;
                txtCuerpoUrlImagen.Text = seleccionado.UrlImagen;
                txtCuerpoMarca.Text = seleccionado.Marca.Descripcion;
                txtCuerpoCategoria.Text = seleccionado.Categoria.Descripcion;
                txtCuerpoPrecio.Text = seleccionado.Precio.ToString("N2");          
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo AltaVentana = new frmAltaArticulo();
            AltaVentana.ShowDialog();
            cargar();
        }

        private bool sinArticulos()
        {
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un artículo.", "Seleccionar artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            
            return false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;

            if (sinArticulos())
                return;

            seleccionado = dgvArticulos.CurrentRow.DataBoundItem as Articulo;
            frmAltaArticulo AltaVentana = new frmAltaArticulo(seleccionado);
            AltaVentana.ShowDialog();
            cargar();           
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (sinArticulos())
                return;
            eliminar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (sinArticulos())
                return;
            eliminar(true);
        }

        private void eliminar(bool logico = false) 
        {
            NegocioArticulo negocioArticulo = new NegocioArticulo();

            try
            {

                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                if (logico)
                {
                    DialogResult resultado = MessageBox.Show($"Quiere eliminar PERMANENTEMENTE: {seleccionado.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                        negocioArticulo.elminarFisico(seleccionado.Id);
                }
                else 
                {
                    DialogResult resultado = MessageBox.Show($"Quiere quitar de la lista: {seleccionado.Nombre}?", "Quitar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                        negocioArticulo.eliminarLogico(seleccionado.Id);
                }
            }                
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally 
            {
                cargar();     
            }
        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            try
            {
                string filtro = txtFiltroRapido.Text.ToLower();

                if (filtro.Length >= 2 )
                    listaFiltrada = listaArticulos.FindAll(x => 
                    (
                        x.Codigo.ToLower().Contains(filtro) ||
                        x.Nombre.ToLower().Contains(filtro) ||
                        x.Descripcion.ToLower().Contains(filtro) ||
                        x.Categoria.Descripcion.ToLower().Contains(filtro) ||
                        x.Marca.Descripcion.ToLower().Contains(filtro)
                    )
                    );
                else
                    listaFiltrada = listaArticulos;

                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
                redondearPrecio();
                ocultarCols();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

            cboCriterio.SelectedIndex = -1;
            cboCriterio.DataSource = null;
            cboCriterio.Items.Clear();
            if (cboCampo.Text == "Precio")
            {
                cboCriterio.Items.Add("Mayor igual a");
                cboCriterio.Items.Add("Menor igual a");
                cboCriterio.Items.Add("Igual a");
            }
            else if (cboCampo.Text == "Marca" || cboCampo.Text == "Categoria")
            {
                if (cboCampo.Text == "Marca")
                {
                    NegocioMarca negocioMarca = new NegocioMarca();
                    cboCriterio.DataSource = negocioMarca.listar();
                }
                else
                {
                    NegocioCategoria negocioCategoria = new NegocioCategoria();
                    cboCriterio.DataSource = negocioCategoria.listar();
                }
            }
            else
            {
                cboCriterio.Items.Add("Empieza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private bool validarFiltro() 
        {
            if (cboCampo.SelectedIndex < 0 || cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (cboCampo.Text == "Precio" && !(soloNumeros(txtFiltroAvanzado.Text))) 
            {
                MessageBox.Show("Debe ingresar solo números para aplicar el filtro.", "Solo números", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            } 
            
            return true;
        }

        private bool soloNumeros(string texto) 
        {
            int contadorSeparadores = 0;
            foreach (char caracter in texto)
            {
                if (!char.IsDigit(caracter))

                    if (caracter == '.' || caracter == ',')
                    {
                        contadorSeparadores++;
                        if (contadorSeparadores > 1)
                            return false;
                    }
                    else
                    {
                        return false; 
                    }
            }
            return true;  
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioArticulo negocioArticulo = new NegocioArticulo();

                if (!validarFiltro())
                    return;
                    
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;

                if (filtro != "")
                {
                    dgvArticulos.DataSource = null;
                    dgvArticulos.DataSource = negocioArticulo.filtrar(campo, criterio, filtro);
                }
                else if (campo == "Marca" || campo == "Categoria")
                {                  
                    filtro = cboCriterio.SelectedItem.ToString();
                    criterio = "Contiene";

                    dgvArticulos.DataSource = null;
                    dgvArticulos.DataSource = negocioArticulo.filtrar(campo, criterio, filtro);                    
                }
                else
                    dgvArticulos.DataSource = listaArticulos;

                redondearPrecio();
                ocultarCols();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }

        private void txtFiltroRapido_MouseClick(object sender, MouseEventArgs e)
        {
            txtFiltroRapido.Clear();            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFiltroAvanzado.Text = string.Empty;
            cboCampo.SelectedIndex = -1;
            cboCriterio.Text = string.Empty;
            cargar();
        }

        
    }
}
