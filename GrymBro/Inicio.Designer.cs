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
            resources.ApplyResources(this.Menu, "Menu");
            this.Menu.BackColor = System.Drawing.Color.Transparent;
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.pagosToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
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
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // consulteMatriculaToolStripMenuItem
            // 
            this.consulteMatriculaToolStripMenuItem.Name = "consulteMatriculaToolStripMenuItem";
            resources.ApplyResources(this.consulteMatriculaToolStripMenuItem, "consulteMatriculaToolStripMenuItem");
            this.consulteMatriculaToolStripMenuItem.Click += new System.EventHandler(this.consulteMatriculaToolStripMenuItem_Click);
            // 
            // eliminarMatriculaToolStripMenuItem
            // 
            this.eliminarMatriculaToolStripMenuItem.Name = "eliminarMatriculaToolStripMenuItem";
            resources.ApplyResources(this.eliminarMatriculaToolStripMenuItem, "eliminarMatriculaToolStripMenuItem");
            // 
            // actualizarMatriculaToolStripMenuItem
            // 
            this.actualizarMatriculaToolStripMenuItem.Name = "actualizarMatriculaToolStripMenuItem";
            resources.ApplyResources(this.actualizarMatriculaToolStripMenuItem, "actualizarMatriculaToolStripMenuItem");
            // 
            // verMatriculasToolStripMenuItem
            // 
            this.verMatriculasToolStripMenuItem.Name = "verMatriculasToolStripMenuItem";
            resources.ApplyResources(this.verMatriculasToolStripMenuItem, "verMatriculasToolStripMenuItem");
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.IndianRed;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarEmpleadosToolStripMenuItem,
            this.verClasesAsingadasToolStripMenuItem,
            this.actualizarEmpleadosToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // consultarEmpleadosToolStripMenuItem
            // 
            this.consultarEmpleadosToolStripMenuItem.Name = "consultarEmpleadosToolStripMenuItem";
            resources.ApplyResources(this.consultarEmpleadosToolStripMenuItem, "consultarEmpleadosToolStripMenuItem");
            this.consultarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.consultarEmpleadosToolStripMenuItem_Click);
            // 
            // verClasesAsingadasToolStripMenuItem
            // 
            this.verClasesAsingadasToolStripMenuItem.Name = "verClasesAsingadasToolStripMenuItem";
            resources.ApplyResources(this.verClasesAsingadasToolStripMenuItem, "verClasesAsingadasToolStripMenuItem");
            // 
            // actualizarEmpleadosToolStripMenuItem
            // 
            this.actualizarEmpleadosToolStripMenuItem.Name = "actualizarEmpleadosToolStripMenuItem";
            resources.ApplyResources(this.actualizarEmpleadosToolStripMenuItem, "actualizarEmpleadosToolStripMenuItem");
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.IndianRed;
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarClasesDisponiblesToolStripMenuItem,
            this.agendarClasesToolStripMenuItem,
            this.eliminarClasesToolStripMenuItem,
            this.elToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // consultarClasesDisponiblesToolStripMenuItem
            // 
            this.consultarClasesDisponiblesToolStripMenuItem.Name = "consultarClasesDisponiblesToolStripMenuItem";
            resources.ApplyResources(this.consultarClasesDisponiblesToolStripMenuItem, "consultarClasesDisponiblesToolStripMenuItem");
            this.consultarClasesDisponiblesToolStripMenuItem.Click += new System.EventHandler(this.consultarClasesDisponiblesToolStripMenuItem_Click);
            // 
            // agendarClasesToolStripMenuItem
            // 
            this.agendarClasesToolStripMenuItem.Name = "agendarClasesToolStripMenuItem";
            resources.ApplyResources(this.agendarClasesToolStripMenuItem, "agendarClasesToolStripMenuItem");
            this.agendarClasesToolStripMenuItem.Click += new System.EventHandler(this.agendarClasesToolStripMenuItem_Click);
            // 
            // eliminarClasesToolStripMenuItem
            // 
            this.eliminarClasesToolStripMenuItem.Name = "eliminarClasesToolStripMenuItem";
            resources.ApplyResources(this.eliminarClasesToolStripMenuItem, "eliminarClasesToolStripMenuItem");
            // 
            // elToolStripMenuItem
            // 
            this.elToolStripMenuItem.Name = "elToolStripMenuItem";
            resources.ApplyResources(this.elToolStripMenuItem, "elToolStripMenuItem");
            this.elToolStripMenuItem.Click += new System.EventHandler(this.elToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.IndianRed;
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.administradorDeUsuariosToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            resources.ApplyResources(this.agregarUsuarioToolStripMenuItem, "agregarUsuarioToolStripMenuItem");
            this.agregarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem_Click);
            // 
            // administradorDeUsuariosToolStripMenuItem
            // 
            this.administradorDeUsuariosToolStripMenuItem.Name = "administradorDeUsuariosToolStripMenuItem";
            resources.ApplyResources(this.administradorDeUsuariosToolStripMenuItem, "administradorDeUsuariosToolStripMenuItem");
            // 
            // pagosToolStripMenuItem
            // 
            resources.ApplyResources(this.pagosToolStripMenuItem, "pagosToolStripMenuItem");
            this.pagosToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarPagosToolStripMenuItem,
            this.pagosPendientesToolStripMenuItem,
            this.eliminarPagosToolStripMenuItem});
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            // 
            // verificarPagosToolStripMenuItem
            // 
            this.verificarPagosToolStripMenuItem.Name = "verificarPagosToolStripMenuItem";
            resources.ApplyResources(this.verificarPagosToolStripMenuItem, "verificarPagosToolStripMenuItem");
            this.verificarPagosToolStripMenuItem.Click += new System.EventHandler(this.verificarPagosToolStripMenuItem_Click);
            // 
            // pagosPendientesToolStripMenuItem
            // 
            this.pagosPendientesToolStripMenuItem.Name = "pagosPendientesToolStripMenuItem";
            resources.ApplyResources(this.pagosPendientesToolStripMenuItem, "pagosPendientesToolStripMenuItem");
            // 
            // eliminarPagosToolStripMenuItem
            // 
            this.eliminarPagosToolStripMenuItem.Name = "eliminarPagosToolStripMenuItem";
            resources.ApplyResources(this.eliminarPagosToolStripMenuItem, "eliminarPagosToolStripMenuItem");
            // 
            // MenuPrincipal
            // 
            resources.ApplyResources(this.MenuPrincipal, "MenuPrincipal");
            this.MenuPrincipal.BackColor = System.Drawing.Color.Red;
            this.MenuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuPrincipal_ItemClicked);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Inicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.MenuPrincipal);
            this.HelpButton = true;
            this.MainMenuStrip = this.MenuPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
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
        private System.Windows.Forms.ToolStripMenuItem administradorDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosPendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPagosToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

