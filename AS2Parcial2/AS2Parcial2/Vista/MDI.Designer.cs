
namespace AS2Parcial2
{
    partial class MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pruebaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVerPuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVerDepartamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVerEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInsertarPuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInsertarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInsertarDepartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActualizarPuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActualizarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActualizarDepartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminarPuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminarDepartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pruebaToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pruebaToolStripMenuItem
            // 
            this.pruebaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVerPuestos,
            this.btnVerDepartamentos,
            this.btnVerEmpleados});
            this.pruebaToolStripMenuItem.Name = "pruebaToolStripMenuItem";
            this.pruebaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.pruebaToolStripMenuItem.Text = "Catálogos";
            this.pruebaToolStripMenuItem.Click += new System.EventHandler(this.pruebaToolStripMenuItem_Click);
            // 
            // btnVerPuestos
            // 
            this.btnVerPuestos.Name = "btnVerPuestos";
            this.btnVerPuestos.Size = new System.Drawing.Size(180, 22);
            this.btnVerPuestos.Text = "Puestos";
            this.btnVerPuestos.Click += new System.EventHandler(this.btnVerPuestos_Click);
            // 
            // btnVerDepartamentos
            // 
            this.btnVerDepartamentos.Name = "btnVerDepartamentos";
            this.btnVerDepartamentos.Size = new System.Drawing.Size(180, 22);
            this.btnVerDepartamentos.Text = "Departamento";
            this.btnVerDepartamentos.Click += new System.EventHandler(this.btnVerDepartamentos_Click);
            // 
            // btnVerEmpleados
            // 
            this.btnVerEmpleados.Name = "btnVerEmpleados";
            this.btnVerEmpleados.Size = new System.Drawing.Size(180, 22);
            this.btnVerEmpleados.Text = "Empleado";
            this.btnVerEmpleados.Click += new System.EventHandler(this.btnVerEmpleados_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsertarPuesto,
            this.btnInsertarEmpleado,
            this.btnInsertarDepartamento});
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertarToolStripMenuItem.Text = "Insertar";
            // 
            // btnInsertarPuesto
            // 
            this.btnInsertarPuesto.Name = "btnInsertarPuesto";
            this.btnInsertarPuesto.Size = new System.Drawing.Size(150, 22);
            this.btnInsertarPuesto.Text = "Puesto";
            this.btnInsertarPuesto.Click += new System.EventHandler(this.btnInsertarPuesto_Click);
            // 
            // btnInsertarEmpleado
            // 
            this.btnInsertarEmpleado.Name = "btnInsertarEmpleado";
            this.btnInsertarEmpleado.Size = new System.Drawing.Size(150, 22);
            this.btnInsertarEmpleado.Text = "Empleado";
            this.btnInsertarEmpleado.Click += new System.EventHandler(this.btnInsertarEmpleado_Click);
            // 
            // btnInsertarDepartamento
            // 
            this.btnInsertarDepartamento.Name = "btnInsertarDepartamento";
            this.btnInsertarDepartamento.Size = new System.Drawing.Size(150, 22);
            this.btnInsertarDepartamento.Text = "Departamento";
            this.btnInsertarDepartamento.Click += new System.EventHandler(this.btnInsertarDepartamento_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnActualizarPuesto,
            this.btnActualizarEmpleado,
            this.btnActualizarDepartamento});
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            // 
            // btnActualizarPuesto
            // 
            this.btnActualizarPuesto.Name = "btnActualizarPuesto";
            this.btnActualizarPuesto.Size = new System.Drawing.Size(150, 22);
            this.btnActualizarPuesto.Text = "Puesto";
            this.btnActualizarPuesto.Click += new System.EventHandler(this.btnActualizarPuesto_Click);
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(150, 22);
            this.btnActualizarEmpleado.Text = "Empleado";
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizarEmpleado_Click);
            // 
            // btnActualizarDepartamento
            // 
            this.btnActualizarDepartamento.Name = "btnActualizarDepartamento";
            this.btnActualizarDepartamento.Size = new System.Drawing.Size(150, 22);
            this.btnActualizarDepartamento.Text = "Departamento";
            this.btnActualizarDepartamento.Click += new System.EventHandler(this.btnActualizarDepartamento_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEliminarPuesto,
            this.btnEliminarEmpleado,
            this.btnEliminarDepartamento});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // btnEliminarPuesto
            // 
            this.btnEliminarPuesto.Name = "btnEliminarPuesto";
            this.btnEliminarPuesto.Size = new System.Drawing.Size(150, 22);
            this.btnEliminarPuesto.Text = "Puesto";
            this.btnEliminarPuesto.Click += new System.EventHandler(this.btnEliminarPuesto_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(150, 22);
            this.btnEliminarEmpleado.Text = "Empleado";
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnEliminarDepartamento
            // 
            this.btnEliminarDepartamento.Name = "btnEliminarDepartamento";
            this.btnEliminarDepartamento.Size = new System.Drawing.Size(150, 22);
            this.btnEliminarDepartamento.Text = "Departamento";
            this.btnEliminarDepartamento.Click += new System.EventHandler(this.btnEliminarDepartamento_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudasToolStripMenuItem
            // 
            this.ayudasToolStripMenuItem.Name = "ayudasToolStripMenuItem";
            this.ayudasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ayudasToolStripMenuItem.Text = "Ayudas";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 339);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "Jorge Eduardo González Campos - 0901 18 3920";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem pruebaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnVerPuestos;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnVerDepartamentos;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem btnInsertarPuesto;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnActualizarPuesto;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEliminarPuesto;
        private System.Windows.Forms.ToolStripMenuItem btnVerEmpleados;
        private System.Windows.Forms.ToolStripMenuItem btnInsertarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem btnInsertarDepartamento;
        private System.Windows.Forms.ToolStripMenuItem btnActualizarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem btnActualizarDepartamento;
        private System.Windows.Forms.ToolStripMenuItem btnEliminarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem btnEliminarDepartamento;
    }
}

