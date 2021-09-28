
namespace AS2Parcial2.Vista.Puestos
{
    partial class ActualizarPuesto
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
            this.DGVPuestos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizarPuesto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPuestoNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPuestoEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPuestoCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPuestos
            // 
            this.DGVPuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPuestos.Location = new System.Drawing.Point(12, 41);
            this.DGVPuestos.Name = "DGVPuestos";
            this.DGVPuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPuestos.Size = new System.Drawing.Size(363, 272);
            this.DGVPuestos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Actualizar Puesto";
            // 
            // btnActualizarPuesto
            // 
            this.btnActualizarPuesto.Location = new System.Drawing.Point(440, 261);
            this.btnActualizarPuesto.Name = "btnActualizarPuesto";
            this.btnActualizarPuesto.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarPuesto.TabIndex = 14;
            this.btnActualizarPuesto.Text = "Actualizar";
            this.btnActualizarPuesto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Puesto";
            // 
            // txtPuestoNombre
            // 
            this.txtPuestoNombre.Location = new System.Drawing.Point(462, 122);
            this.txtPuestoNombre.Name = "txtPuestoNombre";
            this.txtPuestoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtPuestoNombre.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Estado";
            // 
            // txtPuestoEstado
            // 
            this.txtPuestoEstado.Location = new System.Drawing.Point(462, 185);
            this.txtPuestoEstado.Name = "txtPuestoEstado";
            this.txtPuestoEstado.Size = new System.Drawing.Size(100, 20);
            this.txtPuestoEstado.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código";
            // 
            // txtPuestoCodigo
            // 
            this.txtPuestoCodigo.Enabled = false;
            this.txtPuestoCodigo.Location = new System.Drawing.Point(462, 68);
            this.txtPuestoCodigo.Name = "txtPuestoCodigo";
            this.txtPuestoCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtPuestoCodigo.TabIndex = 8;
            // 
            // ActualizarPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 325);
            this.Controls.Add(this.btnActualizarPuesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPuestoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPuestoEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPuestoCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVPuestos);
            this.Name = "ActualizarPuesto";
            this.Text = "ActualizarPuesto";
            ((System.ComponentModel.ISupportInitialize)(this.DGVPuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnActualizarPuesto;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPuestoNombre;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPuestoEstado;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPuestoCodigo;
        public System.Windows.Forms.DataGridView DGVPuestos;
    }
}