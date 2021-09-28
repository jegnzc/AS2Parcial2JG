
namespace AS2Parcial2.Vista
{
    partial class AgregarPuesto
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
            this.txtPuestoCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPuestoEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPuestoNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarPuesto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPuestoCodigo
            // 
            this.txtPuestoCodigo.Location = new System.Drawing.Point(192, 61);
            this.txtPuestoCodigo.Name = "txtPuestoCodigo";
            this.txtPuestoCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtPuestoCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado";
            // 
            // txtPuestoEstado
            // 
            this.txtPuestoEstado.Location = new System.Drawing.Point(192, 178);
            this.txtPuestoEstado.Name = "txtPuestoEstado";
            this.txtPuestoEstado.Size = new System.Drawing.Size(100, 20);
            this.txtPuestoEstado.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Puesto";
            // 
            // txtPuestoNombre
            // 
            this.txtPuestoNombre.Location = new System.Drawing.Point(192, 115);
            this.txtPuestoNombre.Name = "txtPuestoNombre";
            this.txtPuestoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtPuestoNombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Agregar Puesto";
            // 
            // btnAgregarPuesto
            // 
            this.btnAgregarPuesto.Location = new System.Drawing.Point(295, 241);
            this.btnAgregarPuesto.Name = "btnAgregarPuesto";
            this.btnAgregarPuesto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPuesto.TabIndex = 7;
            this.btnAgregarPuesto.Text = "Agregar";
            this.btnAgregarPuesto.UseVisualStyleBackColor = true;
            // 
            // AgregarPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 305);
            this.Controls.Add(this.btnAgregarPuesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPuestoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPuestoEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPuestoCodigo);
            this.Name = "AgregarPuesto";
            this.Text = "MantenimientoPuestos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPuestoCodigo;
        public System.Windows.Forms.TextBox txtPuestoEstado;
        public System.Windows.Forms.TextBox txtPuestoNombre;
        public System.Windows.Forms.Button btnAgregarPuesto;
    }
}