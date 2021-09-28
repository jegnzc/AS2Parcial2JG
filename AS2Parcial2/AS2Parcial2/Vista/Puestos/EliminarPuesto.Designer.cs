
namespace AS2Parcial2.Vista.Puestos
{
    partial class EliminarPuesto
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtPuestoNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPuestoEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPuestoCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVPuestos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarPuesto
            // 
            this.btnEliminarPuesto.Location = new System.Drawing.Point(434, 281);
            this.btnEliminarPuesto.Name = "btnEliminarPuesto";
            this.btnEliminarPuesto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPuesto.TabIndex = 23;
            this.btnEliminarPuesto.Text = "Eliminar";
            this.btnEliminarPuesto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Puesto";
            // 
            // txtPuestoNombre
            // 
            this.txtPuestoNombre.Enabled = false;
            this.txtPuestoNombre.Location = new System.Drawing.Point(456, 142);
            this.txtPuestoNombre.Name = "txtPuestoNombre";
            this.txtPuestoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtPuestoNombre.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Estado";
            // 
            // txtPuestoEstado
            // 
            this.txtPuestoEstado.Enabled = false;
            this.txtPuestoEstado.Location = new System.Drawing.Point(456, 205);
            this.txtPuestoEstado.Name = "txtPuestoEstado";
            this.txtPuestoEstado.Size = new System.Drawing.Size(100, 20);
            this.txtPuestoEstado.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Código";
            // 
            // txtPuestoCodigo
            // 
            this.txtPuestoCodigo.Enabled = false;
            this.txtPuestoCodigo.Location = new System.Drawing.Point(456, 88);
            this.txtPuestoCodigo.Name = "txtPuestoCodigo";
            this.txtPuestoCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtPuestoCodigo.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Eliminar Puesto";
            // 
            // DGVPuestos
            // 
            this.DGVPuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPuestos.Location = new System.Drawing.Point(6, 61);
            this.DGVPuestos.Name = "DGVPuestos";
            this.DGVPuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPuestos.Size = new System.Drawing.Size(363, 272);
            this.DGVPuestos.TabIndex = 15;
            // 
            // EliminarPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 362);
            this.Controls.Add(this.btnEliminarPuesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPuestoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPuestoEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPuestoCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVPuestos);
            this.Name = "EliminarPuesto";
            this.Text = "EliminarPuesto";
            ((System.ComponentModel.ISupportInitialize)(this.DGVPuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnEliminarPuesto;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPuestoNombre;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPuestoEstado;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPuestoCodigo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DGVPuestos;
    }
}