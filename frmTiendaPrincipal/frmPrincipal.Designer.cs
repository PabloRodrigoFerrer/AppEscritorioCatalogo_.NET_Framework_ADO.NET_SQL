namespace frmTiendaPrincipal
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.layOutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtTablaEncabezadoNombre = new System.Windows.Forms.TextBox();
            this.txtTablaEncabezdoCodigo = new System.Windows.Forms.TextBox();
            this.txtTablaEncabezdoDescripcion = new System.Windows.Forms.TextBox();
            this.txtTablaEncabezdoMarca = new System.Windows.Forms.TextBox();
            this.txtTablaEncabezdoCategoria = new System.Windows.Forms.TextBox();
            this.txtCuerpoCodigo = new System.Windows.Forms.TextBox();
            this.txtCuerpoDescripcion = new System.Windows.Forms.TextBox();
            this.txtCuerpoMarca = new System.Windows.Forms.TextBox();
            this.txtCuerpoCategoria = new System.Windows.Forms.TextBox();
            this.txtTablaEncabezadoUrlImagen = new System.Windows.Forms.TextBox();
            this.txtTablaEncabezadoPrecio = new System.Windows.Forms.TextBox();
            this.txtCuerpoUrlImagen = new System.Windows.Forms.TextBox();
            this.txtCuerpoPrecio = new System.Windows.Forms.TextBox();
            this.txtCuerpoNombre = new System.Windows.Forms.TextBox();
            this.pbxPrincipal = new System.Windows.Forms.PictureBox();
            this.txtTablaTitulo = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.ttEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.layOutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(270, 102);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvArticulos.RowTemplate.Height = 30;
            this.dgvArticulos.RowTemplate.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(929, 667);
            this.dgvArticulos.TabIndex = 10;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-189, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "label1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(791, 59);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 35);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "&Agregar";
            this.ttAyuda.SetToolTip(this.btnAgregar, "Agregar elementos a la base de datos.");
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(894, 59);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 35);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "&Modificar";
            this.ttAyuda.SetToolTip(this.btnModificar, "Modifica el elemento seleccionado.");
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(141, 253);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 35);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "&Buscar";
            this.ttAyuda.SetToolTip(this.btnBuscar, "Busca en la DB con condiciones avanzadas, campos obligatorios: \"Campo:\", \"Criteri" +
        "o:\".");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtFiltroRapido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroRapido.ForeColor = System.Drawing.Color.DimGray;
            this.txtFiltroRapido.Location = new System.Drawing.Point(270, 69);
            this.txtFiltroRapido.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(368, 25);
            this.txtFiltroRapido.TabIndex = 5;
            this.txtFiltroRapido.Text = "Buscar...";
            this.ttAyuda.SetToolTip(this.txtFiltroRapido, "Filtra rápido por cualquier campo");
            this.txtFiltroRapido.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFiltroRapido_MouseClick);
            this.txtFiltroRapido.TextChanged += new System.EventHandler(this.txtFiltroRapido_TextChanged);
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(78, 201);
            this.txtFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(175, 25);
            this.txtFiltroAvanzado.TabIndex = 2;
            this.ttAyuda.SetToolTip(this.txtFiltroAvanzado, "Filtro opcional");
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(37, 253);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 35);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "&Limpiar";
            this.ttAyuda.SetToolTip(this.btnLimpiar, "Limpia todos los campos de los filtros.");
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // layOutPanel
            // 
            this.layOutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layOutPanel.ColumnCount = 1;
            this.layOutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layOutPanel.Controls.Add(this.txtTablaEncabezadoNombre, 0, 3);
            this.layOutPanel.Controls.Add(this.txtTablaEncabezdoCodigo, 0, 5);
            this.layOutPanel.Controls.Add(this.txtTablaEncabezdoDescripcion, 0, 7);
            this.layOutPanel.Controls.Add(this.txtTablaEncabezdoMarca, 0, 9);
            this.layOutPanel.Controls.Add(this.txtTablaEncabezdoCategoria, 0, 11);
            this.layOutPanel.Controls.Add(this.txtCuerpoCodigo, 0, 6);
            this.layOutPanel.Controls.Add(this.txtCuerpoDescripcion, 0, 8);
            this.layOutPanel.Controls.Add(this.txtCuerpoMarca, 0, 10);
            this.layOutPanel.Controls.Add(this.txtCuerpoCategoria, 0, 12);
            this.layOutPanel.Controls.Add(this.txtTablaEncabezadoUrlImagen, 0, 13);
            this.layOutPanel.Controls.Add(this.txtTablaEncabezadoPrecio, 0, 15);
            this.layOutPanel.Controls.Add(this.txtCuerpoUrlImagen, 0, 14);
            this.layOutPanel.Controls.Add(this.txtCuerpoPrecio, 0, 16);
            this.layOutPanel.Controls.Add(this.txtCuerpoNombre, 0, 4);
            this.layOutPanel.Controls.Add(this.pbxPrincipal, 0, 1);
            this.layOutPanel.Controls.Add(this.txtTablaTitulo, 0, 0);
            this.layOutPanel.Controls.Add(this.lblID, 0, 2);
            this.layOutPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.layOutPanel.Location = new System.Drawing.Point(1250, 101);
            this.layOutPanel.Name = "layOutPanel";
            this.layOutPanel.RowCount = 17;
            this.layOutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layOutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.layOutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.layOutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layOutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layOutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layOutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layOutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layOutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layOutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layOutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layOutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layOutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layOutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layOutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layOutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layOutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layOutPanel.Size = new System.Drawing.Size(348, 670);
            this.layOutPanel.TabIndex = 8;
            this.ttAyuda.SetToolTip(this.layOutPanel, "Detalle producto");
            // 
            // txtTablaEncabezadoNombre
            // 
            this.txtTablaEncabezadoNombre.BackColor = System.Drawing.Color.SkyBlue;
            this.txtTablaEncabezadoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTablaEncabezadoNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTablaEncabezadoNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTablaEncabezadoNombre.ForeColor = System.Drawing.Color.White;
            this.txtTablaEncabezadoNombre.Location = new System.Drawing.Point(3, 268);
            this.txtTablaEncabezadoNombre.Name = "txtTablaEncabezadoNombre";
            this.txtTablaEncabezadoNombre.Size = new System.Drawing.Size(342, 18);
            this.txtTablaEncabezadoNombre.TabIndex = 1;
            this.txtTablaEncabezadoNombre.Text = "Nombre";
            this.txtTablaEncabezadoNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTablaEncabezdoCodigo
            // 
            this.txtTablaEncabezdoCodigo.BackColor = System.Drawing.Color.SkyBlue;
            this.txtTablaEncabezdoCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTablaEncabezdoCodigo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTablaEncabezdoCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTablaEncabezdoCodigo.ForeColor = System.Drawing.Color.White;
            this.txtTablaEncabezdoCodigo.Location = new System.Drawing.Point(3, 328);
            this.txtTablaEncabezdoCodigo.Name = "txtTablaEncabezdoCodigo";
            this.txtTablaEncabezdoCodigo.Size = new System.Drawing.Size(342, 18);
            this.txtTablaEncabezdoCodigo.TabIndex = 3;
            this.txtTablaEncabezdoCodigo.Text = "Código";
            this.txtTablaEncabezdoCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTablaEncabezdoDescripcion
            // 
            this.txtTablaEncabezdoDescripcion.BackColor = System.Drawing.Color.SkyBlue;
            this.txtTablaEncabezdoDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTablaEncabezdoDescripcion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTablaEncabezdoDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTablaEncabezdoDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtTablaEncabezdoDescripcion.Location = new System.Drawing.Point(3, 388);
            this.txtTablaEncabezdoDescripcion.Name = "txtTablaEncabezdoDescripcion";
            this.txtTablaEncabezdoDescripcion.Size = new System.Drawing.Size(342, 18);
            this.txtTablaEncabezdoDescripcion.TabIndex = 5;
            this.txtTablaEncabezdoDescripcion.Text = "Descripción";
            this.txtTablaEncabezdoDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTablaEncabezdoMarca
            // 
            this.txtTablaEncabezdoMarca.BackColor = System.Drawing.Color.SkyBlue;
            this.txtTablaEncabezdoMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTablaEncabezdoMarca.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTablaEncabezdoMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTablaEncabezdoMarca.ForeColor = System.Drawing.Color.White;
            this.txtTablaEncabezdoMarca.Location = new System.Drawing.Point(3, 448);
            this.txtTablaEncabezdoMarca.Name = "txtTablaEncabezdoMarca";
            this.txtTablaEncabezdoMarca.Size = new System.Drawing.Size(342, 18);
            this.txtTablaEncabezdoMarca.TabIndex = 7;
            this.txtTablaEncabezdoMarca.Text = "Marca";
            this.txtTablaEncabezdoMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTablaEncabezdoCategoria
            // 
            this.txtTablaEncabezdoCategoria.BackColor = System.Drawing.Color.SkyBlue;
            this.txtTablaEncabezdoCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTablaEncabezdoCategoria.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTablaEncabezdoCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTablaEncabezdoCategoria.ForeColor = System.Drawing.Color.White;
            this.txtTablaEncabezdoCategoria.Location = new System.Drawing.Point(3, 508);
            this.txtTablaEncabezdoCategoria.Name = "txtTablaEncabezdoCategoria";
            this.txtTablaEncabezdoCategoria.Size = new System.Drawing.Size(342, 18);
            this.txtTablaEncabezdoCategoria.TabIndex = 9;
            this.txtTablaEncabezdoCategoria.Text = "Categoria";
            this.txtTablaEncabezdoCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCuerpoCodigo
            // 
            this.txtCuerpoCodigo.BackColor = System.Drawing.Color.Azure;
            this.txtCuerpoCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuerpoCodigo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCuerpoCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuerpoCodigo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtCuerpoCodigo.Location = new System.Drawing.Point(3, 348);
            this.txtCuerpoCodigo.Multiline = true;
            this.txtCuerpoCodigo.Name = "txtCuerpoCodigo";
            this.txtCuerpoCodigo.Size = new System.Drawing.Size(342, 34);
            this.txtCuerpoCodigo.TabIndex = 4;
            this.txtCuerpoCodigo.Text = "Nombre";
            this.txtCuerpoCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCuerpoDescripcion
            // 
            this.txtCuerpoDescripcion.BackColor = System.Drawing.Color.Azure;
            this.txtCuerpoDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuerpoDescripcion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCuerpoDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuerpoDescripcion.Location = new System.Drawing.Point(3, 408);
            this.txtCuerpoDescripcion.Multiline = true;
            this.txtCuerpoDescripcion.Name = "txtCuerpoDescripcion";
            this.txtCuerpoDescripcion.Size = new System.Drawing.Size(342, 34);
            this.txtCuerpoDescripcion.TabIndex = 6;
            this.txtCuerpoDescripcion.Text = "Nombre";
            this.txtCuerpoDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCuerpoMarca
            // 
            this.txtCuerpoMarca.BackColor = System.Drawing.Color.Azure;
            this.txtCuerpoMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuerpoMarca.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCuerpoMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuerpoMarca.Location = new System.Drawing.Point(3, 468);
            this.txtCuerpoMarca.Multiline = true;
            this.txtCuerpoMarca.Name = "txtCuerpoMarca";
            this.txtCuerpoMarca.Size = new System.Drawing.Size(342, 34);
            this.txtCuerpoMarca.TabIndex = 8;
            this.txtCuerpoMarca.Text = "Nombre";
            this.txtCuerpoMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCuerpoCategoria
            // 
            this.txtCuerpoCategoria.BackColor = System.Drawing.Color.Azure;
            this.txtCuerpoCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuerpoCategoria.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCuerpoCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuerpoCategoria.Location = new System.Drawing.Point(3, 528);
            this.txtCuerpoCategoria.Multiline = true;
            this.txtCuerpoCategoria.Name = "txtCuerpoCategoria";
            this.txtCuerpoCategoria.Size = new System.Drawing.Size(342, 34);
            this.txtCuerpoCategoria.TabIndex = 10;
            this.txtCuerpoCategoria.Text = "Nombre";
            this.txtCuerpoCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTablaEncabezadoUrlImagen
            // 
            this.txtTablaEncabezadoUrlImagen.BackColor = System.Drawing.Color.SkyBlue;
            this.txtTablaEncabezadoUrlImagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTablaEncabezadoUrlImagen.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTablaEncabezadoUrlImagen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTablaEncabezadoUrlImagen.ForeColor = System.Drawing.Color.White;
            this.txtTablaEncabezadoUrlImagen.Location = new System.Drawing.Point(3, 568);
            this.txtTablaEncabezadoUrlImagen.Name = "txtTablaEncabezadoUrlImagen";
            this.txtTablaEncabezadoUrlImagen.Size = new System.Drawing.Size(342, 18);
            this.txtTablaEncabezadoUrlImagen.TabIndex = 11;
            this.txtTablaEncabezadoUrlImagen.Text = "Url Imagen";
            this.txtTablaEncabezadoUrlImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTablaEncabezadoPrecio
            // 
            this.txtTablaEncabezadoPrecio.BackColor = System.Drawing.Color.SkyBlue;
            this.txtTablaEncabezadoPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTablaEncabezadoPrecio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTablaEncabezadoPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTablaEncabezadoPrecio.ForeColor = System.Drawing.Color.White;
            this.txtTablaEncabezadoPrecio.Location = new System.Drawing.Point(3, 628);
            this.txtTablaEncabezadoPrecio.Name = "txtTablaEncabezadoPrecio";
            this.txtTablaEncabezadoPrecio.Size = new System.Drawing.Size(342, 18);
            this.txtTablaEncabezadoPrecio.TabIndex = 13;
            this.txtTablaEncabezadoPrecio.Text = "Precio";
            this.txtTablaEncabezadoPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCuerpoUrlImagen
            // 
            this.txtCuerpoUrlImagen.BackColor = System.Drawing.Color.Azure;
            this.txtCuerpoUrlImagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuerpoUrlImagen.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCuerpoUrlImagen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuerpoUrlImagen.Location = new System.Drawing.Point(3, 588);
            this.txtCuerpoUrlImagen.Multiline = true;
            this.txtCuerpoUrlImagen.Name = "txtCuerpoUrlImagen";
            this.txtCuerpoUrlImagen.Size = new System.Drawing.Size(342, 34);
            this.txtCuerpoUrlImagen.TabIndex = 12;
            this.txtCuerpoUrlImagen.Text = "Nombre";
            this.txtCuerpoUrlImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCuerpoPrecio
            // 
            this.txtCuerpoPrecio.BackColor = System.Drawing.Color.Azure;
            this.txtCuerpoPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuerpoPrecio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCuerpoPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuerpoPrecio.Location = new System.Drawing.Point(3, 648);
            this.txtCuerpoPrecio.Multiline = true;
            this.txtCuerpoPrecio.Name = "txtCuerpoPrecio";
            this.txtCuerpoPrecio.Size = new System.Drawing.Size(342, 34);
            this.txtCuerpoPrecio.TabIndex = 14;
            this.txtCuerpoPrecio.Text = "Nombre";
            this.txtCuerpoPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCuerpoNombre
            // 
            this.txtCuerpoNombre.BackColor = System.Drawing.Color.Azure;
            this.txtCuerpoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuerpoNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCuerpoNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuerpoNombre.Location = new System.Drawing.Point(3, 288);
            this.txtCuerpoNombre.Multiline = true;
            this.txtCuerpoNombre.Name = "txtCuerpoNombre";
            this.txtCuerpoNombre.Size = new System.Drawing.Size(342, 34);
            this.txtCuerpoNombre.TabIndex = 2;
            this.txtCuerpoNombre.Text = "Nombre";
            this.txtCuerpoNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbxPrincipal
            // 
            this.pbxPrincipal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbxPrincipal.Location = new System.Drawing.Point(4, 24);
            this.pbxPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.pbxPrincipal.Name = "pbxPrincipal";
            this.pbxPrincipal.Size = new System.Drawing.Size(340, 222);
            this.pbxPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPrincipal.TabIndex = 1;
            this.pbxPrincipal.TabStop = false;
            // 
            // txtTablaTitulo
            // 
            this.txtTablaTitulo.BackColor = System.Drawing.Color.SkyBlue;
            this.txtTablaTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTablaTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTablaTitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTablaTitulo.ForeColor = System.Drawing.Color.White;
            this.txtTablaTitulo.Location = new System.Drawing.Point(3, 3);
            this.txtTablaTitulo.Name = "txtTablaTitulo";
            this.txtTablaTitulo.Size = new System.Drawing.Size(342, 20);
            this.txtTablaTitulo.TabIndex = 0;
            this.txtTablaTitulo.Text = "Detalle producto";
            this.txtTablaTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(332, 250);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 15);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "a";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboCampo
            // 
            this.cboCampo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(80, 101);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(4);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(173, 25);
            this.cboCampo.TabIndex = 0;
            this.ttAyuda.SetToolTip(this.cboCampo, "Campo obligatorio");
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(78, 152);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(4);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(175, 25);
            this.cboCriterio.TabIndex = 1;
            this.ttAyuda.SetToolTip(this.cboCriterio, "Campo obligatorio");
            // 
            // ttEliminar
            // 
            this.ttEliminar.Tag = "Eliminar de la base de datos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(997, 59);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 35);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "&Eliminar";
            this.ttEliminar.SetToolTip(this.btnEliminar, "Eliminar elemento de la base de datos");
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.Location = new System.Drawing.Point(1100, 59);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(97, 35);
            this.btnQuitar.TabIndex = 9;
            this.btnQuitar.Text = "&Quitar";
            this.ttEliminar.SetToolTip(this.btnQuitar, "Quitar de la lista (Se puede recuperar el archivo en caso de ser necesario)");
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(20, 104);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(53, 17);
            this.lblCampo.TabIndex = 3;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(19, 155);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(54, 17);
            this.lblCriterio.TabIndex = 3;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(34, 203);
            this.lblFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(40, 17);
            this.lblFiltroAvanzado.TabIndex = 3;
            this.lblFiltroAvanzado.Text = "Filtro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtrar por:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1664, 891);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.layOutPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1560, 930);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor SQL";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.layOutPanel.ResumeLayout(false);
            this.layOutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip ttAyuda;
        private System.Windows.Forms.ToolTip ttEliminar;
        private System.Windows.Forms.PictureBox pbxPrincipal;
        private System.Windows.Forms.TableLayoutPanel layOutPanel;
        private System.Windows.Forms.TextBox txtTablaEncabezadoNombre;
        private System.Windows.Forms.TextBox txtCuerpoNombre;
        private System.Windows.Forms.TextBox txtTablaEncabezdoCodigo;
        private System.Windows.Forms.TextBox txtTablaEncabezdoDescripcion;
        private System.Windows.Forms.TextBox txtTablaEncabezdoMarca;
        private System.Windows.Forms.TextBox txtTablaEncabezdoCategoria;
        private System.Windows.Forms.TextBox txtCuerpoCodigo;
        private System.Windows.Forms.TextBox txtCuerpoDescripcion;
        private System.Windows.Forms.TextBox txtCuerpoMarca;
        private System.Windows.Forms.TextBox txtCuerpoCategoria;
        private System.Windows.Forms.TextBox txtTablaEncabezadoUrlImagen;
        private System.Windows.Forms.TextBox txtTablaEncabezadoPrecio;
        private System.Windows.Forms.TextBox txtCuerpoUrlImagen;
        private System.Windows.Forms.TextBox txtCuerpoPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtTablaTitulo;
        private System.Windows.Forms.Label lblID;
    }
}

