
namespace AS2Parcial2.Vista.Empleado
{
    partial class EliminarEmpleado
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
            this.btnEliminarPuesto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVPuestos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpleadoCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarPuesto
            // 
            this.btnEliminarPuesto.Location = new System.Drawing.Point(481, 278);
            this.btnEliminarPuesto.Name = "btnEliminarPuesto";
            this.btnEliminarPuesto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPuesto.TabIndex = 32;
            this.btnEliminarPuesto.Text = "Eliminar";
            this.btnEliminarPuesto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Eliminar Empleado";
            // 
            // DGVPuestos
            // 
            this.DGVPuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPuestos.Location = new System.Drawing.Point(12, 48);
            this.DGVPuestos.Name = "DGVPuestos";
            this.DGVPuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPuestos.Size = new System.Drawing.Size(363, 272);
            this.DGVPuestos.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Código";
            // 
            // txtEmpleadoCodigo
            // 
            this.txtEmpleadoCodigo.Enabled = false;
            this.txtEmpleadoCodigo.Location = new System.Drawing.Point(481, 141);
            this.txtEmpleadoCodigo.Name = "txtEmpleadoCodigo";
            this.txtEmpleadoCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtEmpleadoCodigo.TabIndex = 51;
            // 
            // EliminarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 333);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmpleadoCodigo);
            this.Controls.Add(this.btnEliminarPuesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVPuestos);
            this.Name = "EliminarEmpleado";
            this.Text = "EliminarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.DGVPuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnEliminarPuesto;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DGVPuestos;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtEmpleadoCodigo;
    }
}