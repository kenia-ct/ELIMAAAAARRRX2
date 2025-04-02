namespace CALCULADORA
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.numero_1 = new System.Windows.Forms.TextBox();
            this.numero_2 = new System.Windows.Forms.TextBox();
            this.label_respuesta = new System.Windows.Forms.Label();
            this.sumar = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // numero_1
            // 
            this.numero_1.Font = new System.Drawing.Font("News706 BT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_1.Location = new System.Drawing.Point(35, 26);
            this.numero_1.Name = "numero_1";
            this.numero_1.Size = new System.Drawing.Size(100, 52);
            this.numero_1.TabIndex = 7;
            this.numero_1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // numero_2
            // 
            this.numero_2.Font = new System.Drawing.Font("News706 BT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_2.Location = new System.Drawing.Point(35, 107);
            this.numero_2.Name = "numero_2";
            this.numero_2.Size = new System.Drawing.Size(100, 52);
            this.numero_2.TabIndex = 8;
            this.numero_2.TextChanged += new System.EventHandler(this.numero_2_TextChanged);
            // 
            // label_respuesta
            // 
            this.label_respuesta.AutoSize = true;
            this.label_respuesta.Font = new System.Drawing.Font("Playbill", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_respuesta.Location = new System.Drawing.Point(222, 198);
            this.label_respuesta.Name = "label_respuesta";
            this.label_respuesta.Size = new System.Drawing.Size(0, 49);
            this.label_respuesta.TabIndex = 9;
            this.label_respuesta.Click += new System.EventHandler(this.label1_Click);
            // 
            // sumar
            // 
            this.sumar.Font = new System.Drawing.Font("Noto Sans JP", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumar.Location = new System.Drawing.Point(204, 26);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(163, 65);
            this.sumar.TabIndex = 10;
            this.sumar.Text = "Sumar";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click_1);
            // 
            // restar
            // 
            this.restar.Font = new System.Drawing.Font("Noto Sans JP", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restar.Location = new System.Drawing.Point(410, 27);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(157, 65);
            this.restar.TabIndex = 11;
            this.restar.Text = "Restar";
            this.restar.UseVisualStyleBackColor = true;
            this.restar.Click += new System.EventHandler(this.restar_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Font = new System.Drawing.Font("Noto Sans JP", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicar.Location = new System.Drawing.Point(163, 98);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(241, 65);
            this.multiplicar.TabIndex = 12;
            this.multiplicar.Text = "Multiplicar";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // dividir
            // 
            this.dividir.Font = new System.Drawing.Font("Noto Sans JP", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividir.Location = new System.Drawing.Point(410, 98);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(157, 65);
            this.dividir.TabIndex = 13;
            this.dividir.Text = "Dividir";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 251);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.label_respuesta);
            this.Controls.Add(this.numero_2);
            this.Controls.Add(this.numero_1);
            this.Name = "Form1";
            this.Text = "  DIVIDIR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox numero_1;
        private System.Windows.Forms.TextBox numero_2;
        private System.Windows.Forms.Label label_respuesta;
        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button dividir;
    }
}

