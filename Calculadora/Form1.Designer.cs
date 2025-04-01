namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sumar = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.numero_uno = new System.Windows.Forms.TextBox();
            this.numero_dos = new System.Windows.Forms.TextBox();
            this.label_respuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sumar
            // 
            this.sumar.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.sumar.Image = ((System.Drawing.Image)(resources.GetObject("sumar.Image")));
            this.sumar.Location = new System.Drawing.Point(160, 15);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(111, 35);
            this.sumar.TabIndex = 0;
            this.sumar.Text = "Sumar";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // restar
            // 
            this.restar.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.restar.Image = ((System.Drawing.Image)(resources.GetObject("restar.Image")));
            this.restar.Location = new System.Drawing.Point(160, 61);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(111, 37);
            this.restar.TabIndex = 1;
            this.restar.Text = "Restar";
            this.restar.UseVisualStyleBackColor = true;
            this.restar.Click += new System.EventHandler(this.restar_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.division.Image = ((System.Drawing.Image)(resources.GetObject("division.Image")));
            this.division.Location = new System.Drawing.Point(160, 115);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(111, 40);
            this.division.TabIndex = 2;
            this.division.Text = "Dividir";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.multiplicar.Image = ((System.Drawing.Image)(resources.GetObject("multiplicar.Image")));
            this.multiplicar.Location = new System.Drawing.Point(160, 161);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(111, 38);
            this.multiplicar.TabIndex = 3;
            this.multiplicar.Text = "Multiplicar";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // numero_uno
            // 
            this.numero_uno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_uno.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numero_uno.Location = new System.Drawing.Point(12, 30);
            this.numero_uno.Name = "numero_uno";
            this.numero_uno.Size = new System.Drawing.Size(100, 26);
            this.numero_uno.TabIndex = 4;
            // 
            // numero_dos
            // 
            this.numero_dos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_dos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numero_dos.Location = new System.Drawing.Point(12, 73);
            this.numero_dos.Name = "numero_dos";
            this.numero_dos.Size = new System.Drawing.Size(100, 26);
            this.numero_dos.TabIndex = 5;
            // 
            // label_respuesta
            // 
            this.label_respuesta.AutoSize = true;
            this.label_respuesta.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_respuesta.ForeColor = System.Drawing.Color.Brown;
            this.label_respuesta.Location = new System.Drawing.Point(40, 138);
            this.label_respuesta.Name = "label_respuesta";
            this.label_respuesta.Size = new System.Drawing.Size(31, 34);
            this.label_respuesta.TabIndex = 6;
            this.label_respuesta.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 228);
            this.Controls.Add(this.label_respuesta);
            this.Controls.Add(this.numero_dos);
            this.Controls.Add(this.numero_uno);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.division);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.sumar);
            this.Name = "Form1";
            this.Text = "Calculadora de Kenia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.TextBox numero_uno;
        private System.Windows.Forms.TextBox numero_dos;
        private System.Windows.Forms.Label label_respuesta;
    }
}

