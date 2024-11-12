namespace GrymBro
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consulteMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMatriculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verClasesAsingadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClasesDisponiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosPendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AutoSize = false;
            this.Menu.BackColor = System.Drawing.Color.Transparent;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.pagosToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 73);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(920, 55);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.IndianRed;
            this.toolStripMenuItem2.Checked = true;
            this.toolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulteMatriculaToolStripMenuItem,
            this.eliminarMatriculaToolStripMenuItem,
            this.actualizarMatriculaToolStripMenuItem,
            this.verMatriculasToolStripMenuItem});
            this.toolStripMenuItem2.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 41);
            this.toolStripMenuItem2.Text = "Miembros";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // consulteMatriculaToolStripMenuItem
            // 
            this.consulteMatriculaToolStripMenuItem.Name = "consulteMatriculaToolStripMenuItem";
            this.consulteMatriculaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consulteMatriculaToolStripMenuItem.Text = "Consulte Miembros";
            // 
            // eliminarMatriculaToolStripMenuItem
            // 
            this.eliminarMatriculaToolStripMenuItem.Name = "eliminarMatriculaToolStripMenuItem";
            this.eliminarMatriculaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarMatriculaToolStripMenuItem.Text = "Eliminar Miembro";
            // 
            // actualizarMatriculaToolStripMenuItem
            // 
            this.actualizarMatriculaToolStripMenuItem.Name = "actualizarMatriculaToolStripMenuItem";
            this.actualizarMatriculaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarMatriculaToolStripMenuItem.Text = "Actualizar Miembro";
            // 
            // verMatriculasToolStripMenuItem
            // 
            this.verMatriculasToolStripMenuItem.Name = "verMatriculasToolStripMenuItem";
            this.verMatriculasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verMatriculasToolStripMenuItem.Text = "Ver Miembros";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.IndianRed;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarEmpleadosToolStripMenuItem,
            this.verClasesAsingadasToolStripMenuItem,
            this.actualizarEmpleadosToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 41);
            this.toolStripMenuItem1.Text = "Empleados";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // consultarEmpleadosToolStripMenuItem
            // 
            this.consultarEmpleadosToolStripMenuItem.Name = "consultarEmpleadosToolStripMenuItem";
            this.consultarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.consultarEmpleadosToolStripMenuItem.Text = "Consultar Empleados";
            // 
            // verClasesAsingadasToolStripMenuItem
            // 
            this.verClasesAsingadasToolStripMenuItem.Name = "verClasesAsingadasToolStripMenuItem";
            this.verClasesAsingadasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.verClasesAsingadasToolStripMenuItem.Text = "Ver Clases  Asingadas";
            // 
            // actualizarEmpleadosToolStripMenuItem
            // 
            this.actualizarEmpleadosToolStripMenuItem.Name = "actualizarEmpleadosToolStripMenuItem";
            this.actualizarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.actualizarEmpleadosToolStripMenuItem.Text = "Actualizar empleados";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AutoSize = false;
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.IndianRed;
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarClasesDisponiblesToolStripMenuItem,
            this.agendarClasesToolStripMenuItem,
            this.eliminarClasesToolStripMenuItem,
            this.elToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 41);
            this.toolStripMenuItem3.Text = "Clases";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // consultarClasesDisponiblesToolStripMenuItem
            // 
            this.consultarClasesDisponiblesToolStripMenuItem.Name = "consultarClasesDisponiblesToolStripMenuItem";
            this.consultarClasesDisponiblesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.consultarClasesDisponiblesToolStripMenuItem.Text = "Consultar clases disponibles";
            // 
            // agendarClasesToolStripMenuItem
            // 
            this.agendarClasesToolStripMenuItem.Name = "agendarClasesToolStripMenuItem";
            this.agendarClasesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.agendarClasesToolStripMenuItem.Text = "Agendar Clases";
            // 
            // eliminarClasesToolStripMenuItem
            // 
            this.eliminarClasesToolStripMenuItem.Name = "eliminarClasesToolStripMenuItem";
            this.eliminarClasesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.eliminarClasesToolStripMenuItem.Text = "Actualizar Clases";
            // 
            // elToolStripMenuItem
            // 
            this.elToolStripMenuItem.Name = "elToolStripMenuItem";
            this.elToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.elToolStripMenuItem.Text = "Eliminar Clases";
            this.elToolStripMenuItem.Click += new System.EventHandler(this.elToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.AutoSize = false;
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.IndianRed;
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.listaDeUsuarioToolStripMenuItem,
            this.administradorDeUsuariosToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 41);
            this.toolStripMenuItem4.Text = "Usuarios";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            // 
            // listaDeUsuarioToolStripMenuItem
            // 
            this.listaDeUsuarioToolStripMenuItem.Name = "listaDeUsuarioToolStripMenuItem";
            this.listaDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.listaDeUsuarioToolStripMenuItem.Text = "Lista de Usuario";
            // 
            // administradorDeUsuariosToolStripMenuItem
            // 
            this.administradorDeUsuariosToolStripMenuItem.Name = "administradorDeUsuariosToolStripMenuItem";
            this.administradorDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.administradorDeUsuariosToolStripMenuItem.Text = "Administrador de Usuarios";
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.AutoSize = false;
            this.pagosToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarPagosToolStripMenuItem,
            this.pagosPendientesToolStripMenuItem,
            this.eliminarPagosToolStripMenuItem});
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(180, 41);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // verificarPagosToolStripMenuItem
            // 
            this.verificarPagosToolStripMenuItem.Name = "verificarPagosToolStripMenuItem";
            this.verificarPagosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verificarPagosToolStripMenuItem.Text = "Verificar Pagos";
            // 
            // pagosPendientesToolStripMenuItem
            // 
            this.pagosPendientesToolStripMenuItem.Name = "pagosPendientesToolStripMenuItem";
            this.pagosPendientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pagosPendientesToolStripMenuItem.Text = "Pagos pendientes";
            // 
            // eliminarPagosToolStripMenuItem
            // 
            this.eliminarPagosToolStripMenuItem.Name = "eliminarPagosToolStripMenuItem";
            this.eliminarPagosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarPagosToolStripMenuItem.Text = "Eliminar pagos";
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.AutoSize = false;
            this.MenuPrincipal.BackColor = System.Drawing.Color.Red;
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MenuPrincipal.Size = new System.Drawing.Size(920, 73);
            this.MenuPrincipal.TabIndex = 1;
            this.MenuPrincipal.Text = "menuStrip2";
            this.MenuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuPrincipal_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "GymBro Manager Optativo IV";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(920, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.MenuPrincipal);
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consulteMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMatriculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verClasesAsingadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem consultarClasesDisponiblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarClasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarClasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosPendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPagosToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

