namespace Ventas_Inventario
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDollar = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuInventario = new System.Windows.Forms.Panel();
            this.brnJuegosMesa = new FontAwesome.Sharp.IconButton();
            this.btnLibros = new FontAwesome.Sharp.IconButton();
            this.btnInventario = new FontAwesome.Sharp.IconButton();
            this.btnVenta = new FontAwesome.Sharp.IconButton();
            this.panelimg = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.btnMin = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinyMax = new FontAwesome.Sharp.IconPictureBox();
            this.btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.IconCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.btnTCG = new FontAwesome.Sharp.IconButton();
            this.btnAnnetys = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelSubMenuInventario.SuspendLayout();
            this.panelimg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinyMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChild)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelMenu.Controls.Add(this.btnDollar);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.panelSubMenuInventario);
            this.panelMenu.Controls.Add(this.btnInventario);
            this.panelMenu.Controls.Add(this.btnVenta);
            this.panelMenu.Controls.Add(this.panelimg);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(179, 549);
            this.panelMenu.TabIndex = 0;
            // 
            // btnDollar
            // 
            this.btnDollar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDollar.FlatAppearance.BorderSize = 0;
            this.btnDollar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDollar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDollar.ForeColor = System.Drawing.Color.Black;
            this.btnDollar.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnDollar.IconColor = System.Drawing.Color.Black;
            this.btnDollar.IconSize = 32;
            this.btnDollar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDollar.Location = new System.Drawing.Point(0, 467);
            this.btnDollar.Name = "btnDollar";
            this.btnDollar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDollar.Rotation = 0D;
            this.btnDollar.Size = new System.Drawing.Size(179, 50);
            this.btnDollar.TabIndex = 6;
            this.btnDollar.Text = "Tipo de cambio";
            this.btnDollar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDollar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDollar.UseVisualStyleBackColor = true;
            this.btnDollar.Click += new System.EventHandler(this.btnDollar_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Black;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnClientes.IconColor = System.Drawing.Color.Black;
            this.btnClientes.IconSize = 32;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 417);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClientes.Rotation = 0D;
            this.btnClientes.Size = new System.Drawing.Size(179, 50);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panelSubMenuInventario
            // 
            this.panelSubMenuInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(0)))));
            this.panelSubMenuInventario.Controls.Add(this.btnAnnetys);
            this.panelSubMenuInventario.Controls.Add(this.btnTCG);
            this.panelSubMenuInventario.Controls.Add(this.brnJuegosMesa);
            this.panelSubMenuInventario.Controls.Add(this.btnLibros);
            this.panelSubMenuInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuInventario.Location = new System.Drawing.Point(0, 210);
            this.panelSubMenuInventario.Name = "panelSubMenuInventario";
            this.panelSubMenuInventario.Size = new System.Drawing.Size(179, 207);
            this.panelSubMenuInventario.TabIndex = 7;
            // 
            // brnJuegosMesa
            // 
            this.brnJuegosMesa.BackColor = System.Drawing.Color.Transparent;
            this.brnJuegosMesa.Dock = System.Windows.Forms.DockStyle.Top;
            this.brnJuegosMesa.FlatAppearance.BorderSize = 0;
            this.brnJuegosMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnJuegosMesa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.brnJuegosMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnJuegosMesa.ForeColor = System.Drawing.Color.Black;
            this.brnJuegosMesa.IconChar = FontAwesome.Sharp.IconChar.Dice;
            this.brnJuegosMesa.IconColor = System.Drawing.Color.Black;
            this.brnJuegosMesa.IconSize = 32;
            this.brnJuegosMesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnJuegosMesa.Location = new System.Drawing.Point(0, 50);
            this.brnJuegosMesa.Name = "brnJuegosMesa";
            this.brnJuegosMesa.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.brnJuegosMesa.Rotation = 0D;
            this.brnJuegosMesa.Size = new System.Drawing.Size(179, 50);
            this.brnJuegosMesa.TabIndex = 5;
            this.brnJuegosMesa.Text = "Juegos de mesa";
            this.brnJuegosMesa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnJuegosMesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.brnJuegosMesa.UseVisualStyleBackColor = false;
            this.brnJuegosMesa.Click += new System.EventHandler(this.brnJuegosMesa_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.BackColor = System.Drawing.Color.Transparent;
            this.btnLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibros.FlatAppearance.BorderSize = 0;
            this.btnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibros.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros.ForeColor = System.Drawing.Color.Black;
            this.btnLibros.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnLibros.IconColor = System.Drawing.Color.Black;
            this.btnLibros.IconSize = 32;
            this.btnLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibros.Location = new System.Drawing.Point(0, 0);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnLibros.Rotation = 0D;
            this.btnLibros.Size = new System.Drawing.Size(179, 50);
            this.btnLibros.TabIndex = 4;
            this.btnLibros.Text = "Libros";
            this.btnLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.Black;
            this.btnInventario.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btnInventario.IconColor = System.Drawing.Color.Black;
            this.btnInventario.IconSize = 32;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 160);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInventario.Rotation = 0D;
            this.btnInventario.Size = new System.Drawing.Size(179, 50);
            this.btnInventario.TabIndex = 2;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.Black;
            this.btnVenta.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.btnVenta.IconColor = System.Drawing.Color.Black;
            this.btnVenta.IconSize = 32;
            this.btnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenta.Location = new System.Drawing.Point(0, 110);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnVenta.Rotation = 0D;
            this.btnVenta.Size = new System.Drawing.Size(179, 50);
            this.btnVenta.TabIndex = 1;
            this.btnVenta.Text = "Venta";
            this.btnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // panelimg
            // 
            this.panelimg.Controls.Add(this.btnInicio);
            this.panelimg.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelimg.Location = new System.Drawing.Point(0, 0);
            this.panelimg.Name = "panelimg";
            this.panelimg.Size = new System.Drawing.Size(179, 110);
            this.panelimg.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(179, 110);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PanelTitulo.Controls.Add(this.btnMin);
            this.PanelTitulo.Controls.Add(this.btnMinyMax);
            this.PanelTitulo.Controls.Add(this.btnCerrar);
            this.PanelTitulo.Controls.Add(this.lblTitulo);
            this.PanelTitulo.Controls.Add(this.IconCurrentChild);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(179, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(776, 38);
            this.PanelTitulo.TabIndex = 1;
            this.PanelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitulo_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(668, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(32, 32);
            this.btnMin.TabIndex = 4;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMinyMax
            // 
            this.btnMinyMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinyMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMinyMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinyMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMinyMax.IconColor = System.Drawing.Color.White;
            this.btnMinyMax.Location = new System.Drawing.Point(706, 3);
            this.btnMinyMax.Name = "btnMinyMax";
            this.btnMinyMax.Size = new System.Drawing.Size(32, 32);
            this.btnMinyMax.TabIndex = 3;
            this.btnMinyMax.TabStop = false;
            this.btnMinyMax.Click += new System.EventHandler(this.btnMinyMax_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(744, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(58, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(68, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Home";
            // 
            // IconCurrentChild
            // 
            this.IconCurrentChild.BackColor = System.Drawing.Color.Transparent;
            this.IconCurrentChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(50)))), ((int)(((byte)(160)))));
            this.IconCurrentChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrentChild.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(50)))), ((int)(((byte)(160)))));
            this.IconCurrentChild.IconSize = 45;
            this.IconCurrentChild.Location = new System.Drawing.Point(0, 0);
            this.IconCurrentChild.Name = "IconCurrentChild";
            this.IconCurrentChild.Size = new System.Drawing.Size(52, 45);
            this.IconCurrentChild.TabIndex = 0;
            this.IconCurrentChild.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.Navy;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(179, 38);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(776, 7);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(50)))), ((int)(((byte)(160)))));
            this.panelDesktop.Controls.Add(this.lblFecha);
            this.panelDesktop.Controls.Add(this.lblHora);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(179, 45);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(776, 504);
            this.panelDesktop.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Pristina", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Gold;
            this.lblFecha.Location = new System.Drawing.Point(186, 340);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(244, 126);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Pristina", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Gold;
            this.lblHora.Location = new System.Drawing.Point(186, 242);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(221, 126);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(200, 146);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // btnTCG
            // 
            this.btnTCG.BackColor = System.Drawing.Color.Transparent;
            this.btnTCG.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTCG.FlatAppearance.BorderSize = 0;
            this.btnTCG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTCG.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTCG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTCG.ForeColor = System.Drawing.Color.Black;
            this.btnTCG.IconChar = FontAwesome.Sharp.IconChar.DiceD20;
            this.btnTCG.IconColor = System.Drawing.Color.Black;
            this.btnTCG.IconSize = 32;
            this.btnTCG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTCG.Location = new System.Drawing.Point(0, 100);
            this.btnTCG.Name = "btnTCG";
            this.btnTCG.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnTCG.Rotation = 0D;
            this.btnTCG.Size = new System.Drawing.Size(179, 50);
            this.btnTCG.TabIndex = 6;
            this.btnTCG.Text = "TCG";
            this.btnTCG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTCG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTCG.UseVisualStyleBackColor = false;
            this.btnTCG.Click += new System.EventHandler(this.btnTCG_Click);
            // 
            // btnAnnetys
            // 
            this.btnAnnetys.BackColor = System.Drawing.Color.Transparent;
            this.btnAnnetys.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnnetys.FlatAppearance.BorderSize = 0;
            this.btnAnnetys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnetys.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAnnetys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnetys.ForeColor = System.Drawing.Color.Black;
            this.btnAnnetys.IconChar = FontAwesome.Sharp.IconChar.Gifts;
            this.btnAnnetys.IconColor = System.Drawing.Color.Black;
            this.btnAnnetys.IconSize = 32;
            this.btnAnnetys.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnetys.Location = new System.Drawing.Point(0, 150);
            this.btnAnnetys.Name = "btnAnnetys";
            this.btnAnnetys.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnAnnetys.Rotation = 0D;
            this.btnAnnetys.Size = new System.Drawing.Size(179, 50);
            this.btnAnnetys.TabIndex = 7;
            this.btnAnnetys.Text = "Annetys";
            this.btnAnnetys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnetys.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnnetys.UseVisualStyleBackColor = false;
            this.btnAnnetys.Click += new System.EventHandler(this.btnAnnetys_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 549);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.PanelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelSubMenuInventario.ResumeLayout(false);
            this.panelimg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinyMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChild)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelimg;
        private FontAwesome.Sharp.IconButton btnVenta;
        private FontAwesome.Sharp.IconButton btnDollar;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnInventario;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Panel PanelTitulo;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChild;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox btnMin;
        private FontAwesome.Sharp.IconPictureBox btnMinyMax;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Panel panelSubMenuInventario;
        private FontAwesome.Sharp.IconButton brnJuegosMesa;
        private FontAwesome.Sharp.IconButton btnLibros;
        private FontAwesome.Sharp.IconButton btnAnnetys;
        private FontAwesome.Sharp.IconButton btnTCG;
    }
}

