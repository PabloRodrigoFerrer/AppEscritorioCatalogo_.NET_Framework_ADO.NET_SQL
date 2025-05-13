using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Configuration;
using Dominio;
using Negocio;

namespace frmTiendaPrincipal
{
    public partial class frmAltaArticulo : Form
    {
        Articulo Articulo = null;
        OpenFileDialog archivo = null;

        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo) 
        {
            InitializeComponent();
            this.Articulo = articulo;
            Text = "Modificar artículo";
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            NegocioMarca negocioMarca = new NegocioMarca();
            NegocioCategoria negocioCategoria = new NegocioCategoria();

            try
            {   
                cboMarca.DataSource = negocioMarca.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = negocioCategoria.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if(Articulo != null) 
                {
                    txtCodigo.Text = Articulo.Codigo;
                    txtNombre.Text = Articulo.Nombre;
                    txtDescripcion.Text = Articulo.Descripcion;
                    cboMarca.SelectedValue = Articulo.Marca.Id;
                    cboCategoria.SelectedValue = Articulo.Categoria.Id;
                    txtUrlImagen.Text = Articulo.UrlImagen;
                    txtPrecio.Text = Articulo.Precio.ToString();

                    cargarImagen(txtUrlImagen.Text);
                
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }    

        }

        private void cargarImagen(string UrlImagen)
        {
            try
            {
                pbxAltaArticulo.Load(UrlImagen);
            }
            catch (Exception ex)
            {
                pbxAltaArticulo.Load("https://cdn-icons-png.freepik.com/512/85/85488.png");
               
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool camposObligatorios()
        {
            if
            (
                (
                 txtCodigo.Text == string.Empty ||
                 txtNombre.Text == string.Empty ||
                 txtPrecio.Text == string.Empty ||
                 cboMarca.SelectedIndex < 0 ||
                 cboCategoria.SelectedIndex < 0
                )
            )
            {
                MessageBox.Show("Debe completar los campos obligatorios.", "Completar campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (!esNumero(txtPrecio.Text))
            {
                MessageBox.Show("Para el campo precio debe ingresar solo números.", "Solo números", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;         

        }

        private bool esNumero(string texto)
        {
            int contadorSeparadores = 0;

            foreach (char caracter in texto)
            {
                if (!char.IsDigit(caracter))
                {
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
            }

            return true;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            NegocioArticulo negocioArticulo = new NegocioArticulo();
            
            try
            {
                if (!camposObligatorios())
                    return;

                if (Articulo == null) 
                    Articulo = new Articulo();

                DialogResult result = DialogResult.No;

                Articulo.Codigo = txtCodigo.Text;
                Articulo.Nombre = txtNombre.Text;
                Articulo.Descripcion = txtDescripcion.Text;
                Articulo.Marca = (Marca)cboMarca.SelectedItem;
                Articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                Articulo.UrlImagen = txtUrlImagen.Text;
                Articulo.Precio = decimal.Parse(txtPrecio.Text);    
              

                if (Articulo.Id != 0) 
                {
                    result = MessageBox.Show($"¿Desea modificar el artículo: {Articulo.Nombre}?","Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        negocioArticulo.modificar(Articulo);
                        MessageBox.Show("Artículo modificado exitosamente.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (Articulo.Id == 0) 
                {
                    result = MessageBox.Show($"¿Desea agregar el artículo: {Articulo.Nombre}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        negocioArticulo.agregar(Articulo);
                        MessageBox.Show("Artículo agregado exitosamente.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (txtUrlImagen.Text != null && !(txtUrlImagen.Text.ToLower().Contains("http")) && result == DialogResult.Yes)
                {
                    File.Copy(txtUrlImagen.Text, ConfigurationManager.AppSettings["Articulo-imagenes"] + archivo.SafeFileName, overwrite: true);
                }
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }  
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();

            archivo.Filter = "Imágenes (*.jpg, *.png)|*.jpg;*.png";
            DialogResult resultado = archivo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
            }
        }

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }
    }
}
