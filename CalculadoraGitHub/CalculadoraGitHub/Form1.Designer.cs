namespace CalculadoraGitHub
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.botonSuma = new System.Windows.Forms.Button();
            this.botonResta = new System.Windows.Forms.Button();
            this.botonMulti = new System.Windows.Forms.Button();
            this.botonDivi = new System.Windows.Forms.Button();
            this.boton7 = new System.Windows.Forms.Button();
            this.boton8 = new System.Windows.Forms.Button();
            this.boton9 = new System.Windows.Forms.Button();
            this.botonCE = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.boton5 = new System.Windows.Forms.Button();
            this.boton6 = new System.Windows.Forms.Button();
            this.botonBorrarCaracter = new System.Windows.Forms.Button();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.botonIgual = new System.Windows.Forms.Button();
            this.botonPunto = new System.Windows.Forms.Button();
            this.boton0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 37);
            this.textBox1.TabIndex = 0;
            // 
            // botonSuma
            // 
            this.botonSuma.AccessibleName = "";
            this.botonSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSuma.Location = new System.Drawing.Point(12, 55);
            this.botonSuma.Name = "botonSuma";
            this.botonSuma.Size = new System.Drawing.Size(58, 58);
            this.botonSuma.TabIndex = 1;
            this.botonSuma.Text = "+";
            this.botonSuma.UseVisualStyleBackColor = true;
            this.botonSuma.Click += new System.EventHandler(this.botonSuma_Click);
            // 
            // botonResta
            // 
            this.botonResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonResta.Location = new System.Drawing.Point(81, 55);
            this.botonResta.Name = "botonResta";
            this.botonResta.Size = new System.Drawing.Size(58, 58);
            this.botonResta.TabIndex = 2;
            this.botonResta.Text = "-";
            this.botonResta.UseVisualStyleBackColor = true;
            this.botonResta.Click += new System.EventHandler(this.botonResta_Click);
            // 
            // botonMulti
            // 
            this.botonMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMulti.Location = new System.Drawing.Point(150, 55);
            this.botonMulti.Name = "botonMulti";
            this.botonMulti.Size = new System.Drawing.Size(58, 58);
            this.botonMulti.TabIndex = 3;
            this.botonMulti.Text = "x";
            this.botonMulti.UseVisualStyleBackColor = true;
            this.botonMulti.Click += new System.EventHandler(this.botonMulti_Click);
            // 
            // botonDivi
            // 
            this.botonDivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDivi.Location = new System.Drawing.Point(219, 55);
            this.botonDivi.Name = "botonDivi";
            this.botonDivi.Size = new System.Drawing.Size(58, 58);
            this.botonDivi.TabIndex = 4;
            this.botonDivi.Text = "/";
            this.botonDivi.UseVisualStyleBackColor = true;
            this.botonDivi.Click += new System.EventHandler(this.botonDivi_Click);
            // 
            // boton7
            // 
            this.boton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton7.Location = new System.Drawing.Point(12, 119);
            this.boton7.Name = "boton7";
            this.boton7.Size = new System.Drawing.Size(58, 58);
            this.boton7.TabIndex = 5;
            this.boton7.Text = "7";
            this.boton7.UseVisualStyleBackColor = true;
            this.boton7.Click += new System.EventHandler(this.boton7_Click);
            // 
            // boton8
            // 
            this.boton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton8.Location = new System.Drawing.Point(81, 119);
            this.boton8.Name = "boton8";
            this.boton8.Size = new System.Drawing.Size(58, 58);
            this.boton8.TabIndex = 6;
            this.boton8.Text = "8";
            this.boton8.UseVisualStyleBackColor = true;
            this.boton8.Click += new System.EventHandler(this.boton8_Click);
            // 
            // boton9
            // 
            this.boton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton9.Location = new System.Drawing.Point(150, 119);
            this.boton9.Name = "boton9";
            this.boton9.Size = new System.Drawing.Size(58, 58);
            this.boton9.TabIndex = 7;
            this.boton9.Text = "9";
            this.boton9.UseVisualStyleBackColor = true;
            this.boton9.Click += new System.EventHandler(this.boton9_Click);
            // 
            // botonCE
            // 
            this.botonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCE.Location = new System.Drawing.Point(219, 119);
            this.botonCE.Name = "botonCE";
            this.botonCE.Size = new System.Drawing.Size(58, 58);
            this.botonCE.TabIndex = 8;
            this.botonCE.Text = "C";
            this.botonCE.UseVisualStyleBackColor = true;
            this.botonCE.Click += new System.EventHandler(this.botonCE_Click);
            // 
            // boton4
            // 
            this.boton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton4.Location = new System.Drawing.Point(12, 183);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(58, 58);
            this.boton4.TabIndex = 9;
            this.boton4.Text = "4";
            this.boton4.UseVisualStyleBackColor = true;
            this.boton4.Click += new System.EventHandler(this.boton4_Click);
            // 
            // boton5
            // 
            this.boton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton5.Location = new System.Drawing.Point(81, 183);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(58, 58);
            this.boton5.TabIndex = 10;
            this.boton5.Text = "5";
            this.boton5.UseVisualStyleBackColor = true;
            this.boton5.Click += new System.EventHandler(this.boton5_Click);
            // 
            // boton6
            // 
            this.boton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton6.Location = new System.Drawing.Point(150, 183);
            this.boton6.Name = "boton6";
            this.boton6.Size = new System.Drawing.Size(58, 58);
            this.boton6.TabIndex = 11;
            this.boton6.Text = "6";
            this.boton6.UseVisualStyleBackColor = true;
            this.boton6.Click += new System.EventHandler(this.boton6_Click);
            // 
            // botonBorrarCaracter
            // 
            this.botonBorrarCaracter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBorrarCaracter.Location = new System.Drawing.Point(219, 183);
            this.botonBorrarCaracter.Name = "botonBorrarCaracter";
            this.botonBorrarCaracter.Size = new System.Drawing.Size(58, 58);
            this.botonBorrarCaracter.TabIndex = 12;
            this.botonBorrarCaracter.Text = "←";
            this.botonBorrarCaracter.UseVisualStyleBackColor = true;
            this.botonBorrarCaracter.Click += new System.EventHandler(this.botonBorrarCaracter_Click);
            // 
            // boton1
            // 
            this.boton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.Location = new System.Drawing.Point(12, 247);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(58, 58);
            this.boton1.TabIndex = 13;
            this.boton1.Text = "1";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton2
            // 
            this.boton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.Location = new System.Drawing.Point(81, 247);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(58, 58);
            this.boton2.TabIndex = 14;
            this.boton2.Text = "2";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // boton3
            // 
            this.boton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton3.Location = new System.Drawing.Point(150, 247);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(58, 58);
            this.boton3.TabIndex = 15;
            this.boton3.Text = "3";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // botonIgual
            // 
            this.botonIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIgual.Location = new System.Drawing.Point(219, 247);
            this.botonIgual.Name = "botonIgual";
            this.botonIgual.Size = new System.Drawing.Size(58, 122);
            this.botonIgual.TabIndex = 16;
            this.botonIgual.Text = "=";
            this.botonIgual.UseVisualStyleBackColor = true;
            this.botonIgual.Click += new System.EventHandler(this.botonIgual_Click);
            // 
            // botonPunto
            // 
            this.botonPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPunto.Location = new System.Drawing.Point(150, 311);
            this.botonPunto.Name = "botonPunto";
            this.botonPunto.Size = new System.Drawing.Size(58, 58);
            this.botonPunto.TabIndex = 17;
            this.botonPunto.Text = ".";
            this.botonPunto.UseVisualStyleBackColor = true;
            this.botonPunto.Click += new System.EventHandler(this.botonPunto_Click);
            // 
            // boton0
            // 
            this.boton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton0.Location = new System.Drawing.Point(12, 311);
            this.boton0.Name = "boton0";
            this.boton0.Size = new System.Drawing.Size(127, 58);
            this.boton0.TabIndex = 18;
            this.boton0.Text = "0";
            this.boton0.UseVisualStyleBackColor = true;
            this.boton0.Click += new System.EventHandler(this.boton0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 390);
            this.Controls.Add(this.boton0);
            this.Controls.Add(this.botonPunto);
            this.Controls.Add(this.botonIgual);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.botonBorrarCaracter);
            this.Controls.Add(this.boton6);
            this.Controls.Add(this.boton5);
            this.Controls.Add(this.boton4);
            this.Controls.Add(this.botonCE);
            this.Controls.Add(this.boton9);
            this.Controls.Add(this.boton8);
            this.Controls.Add(this.boton7);
            this.Controls.Add(this.botonDivi);
            this.Controls.Add(this.botonMulti);
            this.Controls.Add(this.botonResta);
            this.Controls.Add(this.botonSuma);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "HolaCalculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button botonSuma;
        private System.Windows.Forms.Button botonResta;
        private System.Windows.Forms.Button botonMulti;
        private System.Windows.Forms.Button botonDivi;
        private System.Windows.Forms.Button boton7;
        private System.Windows.Forms.Button boton8;
        private System.Windows.Forms.Button boton9;
        private System.Windows.Forms.Button botonCE;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button boton5;
        private System.Windows.Forms.Button boton6;
        private System.Windows.Forms.Button botonBorrarCaracter;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Button botonIgual;
        private System.Windows.Forms.Button botonPunto;
        private System.Windows.Forms.Button boton0;
    }
}

