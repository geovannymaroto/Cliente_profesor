namespace Cliente_profesor
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpregunta = new System.Windows.Forms.TextBox();
            this.btnverdadero = new System.Windows.Forms.RadioButton();
            this.btnfalso = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregunta:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enviar Pregunta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpregunta
            // 
            this.txtpregunta.Location = new System.Drawing.Point(81, 39);
            this.txtpregunta.Name = "txtpregunta";
            this.txtpregunta.Size = new System.Drawing.Size(234, 20);
            this.txtpregunta.TabIndex = 2;
            // 
            // btnverdadero
            // 
            this.btnverdadero.AutoSize = true;
            this.btnverdadero.Location = new System.Drawing.Point(147, 80);
            this.btnverdadero.Name = "btnverdadero";
            this.btnverdadero.Size = new System.Drawing.Size(74, 17);
            this.btnverdadero.TabIndex = 3;
            this.btnverdadero.TabStop = true;
            this.btnverdadero.Text = "Verdadero";
            this.btnverdadero.UseVisualStyleBackColor = true;
            // 
            // btnfalso
            // 
            this.btnfalso.AutoSize = true;
            this.btnfalso.Location = new System.Drawing.Point(147, 103);
            this.btnfalso.Name = "btnfalso";
            this.btnfalso.Size = new System.Drawing.Size(50, 17);
            this.btnfalso.TabIndex = 4;
            this.btnfalso.TabStop = true;
            this.btnfalso.Text = "Falso";
            this.btnfalso.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Respuesta Correcta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 215);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnfalso);
            this.Controls.Add(this.btnverdadero);
            this.Controls.Add(this.txtpregunta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sistema de preguntas del profesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpregunta;
        private System.Windows.Forms.RadioButton btnverdadero;
        private System.Windows.Forms.RadioButton btnfalso;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

