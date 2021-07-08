namespace Ventas_Inventario.Forms
{
    partial class Venta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechatxt = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.GroupLibros = new System.Windows.Forms.GroupBox();
            this.CbNombreL = new System.Windows.Forms.ComboBox();
            this.CbEditorialL = new System.Windows.Forms.ComboBox();
            this.lblTextoEditorialL = new System.Windows.Forms.Label();
            this.txtClienteL = new System.Windows.Forms.TextBox();
            this.lblTextoClienteL = new System.Windows.Forms.Label();
            this.CheckClienteL = new System.Windows.Forms.CheckBox();
            this.CbVolumenL = new System.Windows.Forms.ComboBox();
            this.lblVolumenL = new System.Windows.Forms.Label();
            this.CbPortadaL = new System.Windows.Forms.ComboBox();
            this.lblPortadaL = new System.Windows.Forms.Label();
            this.CbCategoriaL = new System.Windows.Forms.ComboBox();
            this.lbCategoriaL = new System.Windows.Forms.Label();
            this.lblPuntajeL = new System.Windows.Forms.Label();
            this.lblTextoPuntajeL = new System.Windows.Forms.Label();
            this.lblCantidadL = new System.Windows.Forms.Label();
            this.lblPrecioL = new System.Windows.Forms.Label();
            this.lblTextoPrecioL = new System.Windows.Forms.Label();
            this.txtCantidadL = new System.Windows.Forms.TextBox();
            this.lblNombreL = new System.Windows.Forms.Label();
            this.GroupAnnetys = new System.Windows.Forms.GroupBox();
            this.txtClienteA = new System.Windows.Forms.TextBox();
            this.lblTextoClienteA = new System.Windows.Forms.Label();
            this.CheckClienteA = new System.Windows.Forms.CheckBox();
            this.txtDescripcionA = new System.Windows.Forms.TextBox();
            this.CbCategoriaA = new System.Windows.Forms.ComboBox();
            this.lblCategoriaA = new System.Windows.Forms.Label();
            this.CheckAnnetys = new System.Windows.Forms.CheckBox();
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.lblPuntajeA = new System.Windows.Forms.Label();
            this.lblTextoPuntajeA = new System.Windows.Forms.Label();
            this.lblDescripcionA = new System.Windows.Forms.Label();
            this.lblCantidadA = new System.Windows.Forms.Label();
            this.lblPrecioA = new System.Windows.Forms.Label();
            this.lblTextoPrecioA = new System.Windows.Forms.Label();
            this.txtCantidadA = new System.Windows.Forms.TextBox();
            this.lblNombreA = new System.Windows.Forms.Label();
            this.GroupTCG = new System.Windows.Forms.GroupBox();
            this.txtClienteT = new System.Windows.Forms.TextBox();
            this.lblTextoClienteT = new System.Windows.Forms.Label();
            this.CheckTCG = new System.Windows.Forms.CheckBox();
            this.CheckClienteT = new System.Windows.Forms.CheckBox();
            this.txtProductoT = new System.Windows.Forms.TextBox();
            this.lblPuntajeT = new System.Windows.Forms.Label();
            this.lblTextopuntajeT = new System.Windows.Forms.Label();
            this.CbNombreT = new System.Windows.Forms.ComboBox();
            this.lblTextoNombreT = new System.Windows.Forms.Label();
            this.lblTextoCantidadT = new System.Windows.Forms.Label();
            this.lblPrecioT = new System.Windows.Forms.Label();
            this.lblTextoPrecioT = new System.Windows.Forms.Label();
            this.txtCantidadT = new System.Windows.Forms.TextBox();
            this.lblTextoProductoT = new System.Windows.Forms.Label();
            this.GroupJuegosMesa = new System.Windows.Forms.GroupBox();
            this.txtClienteJ = new System.Windows.Forms.TextBox();
            this.lblTextoClienteJ = new System.Windows.Forms.Label();
            this.CheckClienteJ = new System.Windows.Forms.CheckBox();
            this.CheckJuegos = new System.Windows.Forms.CheckBox();
            this.txtNombreJ = new System.Windows.Forms.TextBox();
            this.lblPuntajeJ = new System.Windows.Forms.Label();
            this.lblTextoPunrajeJ = new System.Windows.Forms.Label();
            this.lblCantidadJ = new System.Windows.Forms.Label();
            this.lblPrecioJ = new System.Windows.Forms.Label();
            this.lblTextoPrecioJ = new System.Windows.Forms.Label();
            this.txtCantidadJ = new System.Windows.Forms.TextBox();
            this.lblNombreJ = new System.Windows.Forms.Label();
            this.CbAreaVenta = new System.Windows.Forms.ComboBox();
            this.inventarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBplugYplayDataSet = new Ventas_Inventario.DBplugYplayDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioTableAdapter = new Ventas_Inventario.DBplugYplayDataSetTableAdapters.InventarioTableAdapter();
            this.GroupLibros.SuspendLayout();
            this.GroupAnnetys.SuspendLayout();
            this.GroupTCG.SuspendLayout();
            this.GroupJuegosMesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBplugYplayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(-1, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(802, 20);
            this.lblTitulo.TabIndex = 36;
            this.lblTitulo.Text = "CONTROL DE REGISTRO DE VENTAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechatxt
            // 
            this.lblFechatxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechatxt.AutoSize = true;
            this.lblFechatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechatxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFechatxt.Location = new System.Drawing.Point(637, 20);
            this.lblFechatxt.Name = "lblFechatxt";
            this.lblFechatxt.Size = new System.Drawing.Size(58, 20);
            this.lblFechatxt.TabIndex = 37;
            this.lblFechatxt.Text = "Fecha:";
            this.lblFechatxt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFecha.Location = new System.Drawing.Point(694, 20);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(77, 20);
            this.lblFecha.TabIndex = 38;
            this.lblFecha.Text = "lblFecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GroupLibros
            // 
            this.GroupLibros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupLibros.AutoSize = true;
            this.GroupLibros.Controls.Add(this.CbNombreL);
            this.GroupLibros.Controls.Add(this.CbEditorialL);
            this.GroupLibros.Controls.Add(this.lblTextoEditorialL);
            this.GroupLibros.Controls.Add(this.txtClienteL);
            this.GroupLibros.Controls.Add(this.lblTextoClienteL);
            this.GroupLibros.Controls.Add(this.CheckClienteL);
            this.GroupLibros.Controls.Add(this.CbVolumenL);
            this.GroupLibros.Controls.Add(this.lblVolumenL);
            this.GroupLibros.Controls.Add(this.CbPortadaL);
            this.GroupLibros.Controls.Add(this.lblPortadaL);
            this.GroupLibros.Controls.Add(this.CbCategoriaL);
            this.GroupLibros.Controls.Add(this.lbCategoriaL);
            this.GroupLibros.Controls.Add(this.lblPuntajeL);
            this.GroupLibros.Controls.Add(this.lblTextoPuntajeL);
            this.GroupLibros.Controls.Add(this.lblCantidadL);
            this.GroupLibros.Controls.Add(this.lblPrecioL);
            this.GroupLibros.Controls.Add(this.lblTextoPrecioL);
            this.GroupLibros.Controls.Add(this.txtCantidadL);
            this.GroupLibros.Controls.Add(this.lblNombreL);
            this.GroupLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupLibros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupLibros.Location = new System.Drawing.Point(12, 72);
            this.GroupLibros.Name = "GroupLibros";
            this.GroupLibros.Size = new System.Drawing.Size(776, 190);
            this.GroupLibros.TabIndex = 39;
            this.GroupLibros.TabStop = false;
            this.GroupLibros.Text = "Area de venta Libros";
            // 
            // CbNombreL
            // 
            this.CbNombreL.FormattingEnabled = true;
            this.CbNombreL.Location = new System.Drawing.Point(6, 77);
            this.CbNombreL.Name = "CbNombreL";
            this.CbNombreL.Size = new System.Drawing.Size(157, 24);
            this.CbNombreL.TabIndex = 25;
            // 
            // CbEditorialL
            // 
            this.CbEditorialL.FormattingEnabled = true;
            this.CbEditorialL.Location = new System.Drawing.Point(7, 119);
            this.CbEditorialL.Name = "CbEditorialL";
            this.CbEditorialL.Size = new System.Drawing.Size(157, 24);
            this.CbEditorialL.TabIndex = 24;
            // 
            // lblTextoEditorialL
            // 
            this.lblTextoEditorialL.AutoSize = true;
            this.lblTextoEditorialL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextoEditorialL.Location = new System.Drawing.Point(7, 104);
            this.lblTextoEditorialL.Name = "lblTextoEditorialL";
            this.lblTextoEditorialL.Size = new System.Drawing.Size(131, 16);
            this.lblTextoEditorialL.TabIndex = 23;
            this.lblTextoEditorialL.Text = "Seleccione Editorial:";
            // 
            // txtClienteL
            // 
            this.txtClienteL.Location = new System.Drawing.Point(350, 34);
            this.txtClienteL.Name = "txtClienteL";
            this.txtClienteL.Size = new System.Drawing.Size(157, 22);
            this.txtClienteL.TabIndex = 22;
            // 
            // lblTextoClienteL
            // 
            this.lblTextoClienteL.AutoSize = true;
            this.lblTextoClienteL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextoClienteL.Location = new System.Drawing.Point(347, 15);
            this.lblTextoClienteL.Name = "lblTextoClienteL";
            this.lblTextoClienteL.Size = new System.Drawing.Size(122, 16);
            this.lblTextoClienteL.TabIndex = 21;
            this.lblTextoClienteL.Text = "Numero de Cliente:";
            // 
            // CheckClienteL
            // 
            this.CheckClienteL.AutoSize = true;
            this.CheckClienteL.Location = new System.Drawing.Point(6, 149);
            this.CheckClienteL.Name = "CheckClienteL";
            this.CheckClienteL.Size = new System.Drawing.Size(132, 20);
            this.CheckClienteL.TabIndex = 20;
            this.CheckClienteL.Text = "Cliente registrado";
            this.CheckClienteL.UseVisualStyleBackColor = true;
            // 
            // CbVolumenL
            // 
            this.CbVolumenL.FormattingEnabled = true;
            this.CbVolumenL.Location = new System.Drawing.Point(170, 77);
            this.CbVolumenL.Name = "CbVolumenL";
            this.CbVolumenL.Size = new System.Drawing.Size(157, 24);
            this.CbVolumenL.TabIndex = 19;
            // 
            // lblVolumenL
            // 
            this.lblVolumenL.AutoSize = true;
            this.lblVolumenL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVolumenL.Location = new System.Drawing.Point(170, 61);
            this.lblVolumenL.Name = "lblVolumenL";
            this.lblVolumenL.Size = new System.Drawing.Size(135, 16);
            this.lblVolumenL.TabIndex = 18;
            this.lblVolumenL.Text = "Seleccione Volumen:";
            // 
            // CbPortadaL
            // 
            this.CbPortadaL.FormattingEnabled = true;
            this.CbPortadaL.Location = new System.Drawing.Point(170, 34);
            this.CbPortadaL.Name = "CbPortadaL";
            this.CbPortadaL.Size = new System.Drawing.Size(157, 24);
            this.CbPortadaL.TabIndex = 17;
            // 
            // lblPortadaL
            // 
            this.lblPortadaL.AutoSize = true;
            this.lblPortadaL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPortadaL.Location = new System.Drawing.Point(170, 15);
            this.lblPortadaL.Name = "lblPortadaL";
            this.lblPortadaL.Size = new System.Drawing.Size(130, 16);
            this.lblPortadaL.TabIndex = 16;
            this.lblPortadaL.Text = "Seleccione Portada:";
            // 
            // CbCategoriaL
            // 
            this.CbCategoriaL.FormattingEnabled = true;
            this.CbCategoriaL.Location = new System.Drawing.Point(7, 34);
            this.CbCategoriaL.Name = "CbCategoriaL";
            this.CbCategoriaL.Size = new System.Drawing.Size(157, 24);
            this.CbCategoriaL.TabIndex = 15;
            // 
            // lbCategoriaL
            // 
            this.lbCategoriaL.AutoSize = true;
            this.lbCategoriaL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCategoriaL.Location = new System.Drawing.Point(7, 18);
            this.lbCategoriaL.Name = "lbCategoriaL";
            this.lbCategoriaL.Size = new System.Drawing.Size(141, 16);
            this.lbCategoriaL.TabIndex = 14;
            this.lbCategoriaL.Text = "Seleccione Categoria:";
            // 
            // lblPuntajeL
            // 
            this.lblPuntajeL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuntajeL.AutoSize = true;
            this.lblPuntajeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntajeL.ForeColor = System.Drawing.Color.Crimson;
            this.lblPuntajeL.Location = new System.Drawing.Point(650, 113);
            this.lblPuntajeL.Name = "lblPuntajeL";
            this.lblPuntajeL.Size = new System.Drawing.Size(93, 20);
            this.lblPuntajeL.TabIndex = 11;
            this.lblPuntajeL.Text = " lblPuntaje";
            // 
            // lblTextoPuntajeL
            // 
            this.lblTextoPuntajeL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextoPuntajeL.AutoSize = true;
            this.lblTextoPuntajeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoPuntajeL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextoPuntajeL.Location = new System.Drawing.Point(633, 80);
            this.lblTextoPuntajeL.Name = "lblTextoPuntajeL";
            this.lblTextoPuntajeL.Size = new System.Drawing.Size(134, 16);
            this.lblTextoPuntajeL.TabIndex = 10;
            this.lblTextoPuntajeL.Text = "Puntaje del producto:";
            // 
            // lblCantidadL
            // 
            this.lblCantidadL.AutoSize = true;
            this.lblCantidadL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidadL.Location = new System.Drawing.Point(170, 104);
            this.lblCantidadL.Name = "lblCantidadL";
            this.lblCantidadL.Size = new System.Drawing.Size(62, 16);
            this.lblCantidadL.TabIndex = 7;
            this.lblCantidadL.Text = "Cantidad";
            // 
            // lblPrecioL
            // 
            this.lblPrecioL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioL.AutoSize = true;
            this.lblPrecioL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioL.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblPrecioL.Location = new System.Drawing.Point(659, 49);
            this.lblPrecioL.Name = "lblPrecioL";
            this.lblPrecioL.Size = new System.Drawing.Size(77, 20);
            this.lblPrecioL.TabIndex = 6;
            this.lblPrecioL.Text = "lblPrecio";
            // 
            // lblTextoPrecioL
            // 
            this.lblTextoPrecioL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextoPrecioL.AutoSize = true;
            this.lblTextoPrecioL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoPrecioL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextoPrecioL.Location = new System.Drawing.Point(633, 16);
            this.lblTextoPrecioL.Name = "lblTextoPrecioL";
            this.lblTextoPrecioL.Size = new System.Drawing.Size(128, 16);
            this.lblTextoPrecioL.TabIndex = 5;
            this.lblTextoPrecioL.Text = "Precio del producto:";
            // 
            // txtCantidadL
            // 
            this.txtCantidadL.Location = new System.Drawing.Point(173, 119);
            this.txtCantidadL.Name = "txtCantidadL";
            this.txtCantidadL.Size = new System.Drawing.Size(37, 22);
            this.txtCantidadL.TabIndex = 4;
            // 
            // lblNombreL
            // 
            this.lblNombreL.AutoSize = true;
            this.lblNombreL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombreL.Location = new System.Drawing.Point(7, 61);
            this.lblNombreL.Name = "lblNombreL";
            this.lblNombreL.Size = new System.Drawing.Size(138, 16);
            this.lblNombreL.TabIndex = 1;
            this.lblNombreL.Text = "Nombre del producto:";
            // 
            // GroupAnnetys
            // 
            this.GroupAnnetys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupAnnetys.AutoSize = true;
            this.GroupAnnetys.Controls.Add(this.txtClienteA);
            this.GroupAnnetys.Controls.Add(this.lblTextoClienteA);
            this.GroupAnnetys.Controls.Add(this.CheckClienteA);
            this.GroupAnnetys.Controls.Add(this.txtDescripcionA);
            this.GroupAnnetys.Controls.Add(this.CbCategoriaA);
            this.GroupAnnetys.Controls.Add(this.lblCategoriaA);
            this.GroupAnnetys.Controls.Add(this.CheckAnnetys);
            this.GroupAnnetys.Controls.Add(this.txtNombreA);
            this.GroupAnnetys.Controls.Add(this.lblPuntajeA);
            this.GroupAnnetys.Controls.Add(this.lblTextoPuntajeA);
            this.GroupAnnetys.Controls.Add(this.lblDescripcionA);
            this.GroupAnnetys.Controls.Add(this.lblCantidadA);
            this.GroupAnnetys.Controls.Add(this.lblPrecioA);
            this.GroupAnnetys.Controls.Add(this.lblTextoPrecioA);
            this.GroupAnnetys.Controls.Add(this.txtCantidadA);
            this.GroupAnnetys.Controls.Add(this.lblNombreA);
            this.GroupAnnetys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupAnnetys.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupAnnetys.Location = new System.Drawing.Point(794, 31);
            this.GroupAnnetys.Name = "GroupAnnetys";
            this.GroupAnnetys.Size = new System.Drawing.Size(776, 198);
            this.GroupAnnetys.TabIndex = 40;
            this.GroupAnnetys.TabStop = false;
            this.GroupAnnetys.Text = "Area de venta Annetys";
            // 
            // txtClienteA
            // 
            this.txtClienteA.Location = new System.Drawing.Point(169, 35);
            this.txtClienteA.Name = "txtClienteA";
            this.txtClienteA.Size = new System.Drawing.Size(157, 22);
            this.txtClienteA.TabIndex = 25;
            // 
            // lblTextoClienteA
            // 
            this.lblTextoClienteA.AutoSize = true;
            this.lblTextoClienteA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextoClienteA.Location = new System.Drawing.Point(166, 16);
            this.lblTextoClienteA.Name = "lblTextoClienteA";
            this.lblTextoClienteA.Size = new System.Drawing.Size(122, 16);
            this.lblTextoClienteA.TabIndex = 24;
            this.lblTextoClienteA.Text = "Numero de Cliente:";
            // 
            // CheckClienteA
            // 
            this.CheckClienteA.AutoSize = true;
            this.CheckClienteA.Location = new System.Drawing.Point(190, 156);
            this.CheckClienteA.Name = "CheckClienteA";
            this.CheckClienteA.Size = new System.Drawing.Size(132, 20);
            this.CheckClienteA.TabIndex = 23;
            this.CheckClienteA.Text = "Cliente registrado";
            this.CheckClienteA.UseVisualStyleBackColor = true;
            // 
            // txtDescripcionA
            // 
            this.txtDescripcionA.Location = new System.Drawing.Point(6, 125);
            this.txtDescripcionA.Name = "txtDescripcionA";
            this.txtDescripcionA.Size = new System.Drawing.Size(320, 22);
            this.txtDescripcionA.TabIndex = 16;
            // 
            // CbCategoriaA
            // 
            this.CbCategoriaA.FormattingEnabled = true;
            this.CbCategoriaA.Location = new System.Drawing.Point(6, 34);
            this.CbCategoriaA.Name = "CbCategoriaA";
            this.CbCategoriaA.Size = new System.Drawing.Size(157, 24);
            this.CbCategoriaA.TabIndex = 15;
            // 
            // lblCategoriaA
            // 
            this.lblCategoriaA.AutoSize = true;
            this.lblCategoriaA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategoriaA.Location = new System.Drawing.Point(6, 18);
            this.lblCategoriaA.Name = "lblCategoriaA";
            this.lblCategoriaA.Size = new System.Drawing.Size(141, 16);
            this.lblCategoriaA.TabIndex = 14;
            this.lblCategoriaA.Text = "Seleccione Categoria:";
            // 
            // CheckAnnetys
            // 
            this.CheckAnnetys.AutoSize = true;
            this.CheckAnnetys.Location = new System.Drawing.Point(6, 157);
            this.CheckAnnetys.Name = "CheckAnnetys";
            this.CheckAnnetys.Size = new System.Drawing.Size(178, 20);
            this.CheckAnnetys.TabIndex = 13;
            this.CheckAnnetys.Text = "Buscar producto por lista:";
            this.CheckAnnetys.UseVisualStyleBackColor = true;
            // 
            // txtNombreA
            // 
            this.txtNombreA.Location = new System.Drawing.Point(6, 81);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(157, 22);
            this.txtNombreA.TabIndex = 12;
            // 
            // lblPuntajeA
            // 
            this.lblPuntajeA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuntajeA.AutoSize = true;
            this.lblPuntajeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntajeA.ForeColor = System.Drawing.Color.Crimson;
            this.lblPuntajeA.Location = new System.Drawing.Point(650, 113);
            this.lblPuntajeA.Name = "lblPuntajeA";
            this.lblPuntajeA.Size = new System.Drawing.Size(93, 20);
            this.lblPuntajeA.TabIndex = 11;
            this.lblPuntajeA.Text = " lblPuntaje";
            // 
            // lblTextoPuntajeA
            // 
            this.lblTextoPuntajeA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextoPuntajeA.AutoSize = true;
            this.lblTextoPuntajeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoPuntajeA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextoPuntajeA.Location = new System.Drawing.Point(633, 80);
            this.lblTextoPuntajeA.Name = "lblTextoPuntajeA";
            this.lblTextoPuntajeA.Size = new System.Drawing.Size(134, 16);
            this.lblTextoPuntajeA.TabIndex = 10;
            this.lblTextoPuntajeA.Text = "Puntaje del producto:";
            // 
            // lblDescripcionA
            // 
            this.lblDescripcionA.AutoSize = true;
            this.lblDescripcionA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescripcionA.Location = new System.Drawing.Point(6, 106);
            this.lblDescripcionA.Name = "lblDescripcionA";
            this.lblDescripcionA.Size = new System.Drawing.Size(83, 16);
            this.lblDescripcionA.TabIndex = 8;
            this.lblDescripcionA.Text = "Descripcion:";
            // 
            // lblCantidadA
            // 
            this.lblCantidadA.AutoSize = true;
            this.lblCantidadA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidadA.Location = new System.Drawing.Point(166, 61);
            this.lblCantidadA.Name = "lblCantidadA";
            this.lblCantidadA.Size = new System.Drawing.Size(62, 16);
            this.lblCantidadA.TabIndex = 7;
            this.lblCantidadA.Text = "Cantidad";
            // 
            // lblPrecioA
            // 
            this.lblPrecioA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioA.AutoSize = true;
            this.lblPrecioA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioA.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblPrecioA.Location = new System.Drawing.Point(659, 49);
            this.lblPrecioA.Name = "lblPrecioA";
            this.lblPrecioA.Size = new System.Drawing.Size(77, 20);
            this.lblPrecioA.TabIndex = 6;
            this.lblPrecioA.Text = "lblPrecio";
            // 
            // lblTextoPrecioA
            // 
            this.lblTextoPrecioA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextoPrecioA.AutoSize = true;
            this.lblTextoPrecioA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoPrecioA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextoPrecioA.Location = new System.Drawing.Point(633, 16);
            this.lblTextoPrecioA.Name = "lblTextoPrecioA";
            this.lblTextoPrecioA.Size = new System.Drawing.Size(128, 16);
            this.lblTextoPrecioA.TabIndex = 5;
            this.lblTextoPrecioA.Text = "Precio del producto:";
            // 
            // txtCantidadA
            // 
            this.txtCantidadA.Location = new System.Drawing.Point(169, 81);
            this.txtCantidadA.Name = "txtCantidadA";
            this.txtCantidadA.Size = new System.Drawing.Size(37, 22);
            this.txtCantidadA.TabIndex = 4;
            // 
            // lblNombreA
            // 
            this.lblNombreA.AutoSize = true;
            this.lblNombreA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombreA.Location = new System.Drawing.Point(6, 61);
            this.lblNombreA.Name = "lblNombreA";
            this.lblNombreA.Size = new System.Drawing.Size(135, 16);
            this.lblNombreA.TabIndex = 1;
            this.lblNombreA.Text = "Nombre del producto";
            // 
            // GroupTCG
            // 
            this.GroupTCG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupTCG.AutoSize = true;
            this.GroupTCG.Controls.Add(this.txtClienteT);
            this.GroupTCG.Controls.Add(this.lblTextoClienteT);
            this.GroupTCG.Controls.Add(this.CheckTCG);
            this.GroupTCG.Controls.Add(this.CheckClienteT);
            this.GroupTCG.Controls.Add(this.txtProductoT);
            this.GroupTCG.Controls.Add(this.lblPuntajeT);
            this.GroupTCG.Controls.Add(this.lblTextopuntajeT);
            this.GroupTCG.Controls.Add(this.CbNombreT);
            this.GroupTCG.Controls.Add(this.lblTextoNombreT);
            this.GroupTCG.Controls.Add(this.lblTextoCantidadT);
            this.GroupTCG.Controls.Add(this.lblPrecioT);
            this.GroupTCG.Controls.Add(this.lblTextoPrecioT);
            this.GroupTCG.Controls.Add(this.txtCantidadT);
            this.GroupTCG.Controls.Add(this.lblTextoProductoT);
            this.GroupTCG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupTCG.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupTCG.Location = new System.Drawing.Point(794, 235);
            this.GroupTCG.Name = "GroupTCG";
            this.GroupTCG.Size = new System.Drawing.Size(776, 198);
            this.GroupTCG.TabIndex = 41;
            this.GroupTCG.TabStop = false;
            this.GroupTCG.Text = "Area de venta TCG";
            // 
            // txtClienteT
            // 
            this.txtClienteT.Location = new System.Drawing.Point(190, 37);
            this.txtClienteT.Name = "txtClienteT";
            this.txtClienteT.Size = new System.Drawing.Size(157, 22);
            this.txtClienteT.TabIndex = 25;
            // 
            // lblTextoClienteT
            // 
            this.lblTextoClienteT.AutoSize = true;
            this.lblTextoClienteT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextoClienteT.Location = new System.Drawing.Point(187, 18);
            this.lblTextoClienteT.Name = "lblTextoClienteT";
            this.lblTextoClienteT.Size = new System.Drawing.Size(122, 16);
            this.lblTextoClienteT.TabIndex = 24;
            this.lblTextoClienteT.Text = "Numero de Cliente:";
            // 
            // CheckTCG
            // 
            this.CheckTCG.AutoSize = true;
            this.CheckTCG.Location = new System.Drawing.Point(6, 157);
            this.CheckTCG.Name = "CheckTCG";
            this.CheckTCG.Size = new System.Drawing.Size(178, 20);
            this.CheckTCG.TabIndex = 13;
            this.CheckTCG.Text = "Buscar producto por lista:";
            this.CheckTCG.UseVisualStyleBackColor = true;
            // 
            // CheckClienteT
            // 
            this.CheckClienteT.AutoSize = true;
            this.CheckClienteT.Location = new System.Drawing.Point(190, 157);
            this.CheckClienteT.Name = "CheckClienteT";
            this.CheckClienteT.Size = new System.Drawing.Size(132, 20);
            this.CheckClienteT.TabIndex = 23;
            this.CheckClienteT.Text = "Cliente registrado";
            this.CheckClienteT.UseVisualStyleBackColor = true;
            // 
            // txtProductoT
            // 
            this.txtProductoT.Location = new System.Drawing.Point(6, 80);
            this.txtProductoT.Name = "txtProductoT";
            this.txtProductoT.Size = new System.Drawing.Size(157, 22);
            this.txtProductoT.TabIndex = 12;
            // 
            // lblPuntajeT
            // 
            this.lblPuntajeT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuntajeT.AutoSize = true;
            this.lblPuntajeT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntajeT.ForeColor = System.Drawing.Color.Crimson;
            this.lblPuntajeT.Location = new System.Drawing.Point(650, 113);
            this.lblPuntajeT.Name = "lblPuntajeT";
            this.lblPuntajeT.Size = new System.Drawing.Size(93, 20);
            this.lblPuntajeT.TabIndex = 11;
            this.lblPuntajeT.Text = " lblPuntaje";
            // 
            // lblTextopuntajeT
            // 
            this.lblTextopuntajeT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextopuntajeT.AutoSize = true;
            this.lblTextopuntajeT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextopuntajeT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextopuntajeT.Location = new System.Drawing.Point(633, 80);
            this.lblTextopuntajeT.Name = "lblTextopuntajeT";
            this.lblTextopuntajeT.Size = new System.Drawing.Size(134, 16);
            this.lblTextopuntajeT.TabIndex = 10;
            this.lblTextopuntajeT.Text = "Puntaje del producto:";
            // 
            // CbNombreT
            // 
            this.CbNombreT.FormattingEnabled = true;
            this.CbNombreT.Location = new System.Drawing.Point(6, 34);
            this.CbNombreT.Name = "CbNombreT";
            this.CbNombreT.Size = new System.Drawing.Size(157, 24);
            this.CbNombreT.TabIndex = 9;
            // 
            // lblTextoNombreT
            // 
            this.lblTextoNombreT.AutoSize = true;
            this.lblTextoNombreT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextoNombreT.Location = new System.Drawing.Point(3, 18);
            this.lblTextoNombreT.Name = "lblTextoNombreT";
            this.lblTextoNombreT.Size = new System.Drawing.Size(181, 16);
            this.lblTextoNombreT.TabIndex = 8;
            this.lblTextoNombreT.Text = "Seleccione Nombre de TCG:";
            // 
            // lblTextoCantidadT
            // 
            this.lblTextoCantidadT.AutoSize = true;
            this.lblTextoCantidadT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextoCantidadT.Location = new System.Drawing.Point(3, 105);
            this.lblTextoCantidadT.Name = "lblTextoCantidadT";
            this.lblTextoCantidadT.Size = new System.Drawing.Size(62, 16);
            this.lblTextoCantidadT.TabIndex = 7;
            this.lblTextoCantidadT.Text = "Cantidad";
            // 
            // lblPrecioT
            // 
            this.lblPrecioT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioT.AutoSize = true;
            this.lblPrecioT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioT.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblPrecioT.Location = new System.Drawing.Point(659, 49);
            this.lblPrecioT.Name = "lblPrecioT";
            this.lblPrecioT.Size = new System.Drawing.Size(77, 20);
            this.lblPrecioT.TabIndex = 6;
            this.lblPrecioT.Text = "lblPrecio";
            // 
            // lblTextoPrecioT
            // 
            this.lblTextoPrecioT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextoPrecioT.AutoSize = true;
            this.lblTextoPrecioT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoPrecioT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextoPrecioT.Location = new System.Drawing.Point(633, 16);
            this.lblTextoPrecioT.Name = "lblTextoPrecioT";
            this.lblTextoPrecioT.Size = new System.Drawing.Size(128, 16);
            this.lblTextoPrecioT.TabIndex = 5;
            this.lblTextoPrecioT.Text = "Precio del producto:";
            // 
            // txtCantidadT
            // 
            this.txtCantidadT.Location = new System.Drawing.Point(6, 125);
            this.txtCantidadT.Name = "txtCantidadT";
            this.txtCantidadT.Size = new System.Drawing.Size(40, 22);
            this.txtCantidadT.TabIndex = 4;
            // 
            // lblTextoProductoT
            // 
            this.lblTextoProductoT.AutoSize = true;
            this.lblTextoProductoT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextoProductoT.Location = new System.Drawing.Point(6, 60);
            this.lblTextoProductoT.Name = "lblTextoProductoT";
            this.lblTextoProductoT.Size = new System.Drawing.Size(135, 16);
            this.lblTextoProductoT.TabIndex = 1;
            this.lblTextoProductoT.Text = "Nombre del producto";
            // 
            // GroupJuegosMesa
            // 
            this.GroupJuegosMesa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupJuegosMesa.AutoSize = true;
            this.GroupJuegosMesa.Controls.Add(this.txtClienteJ);
            this.GroupJuegosMesa.Controls.Add(this.lblTextoClienteJ);
            this.GroupJuegosMesa.Controls.Add(this.CheckClienteJ);
            this.GroupJuegosMesa.Controls.Add(this.CheckJuegos);
            this.GroupJuegosMesa.Controls.Add(this.txtNombreJ);
            this.GroupJuegosMesa.Controls.Add(this.lblPuntajeJ);
            this.GroupJuegosMesa.Controls.Add(this.lblTextoPunrajeJ);
            this.GroupJuegosMesa.Controls.Add(this.lblCantidadJ);
            this.GroupJuegosMesa.Controls.Add(this.lblPrecioJ);
            this.GroupJuegosMesa.Controls.Add(this.lblTextoPrecioJ);
            this.GroupJuegosMesa.Controls.Add(this.txtCantidadJ);
            this.GroupJuegosMesa.Controls.Add(this.lblNombreJ);
            this.GroupJuegosMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupJuegosMesa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupJuegosMesa.Location = new System.Drawing.Point(794, 420);
            this.GroupJuegosMesa.Name = "GroupJuegosMesa";
            this.GroupJuegosMesa.Size = new System.Drawing.Size(776, 198);
            this.GroupJuegosMesa.TabIndex = 40;
            this.GroupJuegosMesa.TabStop = false;
            this.GroupJuegosMesa.Text = "Area de venta Juegos de mesa:";
            // 
            // txtClienteJ
            // 
            this.txtClienteJ.Location = new System.Drawing.Point(172, 47);
            this.txtClienteJ.Name = "txtClienteJ";
            this.txtClienteJ.Size = new System.Drawing.Size(157, 22);
            this.txtClienteJ.TabIndex = 25;
            // 
            // lblTextoClienteJ
            // 
            this.lblTextoClienteJ.AutoSize = true;
            this.lblTextoClienteJ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextoClienteJ.Location = new System.Drawing.Point(169, 28);
            this.lblTextoClienteJ.Name = "lblTextoClienteJ";
            this.lblTextoClienteJ.Size = new System.Drawing.Size(122, 16);
            this.lblTextoClienteJ.TabIndex = 24;
            this.lblTextoClienteJ.Text = "Numero de Cliente:";
            // 
            // CheckClienteJ
            // 
            this.CheckClienteJ.AutoSize = true;
            this.CheckClienteJ.Location = new System.Drawing.Point(194, 157);
            this.CheckClienteJ.Name = "CheckClienteJ";
            this.CheckClienteJ.Size = new System.Drawing.Size(132, 20);
            this.CheckClienteJ.TabIndex = 23;
            this.CheckClienteJ.Text = "Cliente registrado";
            this.CheckClienteJ.UseVisualStyleBackColor = true;
            // 
            // CheckJuegos
            // 
            this.CheckJuegos.AutoSize = true;
            this.CheckJuegos.Location = new System.Drawing.Point(6, 157);
            this.CheckJuegos.Name = "CheckJuegos";
            this.CheckJuegos.Size = new System.Drawing.Size(178, 20);
            this.CheckJuegos.TabIndex = 13;
            this.CheckJuegos.Text = "Buscar producto por lista:";
            this.CheckJuegos.UseVisualStyleBackColor = true;
            // 
            // txtNombreJ
            // 
            this.txtNombreJ.Location = new System.Drawing.Point(6, 47);
            this.txtNombreJ.Name = "txtNombreJ";
            this.txtNombreJ.Size = new System.Drawing.Size(157, 22);
            this.txtNombreJ.TabIndex = 12;
            // 
            // lblPuntajeJ
            // 
            this.lblPuntajeJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuntajeJ.AutoSize = true;
            this.lblPuntajeJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntajeJ.ForeColor = System.Drawing.Color.Crimson;
            this.lblPuntajeJ.Location = new System.Drawing.Point(650, 113);
            this.lblPuntajeJ.Name = "lblPuntajeJ";
            this.lblPuntajeJ.Size = new System.Drawing.Size(93, 20);
            this.lblPuntajeJ.TabIndex = 11;
            this.lblPuntajeJ.Text = " lblPuntaje";
            // 
            // lblTextoPunrajeJ
            // 
            this.lblTextoPunrajeJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextoPunrajeJ.AutoSize = true;
            this.lblTextoPunrajeJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoPunrajeJ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextoPunrajeJ.Location = new System.Drawing.Point(633, 80);
            this.lblTextoPunrajeJ.Name = "lblTextoPunrajeJ";
            this.lblTextoPunrajeJ.Size = new System.Drawing.Size(134, 16);
            this.lblTextoPunrajeJ.TabIndex = 10;
            this.lblTextoPunrajeJ.Text = "Puntaje del producto:";
            // 
            // lblCantidadJ
            // 
            this.lblCantidadJ.AutoSize = true;
            this.lblCantidadJ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidadJ.Location = new System.Drawing.Point(3, 72);
            this.lblCantidadJ.Name = "lblCantidadJ";
            this.lblCantidadJ.Size = new System.Drawing.Size(62, 16);
            this.lblCantidadJ.TabIndex = 7;
            this.lblCantidadJ.Text = "Cantidad";
            // 
            // lblPrecioJ
            // 
            this.lblPrecioJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioJ.AutoSize = true;
            this.lblPrecioJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioJ.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblPrecioJ.Location = new System.Drawing.Point(659, 49);
            this.lblPrecioJ.Name = "lblPrecioJ";
            this.lblPrecioJ.Size = new System.Drawing.Size(77, 20);
            this.lblPrecioJ.TabIndex = 6;
            this.lblPrecioJ.Text = "lblPrecio";
            // 
            // lblTextoPrecioJ
            // 
            this.lblTextoPrecioJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextoPrecioJ.AutoSize = true;
            this.lblTextoPrecioJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoPrecioJ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextoPrecioJ.Location = new System.Drawing.Point(633, 16);
            this.lblTextoPrecioJ.Name = "lblTextoPrecioJ";
            this.lblTextoPrecioJ.Size = new System.Drawing.Size(128, 16);
            this.lblTextoPrecioJ.TabIndex = 5;
            this.lblTextoPrecioJ.Text = "Precio del producto:";
            // 
            // txtCantidadJ
            // 
            this.txtCantidadJ.Location = new System.Drawing.Point(6, 92);
            this.txtCantidadJ.Name = "txtCantidadJ";
            this.txtCantidadJ.Size = new System.Drawing.Size(40, 22);
            this.txtCantidadJ.TabIndex = 4;
            // 
            // lblNombreJ
            // 
            this.lblNombreJ.AutoSize = true;
            this.lblNombreJ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombreJ.Location = new System.Drawing.Point(3, 28);
            this.lblNombreJ.Name = "lblNombreJ";
            this.lblNombreJ.Size = new System.Drawing.Size(135, 16);
            this.lblNombreJ.TabIndex = 1;
            this.lblNombreJ.Text = "Nombre del producto";
            // 
            // CbAreaVenta
            // 
            this.CbAreaVenta.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.inventarioBindingSource1, "Categoria", true));
            this.CbAreaVenta.FormattingEnabled = true;
            this.CbAreaVenta.Items.AddRange(new object[] {
            "Libros",
            "Annetys",
            "TCG",
            "Juegos de mesa"});
            this.CbAreaVenta.Location = new System.Drawing.Point(12, 42);
            this.CbAreaVenta.Name = "CbAreaVenta";
            this.CbAreaVenta.Size = new System.Drawing.Size(157, 21);
            this.CbAreaVenta.TabIndex = 2;
            this.CbAreaVenta.SelectedIndexChanged += new System.EventHandler(this.CbAreaVenta_SelectedIndexChanged);
            // 
            // inventarioBindingSource1
            // 
            this.inventarioBindingSource1.DataMember = "Inventario";
            this.inventarioBindingSource1.DataSource = this.dBplugYplayDataSet;
            // 
            // dBplugYplayDataSet
            // 
            this.dBplugYplayDataSet.DataSetName = "DBplugYplayDataSet";
            this.dBplugYplayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(8, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seleccione area de venta:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.AutoSize = true;
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnGuardar.IconColor = System.Drawing.Color.Black;
            this.BtnGuardar.IconSize = 16;
            this.BtnGuardar.Location = new System.Drawing.Point(288, 276);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Rotation = 0D;
            this.BtnGuardar.Size = new System.Drawing.Size(102, 38);
            this.BtnGuardar.TabIndex = 40;
            this.BtnGuardar.Text = "Registrar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.AutoSize = true;
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 16;
            this.iconButton2.Location = new System.Drawing.Point(425, 276);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(102, 38);
            this.iconButton2.TabIndex = 41;
            this.iconButton2.Text = "Cancelar";
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconSize = 16;
            this.iconButton3.Location = new System.Drawing.Point(654, 504);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(140, 38);
            this.iconButton3.TabIndex = 43;
            this.iconButton3.Text = "Guardar Registro";
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 321);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 177);
            this.listView1.TabIndex = 44;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "Inventario";
            this.inventarioBindingSource.DataSource = this.dBplugYplayDataSet;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.GroupJuegosMesa);
            this.Controls.Add(this.GroupTCG);
            this.Controls.Add(this.GroupAnnetys);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.GroupLibros);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblFechatxt);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.CbAreaVenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            this.GroupLibros.ResumeLayout(false);
            this.GroupLibros.PerformLayout();
            this.GroupAnnetys.ResumeLayout(false);
            this.GroupAnnetys.PerformLayout();
            this.GroupTCG.ResumeLayout(false);
            this.GroupTCG.PerformLayout();
            this.GroupJuegosMesa.ResumeLayout(false);
            this.GroupJuegosMesa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBplugYplayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechatxt;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox GroupLibros;
        private System.Windows.Forms.ComboBox CbAreaVenta;
        private System.Windows.Forms.Label lblNombreL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantidadL;
        private System.Windows.Forms.Label lblPrecioL;
        private System.Windows.Forms.Label lblTextoPrecioL;
        private System.Windows.Forms.TextBox txtCantidadL;
        private System.Windows.Forms.Label lblPuntajeL;
        private System.Windows.Forms.Label lblTextoPuntajeL;
        private System.Windows.Forms.ComboBox CbCategoriaL;
        private System.Windows.Forms.Label lbCategoriaL;
        private System.Windows.Forms.ComboBox CbVolumenL;
        private System.Windows.Forms.Label lblVolumenL;
        private System.Windows.Forms.ComboBox CbPortadaL;
        private System.Windows.Forms.Label lblPortadaL;
        private System.Windows.Forms.GroupBox GroupAnnetys;
        private System.Windows.Forms.ComboBox CbCategoriaA;
        private System.Windows.Forms.Label lblCategoriaA;
        private System.Windows.Forms.CheckBox CheckAnnetys;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.Label lblPuntajeA;
        private System.Windows.Forms.Label lblTextoPuntajeA;
        private System.Windows.Forms.Label lblDescripcionA;
        private System.Windows.Forms.Label lblCantidadA;
        private System.Windows.Forms.Label lblPrecioA;
        private System.Windows.Forms.Label lblTextoPrecioA;
        private System.Windows.Forms.TextBox txtCantidadA;
        private System.Windows.Forms.Label lblNombreA;
        private System.Windows.Forms.TextBox txtDescripcionA;
        private System.Windows.Forms.GroupBox GroupJuegosMesa;
        private System.Windows.Forms.CheckBox CheckJuegos;
        private System.Windows.Forms.TextBox txtNombreJ;
        private System.Windows.Forms.Label lblPuntajeJ;
        private System.Windows.Forms.Label lblTextoPunrajeJ;
        private System.Windows.Forms.Label lblCantidadJ;
        private System.Windows.Forms.Label lblPrecioJ;
        private System.Windows.Forms.Label lblTextoPrecioJ;
        private System.Windows.Forms.TextBox txtCantidadJ;
        private System.Windows.Forms.Label lblNombreJ;
        private System.Windows.Forms.GroupBox GroupTCG;
        private System.Windows.Forms.CheckBox CheckTCG;
        private System.Windows.Forms.TextBox txtProductoT;
        private System.Windows.Forms.Label lblPuntajeT;
        private System.Windows.Forms.Label lblTextopuntajeT;
        private System.Windows.Forms.ComboBox CbNombreT;
        private System.Windows.Forms.Label lblTextoNombreT;
        private System.Windows.Forms.Label lblTextoCantidadT;
        private System.Windows.Forms.Label lblPrecioT;
        private System.Windows.Forms.Label lblTextoPrecioT;
        private System.Windows.Forms.TextBox txtCantidadT;
        private System.Windows.Forms.Label lblTextoProductoT;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtClienteL;
        private System.Windows.Forms.Label lblTextoClienteL;
        private System.Windows.Forms.CheckBox CheckClienteL;
        private System.Windows.Forms.TextBox txtClienteA;
        private System.Windows.Forms.Label lblTextoClienteA;
        private System.Windows.Forms.CheckBox CheckClienteA;
        private System.Windows.Forms.TextBox txtClienteT;
        private System.Windows.Forms.Label lblTextoClienteT;
        private System.Windows.Forms.CheckBox CheckClienteT;
        private System.Windows.Forms.TextBox txtClienteJ;
        private System.Windows.Forms.Label lblTextoClienteJ;
        private System.Windows.Forms.CheckBox CheckClienteJ;
        private System.Windows.Forms.ComboBox CbNombreL;
        private System.Windows.Forms.ComboBox CbEditorialL;
        private System.Windows.Forms.Label lblTextoEditorialL;
        private DBplugYplayDataSet dBplugYplayDataSet;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private DBplugYplayDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.BindingSource inventarioBindingSource1;
    }
}