namespace Prestamo_Equipos_Herramientas.GUI
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.Top = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Menu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Alumnos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Maestros = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Equipos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Prestamos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSlidelPanel = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.frm_prestamo1 = new Prestamo_Equipos_Herramientas.GUI.Frm_Prestamo();
            this.frm_Maestro1 = new Prestamo_Equipos_Herramientas.GUI.Frm_Maestro();
            this.frm_Equipo_Herramienta1 = new Prestamo_Equipos_Herramientas.GUI.Frm_Equipo_Herramienta();
            this.frm_Alumno1 = new Prestamo_Equipos_Herramientas.GUI.Frm_Alumno();
            this.frm_Admin1 = new Prestamo_Equipos_Herramientas.GUI.Frm_Admin();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Animacion1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Animacion2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlidelPanel)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.PanelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.Top.Controls.Add(this.button3);
            this.Top.Controls.Add(this.button4);
            this.Top.Controls.Add(this.label1);
            this.Animacion2.SetDecoration(this.Top, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this.Top, BunifuAnimatorNS.DecorationType.None);
            this.Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top.Location = new System.Drawing.Point(0, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(898, 36);
            this.Top.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(810, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 56);
            this.button3.TabIndex = 24;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(854, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 36);
            this.button4.TabIndex = 23;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.Animacion1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(452, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Menú";
            // 
            // btn_Menu
            // 
            this.btn_Menu.Activecolor = System.Drawing.Color.Black;
            this.btn_Menu.BackColor = System.Drawing.Color.Black;
            this.btn_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Menu.BorderRadius = 0;
            this.btn_Menu.ButtonText = "Menú";
            this.btn_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion2.SetDecoration(this.btn_Menu, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this.btn_Menu, BunifuAnimatorNS.DecorationType.None);
            this.btn_Menu.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Menu.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Menu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Menu.Iconimage")));
            this.btn_Menu.Iconimage_right = null;
            this.btn_Menu.Iconimage_right_Selected = null;
            this.btn_Menu.Iconimage_Selected = null;
            this.btn_Menu.IconMarginLeft = 0;
            this.btn_Menu.IconMarginRight = 0;
            this.btn_Menu.IconRightVisible = true;
            this.btn_Menu.IconRightZoom = 0D;
            this.btn_Menu.IconVisible = true;
            this.btn_Menu.IconZoom = 45D;
            this.btn_Menu.IsTab = true;
            this.btn_Menu.Location = new System.Drawing.Point(0, 143);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Menu.OnHovercolor = System.Drawing.Color.Silver;
            this.btn_Menu.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Menu.selected = true;
            this.btn_Menu.Size = new System.Drawing.Size(198, 30);
            this.btn_Menu.TabIndex = 15;
            this.btn_Menu.Text = "Menú";
            this.btn_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Menu.Textcolor = System.Drawing.Color.White;
            this.btn_Menu.TextFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.Click += new System.EventHandler(this.btn_Mantenimiento_Click);
            // 
            // btn_Alumnos
            // 
            this.btn_Alumnos.Activecolor = System.Drawing.Color.Black;
            this.btn_Alumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Alumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Alumnos.BorderRadius = 0;
            this.btn_Alumnos.ButtonText = "Alumnos";
            this.btn_Alumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion2.SetDecoration(this.btn_Alumnos, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this.btn_Alumnos, BunifuAnimatorNS.DecorationType.None);
            this.btn_Alumnos.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Alumnos.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alumnos.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Alumnos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Alumnos.Iconimage")));
            this.btn_Alumnos.Iconimage_right = null;
            this.btn_Alumnos.Iconimage_right_Selected = null;
            this.btn_Alumnos.Iconimage_Selected = null;
            this.btn_Alumnos.IconMarginLeft = 0;
            this.btn_Alumnos.IconMarginRight = 0;
            this.btn_Alumnos.IconRightVisible = true;
            this.btn_Alumnos.IconRightZoom = 0D;
            this.btn_Alumnos.IconVisible = true;
            this.btn_Alumnos.IconZoom = 45D;
            this.btn_Alumnos.IsTab = true;
            this.btn_Alumnos.Location = new System.Drawing.Point(0, 195);
            this.btn_Alumnos.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.btn_Alumnos.Name = "btn_Alumnos";
            this.btn_Alumnos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Alumnos.OnHovercolor = System.Drawing.Color.Silver;
            this.btn_Alumnos.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Alumnos.selected = false;
            this.btn_Alumnos.Size = new System.Drawing.Size(198, 30);
            this.btn_Alumnos.TabIndex = 15;
            this.btn_Alumnos.Text = "Alumnos";
            this.btn_Alumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Alumnos.Textcolor = System.Drawing.Color.White;
            this.btn_Alumnos.TextFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alumnos.Click += new System.EventHandler(this.btn_software_Click);
            // 
            // btn_Maestros
            // 
            this.btn_Maestros.Activecolor = System.Drawing.Color.Black;
            this.btn_Maestros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Maestros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Maestros.BorderRadius = 0;
            this.btn_Maestros.ButtonText = "Maestros";
            this.btn_Maestros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion2.SetDecoration(this.btn_Maestros, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this.btn_Maestros, BunifuAnimatorNS.DecorationType.None);
            this.btn_Maestros.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Maestros.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maestros.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Maestros.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Maestros.Iconimage")));
            this.btn_Maestros.Iconimage_right = null;
            this.btn_Maestros.Iconimage_right_Selected = null;
            this.btn_Maestros.Iconimage_Selected = null;
            this.btn_Maestros.IconMarginLeft = 0;
            this.btn_Maestros.IconMarginRight = 0;
            this.btn_Maestros.IconRightVisible = true;
            this.btn_Maestros.IconRightZoom = 0D;
            this.btn_Maestros.IconVisible = true;
            this.btn_Maestros.IconZoom = 45D;
            this.btn_Maestros.IsTab = true;
            this.btn_Maestros.Location = new System.Drawing.Point(0, 247);
            this.btn_Maestros.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.btn_Maestros.Name = "btn_Maestros";
            this.btn_Maestros.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Maestros.OnHovercolor = System.Drawing.Color.Silver;
            this.btn_Maestros.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Maestros.selected = false;
            this.btn_Maestros.Size = new System.Drawing.Size(198, 30);
            this.btn_Maestros.TabIndex = 15;
            this.btn_Maestros.Text = "Maestros";
            this.btn_Maestros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Maestros.Textcolor = System.Drawing.Color.White;
            this.btn_Maestros.TextFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maestros.Click += new System.EventHandler(this.btn_equipos_Click);
            // 
            // btn_Equipos
            // 
            this.btn_Equipos.Activecolor = System.Drawing.Color.Black;
            this.btn_Equipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Equipos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Equipos.BorderRadius = 0;
            this.btn_Equipos.ButtonText = "Equipos/Herramientas";
            this.btn_Equipos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion2.SetDecoration(this.btn_Equipos, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this.btn_Equipos, BunifuAnimatorNS.DecorationType.None);
            this.btn_Equipos.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Equipos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Equipos.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Equipos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Equipos.Iconimage")));
            this.btn_Equipos.Iconimage_right = null;
            this.btn_Equipos.Iconimage_right_Selected = null;
            this.btn_Equipos.Iconimage_Selected = null;
            this.btn_Equipos.IconMarginLeft = 0;
            this.btn_Equipos.IconMarginRight = 0;
            this.btn_Equipos.IconRightVisible = true;
            this.btn_Equipos.IconRightZoom = 0D;
            this.btn_Equipos.IconVisible = true;
            this.btn_Equipos.IconZoom = 45D;
            this.btn_Equipos.IsTab = true;
            this.btn_Equipos.Location = new System.Drawing.Point(0, 299);
            this.btn_Equipos.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.btn_Equipos.Name = "btn_Equipos";
            this.btn_Equipos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Equipos.OnHovercolor = System.Drawing.Color.Silver;
            this.btn_Equipos.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Equipos.selected = false;
            this.btn_Equipos.Size = new System.Drawing.Size(198, 28);
            this.btn_Equipos.TabIndex = 15;
            this.btn_Equipos.Text = "Equipos/Herramientas";
            this.btn_Equipos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Equipos.Textcolor = System.Drawing.Color.White;
            this.btn_Equipos.TextFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Equipos.Click += new System.EventHandler(this.btn_laboratorios_Click);
            // 
            // btn_Prestamos
            // 
            this.btn_Prestamos.Activecolor = System.Drawing.Color.Black;
            this.btn_Prestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Prestamos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Prestamos.BorderRadius = 0;
            this.btn_Prestamos.ButtonText = "Préstamos";
            this.btn_Prestamos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion2.SetDecoration(this.btn_Prestamos, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this.btn_Prestamos, BunifuAnimatorNS.DecorationType.None);
            this.btn_Prestamos.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Prestamos.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prestamos.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Prestamos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Prestamos.Iconimage")));
            this.btn_Prestamos.Iconimage_right = null;
            this.btn_Prestamos.Iconimage_right_Selected = null;
            this.btn_Prestamos.Iconimage_Selected = null;
            this.btn_Prestamos.IconMarginLeft = 0;
            this.btn_Prestamos.IconMarginRight = 0;
            this.btn_Prestamos.IconRightVisible = true;
            this.btn_Prestamos.IconRightZoom = 0D;
            this.btn_Prestamos.IconVisible = true;
            this.btn_Prestamos.IconZoom = 45D;
            this.btn_Prestamos.IsTab = true;
            this.btn_Prestamos.Location = new System.Drawing.Point(0, 349);
            this.btn_Prestamos.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.btn_Prestamos.Name = "btn_Prestamos";
            this.btn_Prestamos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Prestamos.OnHovercolor = System.Drawing.Color.Silver;
            this.btn_Prestamos.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Prestamos.selected = false;
            this.btn_Prestamos.Size = new System.Drawing.Size(198, 30);
            this.btn_Prestamos.TabIndex = 15;
            this.btn_Prestamos.Text = "Préstamos";
            this.btn_Prestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Prestamos.Textcolor = System.Drawing.Color.White;
            this.btn_Prestamos.TextFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prestamos.Click += new System.EventHandler(this.btn_administradores_Click);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(144)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "        Carreras";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion2.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 50D;
            this.bunifuFlatButton6.IsTab = true;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(0, 730);
            this.bunifuFlatButton6.Margin = new System.Windows.Forms.Padding(3, 27, 3, 27);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(144)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.Empty;
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(247, 63);
            this.bunifuFlatButton6.TabIndex = 15;
            this.bunifuFlatButton6.Text = "        Carreras";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSlidelPanel
            // 
            this.btnSlidelPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSlidelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnSlidelPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion2.SetDecoration(this.btnSlidelPanel, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this.btnSlidelPanel, BunifuAnimatorNS.DecorationType.None);
            this.btnSlidelPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnSlidelPanel.Image")));
            this.btnSlidelPanel.ImageActive = null;
            this.btnSlidelPanel.Location = new System.Drawing.Point(170, 3);
            this.btnSlidelPanel.Name = "btnSlidelPanel";
            this.btnSlidelPanel.Size = new System.Drawing.Size(25, 24);
            this.btnSlidelPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSlidelPanel.TabIndex = 16;
            this.btnSlidelPanel.TabStop = false;
            this.btnSlidelPanel.Zoom = 10;
            this.btnSlidelPanel.Click += new System.EventHandler(this.btnSlidelPanel_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.panelMenu.Controls.Add(this.Logo);
            this.panelMenu.Controls.Add(this.btnSlidelPanel);
            this.panelMenu.Controls.Add(this.bunifuFlatButton6);
            this.panelMenu.Controls.Add(this.btn_Prestamos);
            this.panelMenu.Controls.Add(this.btn_Equipos);
            this.panelMenu.Controls.Add(this.btn_Maestros);
            this.panelMenu.Controls.Add(this.btn_Alumnos);
            this.panelMenu.Controls.Add(this.btn_Menu);
            this.Animacion2.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 36);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(198, 493);
            this.panelMenu.TabIndex = 10;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // Logo
            // 
            this.Animacion1.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(61, 39);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(73, 70);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // PanelCentral
            // 
            this.PanelCentral.Controls.Add(this.frm_prestamo1);
            this.PanelCentral.Controls.Add(this.frm_Maestro1);
            this.PanelCentral.Controls.Add(this.frm_Equipo_Herramienta1);
            this.PanelCentral.Controls.Add(this.frm_Alumno1);
            this.PanelCentral.Controls.Add(this.frm_Admin1);
            this.Animacion2.SetDecoration(this.PanelCentral, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this.PanelCentral, BunifuAnimatorNS.DecorationType.None);
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(198, 36);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(700, 493);
            this.PanelCentral.TabIndex = 11;
            // 
            // frm_prestamo1
            // 
            this.Animacion1.SetDecoration(this.frm_prestamo1, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.frm_prestamo1, BunifuAnimatorNS.DecorationType.None);
            this.frm_prestamo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_prestamo1.Location = new System.Drawing.Point(0, 0);
            this.frm_prestamo1.Name = "frm_prestamo1";
            this.frm_prestamo1.Size = new System.Drawing.Size(700, 493);
            this.frm_prestamo1.TabIndex = 4;
            // 
            // frm_Maestro1
            // 
            this.frm_Maestro1.BackColor = System.Drawing.Color.White;
            this.Animacion1.SetDecoration(this.frm_Maestro1, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.frm_Maestro1, BunifuAnimatorNS.DecorationType.None);
            this.frm_Maestro1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_Maestro1.Location = new System.Drawing.Point(0, 0);
            this.frm_Maestro1.Name = "frm_Maestro1";
            this.frm_Maestro1.Size = new System.Drawing.Size(700, 493);
            this.frm_Maestro1.TabIndex = 3;
            // 
            // frm_Equipo_Herramienta1
            // 
            this.frm_Equipo_Herramienta1.BackColor = System.Drawing.Color.White;
            this.Animacion1.SetDecoration(this.frm_Equipo_Herramienta1, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.frm_Equipo_Herramienta1, BunifuAnimatorNS.DecorationType.None);
            this.frm_Equipo_Herramienta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_Equipo_Herramienta1.Location = new System.Drawing.Point(0, 0);
            this.frm_Equipo_Herramienta1.Name = "frm_Equipo_Herramienta1";
            this.frm_Equipo_Herramienta1.Size = new System.Drawing.Size(700, 493);
            this.frm_Equipo_Herramienta1.TabIndex = 2;
            // 
            // frm_Alumno1
            // 
            this.frm_Alumno1.BackColor = System.Drawing.Color.White;
            this.Animacion1.SetDecoration(this.frm_Alumno1, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.frm_Alumno1, BunifuAnimatorNS.DecorationType.None);
            this.frm_Alumno1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_Alumno1.Location = new System.Drawing.Point(0, 0);
            this.frm_Alumno1.Name = "frm_Alumno1";
            this.frm_Alumno1.Size = new System.Drawing.Size(700, 493);
            this.frm_Alumno1.TabIndex = 1;
            // 
            // frm_Admin1
            // 
            this.frm_Admin1.BackColor = System.Drawing.Color.White;
            this.frm_Admin1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.frm_Admin1, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.frm_Admin1, BunifuAnimatorNS.DecorationType.None);
            this.frm_Admin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_Admin1.Location = new System.Drawing.Point(0, 0);
            this.frm_Admin1.Name = "frm_Admin1";
            this.frm_Admin1.Size = new System.Drawing.Size(700, 493);
            this.frm_Admin1.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Top;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Animacion1
            // 
            this.Animacion1.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.Animacion1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.Animacion1.DefaultAnimation = animation1;
            // 
            // Animacion2
            // 
            this.Animacion2.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.Animacion2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(50);
            animation2.RotateCoeff = 1F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.Animacion2.DefaultAnimation = animation2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 529);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.Top);
            this.Animacion1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Menu";
            this.Top.ResumeLayout(false);
            this.Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlidelPanel)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.PanelCentral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Menu;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Alumnos;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Maestros;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Equipos;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Prestamos;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuImageButton btnSlidelPanel;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel PanelCentral;
        private Frm_Admin frm_Admin1;
        private Frm_Alumno frm_Alumno1;
        private Frm_Equipo_Herramienta frm_Equipo_Herramienta1;
        private System.Windows.Forms.Button button4;
        private Frm_Maestro frm_Maestro1;
        private Frm_Prestamo frm_prestamo1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox Logo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition Animacion1;
        private BunifuAnimatorNS.BunifuTransition Animacion2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}