
namespace QuizGhas
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
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.rdbtnOpcion5 = new System.Windows.Forms.RadioButton();
            this.rdbtnOpcion4 = new System.Windows.Forms.RadioButton();
            this.rdbtnOpcion3 = new System.Windows.Forms.RadioButton();
            this.rdbtnOpcion2 = new System.Windows.Forms.RadioButton();
            this.rdbtnOpcion1 = new System.Windows.Forms.RadioButton();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblNumeroPregunta = new System.Windows.Forms.Label();
            this.pnlOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(72, 56);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(84, 18);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "Pregunta";
            this.lblPregunta.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnValidar.Location = new System.Drawing.Point(75, 409);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(85, 29);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFinalizar.Location = new System.Drawing.Point(630, 409);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(85, 29);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(691, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(47, 13);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score: 0";
            this.lblScore.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.rdbtnOpcion5);
            this.pnlOpciones.Controls.Add(this.rdbtnOpcion4);
            this.pnlOpciones.Controls.Add(this.rdbtnOpcion3);
            this.pnlOpciones.Controls.Add(this.rdbtnOpcion2);
            this.pnlOpciones.Controls.Add(this.rdbtnOpcion1);
            this.pnlOpciones.Location = new System.Drawing.Point(49, 113);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(678, 267);
            this.pnlOpciones.TabIndex = 6;
            // 
            // rdbtnOpcion5
            // 
            this.rdbtnOpcion5.AutoSize = true;
            this.rdbtnOpcion5.Location = new System.Drawing.Point(26, 221);
            this.rdbtnOpcion5.Name = "rdbtnOpcion5";
            this.rdbtnOpcion5.Size = new System.Drawing.Size(85, 17);
            this.rdbtnOpcion5.TabIndex = 4;
            this.rdbtnOpcion5.TabStop = true;
            this.rdbtnOpcion5.Text = "radioButton5";
            this.rdbtnOpcion5.UseVisualStyleBackColor = true;
            this.rdbtnOpcion5.Visible = false;
            // 
            // rdbtnOpcion4
            // 
            this.rdbtnOpcion4.AutoSize = true;
            this.rdbtnOpcion4.Location = new System.Drawing.Point(26, 176);
            this.rdbtnOpcion4.Name = "rdbtnOpcion4";
            this.rdbtnOpcion4.Size = new System.Drawing.Size(85, 17);
            this.rdbtnOpcion4.TabIndex = 3;
            this.rdbtnOpcion4.TabStop = true;
            this.rdbtnOpcion4.Text = "radioButton4";
            this.rdbtnOpcion4.UseVisualStyleBackColor = true;
            this.rdbtnOpcion4.Visible = false;
            this.rdbtnOpcion4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rdbtnOpcion3
            // 
            this.rdbtnOpcion3.AutoSize = true;
            this.rdbtnOpcion3.Location = new System.Drawing.Point(26, 127);
            this.rdbtnOpcion3.Name = "rdbtnOpcion3";
            this.rdbtnOpcion3.Size = new System.Drawing.Size(85, 17);
            this.rdbtnOpcion3.TabIndex = 2;
            this.rdbtnOpcion3.TabStop = true;
            this.rdbtnOpcion3.Text = "radioButton3";
            this.rdbtnOpcion3.UseVisualStyleBackColor = true;
            // 
            // rdbtnOpcion2
            // 
            this.rdbtnOpcion2.AutoSize = true;
            this.rdbtnOpcion2.Location = new System.Drawing.Point(26, 79);
            this.rdbtnOpcion2.Name = "rdbtnOpcion2";
            this.rdbtnOpcion2.Size = new System.Drawing.Size(85, 17);
            this.rdbtnOpcion2.TabIndex = 1;
            this.rdbtnOpcion2.TabStop = true;
            this.rdbtnOpcion2.Text = "radioButton2";
            this.rdbtnOpcion2.UseVisualStyleBackColor = true;
            // 
            // rdbtnOpcion1
            // 
            this.rdbtnOpcion1.AutoSize = true;
            this.rdbtnOpcion1.Location = new System.Drawing.Point(26, 30);
            this.rdbtnOpcion1.Name = "rdbtnOpcion1";
            this.rdbtnOpcion1.Size = new System.Drawing.Size(85, 17);
            this.rdbtnOpcion1.TabIndex = 0;
            this.rdbtnOpcion1.TabStop = true;
            this.rdbtnOpcion1.Text = "radioButton1";
            this.rdbtnOpcion1.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAtras.Location = new System.Drawing.Point(411, 409);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(85, 29);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "<< Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSiguiente.Location = new System.Drawing.Point(525, 409);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(85, 29);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Siguiente >>";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblNumeroPregunta
            // 
            this.lblNumeroPregunta.AutoSize = true;
            this.lblNumeroPregunta.Location = new System.Drawing.Point(583, 9);
            this.lblNumeroPregunta.Name = "lblNumeroPregunta";
            this.lblNumeroPregunta.Size = new System.Drawing.Size(64, 13);
            this.lblNumeroPregunta.TabIndex = 9;
            this.lblNumeroPregunta.Text = "Preguntas =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumeroPregunta);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblPregunta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.RadioButton rdbtnOpcion5;
        private System.Windows.Forms.RadioButton rdbtnOpcion4;
        private System.Windows.Forms.RadioButton rdbtnOpcion3;
        private System.Windows.Forms.RadioButton rdbtnOpcion2;
        private System.Windows.Forms.RadioButton rdbtnOpcion1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblNumeroPregunta;
    }
}

