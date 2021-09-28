
namespace AS2Parcial2.Vista.Departamento
{
    partial class AgregarDepartamento
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
            this.btnAgregarPuesto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPuestoNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPuestoEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPuestoCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregarPuesto
            // 
            this.btnAgregarPuesto.Location = new System.Drawing.Point(261, 278);
            this.btnAgregarPuesto.Name = "btnAgregarPuesto";
            this.btnAgregarPuesto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPuesto.TabIndex = 15;
            this.btnAgregarPuesto.Text = "Agregar";
            this.btnAgregarPuesto.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Agregar Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Puesto";
            // 
            // txtPuestoNombre
            // 
            this.txtPuestoNombre.Location = new System.Drawing.Point(158, 152);
            this.txtPuestoNombre.Name = "txtPuestoNombre";
            this.txtPuestoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtPuestoNombre.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Estado";
            // 
            // txtPuestoEstado
            // 
            this.txtPuestoEstado.Location = new System.Drawing.Point(158, 215);
            this.txtPuestoEstado.Name = "txtPuestoEstado";
            this.txtPuestoEstado.Size = new System.Drawing.Size(100, 20);
            this.txtPuestoEstado.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código";
            // 
            // txtPuestoCodigo
            // 
            this.txtPuestoCodigo.Location = new System.Drawing.Point(158, 98);
            this.txtPuestoCodigo.Name = "txtPuestoCodigo";
            this.txtPuestoCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtPuestoCodigo.TabIndex = 8;
            // 
            // AgregarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 338);
            this.Controls.Add(this.btnAgregarPuesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPuestoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPuestoEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPuestoCodigo);
            this.Name = "AgregarDepartamento";
            this.Text = "AgregarDepartamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAgregarPuesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPuestoNombre;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPuestoEstado;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPuestoCodigo;
    }
}