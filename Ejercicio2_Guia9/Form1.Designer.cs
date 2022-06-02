
namespace Ejercicio2_Guia9
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
            this.tcarga = new System.Windows.Forms.Label();
            this.t5litros = new System.Windows.Forms.Label();
            this.t10litros = new System.Windows.Forms.Label();
            this.biniciar = new System.Windows.Forms.Button();
            this.bdescargar = new System.Windows.Forms.Button();
            this.binformar = new System.Windows.Forms.Button();
            this.tB10litros = new System.Windows.Forms.TextBox();
            this.tB5litros = new System.Windows.Forms.TextBox();
            this.tdescarga = new System.Windows.Forms.Label();
            this.tinforme = new System.Windows.Forms.Label();
            this.lBinforme = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tcarga
            // 
            this.tcarga.AutoSize = true;
            this.tcarga.Location = new System.Drawing.Point(103, 81);
            this.tcarga.Name = "tcarga";
            this.tcarga.Size = new System.Drawing.Size(65, 13);
            this.tcarga.TabIndex = 0;
            this.tcarga.Text = "Carga Inicial";
            this.tcarga.Click += new System.EventHandler(this.tcarga_Click);
            // 
            // t5litros
            // 
            this.t5litros.AutoSize = true;
            this.t5litros.Location = new System.Drawing.Point(230, 81);
            this.t5litros.Name = "t5litros";
            this.t5litros.Size = new System.Drawing.Size(41, 13);
            this.t5litros.TabIndex = 1;
            this.t5litros.Text = "5 Litros";
            // 
            // t10litros
            // 
            this.t10litros.AutoSize = true;
            this.t10litros.Location = new System.Drawing.Point(334, 81);
            this.t10litros.Name = "t10litros";
            this.t10litros.Size = new System.Drawing.Size(47, 13);
            this.t10litros.TabIndex = 2;
            this.t10litros.Text = "10 Litros";
            // 
            // biniciar
            // 
            this.biniciar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.biniciar.Location = new System.Drawing.Point(358, 135);
            this.biniciar.Name = "biniciar";
            this.biniciar.Size = new System.Drawing.Size(75, 23);
            this.biniciar.TabIndex = 3;
            this.biniciar.Text = "Iniciar";
            this.biniciar.UseVisualStyleBackColor = false;
            this.biniciar.Click += new System.EventHandler(this.biniciar_Click);
            // 
            // bdescargar
            // 
            this.bdescargar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bdescargar.Enabled = false;
            this.bdescargar.Location = new System.Drawing.Point(358, 175);
            this.bdescargar.Name = "bdescargar";
            this.bdescargar.Size = new System.Drawing.Size(75, 23);
            this.bdescargar.TabIndex = 4;
            this.bdescargar.Text = "Descargar";
            this.bdescargar.UseVisualStyleBackColor = false;
            this.bdescargar.Click += new System.EventHandler(this.bdescargar_Click);
            // 
            // binformar
            // 
            this.binformar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.binformar.Enabled = false;
            this.binformar.Location = new System.Drawing.Point(358, 220);
            this.binformar.Name = "binformar";
            this.binformar.Size = new System.Drawing.Size(75, 23);
            this.binformar.TabIndex = 5;
            this.binformar.Text = "Informar";
            this.binformar.UseVisualStyleBackColor = false;
            this.binformar.Click += new System.EventHandler(this.binformar_Click);
            // 
            // tB10litros
            // 
            this.tB10litros.Location = new System.Drawing.Point(277, 78);
            this.tB10litros.Name = "tB10litros";
            this.tB10litros.Size = new System.Drawing.Size(51, 20);
            this.tB10litros.TabIndex = 6;
            // 
            // tB5litros
            // 
            this.tB5litros.Location = new System.Drawing.Point(174, 78);
            this.tB5litros.Name = "tB5litros";
            this.tB5litros.Size = new System.Drawing.Size(50, 20);
            this.tB5litros.TabIndex = 7;
            this.tB5litros.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tdescarga
            // 
            this.tdescarga.AutoSize = true;
            this.tdescarga.Location = new System.Drawing.Point(105, 81);
            this.tdescarga.Name = "tdescarga";
            this.tdescarga.Size = new System.Drawing.Size(53, 13);
            this.tdescarga.TabIndex = 9;
            this.tdescarga.Text = "Descarga";
            this.tdescarga.Visible = false;
            // 
            // tinforme
            // 
            this.tinforme.AutoSize = true;
            this.tinforme.Location = new System.Drawing.Point(103, 109);
            this.tinforme.Name = "tinforme";
            this.tinforme.Size = new System.Drawing.Size(0, 13);
            this.tinforme.TabIndex = 10;
            // 
            // lBinforme
            // 
            this.lBinforme.FormattingEnabled = true;
            this.lBinforme.Location = new System.Drawing.Point(103, 135);
            this.lBinforme.Name = "lBinforme";
            this.lBinforme.Size = new System.Drawing.Size(225, 108);
            this.lBinforme.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 385);
            this.Controls.Add(this.lBinforme);
            this.Controls.Add(this.tinforme);
            this.Controls.Add(this.tdescarga);
            this.Controls.Add(this.tB5litros);
            this.Controls.Add(this.tB10litros);
            this.Controls.Add(this.binformar);
            this.Controls.Add(this.bdescargar);
            this.Controls.Add(this.biniciar);
            this.Controls.Add(this.t10litros);
            this.Controls.Add(this.t5litros);
            this.Controls.Add(this.tcarga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tcarga;
        private System.Windows.Forms.Label t5litros;
        private System.Windows.Forms.Label t10litros;
        private System.Windows.Forms.Button biniciar;
        private System.Windows.Forms.Button bdescargar;
        private System.Windows.Forms.Button binformar;
        private System.Windows.Forms.TextBox tB10litros;
        private System.Windows.Forms.TextBox tB5litros;
        private System.Windows.Forms.Label tdescarga;
        private System.Windows.Forms.Label tinforme;
        private System.Windows.Forms.ListBox lBinforme;
    }
}

