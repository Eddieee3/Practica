namespace Busqueda
{
    partial class Form1
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
            this.Lineal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Binaria = new System.Windows.Forms.TabPage();
            this.Texto = new System.Windows.Forms.TabPage();
            this.Estudiantes = new System.Windows.Forms.TabPage();
            this.MaxMin = new System.Windows.Forms.TabPage();
            this.Matriz = new System.Windows.Forms.TabPage();
            this.lstNumerosE1 = new System.Windows.Forms.ListBox();
            this.btnGenerarE1 = new System.Windows.Forms.Button();
            this.txtBuscarE1 = new System.Windows.Forms.TextBox();
            this.btnBuscarE1 = new System.Windows.Forms.Button();
            this.lblNumeroABuscar = new System.Windows.Forms.Label();
            this.lblEstadoOResultado = new System.Windows.Forms.Label();
            this.lblResultadoE1 = new System.Windows.Forms.Label();
            this.Lineal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lineal
            // 
            this.Lineal.Controls.Add(this.tabPage1);
            this.Lineal.Controls.Add(this.Binaria);
            this.Lineal.Controls.Add(this.Texto);
            this.Lineal.Controls.Add(this.Estudiantes);
            this.Lineal.Controls.Add(this.MaxMin);
            this.Lineal.Controls.Add(this.Matriz);
            this.Lineal.Location = new System.Drawing.Point(12, 12);
            this.Lineal.Name = "Lineal";
            this.Lineal.SelectedIndex = 0;
            this.Lineal.Size = new System.Drawing.Size(646, 255);
            this.Lineal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblResultadoE1);
            this.tabPage1.Controls.Add(this.lblEstadoOResultado);
            this.tabPage1.Controls.Add(this.lblNumeroABuscar);
            this.tabPage1.Controls.Add(this.btnBuscarE1);
            this.tabPage1.Controls.Add(this.txtBuscarE1);
            this.tabPage1.Controls.Add(this.btnGenerarE1);
            this.tabPage1.Controls.Add(this.lstNumerosE1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lineal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Binaria
            // 
            this.Binaria.Location = new System.Drawing.Point(4, 22);
            this.Binaria.Name = "Binaria";
            this.Binaria.Padding = new System.Windows.Forms.Padding(3);
            this.Binaria.Size = new System.Drawing.Size(390, 211);
            this.Binaria.TabIndex = 1;
            this.Binaria.Text = "Binaria";
            this.Binaria.UseVisualStyleBackColor = true;
            // 
            // Texto
            // 
            this.Texto.Location = new System.Drawing.Point(4, 22);
            this.Texto.Name = "Texto";
            this.Texto.Padding = new System.Windows.Forms.Padding(3);
            this.Texto.Size = new System.Drawing.Size(390, 211);
            this.Texto.TabIndex = 2;
            this.Texto.Text = "Texto";
            this.Texto.UseVisualStyleBackColor = true;
            // 
            // Estudiantes
            // 
            this.Estudiantes.Location = new System.Drawing.Point(4, 22);
            this.Estudiantes.Name = "Estudiantes";
            this.Estudiantes.Padding = new System.Windows.Forms.Padding(3);
            this.Estudiantes.Size = new System.Drawing.Size(390, 211);
            this.Estudiantes.TabIndex = 3;
            this.Estudiantes.Text = "Estudiantes";
            this.Estudiantes.UseVisualStyleBackColor = true;
            // 
            // MaxMin
            // 
            this.MaxMin.Location = new System.Drawing.Point(4, 22);
            this.MaxMin.Name = "MaxMin";
            this.MaxMin.Padding = new System.Windows.Forms.Padding(3);
            this.MaxMin.Size = new System.Drawing.Size(390, 211);
            this.MaxMin.TabIndex = 4;
            this.MaxMin.Text = "Max/Min";
            this.MaxMin.UseVisualStyleBackColor = true;
            // 
            // Matriz
            // 
            this.Matriz.Location = new System.Drawing.Point(4, 22);
            this.Matriz.Name = "Matriz";
            this.Matriz.Padding = new System.Windows.Forms.Padding(3);
            this.Matriz.Size = new System.Drawing.Size(390, 211);
            this.Matriz.TabIndex = 5;
            this.Matriz.Text = "Matriz";
            this.Matriz.UseVisualStyleBackColor = true;
            // 
            // lstNumerosE1
            // 
            this.lstNumerosE1.FormattingEnabled = true;
            this.lstNumerosE1.Location = new System.Drawing.Point(6, 6);
            this.lstNumerosE1.Name = "lstNumerosE1";
            this.lstNumerosE1.Size = new System.Drawing.Size(332, 212);
            this.lstNumerosE1.TabIndex = 0;
            // 
            // btnGenerarE1
            // 
            this.btnGenerarE1.Location = new System.Drawing.Point(360, 29);
            this.btnGenerarE1.Name = "btnGenerarE1";
            this.btnGenerarE1.Size = new System.Drawing.Size(200, 32);
            this.btnGenerarE1.TabIndex = 1;
            this.btnGenerarE1.Text = "Generar Arreglo";
            this.btnGenerarE1.UseVisualStyleBackColor = true;
            // 
            // txtBuscarE1
            // 
            this.txtBuscarE1.Location = new System.Drawing.Point(370, 101);
            this.txtBuscarE1.Name = "txtBuscarE1";
            this.txtBuscarE1.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarE1.TabIndex = 2;
            // 
            // btnBuscarE1
            // 
            this.btnBuscarE1.Location = new System.Drawing.Point(485, 99);
            this.btnBuscarE1.Name = "btnBuscarE1";
            this.btnBuscarE1.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarE1.TabIndex = 3;
            this.btnBuscarE1.Text = "Buscar";
            this.btnBuscarE1.UseVisualStyleBackColor = true;
            // 
            // lblNumeroABuscar
            // 
            this.lblNumeroABuscar.AutoSize = true;
            this.lblNumeroABuscar.Location = new System.Drawing.Point(367, 83);
            this.lblNumeroABuscar.Name = "lblNumeroABuscar";
            this.lblNumeroABuscar.Size = new System.Drawing.Size(88, 13);
            this.lblNumeroABuscar.TabIndex = 5;
            this.lblNumeroABuscar.Text = "Numero a buscar";
            // 
            // lblEstadoOResultado
            // 
            this.lblEstadoOResultado.AutoSize = true;
            this.lblEstadoOResultado.Location = new System.Drawing.Point(367, 136);
            this.lblEstadoOResultado.Name = "lblEstadoOResultado";
            this.lblEstadoOResultado.Size = new System.Drawing.Size(93, 13);
            this.lblEstadoOResultado.TabIndex = 6;
            this.lblEstadoOResultado.Text = "Estado/Resultado";
            // 
            // lblResultadoE1
            // 
            this.lblResultadoE1.AutoSize = true;
            this.lblResultadoE1.Location = new System.Drawing.Point(372, 160);
            this.lblResultadoE1.Name = "lblResultadoE1";
            this.lblResultadoE1.Size = new System.Drawing.Size(16, 13);
            this.lblResultadoE1.TabIndex = 7;
            this.lblResultadoE1.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lineal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Lineal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Lineal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Binaria;
        private System.Windows.Forms.TabPage Texto;
        private System.Windows.Forms.TabPage Estudiantes;
        private System.Windows.Forms.TabPage MaxMin;
        private System.Windows.Forms.TextBox txtBuscarE1;
        private System.Windows.Forms.Button btnGenerarE1;
        private System.Windows.Forms.ListBox lstNumerosE1;
        private System.Windows.Forms.TabPage Matriz;
        private System.Windows.Forms.Button btnBuscarE1;
        private System.Windows.Forms.Label lblNumeroABuscar;
        private System.Windows.Forms.Label lblResultadoE1;
        private System.Windows.Forms.Label lblEstadoOResultado;
    }
}

